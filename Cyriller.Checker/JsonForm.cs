using System;
using System.Collections.Generic;
using System.Collections.Concurrent;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using Newtonsoft.Json;
using Cyriller.Model;
using Cyriller.Checker.Model;

namespace Cyriller.Checker
{
    public partial class JsonForm : UserControl
    {
        public JsonForm()
        {
            InitializeComponent();
        }

        private void btnSelectFolder_Click(object sender, EventArgs e)
        {
            if (fbdDialog.ShowDialog() == DialogResult.OK)
            {
                txtFolder.Text = fbdDialog.SelectedPath;
            }
        }

        private void WriteToFile(string content, string filePath)
        {
            FileInfo fi = new FileInfo(filePath);

            if (!fi.Directory.Exists)
            {
                fi.Directory.Create();
            }
            else if (fi.Exists)
            {
                fi.Delete();
            }

            TextWriter writer = new StreamWriter(fi.FullName, true, Encoding.UTF8);

            writer.Write(content);
            writer.Dispose();
        }

        private void btnNouns_Click(object sender, EventArgs e)
        {
            this.Cursor = Cursors.WaitCursor;

            CyrNounCollection collection = new CyrNounCollection();
            ConcurrentBag<Dictionary<string, object>> words = new ConcurrentBag<Dictionary<string, object>>();
            string filePath = Path.Combine(txtFolder.Text, "nouns.json");

            collection.SelectNouns().AsParallel().ForAll(noun =>
            {
                CyrResult singular = noun.Decline();
                CyrResult plural = noun.DeclinePlural();
                Dictionary<string, object> result = new Dictionary<string, object>();

                result.Add(nameof(CyrNoun.Animate), noun.Animate.ToString());
                result.Add(nameof(CyrNoun.Gender), noun.Gender.ToString());
                result.Add(nameof(CyrNoun.Name), noun.Name);
                result.Add(nameof(CyrNoun.WordType), noun.WordType.ToString());

                result.Add(nameof(NumbersEnum.Singular), singular.ToArray());
                result.Add(nameof(NumbersEnum.Plural), plural.ToArray());

                words.Add(result);
            });

            string json = JsonConvert.SerializeObject(words.OrderBy(x => x[nameof(CyrNoun.Name)]), Formatting.Indented);

            this.WriteToFile(json, filePath);
            this.Cursor = Cursors.Default;
        }

        private void btnAdjectives_Click(object sender, EventArgs e)
        {
            this.Cursor = Cursors.WaitCursor;

            CyrAdjectiveCollection collection = new CyrAdjectiveCollection();
            ConcurrentBag<Dictionary<string, object>> words = new ConcurrentBag<Dictionary<string, object>>();
            string filePath = Path.Combine(txtFolder.Text, "adjectives.json");
            GendersEnum[] genders = new GendersEnum[] { GendersEnum.Neuter, GendersEnum.Masculine, GendersEnum.Feminine };

            collection.SelectAdjectives().AsParallel().ForAll(adj =>
            {
                Dictionary<string, object> result = new Dictionary<string, object>();

                result.Add(nameof(CyrAdjective.Name), adj.Name);

                {
                    CyrResult animated = adj.DeclinePlural(AnimatesEnum.Animated);
                    result[nameof(NumbersEnum.Plural)] = animated.ToArray();
                }

                foreach (GendersEnum gender in genders)
                {
                    CyrResult animated = adj.Decline(gender, AnimatesEnum.Animated);
                    result[gender.ToString()] = animated.ToArray();
                }

                words.Add(result);
            });

            string json = JsonConvert.SerializeObject(words.OrderBy(x => x[nameof(CyrAdjective.Name)]), Formatting.Indented);

            this.WriteToFile(json, filePath);
            this.Cursor = Cursors.Default;
        }
    }
}
