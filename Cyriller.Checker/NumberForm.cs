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
    public partial class NumberForm : UserControl
    {
        CyrNounCollection cyrCollection;

        public NumberForm()
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

        private void NumberForm_Load(object sender, EventArgs e)
        {
            ddlAction.SelectedIndex = 0;
            this.ParentForm.AcceptButton = btnDecline;
            cyrCollection = new CyrNounCollection();
        }

        private void btnDecline_Click(object sender, EventArgs e)
        {
            CyrNumber number = new CyrNumber();
            CyrResult result = null;

            switch (ddlAction.SelectedIndex)
            {
                case 0:
                    if (txtItem.Text.IsNullOrEmpty())
                    {
                        MessageBox.Show("Необходимо ввести единицу измерения!");
                        return;
                    }

                    CyrNoun noun;

                    try
                    {
                        noun = cyrCollection.Get(txtItem.Text, out string fw, out CasesEnum c, out NumbersEnum n);
                    }
                    catch (CyrWordNotFoundException ex)
                    {
                        MessageBox.Show(string.Format("Слово {0} не найдено в коллекции!", ex.Word));
                        return;
                    }

                    CyrNumber.Item item = new CyrNumber.Item(noun);

                    result = number.Decline(txtNumber.Value, item);

                    break;
                case 1:
                    result = number.Decline(txtNumber.Value);
                    break;
                case 2:
                    result = number.Decline(txtNumber.Value, Cyriller.Model.GendersEnum.Feminine, Cyriller.Model.AnimatesEnum.Inanimated);
                    break;
                case 3:
                    result = number.Decline(txtNumber.Value, new CyrNumber.RurCurrency());
                    break;
                case 4:
                    result = number.Decline(txtNumber.Value, new CyrNumber.UsdCurrency());
                    break;
                case 5:
                    result = number.Decline(txtNumber.Value, new CyrNumber.EurCurrency());
                    break;
                case 6:
                    result = number.Decline(txtNumber.Value, new CyrNumber.YuanCurrency());
                    break;
                default:
                    MessageBox.Show("Необходимо выбрать тип склонения!");
                    return;
            }

            SetResult(result);
        }

        private void ddlAction_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtItem.Enabled = ddlAction.SelectedIndex == 0;
        }
    }
}
