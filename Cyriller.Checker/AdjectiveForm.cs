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
    public partial class AdjectiveForm : UserControl
    {
        CyrAdjectiveCollection cyrCollection;

        public AdjectiveForm()
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

        private void AdjectiveForm_Load(object sender, EventArgs e)
        {
            ddlAction.SelectedIndex = 0;
            ddlGender.SelectedIndex = 0;
            cyrCollection = new CyrAdjectiveCollection();
            this.ParentForm.AcceptButton = btnDecline;
        }

        private void btnDecline_Click(object sender, EventArgs e)
        {
            if (txtWord.Text.IsNullOrEmpty())
            {
                MessageBox.Show("Необходимо ввести слово!");
            }

            CyrAdjective adj;
            GendersEnum gender = 0;

            switch (ddlGender.SelectedIndex)
            {
                case 1:
                    gender = GendersEnum.Masculine;
                    break;
                case 2:
                    gender = GendersEnum.Feminine;
                    break;
                case 3:
                    gender = GendersEnum.Neuter;
                    break;
            }

            try
            {
                adj = cyrCollection.Get(txtWord.Text, GetConditionsEnum.Similar, gender);
            }
            catch (CyrWordNotFoundException)
            {
                MessageBox.Show("Данное слово не найдено в коллекции!");
                return;
            }

            switch (ddlAction.SelectedIndex)
            {
                case 0:
                    this.SetResult(adj.Decline(AnimatesEnum.Animated));
                    break;
                case 1:
                    this.SetResult(adj.DeclinePlural(AnimatesEnum.Animated));
                    break;

                default:
                    MessageBox.Show("Необходимо выбрать тип склонения!");
                    return;
            }

            txtCollectionName.Text = adj.CollectionName;
            txtDetails.Text = string.Empty;

            switch (adj.Gender)
            {
                case Cyriller.Model.GendersEnum.Feminine:
                    txtDetails.Text += "женский род";
                    break;
                case Cyriller.Model.GendersEnum.Masculine:
                    txtDetails.Text += "мужской род";
                    break;
                case Cyriller.Model.GendersEnum.Neuter:
                    txtDetails.Text += "средний род";
                    break;
            }

            if (adj.ExactMatch)
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
