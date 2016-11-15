namespace BMI_als_FORM
{
    partial class Form1
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.lb_Gewicht = new System.Windows.Forms.Label();
            this.lb_Groesse = new System.Windows.Forms.Label();
            this.lb_sex = new System.Windows.Forms.Label();
            this.lbl_BMI = new System.Windows.Forms.Label();
            this.txt_Weight = new System.Windows.Forms.TextBox();
            this.txt_Size = new System.Windows.Forms.TextBox();
            this.cB_Sex = new System.Windows.Forms.ComboBox();
            this.lbl_Ergebniss = new System.Windows.Forms.Label();
            this.lbl_Ergebniss_Text = new System.Windows.Forms.Label();
            this.lbl_BMI_Text = new System.Windows.Forms.Label();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.pB_m_dick = new System.Windows.Forms.PictureBox();
            this.bt_test = new System.Windows.Forms.Button();
            this.pB_m_normal = new System.Windows.Forms.PictureBox();
            this.pB_m_skinny = new System.Windows.Forms.PictureBox();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pB_m_dick)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pB_m_normal)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pB_m_skinny)).BeginInit();
            this.SuspendLayout();
            // 
            // lb_Gewicht
            // 
            this.lb_Gewicht.AutoSize = true;
            this.lb_Gewicht.Location = new System.Drawing.Point(3, 0);
            this.lb_Gewicht.Name = "lb_Gewicht";
            this.lb_Gewicht.Size = new System.Drawing.Size(96, 17);
            this.lb_Gewicht.TabIndex = 0;
            this.lb_Gewicht.Text = "Gewicht in kg:";
            // 
            // lb_Groesse
            // 
            this.lb_Groesse.Location = new System.Drawing.Point(3, 99);
            this.lb_Groesse.Name = "lb_Groesse";
            this.lb_Groesse.Size = new System.Drawing.Size(100, 23);
            this.lb_Groesse.TabIndex = 1;
            this.lb_Groesse.Text = "Größe in m:";
            // 
            // lb_sex
            // 
            this.lb_sex.AutoSize = true;
            this.lb_sex.Location = new System.Drawing.Point(3, 198);
            this.lb_sex.Name = "lb_sex";
            this.lb_sex.Size = new System.Drawing.Size(79, 17);
            this.lb_sex.TabIndex = 2;
            this.lb_sex.Text = "Geschlecht";
            // 
            // lbl_BMI
            // 
            this.lbl_BMI.AutoSize = true;
            this.lbl_BMI.Location = new System.Drawing.Point(3, 297);
            this.lbl_BMI.Name = "lbl_BMI";
            this.lbl_BMI.Size = new System.Drawing.Size(86, 17);
            this.lbl_BMI.TabIndex = 3;
            this.lbl_BMI.Text = "Erläuterung:";
            // 
            // txt_Weight
            // 
            this.txt_Weight.Location = new System.Drawing.Point(316, 3);
            this.txt_Weight.Name = "txt_Weight";
            this.txt_Weight.Size = new System.Drawing.Size(152, 22);
            this.txt_Weight.TabIndex = 0;
            // 
            // txt_Size
            // 
            this.txt_Size.Location = new System.Drawing.Point(316, 102);
            this.txt_Size.Name = "txt_Size";
            this.txt_Size.Size = new System.Drawing.Size(152, 22);
            this.txt_Size.TabIndex = 1;
            // 
            // cB_Sex
            // 
            this.cB_Sex.FormattingEnabled = true;
            this.cB_Sex.Items.AddRange(new object[] {
            "m",
            "w"});
            this.cB_Sex.Location = new System.Drawing.Point(316, 201);
            this.cB_Sex.Name = "cB_Sex";
            this.cB_Sex.Size = new System.Drawing.Size(68, 24);
            this.cB_Sex.TabIndex = 2;
            // 
            // lbl_Ergebniss
            // 
            this.lbl_Ergebniss.AutoSize = true;
            this.lbl_Ergebniss.Location = new System.Drawing.Point(3, 396);
            this.lbl_Ergebniss.Name = "lbl_Ergebniss";
            this.lbl_Ergebniss.Size = new System.Drawing.Size(35, 17);
            this.lbl_Ergebniss.TabIndex = 9;
            this.lbl_Ergebniss.Text = "BMI:";
            // 
            // lbl_Ergebniss_Text
            // 
            this.lbl_Ergebniss_Text.AutoSize = true;
            this.lbl_Ergebniss_Text.Location = new System.Drawing.Point(316, 297);
            this.lbl_Ergebniss_Text.Name = "lbl_Ergebniss_Text";
            this.lbl_Ergebniss_Text.Size = new System.Drawing.Size(91, 17);
            this.lbl_Ergebniss_Text.TabIndex = 11;
            this.lbl_Ergebniss_Text.Text = "Ihr Ergebniss";
            // 
            // lbl_BMI_Text
            // 
            this.lbl_BMI_Text.AutoSize = true;
            this.lbl_BMI_Text.Location = new System.Drawing.Point(316, 396);
            this.lbl_BMI_Text.Name = "lbl_BMI_Text";
            this.lbl_BMI_Text.Size = new System.Drawing.Size(51, 17);
            this.lbl_BMI_Text.TabIndex = 12;
            this.lbl_BMI_Text.Text = "Ihr BMI";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.Controls.Add(this.lb_Gewicht, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.lbl_BMI_Text, 1, 4);
            this.tableLayoutPanel1.Controls.Add(this.txt_Weight, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.lbl_Ergebniss, 0, 4);
            this.tableLayoutPanel1.Controls.Add(this.txt_Size, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.lbl_BMI, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.lb_Groesse, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.cB_Sex, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.lb_sex, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.lbl_Ergebniss_Text, 1, 3);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(12, 12);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 5;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(627, 498);
            this.tableLayoutPanel1.TabIndex = 13;
            // 
            // pB_m_dick
            // 
            this.pB_m_dick.Image = ((System.Drawing.Image)(resources.GetObject("pB_m_dick.Image")));
            this.pB_m_dick.Location = new System.Drawing.Point(713, 114);
            this.pB_m_dick.Name = "pB_m_dick";
            this.pB_m_dick.Size = new System.Drawing.Size(325, 396);
            this.pB_m_dick.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pB_m_dick.TabIndex = 13;
            this.pB_m_dick.TabStop = false;
            this.pB_m_dick.Visible = false;
            // 
            // bt_test
            // 
            this.bt_test.Location = new System.Drawing.Point(702, 34);
            this.bt_test.Name = "bt_test";
            this.bt_test.Size = new System.Drawing.Size(115, 23);
            this.bt_test.TabIndex = 3;
            this.bt_test.Text = "Berechne BMI";
            this.bt_test.UseVisualStyleBackColor = true;
            this.bt_test.Click += new System.EventHandler(this.button1_Click);
            // 
            // pB_m_normal
            // 
            this.pB_m_normal.Location = new System.Drawing.Point(713, 114);
            this.pB_m_normal.Name = "pB_m_normal";
            this.pB_m_normal.Size = new System.Drawing.Size(325, 396);
            this.pB_m_normal.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pB_m_normal.TabIndex = 14;
            this.pB_m_normal.TabStop = false;
            this.pB_m_normal.Visible = false;
            // 
            // pB_m_skinny
            // 
            this.pB_m_skinny.Location = new System.Drawing.Point(713, 111);
            this.pB_m_skinny.Name = "pB_m_skinny";
            this.pB_m_skinny.Size = new System.Drawing.Size(325, 396);
            this.pB_m_skinny.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pB_m_skinny.TabIndex = 15;
            this.pB_m_skinny.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Lime;
            this.ClientSize = new System.Drawing.Size(1050, 522);
            this.Controls.Add(this.pB_m_skinny);
            this.Controls.Add(this.pB_m_normal);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.pB_m_dick);
            this.Controls.Add(this.bt_test);
            this.Name = "Form1";
            this.Text = "BMI-Rechner";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pB_m_dick)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pB_m_normal)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pB_m_skinny)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lb_Gewicht;
        private System.Windows.Forms.Label lb_Groesse;
        private System.Windows.Forms.Label lb_sex;
        private System.Windows.Forms.Label lbl_BMI;
        private System.Windows.Forms.TextBox txt_Weight;
        private System.Windows.Forms.TextBox txt_Size;
        private System.Windows.Forms.ComboBox cB_Sex;
        private System.Windows.Forms.Label lbl_Ergebniss;
        private System.Windows.Forms.Label lbl_Ergebniss_Text;
        private System.Windows.Forms.Label lbl_BMI_Text;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.PictureBox pB_m_dick;
        private System.Windows.Forms.Button bt_test;
        private System.Windows.Forms.PictureBox pB_m_normal;
        private System.Windows.Forms.PictureBox pB_m_skinny;
    }
}

