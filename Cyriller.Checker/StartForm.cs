using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cyriller.Checker
{
    public partial class StartForm : Form
    {
        public StartForm()
        {
            InitializeComponent();
        }

        protected void OpenForm(Control form)
        {
            form.Dock = DockStyle.Fill;
            pnlContainer.Controls.Clear();
            pnlContainer.Controls.Add(form);
        }

        private void msiNumber_Click(object sender, EventArgs e)
        {
            OpenForm(new NumberForm());
        }

        private void msiNoun_Click(object sender, EventArgs e)
        {
            OpenForm(new NounForm());
        }

        private void msiExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void StartForm_Load(object sender, EventArgs e)
        {
            OpenForm(new AboutForm());
        }

        private void msiAdjective_Click(object sender, EventArgs e)
        {
            OpenForm(new AdjectiveForm());
        }

        private void msiPhrase_Click(object sender, EventArgs e)
        {
            OpenForm(new PhraseForm());
        }

        private void msiExportToJson_Click(object sender, EventArgs e)
        {
            OpenForm(new JsonForm());
        }
    }
}
