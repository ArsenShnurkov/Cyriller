namespace Cyriller.Checker
{
    partial class NumberForm
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
            this.txtCase1 = new System.Windows.Forms.TextBox();
            this.btnDecline = new System.Windows.Forms.Button();
            this.txtNumber = new System.Windows.Forms.NumericUpDown();
            this.txtCase2 = new System.Windows.Forms.TextBox();
            this.txtCase3 = new System.Windows.Forms.TextBox();
            this.txtCase4 = new System.Windows.Forms.TextBox();
            this.txtCase5 = new System.Windows.Forms.TextBox();
            this.txtCase6 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.ddlAction = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.label9 = new System.Windows.Forms.Label();
            this.txtItem = new System.Windows.Forms.TextBox();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtNumber)).BeginInit();
            this.tableLayoutPanel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 70F));
            this.tableLayoutPanel1.Controls.Add(this.txtCase1, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.btnDecline, 1, 9);
            this.tableLayoutPanel1.Controls.Add(this.txtCase2, 1, 4);
            this.tableLayoutPanel1.Controls.Add(this.txtCase3, 1, 5);
            this.tableLayoutPanel1.Controls.Add(this.txtCase4, 1, 6);
            this.tableLayoutPanel1.Controls.Add(this.txtCase5, 1, 7);
            this.tableLayoutPanel1.Controls.Add(this.txtCase6, 1, 8);
            this.tableLayoutPanel1.Controls.Add(this.label2, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.label8, 0, 4);
            this.tableLayoutPanel1.Controls.Add(this.label3, 0, 5);
            this.tableLayoutPanel1.Controls.Add(this.label4, 0, 6);
            this.tableLayoutPanel1.Controls.Add(this.label5, 0, 7);
            this.tableLayoutPanel1.Controls.Add(this.label6, 0, 8);
            this.tableLayoutPanel1.Controls.Add(this.ddlAction, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.label1, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 1, 2);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 11;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 60F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(764, 432);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // txtCase1
            // 
            this.txtCase1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txtCase1.Location = new System.Drawing.Point(232, 125);
            this.txtCase1.Name = "txtCase1";
            this.txtCase1.ReadOnly = true;
            this.txtCase1.Size = new System.Drawing.Size(529, 20);
            this.txtCase1.TabIndex = 2;
            // 
            // btnDecline
            // 
            this.btnDecline.Location = new System.Drawing.Point(232, 303);
            this.btnDecline.Name = "btnDecline";
            this.btnDecline.Size = new System.Drawing.Size(112, 23);
            this.btnDecline.TabIndex = 3;
            this.btnDecline.Text = "Просклонять";
            this.btnDecline.UseVisualStyleBackColor = true;
            this.btnDecline.Click += new System.EventHandler(this.btnDecline_Click);
            // 
            // txtNumber
            // 
            this.txtNumber.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txtNumber.DecimalPlaces = 5;
            this.txtNumber.Location = new System.Drawing.Point(3, 35);
            this.txtNumber.Maximum = new decimal(new int[] {
            10000000,
            0,
            0,
            0});
            this.txtNumber.Minimum = new decimal(new int[] {
            10000000,
            0,
            0,
            -2147483648});
            this.txtNumber.Name = "txtNumber";
            this.txtNumber.Size = new System.Drawing.Size(261, 20);
            this.txtNumber.TabIndex = 4;
            this.txtNumber.Value = new decimal(new int[] {
            128,
            0,
            0,
            0});
            // 
            // txtCase2
            // 
            this.txtCase2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txtCase2.Location = new System.Drawing.Point(232, 155);
            this.txtCase2.Name = "txtCase2";
            this.txtCase2.ReadOnly = true;
            this.txtCase2.Size = new System.Drawing.Size(529, 20);
            this.txtCase2.TabIndex = 5;
            // 
            // txtCase3
            // 
            this.txtCase3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txtCase3.Location = new System.Drawing.Point(232, 185);
            this.txtCase3.Name = "txtCase3";
            this.txtCase3.ReadOnly = true;
            this.txtCase3.Size = new System.Drawing.Size(529, 20);
            this.txtCase3.TabIndex = 6;
            // 
            // txtCase4
            // 
            this.txtCase4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txtCase4.Location = new System.Drawing.Point(232, 215);
            this.txtCase4.Name = "txtCase4";
            this.txtCase4.ReadOnly = true;
            this.txtCase4.Size = new System.Drawing.Size(529, 20);
            this.txtCase4.TabIndex = 7;
            // 
            // txtCase5
            // 
            this.txtCase5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txtCase5.Location = new System.Drawing.Point(232, 245);
            this.txtCase5.Name = "txtCase5";
            this.txtCase5.ReadOnly = true;
            this.txtCase5.Size = new System.Drawing.Size(529, 20);
            this.txtCase5.TabIndex = 8;
            // 
            // txtCase6
            // 
            this.txtCase6.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txtCase6.Location = new System.Drawing.Point(232, 275);
            this.txtCase6.Name = "txtCase6";
            this.txtCase6.ReadOnly = true;
            this.txtCase6.Size = new System.Drawing.Size(529, 20);
            this.txtCase6.TabIndex = 9;
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(52, 128);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(174, 13);
            this.label2.TabIndex = 16;
            this.label2.Text = "Именительный, Кто? Что? (есть)";
            // 
            // label8
            // 
            this.label8.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(55, 158);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(171, 13);
            this.label8.TabIndex = 17;
            this.label8.Text = "Родительный, Кого? Чего? (нет)";
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(58, 188);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(168, 13);
            this.label3.TabIndex = 18;
            this.label3.Text = "Дательный, Кому? Чему? (дам)";
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(53, 218);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(173, 13);
            this.label4.TabIndex = 19;
            this.label4.Text = "Винительный, Кого? Что? (вижу)";
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(30, 248);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(196, 13);
            this.label5.TabIndex = 20;
            this.label5.Text = "Творительный, Кем? Чем? (горжусь)";
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(29, 278);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(197, 13);
            this.label6.TabIndex = 21;
            this.label6.Text = "Предложный, О ком? О чем? (думаю)";
            // 
            // ddlAction
            // 
            this.ddlAction.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.ddlAction.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ddlAction.FormattingEnabled = true;
            this.ddlAction.Items.AddRange(new object[] {
            "Число прописью - ввести единицу",
            "Число прописью - мужской род",
            "Число прописью - женский род",
            "Деньги прописью - рубли",
            "Деньги прописью - доллары",
            "Деньги прописью - евро",
            "Деньги прописью - юань"});
            this.ddlAction.Location = new System.Drawing.Point(232, 34);
            this.ddlAction.Name = "ddlAction";
            this.ddlAction.Size = new System.Drawing.Size(529, 21);
            this.ddlAction.TabIndex = 22;
            this.ddlAction.SelectedIndexChanged += new System.EventHandler(this.ddlAction_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(232, 8);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 13);
            this.label1.TabIndex = 23;
            this.label1.Text = "Тип склонения";
            // 
            // label7
            // 
            this.label7.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(3, 8);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(39, 13);
            this.label7.TabIndex = 24;
            this.label7.Text = "Число";
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Controls.Add(this.label9, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.txtNumber, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.label7, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.txtItem, 1, 1);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(229, 60);
            this.tableLayoutPanel2.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 2;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(535, 60);
            this.tableLayoutPanel2.TabIndex = 25;
            // 
            // label9
            // 
            this.label9.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(270, 8);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(109, 13);
            this.label9.TabIndex = 25;
            this.label9.Text = "Единица измерения";
            // 
            // txtItem
            // 
            this.txtItem.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txtItem.Location = new System.Drawing.Point(270, 35);
            this.txtItem.Name = "txtItem";
            this.txtItem.Size = new System.Drawing.Size(262, 20);
            this.txtItem.TabIndex = 26;
            this.txtItem.Text = "байт";
            // 
            // NumberForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "NumberForm";
            this.Size = new System.Drawing.Size(764, 432);
            this.Load += new System.EventHandler(this.NumberForm_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtNumber)).EndInit();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TextBox txtCase1;
        private System.Windows.Forms.Button btnDecline;
        private System.Windows.Forms.NumericUpDown txtNumber;
        private System.Windows.Forms.TextBox txtCase2;
        private System.Windows.Forms.TextBox txtCase3;
        private System.Windows.Forms.TextBox txtCase4;
        private System.Windows.Forms.TextBox txtCase5;
        private System.Windows.Forms.TextBox txtCase6;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox ddlAction;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtItem;
    }
}
