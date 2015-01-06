using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using Cyriller.Model;
using Cyriller.Checker.Model;

namespace Cyriller.Checker
{
    public partial class MainForm : Form
    {
        protected int total = 0;
        protected int done = 0;
        protected Thread thread;
        CyrillerEntities db;
        CyrCollection cyrCollection;

        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            try
            {
                db = new CyrillerEntities();
                db.Cases.Count();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Нет соединения с базой данных. " + ex.Message, this.Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
                Application.Exit();
            }

            cyrCollection = new CyrCollection();
        }

        private void btnCheckNouns_Click(object sender, EventArgs e)
        {
            if (txtLetters.Text.IsNullOrEmpty())
            {
                MessageBox.Show("Введите несколько букв для проверки!", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtLetters.Focus();

                return;
            }

            this.thread = new Thread(new ParameterizedThreadStart(o => CheckNouns()));
            thread.Start();
        }

        private void btnFirstHalf_Click(object sender, EventArgs e)
        {
            txtLetters.Text = btnFirstHalf.Text;
        }

        private void btnSecondHalf_Click(object sender, EventArgs e)
        {
            txtLetters.Text = btnSecondHalf.Text;
        }

        private void btnThirdHalf_Click(object sender, EventArgs e)
        {
            txtLetters.Text = btnThirdHalf.Text;
        }

        private void btnFourthHalf_Click(object sender, EventArgs e)
        {
            txtLetters.Text = btnFourthHalf.Text;
        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (thread != null && thread.ThreadState == ThreadState.Running)
            {
                thread.Abort();
            }

            db.Dispose();
        }

        private void btnDecline_Click(object sender, EventArgs e)
        {
            this.DeclineNoun(txtWord.Text);
        }

        private void btnRandom_Click(object sender, EventArgs e)
        {
            Word word = db.Words.Where(val => val.SpeechPartID == (int)SpeechPartsEnum.Noun).OrderBy(val => Guid.NewGuid()).FirstOrDefault();

            this.DeclineNoun(word.Name);
        }

        private void btnRandomWhile_Click(object sender, EventArgs e)
        {
            bool valid = true;

            while (valid)
            {
                Word word = db.Words.Where(val => val.SpeechPartID == (int)SpeechPartsEnum.Noun).OrderBy(val => Guid.NewGuid()).FirstOrDefault();

                valid = this.DeclineNoun(word.Name);
            }
        }

        private void btnCheckENouns_Click(object sender, EventArgs e)
        {
            CyrillerEntities db = new CyrillerEntities();
            IQueryable<Word> query = db.Words.Include("WordCases").Where(val => val.Error && val.SpeechPartID == (int)SpeechPartsEnum.Noun && (val.Name.Contains("ё") || val.WordCases.Any(v => v.Name.Contains("ё"))));

            CheckNouns(query);
            db.SaveChanges();
            db.Dispose();
        }

        private void btnHelp_Click(object sender, EventArgs e)
        {
            HelpForm frm = new HelpForm();
            frm.ShowDialog();
        }

        private void btnLog_Click(object sender, EventArgs e)
        {
            txtLog.Text = string.Empty;
        }

        protected void CheckNouns()
        {
            if (txtLetters.Text.IsNullOrEmpty())
            {
                return;
            }

            string[] letters = txtLetters.Text.ToCharArray().Select(val => val.ToString()).ToArray();

            this.Invoke(new Action(() =>
            {
                txtLetters.ReadOnly = true;
            }));


            foreach (string s in letters)
            {
                this.CheckNouns(s);

                this.Invoke(new Action(() =>
                {
                    txtLetters.Text = txtLetters.Text.Replace(s, string.Empty);
                }));
            }

            this.Invoke(new Action(() =>
            {
                txtLetters.ReadOnly = false;
            }));
        }

        protected void CheckNouns(string Letter)
        {
            int index = 0;
            int pageSize = 100;

            this.done = 0;
            this.total = db.Words.Where(val => val.Error && val.SpeechPartID == (int)SpeechPartsEnum.Noun && val.Name.StartsWith(Letter)).Count();

            this.AddLog("Begin execution.");
            this.SetProgress(done, total);

            while (index < total)
            {
                CheckNouns(index, pageSize, Letter);

                this.AddLog(string.Format("Page #{0} saved.", index / pageSize));
                index += pageSize;
            }

            this.SetProgress(done, total);
        }

        protected void CheckNouns(int Skip, int PageSize, string Letter)
        {
            CyrillerEntities db = new CyrillerEntities();
            List<Word> words = db.Words.Include("WordCases").Where(val => val.Error && val.SpeechPartID == (int)SpeechPartsEnum.Noun && val.Name.StartsWith(Letter))
                .OrderBy(val => val.ID).Skip(Skip).Take(PageSize).ToList();

            words.AsParallel().ForAll(word => CheckNoun(word));

            db.SaveChanges();
            db.Dispose();
        }

        protected void CheckNouns(IQueryable<Word> Query)
        {
            this.done = 0;
            this.total = Query.Count();
            this.SetProgress(done, total);

            Query.ToList().AsParallel().ForAll(word => CheckNoun(word));
        }

        protected void CheckNoun(Word Word)
        {
            CyrWord cyr;

            try
            {
                cyr = cyrCollection.Get(Word.Name);
            }
            catch (ArgumentException)
            {
                lock (this)
                {
                    done++;
                }

                this.SetProgress(done, total);

                return;
            }

            CyrResult result = cyr.Decline();
            int caseID = 0;

            foreach (string item in result.ToArray())
            {
                caseID++;

                bool valid = false;
                List<WordCase> cases = new List<WordCase>();

                foreach (WordCase wcase in Word.WordCases.Where(val => val.CaseID == caseID && val.NumberID == 1))
                {
                    string v1 = wcase.Name.ToLower();
                    string v2 = item.ToLower();

                    wcase.Error = v1 != v2;
                    wcase.Checked = true;

                    if (!wcase.Error)
                    {
                        valid = true;
                    }

                    cases.Add(wcase);
                }

                if (valid)
                {
                    cases.ForEach(val =>
                    {
                        if (val.Error)
                        {
                            val.Checked = false;
                        }
                    });
                }
            }

            lock (this)
            {
                done++;
            }

            this.SetProgress(done, total);
        }

        protected void SetProgress(int Done, int Total)
        {
            Invoke(new Action(() =>
            {
                lblProgress.Text = string.Format("{0}/{1}", Done, Total);
                lblProgress.Refresh();

                if (Total > 0)
                {
                    pbDefault.Value = (int)((decimal)Done / (decimal)Total * 100);
                    pbDefault.Refresh();
                }
                else
                {
                    pbDefault.Value = 100;
                    pbDefault.Refresh();
                }
            }));
        }

        protected void AddLog(string Text)
        {
            Text = string.Format("{0}: {1}{2}", DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss"), Text, Environment.NewLine);

            Invoke(new Action(() =>
            {
                txtLog.Text += Text;
                txtLog.Refresh();
            }));
        }

        protected bool DeclineNoun(string Word)
        {
            if (Word.IsNullOrEmpty())
            {
                MessageBox.Show("Необходимо ввести слово!", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Information);

                return false;
            }

            CyrWord cyr;

            try
            {
                cyr = cyrCollection.Get(Word);
            }
            catch (CyrWordNotFoundException)
            {
                MessageBox.Show(string.Format("Слово \"{0}\" не найдено в коллекции.", Word), this.Text, MessageBoxButtons.OK, MessageBoxIcon.Information);

                return false;
            }

            CyrResult result = cyr.Decline();
            string[] values = result.ToArray();

            txtCase1.Text = values[0];
            txtCase2.Text = values[1];
            txtCase3.Text = values[2];
            txtCase4.Text = values[3];
            txtCase5.Text = values[4];
            txtCase6.Text = values[5];

            Word word = db.Words.FirstOrDefault(val => val.Name == Word && val.SpeechPartID == (int)SpeechPartsEnum.Noun);

            if (word == null)
            {
                txtCaseCorrect1.Text = string.Empty;
                txtCaseCorrect2.Text = string.Empty;
                txtCaseCorrect3.Text = string.Empty;
                txtCaseCorrect4.Text = string.Empty;
                txtCaseCorrect5.Text = string.Empty;
                txtCaseCorrect6.Text = string.Empty;
            }
            else
            {
                WordCase wcase = word.WordCases.OrderByDescending(val => val.Name == values[0]).FirstOrDefault(val => val.CaseID == 1 && val.NumberID == (int)NumbersEnum.Singular);
                txtCaseCorrect1.Text = wcase != null ? wcase.Name : string.Empty;

                wcase = word.WordCases.OrderByDescending(val => val.Name == values[1]).FirstOrDefault(val => val.CaseID == 2 && val.NumberID == (int)NumbersEnum.Singular);
                txtCaseCorrect2.Text = wcase != null ? wcase.Name : string.Empty;

                wcase = word.WordCases.OrderByDescending(val => val.Name == values[2]).FirstOrDefault(val => val.CaseID == 3 && val.NumberID == (int)NumbersEnum.Singular);
                txtCaseCorrect3.Text = wcase != null ? wcase.Name : string.Empty;

                wcase = word.WordCases.OrderByDescending(val => val.Name == values[3]).FirstOrDefault(val => val.CaseID == 4 && val.NumberID == (int)NumbersEnum.Singular);
                txtCaseCorrect4.Text = wcase != null ? wcase.Name : string.Empty;

                wcase = word.WordCases.OrderByDescending(val => val.Name == values[4]).FirstOrDefault(val => val.CaseID == 5 && val.NumberID == (int)NumbersEnum.Singular);
                txtCaseCorrect5.Text = wcase != null ? wcase.Name : string.Empty;

                wcase = word.WordCases.OrderByDescending(val => val.Name == values[5]).FirstOrDefault(val => val.CaseID == 6 && val.NumberID == (int)NumbersEnum.Singular);
                txtCaseCorrect6.Text = wcase != null ? wcase.Name : string.Empty;
            }

            TextBox[] mineBoxes = new TextBox[] { txtCase1, txtCase2, txtCase3, txtCase4, txtCase5, txtCase6 };
            TextBox[] correctBoxes = new TextBox[] { txtCaseCorrect1, txtCaseCorrect2, txtCaseCorrect3, txtCaseCorrect4, txtCaseCorrect5, txtCaseCorrect6 };

            for (int i = 0; i < mineBoxes.Length; i++)
            {
                string v1 = mineBoxes[i].Text.ToLower();
                string v2 = correctBoxes[i].Text.ToLower();

                mineBoxes[i].BackColor = v1 == v2 ? System.Drawing.SystemColors.Control : System.Drawing.SystemColors.Highlight;
            }

            return txtCase1.BackColor == System.Drawing.SystemColors.Control
                && txtCase2.BackColor == System.Drawing.SystemColors.Control
                && txtCase3.BackColor == System.Drawing.SystemColors.Control
                && txtCase4.BackColor == System.Drawing.SystemColors.Control
                && txtCase5.BackColor == System.Drawing.SystemColors.Control
                && txtCase6.BackColor == System.Drawing.SystemColors.Control;
        }
    }
}
