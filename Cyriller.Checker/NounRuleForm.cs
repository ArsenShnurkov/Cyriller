using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cyriller.Checker
{
    public partial class NounRuleForm : UserControl
    {
        public NounRuleForm()
        {
            InitializeComponent();
        }

        protected void RefreshRule()
        {
            string noun = txtCase1.Text;

            if (string.IsNullOrEmpty(noun))
            {
                txtRule.Text = null;
                return;
            }

            string[] parts = noun.Split(CyrNoun.Hyphen.ToCharArray(), StringSplitOptions.RemoveEmptyEntries);
            List<string> rules = new List<string>();
            string[] variants = new string[] { txtCase2.Text, txtCase3.Text, txtCase4.Text, txtCase5.Text, txtCase6.Text, txtCasePlural1.Text, txtCasePlural2.Text, txtCasePlural3.Text, txtCasePlural4.Text, txtCasePlural5.Text, txtCasePlural6.Text };
            string[][] variantParts = variants.Select(x => x.Split(CyrNoun.Hyphen.ToCharArray(), StringSplitOptions.RemoveEmptyEntries)).ToArray();

            for (int i = 0; i < parts.Length; i++)
            {
                string part = parts[i];
                string[] variant = variantParts.Select(x => x.Length > i ? x[i] : null).ToArray();

                rules.Add(this.GetNounRule(part, variant));
            }

            string rule = string.Join("|", rules.ToArray());

            txtRule.Text = rule;
        }

        protected string GetNounRule(string noun, string[] variants)
        {
            List<string> rules = new List<string>();

            foreach (string variant in variants)
            {
                if (string.IsNullOrEmpty(variant))
                {
                    rules.Add("*");
                    continue;
                }

                int index = 0;
                StringBuilder sb = new StringBuilder();

                for (index = 0; index < noun.Length && index < variant.Length; index++)
                {
                    if (noun[index] != variant[index])
                    {
                        break;
                    }
                }

                string end = variant.Substring(index);
                int cut = noun.Length - index;

                sb.Append(end);

                if (cut > 0)
                {
                    sb.Append(cut);
                }

                rules.Add(sb.ToString());
            }

            return string.Join(",", rules.ToArray());
        }

        private void txtCase1_TextChanged(object sender, EventArgs e)
        {
            RefreshRule();
        }

        private void txtCase2_TextChanged(object sender, EventArgs e)
        {
            RefreshRule();
        }

        private void txtCase3_TextChanged(object sender, EventArgs e)
        {
            RefreshRule();
        }

        private void txtCase4_TextChanged(object sender, EventArgs e)
        {
            RefreshRule();
        }

        private void txtCase5_TextChanged(object sender, EventArgs e)
        {
            RefreshRule();
        }

        private void txtCase6_TextChanged(object sender, EventArgs e)
        {
            RefreshRule();
        }

        private void txtCasePlural1_TextChanged(object sender, EventArgs e)
        {
            RefreshRule();
        }

        private void txtCasePlural2_TextChanged(object sender, EventArgs e)
        {
            RefreshRule();
        }

        private void txtCasePlural3_TextChanged(object sender, EventArgs e)
        {
            RefreshRule();
        }

        private void txtCasePlural4_TextChanged(object sender, EventArgs e)
        {
            RefreshRule();
        }

        private void txtCasePlural5_TextChanged(object sender, EventArgs e)
        {
            RefreshRule();
        }

        private void txtCasePlural6_TextChanged(object sender, EventArgs e)
        {
            RefreshRule();
        }
    }
}
