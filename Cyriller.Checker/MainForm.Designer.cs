namespace Cyriller.Checker
{
    partial class MainForm
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.btnCheckENouns = new System.Windows.Forms.Button();
            this.lblProgress = new System.Windows.Forms.Label();
            this.btnCheckNouns = new System.Windows.Forms.Button();
            this.pbDefault = new System.Windows.Forms.ProgressBar();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.txtLetters = new System.Windows.Forms.TextBox();
            this.btnFirstHalf = new System.Windows.Forms.Button();
            this.btnSecondHalf = new System.Windows.Forms.Button();
            this.btnThirdHalf = new System.Windows.Forms.Button();
            this.btnFourthHalf = new System.Windows.Forms.Button();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.txtLog = new System.Windows.Forms.RichTextBox();
            this.tableLayoutPanel4 = new System.Windows.Forms.TableLayoutPanel();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtWord = new System.Windows.Forms.TextBox();
            this.txtCase1 = new System.Windows.Forms.TextBox();
            this.txtCase2 = new System.Windows.Forms.TextBox();
            this.txtCase3 = new System.Windows.Forms.TextBox();
            this.txtCase4 = new System.Windows.Forms.TextBox();
            this.txtCase5 = new System.Windows.Forms.TextBox();
            this.txtCase6 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnDecline = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.txtCaseCorrect1 = new System.Windows.Forms.TextBox();
            this.txtCaseCorrect2 = new System.Windows.Forms.TextBox();
            this.txtCaseCorrect3 = new System.Windows.Forms.TextBox();
            this.txtCaseCorrect4 = new System.Windows.Forms.TextBox();
            this.txtCaseCorrect5 = new System.Windows.Forms.TextBox();
            this.txtCaseCorrect6 = new System.Windows.Forms.TextBox();
            this.btnRandom = new System.Windows.Forms.Button();
            this.btnRandomWhile = new System.Windows.Forms.Button();
            this.tableLayoutPanel5 = new System.Windows.Forms.TableLayoutPanel();
            this.label9 = new System.Windows.Forms.Label();
            this.btnHelp = new System.Windows.Forms.Button();
            this.tableLayoutPanel7 = new System.Windows.Forms.TableLayoutPanel();
            this.label10 = new System.Windows.Forms.Label();
            this.btnLog = new System.Windows.Forms.Button();
            this.label11 = new System.Windows.Forms.Label();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            this.tableLayoutPanel4.SuspendLayout();
            this.tableLayoutPanel5.SuspendLayout();
            this.tableLayoutPanel7.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.pbDefault, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel3, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel5, 0, 3);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 4;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(984, 561);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // btnCheckENouns
            // 
            this.btnCheckENouns.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnCheckENouns.Location = new System.Drawing.Point(587, 3);
            this.btnCheckENouns.Name = "btnCheckENouns";
            this.btnCheckENouns.Size = new System.Drawing.Size(194, 24);
            this.btnCheckENouns.TabIndex = 2;
            this.btnCheckENouns.Text = "Проверить слова с Ё";
            this.btnCheckENouns.UseVisualStyleBackColor = true;
            this.btnCheckENouns.Click += new System.EventHandler(this.btnCheckENouns_Click);
            // 
            // lblProgress
            // 
            this.lblProgress.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblProgress.AutoSize = true;
            this.lblProgress.Location = new System.Drawing.Point(58, 8);
            this.lblProgress.Name = "lblProgress";
            this.lblProgress.Size = new System.Drawing.Size(24, 13);
            this.lblProgress.TabIndex = 1;
            this.lblProgress.Text = "0/0";
            // 
            // btnCheckNouns
            // 
            this.btnCheckNouns.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnCheckNouns.Location = new System.Drawing.Point(787, 3);
            this.btnCheckNouns.Name = "btnCheckNouns";
            this.btnCheckNouns.Size = new System.Drawing.Size(194, 24);
            this.btnCheckNouns.TabIndex = 0;
            this.btnCheckNouns.Text = "Запустить проверку";
            this.btnCheckNouns.UseVisualStyleBackColor = true;
            this.btnCheckNouns.Click += new System.EventHandler(this.btnCheckNouns_Click);
            // 
            // pbDefault
            // 
            this.pbDefault.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pbDefault.Location = new System.Drawing.Point(3, 474);
            this.pbDefault.Name = "pbDefault";
            this.pbDefault.Size = new System.Drawing.Size(978, 24);
            this.pbDefault.TabIndex = 1;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 6;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 250F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20.0008F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20.0008F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20.0008F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 19.9988F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 19.9988F));
            this.tableLayoutPanel2.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.txtLetters, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.btnFirstHalf, 2, 0);
            this.tableLayoutPanel2.Controls.Add(this.btnSecondHalf, 3, 0);
            this.tableLayoutPanel2.Controls.Add(this.btnThirdHalf, 4, 0);
            this.tableLayoutPanel2.Controls.Add(this.btnFourthHalf, 5, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(0, 501);
            this.tableLayoutPanel2.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(984, 30);
            this.tableLayoutPanel2.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 8);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(219, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Проверять слова, которые начинаются с:";
            // 
            // txtLetters
            // 
            this.txtLetters.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txtLetters.Location = new System.Drawing.Point(253, 5);
            this.txtLetters.Name = "txtLetters";
            this.txtLetters.Size = new System.Drawing.Size(140, 20);
            this.txtLetters.TabIndex = 1;
            // 
            // btnFirstHalf
            // 
            this.btnFirstHalf.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnFirstHalf.Location = new System.Drawing.Point(399, 3);
            this.btnFirstHalf.Name = "btnFirstHalf";
            this.btnFirstHalf.Size = new System.Drawing.Size(140, 24);
            this.btnFirstHalf.TabIndex = 2;
            this.btnFirstHalf.Text = "АБВГДЕЁЖ";
            this.btnFirstHalf.UseVisualStyleBackColor = true;
            this.btnFirstHalf.Click += new System.EventHandler(this.btnFirstHalf_Click);
            // 
            // btnSecondHalf
            // 
            this.btnSecondHalf.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnSecondHalf.Location = new System.Drawing.Point(545, 3);
            this.btnSecondHalf.Name = "btnSecondHalf";
            this.btnSecondHalf.Size = new System.Drawing.Size(140, 24);
            this.btnSecondHalf.TabIndex = 3;
            this.btnSecondHalf.Text = "ЗИЙКЛМНО";
            this.btnSecondHalf.UseVisualStyleBackColor = true;
            this.btnSecondHalf.Click += new System.EventHandler(this.btnSecondHalf_Click);
            // 
            // btnThirdHalf
            // 
            this.btnThirdHalf.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnThirdHalf.Location = new System.Drawing.Point(691, 3);
            this.btnThirdHalf.Name = "btnThirdHalf";
            this.btnThirdHalf.Size = new System.Drawing.Size(140, 24);
            this.btnThirdHalf.TabIndex = 4;
            this.btnThirdHalf.Text = "ПРСТУФХЦ";
            this.btnThirdHalf.UseVisualStyleBackColor = true;
            this.btnThirdHalf.Click += new System.EventHandler(this.btnThirdHalf_Click);
            // 
            // btnFourthHalf
            // 
            this.btnFourthHalf.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnFourthHalf.Location = new System.Drawing.Point(837, 3);
            this.btnFourthHalf.Name = "btnFourthHalf";
            this.btnFourthHalf.Size = new System.Drawing.Size(144, 24);
            this.btnFourthHalf.TabIndex = 5;
            this.btnFourthHalf.Text = "ЧШЩЪЫЪЭЮЯ";
            this.btnFourthHalf.UseVisualStyleBackColor = true;
            this.btnFourthHalf.Click += new System.EventHandler(this.btnFourthHalf_Click);
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 2;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 70F));
            this.tableLayoutPanel3.Controls.Add(this.tableLayoutPanel4, 1, 0);
            this.tableLayoutPanel3.Controls.Add(this.tableLayoutPanel7, 0, 0);
            this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel3.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 1;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(978, 465);
            this.tableLayoutPanel3.TabIndex = 4;
            // 
            // txtLog
            // 
            this.txtLog.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtLog.Location = new System.Drawing.Point(3, 33);
            this.txtLog.Name = "txtLog";
            this.txtLog.ReadOnly = true;
            this.txtLog.Size = new System.Drawing.Size(281, 393);
            this.txtLog.TabIndex = 2;
            this.txtLog.Text = "";
            // 
            // tableLayoutPanel4
            // 
            this.tableLayoutPanel4.ColumnCount = 3;
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 250F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel4.Controls.Add(this.label8, 0, 7);
            this.tableLayoutPanel4.Controls.Add(this.label7, 0, 6);
            this.tableLayoutPanel4.Controls.Add(this.label6, 0, 5);
            this.tableLayoutPanel4.Controls.Add(this.label5, 0, 4);
            this.tableLayoutPanel4.Controls.Add(this.label4, 0, 3);
            this.tableLayoutPanel4.Controls.Add(this.txtWord, 1, 1);
            this.tableLayoutPanel4.Controls.Add(this.txtCase1, 1, 2);
            this.tableLayoutPanel4.Controls.Add(this.txtCase2, 1, 3);
            this.tableLayoutPanel4.Controls.Add(this.txtCase3, 1, 4);
            this.tableLayoutPanel4.Controls.Add(this.txtCase4, 1, 5);
            this.tableLayoutPanel4.Controls.Add(this.txtCase5, 1, 6);
            this.tableLayoutPanel4.Controls.Add(this.txtCase6, 1, 7);
            this.tableLayoutPanel4.Controls.Add(this.label2, 1, 0);
            this.tableLayoutPanel4.Controls.Add(this.btnDecline, 1, 8);
            this.tableLayoutPanel4.Controls.Add(this.label3, 0, 2);
            this.tableLayoutPanel4.Controls.Add(this.txtCaseCorrect1, 2, 2);
            this.tableLayoutPanel4.Controls.Add(this.txtCaseCorrect2, 2, 3);
            this.tableLayoutPanel4.Controls.Add(this.txtCaseCorrect3, 2, 4);
            this.tableLayoutPanel4.Controls.Add(this.txtCaseCorrect4, 2, 5);
            this.tableLayoutPanel4.Controls.Add(this.txtCaseCorrect5, 2, 6);
            this.tableLayoutPanel4.Controls.Add(this.txtCaseCorrect6, 2, 7);
            this.tableLayoutPanel4.Controls.Add(this.btnRandom, 2, 8);
            this.tableLayoutPanel4.Controls.Add(this.btnRandomWhile, 2, 9);
            this.tableLayoutPanel4.Controls.Add(this.label9, 2, 1);
            this.tableLayoutPanel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel4.Location = new System.Drawing.Point(296, 3);
            this.tableLayoutPanel4.Name = "tableLayoutPanel4";
            this.tableLayoutPanel4.RowCount = 10;
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel4.Size = new System.Drawing.Size(679, 459);
            this.tableLayoutPanel4.TabIndex = 3;
            // 
            // label8
            // 
            this.label8.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(50, 218);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(197, 13);
            this.label8.TabIndex = 10;
            this.label8.Text = "Предложный, О ком? О чем? (думаю)";
            // 
            // label7
            // 
            this.label7.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(51, 188);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(196, 13);
            this.label7.TabIndex = 10;
            this.label7.Text = "Творительный, Кем? Чем? (горжусь)";
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(74, 158);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(173, 13);
            this.label6.TabIndex = 10;
            this.label6.Text = "Винительный, Кого? Что? (вижу)";
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(79, 128);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(168, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "Дательный, Кому? Чему? (дам)";
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(76, 98);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(171, 13);
            this.label4.TabIndex = 10;
            this.label4.Text = "Родительный, Кого? Чего? (нет)";
            // 
            // txtWord
            // 
            this.txtWord.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txtWord.Location = new System.Drawing.Point(253, 35);
            this.txtWord.Name = "txtWord";
            this.txtWord.Size = new System.Drawing.Size(208, 20);
            this.txtWord.TabIndex = 0;
            // 
            // txtCase1
            // 
            this.txtCase1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txtCase1.Location = new System.Drawing.Point(253, 65);
            this.txtCase1.Name = "txtCase1";
            this.txtCase1.ReadOnly = true;
            this.txtCase1.Size = new System.Drawing.Size(208, 20);
            this.txtCase1.TabIndex = 1;
            // 
            // txtCase2
            // 
            this.txtCase2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txtCase2.Location = new System.Drawing.Point(253, 95);
            this.txtCase2.Name = "txtCase2";
            this.txtCase2.ReadOnly = true;
            this.txtCase2.Size = new System.Drawing.Size(208, 20);
            this.txtCase2.TabIndex = 2;
            // 
            // txtCase3
            // 
            this.txtCase3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txtCase3.Location = new System.Drawing.Point(253, 125);
            this.txtCase3.Name = "txtCase3";
            this.txtCase3.ReadOnly = true;
            this.txtCase3.Size = new System.Drawing.Size(208, 20);
            this.txtCase3.TabIndex = 3;
            // 
            // txtCase4
            // 
            this.txtCase4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txtCase4.Location = new System.Drawing.Point(253, 155);
            this.txtCase4.Name = "txtCase4";
            this.txtCase4.ReadOnly = true;
            this.txtCase4.Size = new System.Drawing.Size(208, 20);
            this.txtCase4.TabIndex = 4;
            // 
            // txtCase5
            // 
            this.txtCase5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txtCase5.Location = new System.Drawing.Point(253, 185);
            this.txtCase5.Name = "txtCase5";
            this.txtCase5.ReadOnly = true;
            this.txtCase5.Size = new System.Drawing.Size(208, 20);
            this.txtCase5.TabIndex = 5;
            // 
            // txtCase6
            // 
            this.txtCase6.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txtCase6.Location = new System.Drawing.Point(253, 215);
            this.txtCase6.Name = "txtCase6";
            this.txtCase6.ReadOnly = true;
            this.txtCase6.Size = new System.Drawing.Size(208, 20);
            this.txtCase6.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(313, 8);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(88, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Склонять слово";
            // 
            // btnDecline
            // 
            this.btnDecline.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnDecline.Location = new System.Drawing.Point(253, 243);
            this.btnDecline.Name = "btnDecline";
            this.btnDecline.Size = new System.Drawing.Size(208, 24);
            this.btnDecline.TabIndex = 8;
            this.btnDecline.Text = "Склонять введенное слово";
            this.btnDecline.UseVisualStyleBackColor = true;
            this.btnDecline.Click += new System.EventHandler(this.btnDecline_Click);
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(73, 68);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(174, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "Именительный, Кто? Что? (есть)";
            // 
            // txtCaseCorrect1
            // 
            this.txtCaseCorrect1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txtCaseCorrect1.Location = new System.Drawing.Point(467, 65);
            this.txtCaseCorrect1.Name = "txtCaseCorrect1";
            this.txtCaseCorrect1.ReadOnly = true;
            this.txtCaseCorrect1.Size = new System.Drawing.Size(209, 20);
            this.txtCaseCorrect1.TabIndex = 12;
            // 
            // txtCaseCorrect2
            // 
            this.txtCaseCorrect2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txtCaseCorrect2.Location = new System.Drawing.Point(467, 95);
            this.txtCaseCorrect2.Name = "txtCaseCorrect2";
            this.txtCaseCorrect2.ReadOnly = true;
            this.txtCaseCorrect2.Size = new System.Drawing.Size(209, 20);
            this.txtCaseCorrect2.TabIndex = 13;
            // 
            // txtCaseCorrect3
            // 
            this.txtCaseCorrect3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txtCaseCorrect3.Location = new System.Drawing.Point(467, 125);
            this.txtCaseCorrect3.Name = "txtCaseCorrect3";
            this.txtCaseCorrect3.ReadOnly = true;
            this.txtCaseCorrect3.Size = new System.Drawing.Size(209, 20);
            this.txtCaseCorrect3.TabIndex = 14;
            // 
            // txtCaseCorrect4
            // 
            this.txtCaseCorrect4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txtCaseCorrect4.Location = new System.Drawing.Point(467, 155);
            this.txtCaseCorrect4.Name = "txtCaseCorrect4";
            this.txtCaseCorrect4.ReadOnly = true;
            this.txtCaseCorrect4.Size = new System.Drawing.Size(209, 20);
            this.txtCaseCorrect4.TabIndex = 15;
            // 
            // txtCaseCorrect5
            // 
            this.txtCaseCorrect5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txtCaseCorrect5.Location = new System.Drawing.Point(467, 185);
            this.txtCaseCorrect5.Name = "txtCaseCorrect5";
            this.txtCaseCorrect5.ReadOnly = true;
            this.txtCaseCorrect5.Size = new System.Drawing.Size(209, 20);
            this.txtCaseCorrect5.TabIndex = 16;
            // 
            // txtCaseCorrect6
            // 
            this.txtCaseCorrect6.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txtCaseCorrect6.Location = new System.Drawing.Point(467, 215);
            this.txtCaseCorrect6.Name = "txtCaseCorrect6";
            this.txtCaseCorrect6.ReadOnly = true;
            this.txtCaseCorrect6.Size = new System.Drawing.Size(209, 20);
            this.txtCaseCorrect6.TabIndex = 17;
            // 
            // btnRandom
            // 
            this.btnRandom.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnRandom.Location = new System.Drawing.Point(467, 243);
            this.btnRandom.Name = "btnRandom";
            this.btnRandom.Size = new System.Drawing.Size(209, 24);
            this.btnRandom.TabIndex = 18;
            this.btnRandom.Text = "Склонять случайное слово";
            this.btnRandom.UseVisualStyleBackColor = true;
            this.btnRandom.Click += new System.EventHandler(this.btnRandom_Click);
            // 
            // btnRandomWhile
            // 
            this.btnRandomWhile.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnRandomWhile.Location = new System.Drawing.Point(467, 273);
            this.btnRandomWhile.Name = "btnRandomWhile";
            this.btnRandomWhile.Size = new System.Drawing.Size(209, 24);
            this.btnRandomWhile.TabIndex = 19;
            this.btnRandomWhile.Text = "Случайным выбором искать ошибки";
            this.btnRandomWhile.UseVisualStyleBackColor = true;
            this.btnRandomWhile.Click += new System.EventHandler(this.btnRandomWhile_Click);
            // 
            // tableLayoutPanel5
            // 
            this.tableLayoutPanel5.ColumnCount = 6;
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 55F));
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 200F));
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 200F));
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 200F));
            this.tableLayoutPanel5.Controls.Add(this.btnCheckNouns, 5, 0);
            this.tableLayoutPanel5.Controls.Add(this.btnCheckENouns, 4, 0);
            this.tableLayoutPanel5.Controls.Add(this.lblProgress, 1, 0);
            this.tableLayoutPanel5.Controls.Add(this.btnHelp, 3, 0);
            this.tableLayoutPanel5.Controls.Add(this.label11, 0, 0);
            this.tableLayoutPanel5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel5.Location = new System.Drawing.Point(0, 531);
            this.tableLayoutPanel5.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanel5.Name = "tableLayoutPanel5";
            this.tableLayoutPanel5.RowCount = 1;
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel5.Size = new System.Drawing.Size(984, 30);
            this.tableLayoutPanel5.TabIndex = 5;
            // 
            // label9
            // 
            this.label9.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(467, 38);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(99, 13);
            this.label9.TabIndex = 20;
            this.label9.Text = "Значения из базы";
            // 
            // btnHelp
            // 
            this.btnHelp.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnHelp.Location = new System.Drawing.Point(387, 3);
            this.btnHelp.Name = "btnHelp";
            this.btnHelp.Size = new System.Drawing.Size(194, 24);
            this.btnHelp.TabIndex = 3;
            this.btnHelp.Text = "Помощь и обратная связь";
            this.btnHelp.UseVisualStyleBackColor = true;
            this.btnHelp.Click += new System.EventHandler(this.btnHelp_Click);
            // 
            // tableLayoutPanel7
            // 
            this.tableLayoutPanel7.ColumnCount = 1;
            this.tableLayoutPanel7.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel7.Controls.Add(this.txtLog, 0, 1);
            this.tableLayoutPanel7.Controls.Add(this.label10, 0, 0);
            this.tableLayoutPanel7.Controls.Add(this.btnLog, 0, 2);
            this.tableLayoutPanel7.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel7.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel7.Name = "tableLayoutPanel7";
            this.tableLayoutPanel7.RowCount = 3;
            this.tableLayoutPanel7.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel7.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel7.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel7.Size = new System.Drawing.Size(287, 459);
            this.tableLayoutPanel7.TabIndex = 4;
            // 
            // label10
            // 
            this.label10.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(98, 17);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(91, 13);
            this.label10.TabIndex = 3;
            this.label10.Text = "Лог приложения";
            // 
            // btnLog
            // 
            this.btnLog.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.btnLog.Location = new System.Drawing.Point(88, 432);
            this.btnLog.Name = "btnLog";
            this.btnLog.Size = new System.Drawing.Size(110, 24);
            this.btnLog.TabIndex = 4;
            this.btnLog.Text = "Очистить лог";
            this.btnLog.UseVisualStyleBackColor = true;
            this.btnLog.Click += new System.EventHandler(this.btnLog_Click);
            // 
            // label11
            // 
            this.label11.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(3, 8);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(45, 13);
            this.label11.TabIndex = 4;
            this.label11.Text = "Готово:";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(984, 561);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Кириллер";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.tableLayoutPanel3.ResumeLayout(false);
            this.tableLayoutPanel4.ResumeLayout(false);
            this.tableLayoutPanel4.PerformLayout();
            this.tableLayoutPanel5.ResumeLayout(false);
            this.tableLayoutPanel5.PerformLayout();
            this.tableLayoutPanel7.ResumeLayout(false);
            this.tableLayoutPanel7.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Button btnCheckNouns;
        private System.Windows.Forms.ProgressBar pbDefault;
        private System.Windows.Forms.RichTextBox txtLog;
        private System.Windows.Forms.Label lblProgress;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtLetters;
        private System.Windows.Forms.Button btnFirstHalf;
        private System.Windows.Forms.Button btnSecondHalf;
        private System.Windows.Forms.Button btnThirdHalf;
        private System.Windows.Forms.Button btnFourthHalf;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel4;
        private System.Windows.Forms.TextBox txtWord;
        private System.Windows.Forms.TextBox txtCase1;
        private System.Windows.Forms.TextBox txtCase2;
        private System.Windows.Forms.TextBox txtCase3;
        private System.Windows.Forms.TextBox txtCase4;
        private System.Windows.Forms.TextBox txtCase5;
        private System.Windows.Forms.TextBox txtCase6;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnDecline;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtCaseCorrect1;
        private System.Windows.Forms.TextBox txtCaseCorrect2;
        private System.Windows.Forms.TextBox txtCaseCorrect3;
        private System.Windows.Forms.TextBox txtCaseCorrect4;
        private System.Windows.Forms.TextBox txtCaseCorrect5;
        private System.Windows.Forms.TextBox txtCaseCorrect6;
        private System.Windows.Forms.Button btnRandom;
        private System.Windows.Forms.Button btnRandomWhile;
        private System.Windows.Forms.Button btnCheckENouns;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel5;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button btnHelp;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel7;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button btnLog;
        private System.Windows.Forms.Label label11;
    }
}

