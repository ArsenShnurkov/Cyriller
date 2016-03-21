using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.IO.Compression;

namespace Cyriller.Checker
{
    public partial class ZipForm : UserControl
    {
        public ZipForm()
        {
            InitializeComponent();
        }

        private void ZipFile(string FolderPath, string DictionaryName)
        {
            if (txtFolder.Text.IsNullOrEmpty())
            {
                MessageBox.Show("Нужно выбрать папку!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            DirectoryInfo di = new DirectoryInfo(FolderPath);

            if (!di.Exists)
            {
                MessageBox.Show("Неправильно выбрана папка!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            FileInfo fi = new FileInfo(Path.Combine(di.FullName, DictionaryName + ".gz"));

            if (fi.Exists)
            {
                fi.Delete();
            }

            FileInfo textFi = new FileInfo(Path.Combine(di.FullName, DictionaryName + ".txt"));

            if (!textFi.Exists)
            {
                MessageBox.Show("Неправильно выбрана папка! Файл " + textFi.Name + " не найден!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            FileStream read = new FileStream(textFi.FullName, FileMode.Open);
            FileStream writer = new FileStream(fi.FullName, FileMode.Create);
            GZipStream gzip = new GZipStream(writer, CompressionLevel.Optimal);

            read.CopyTo(gzip);
            read.Dispose();
            gzip.Dispose();
            writer.Dispose();

            MessageBox.Show("Файл " + fi.Name + " успешно запакован!", "Результат", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void ZipForm_Load(object sender, EventArgs e)
        {

        }

        private void btnSelectFolder_Click(object sender, EventArgs e)
        {
            if (fbdDialog.ShowDialog() == DialogResult.OK)
            {
                txtFolder.Text = fbdDialog.SelectedPath;
            }
        }

        private void btnNouns_Click(object sender, EventArgs e)
        {
            ZipFile(txtFolder.Text, "nouns");
        }

        private void btnNounRules_Click(object sender, EventArgs e)
        {
            ZipFile(txtFolder.Text, "noun-rules");
        }

        private void btnAdjectives_Click(object sender, EventArgs e)
        {
            ZipFile(txtFolder.Text, "adjectives");
        }

        private void btnAdjectiveRules_Click(object sender, EventArgs e)
        {
            ZipFile(txtFolder.Text, "adjective-rules");
        }
    }
}
