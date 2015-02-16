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
    public partial class NounForm : UserControl
    {
        CyrNounCollection cyrCollection;

        public NounForm()
        {
            InitializeComponent();
        }

        protected void SetResult(CyrResult Result)
        {
            txtCase1.Text = Result[1];
            txtCase2.Text = Result[2];
            txtCase3.Text = Result[3];
            txtCase4.Text = Result[4];
            txtCase5.Text = Result[5];
            txtCase6.Text = Result[6];
        }

        private void NounForm_Load(object sender, EventArgs e)
        {
            cyrCollection = new CyrNounCollection();
            ddlAction.SelectedIndex = 0;
            this.ParentForm.AcceptButton = btnDecline;
        }

        private void btnDecline_Click(object sender, EventArgs e)
        {
            if (txtWord.Text.IsNullOrEmpty())
            {
                MessageBox.Show("Необходимо ввести слово!");
            }

            CyrNoun noun;

            try
            {
                noun = cyrCollection.Get(txtWord.Text, GetConditionsEnum.Similar);
            }
            catch (CyrWordNotFoundException)
            {
                MessageBox.Show("Данное слово не найдено в коллекции!");
                return;
            }

            switch (ddlAction.SelectedIndex)
            { 
                case 0:
                    this.SetResult(noun.Decline());
                    break;
                case 1:
                    this.SetResult(noun.DeclinePlural());
                    break;

                default:
                    MessageBox.Show("Необходимо выбрать тип склонения!");
                    return;
            }

            txtCollectionName.Text = noun.CollectionName;
            txtDetails.Text = string.Empty;

            switch (noun.Gender)
            {
                case Cyriller.Model.GendersEnum.Feminine:
                    txtDetails.Text += "женский род, ";
                    break;
                case Cyriller.Model.GendersEnum.Masculine:
                    txtDetails.Text += "мужской род, ";
                    break;
                case Cyriller.Model.GendersEnum.Neuter:
                    txtDetails.Text += "средний род, ";
                    break;
            }

            switch (noun.Animate)
            { 
                case Cyriller.Model.AnimatesEnum.Animated:
                    txtDetails.Text += "одушевленное";
                    break;
                default:
                    txtDetails.Text += "неодушевленное";
                    break;
            }

            if (noun.ExactMatch)
            {
                txtCollectionName.BackColor = System.Drawing.SystemColors.Control;
            }
            else
            {
                txtCollectionName.BackColor = System.Drawing.SystemColors.Highlight;
            }
        }
    }
}
