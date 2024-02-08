using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Cyriller.Model;

namespace Cyriller.Checker
{
    public partial class PhraseForm : UserControl
    {
        CyrAdjectiveCollection adjCollection;
        CyrNounCollection nounCollection;

        public PhraseForm()
        {
            InitializeComponent();
        }

        protected void SetResult(CyrResult result)
        {
            txtCase1.Text = result[1];
            txtCase2.Text = result[2];
            txtCase3.Text = result[3];
            txtCase4.Text = result[4];
            txtCase5.Text = result[5];
            txtCase6.Text = result[6];
        }

        private void PhraseForm_Load(object sender, EventArgs e)
        {
            ddlAction.SelectedIndex = 0;
            adjCollection = new CyrAdjectiveCollection();
            nounCollection = new CyrNounCollection();
            this.ParentForm.AcceptButton = btnDecline;
        }

        private void btnDecline_Click(object sender, EventArgs e)
        {
            if (txtWord.Text.IsNullOrEmpty())
            {
                MessageBox.Show("Необходимо ввести слово или фразу!");
            }

            CyrPhrase phrase = new CyrPhrase(nounCollection, adjCollection);
            CyrResult result;

            try
            {
                if (ddlAction.SelectedIndex == 0)
                {
                    result = phrase.Decline(txtWord.Text, GetConditionsEnum.Similar);
                }
                else
                {
                    result = phrase.DeclinePlural(txtWord.Text, GetConditionsEnum.Similar);
                }
            }
            catch (CyrWordNotFoundException ex)
            {
                MessageBox.Show(string.Format("Слово {0} не найдено в коллекции!", ex.Word));
                return;
            }

            this.SetResult(result);
        }
    }
}
