namespace Cyriller.Checker
{
    partial class ZipForm
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.btnNouns = new System.Windows.Forms.Button();
            this.btnNounRules = new System.Windows.Forms.Button();
            this.btnAdjectives = new System.Windows.Forms.Button();
            this.btnAdjectiveRules = new System.Windows.Forms.Button();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.txtFolder = new System.Windows.Forms.TextBox();
            this.btnSelectFolder = new System.Windows.Forms.Button();
            this.fbdDialog = new System.Windows.Forms.FolderBrowserDialog();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 70F));
            this.tableLayoutPanel1.Controls.Add(this.label1, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.label2, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.label3, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.label4, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.label5, 0, 4);
            this.tableLayoutPanel1.Controls.Add(this.label6, 0, 5);
            this.tableLayoutPanel1.Controls.Add(this.btnNouns, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.btnNounRules, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.btnAdjectives, 1, 4);
            this.tableLayoutPanel1.Controls.Add(this.btnAdjectiveRules, 1, 5);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 1, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 7;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1000, 600);
            this.tableLayoutPanel1.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(303, 8);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(112, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Запаковать словарь";
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(255, 38);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(42, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Папка:";
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(194, 68);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(103, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Существительные:";
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(149, 98);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(148, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Правила существительных:";
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(201, 128);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(96, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Прилагательные:";
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(157, 158);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(140, 13);
            this.label6.TabIndex = 5;
            this.label6.Text = "Правила прилагательных:";
            // 
            // btnNouns
            // 
            this.btnNouns.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.btnNouns.Location = new System.Drawing.Point(303, 63);
            this.btnNouns.Name = "btnNouns";
            this.btnNouns.Size = new System.Drawing.Size(75, 23);
            this.btnNouns.TabIndex = 6;
            this.btnNouns.Text = "Запаковать";
            this.btnNouns.UseVisualStyleBackColor = true;
            this.btnNouns.Click += new System.EventHandler(this.btnNouns_Click);
            // 
            // btnNounRules
            // 
            this.btnNounRules.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.btnNounRules.Location = new System.Drawing.Point(303, 93);
            this.btnNounRules.Name = "btnNounRules";
            this.btnNounRules.Size = new System.Drawing.Size(75, 23);
            this.btnNounRules.TabIndex = 7;
            this.btnNounRules.Text = "Запаковать";
            this.btnNounRules.UseVisualStyleBackColor = true;
            this.btnNounRules.Click += new System.EventHandler(this.btnNounRules_Click);
            // 
            // btnAdjectives
            // 
            this.btnAdjectives.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.btnAdjectives.Location = new System.Drawing.Point(303, 123);
            this.btnAdjectives.Name = "btnAdjectives";
            this.btnAdjectives.Size = new System.Drawing.Size(75, 23);
            this.btnAdjectives.TabIndex = 8;
            this.btnAdjectives.Text = "Запаковать";
            this.btnAdjectives.UseVisualStyleBackColor = true;
            this.btnAdjectives.Click += new System.EventHandler(this.btnAdjectives_Click);
            // 
            // btnAdjectiveRules
            // 
            this.btnAdjectiveRules.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.btnAdjectiveRules.Location = new System.Drawing.Point(303, 153);
            this.btnAdjectiveRules.Name = "btnAdjectiveRules";
            this.btnAdjectiveRules.Size = new System.Drawing.Size(75, 23);
            this.btnAdjectiveRules.TabIndex = 9;
            this.btnAdjectiveRules.Text = "Запаковать";
            this.btnAdjectiveRules.UseVisualStyleBackColor = true;
            this.btnAdjectiveRules.Click += new System.EventHandler(this.btnAdjectiveRules_Click);
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 80F));
            this.tableLayoutPanel2.Controls.Add(this.txtFolder, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.btnSelectFolder, 1, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(300, 30);
            this.tableLayoutPanel2.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(700, 30);
            this.tableLayoutPanel2.TabIndex = 10;
            // 
            // txtFolder
            // 
            this.txtFolder.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txtFolder.Location = new System.Drawing.Point(3, 5);
            this.txtFolder.Name = "txtFolder";
            this.txtFolder.Size = new System.Drawing.Size(614, 20);
            this.txtFolder.TabIndex = 0;
            this.txtFolder.Text = "E:\\GitHub\\Miyconst\\Cyriller\\Cyriller\\App_Data";
            // 
            // btnSelectFolder
            // 
            this.btnSelectFolder.Location = new System.Drawing.Point(623, 3);
            this.btnSelectFolder.Name = "btnSelectFolder";
            this.btnSelectFolder.Size = new System.Drawing.Size(74, 23);
            this.btnSelectFolder.TabIndex = 1;
            this.btnSelectFolder.Text = "Выбрать";
            this.btnSelectFolder.UseVisualStyleBackColor = true;
            this.btnSelectFolder.Click += new System.EventHandler(this.btnSelectFolder_Click);
            // 
            // ZipForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "ZipForm";
            this.Size = new System.Drawing.Size(1000, 600);
            this.Load += new System.EventHandler(this.ZipForm_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnNouns;
        private System.Windows.Forms.Button btnNounRules;
        private System.Windows.Forms.Button btnAdjectives;
        private System.Windows.Forms.Button btnAdjectiveRules;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.TextBox txtFolder;
        private System.Windows.Forms.Button btnSelectFolder;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.FolderBrowserDialog fbdDialog;
    }
}
