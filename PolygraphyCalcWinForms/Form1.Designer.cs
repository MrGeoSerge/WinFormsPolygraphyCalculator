namespace PolygraphyCalcWinForms
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            this.txtPrintRun = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.FormatLabel = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cBox_IB_Colors = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.cBox_IB_Paper = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.cBox_Format = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtPages = new System.Windows.Forms.TextBox();
            this.PrintrunValidation = new System.Windows.Forms.Label();
            this.PagesNumberValidation = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.cBox_Cov_Colors = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.cBox_Cov_Paper = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.checkBoxPackaging = new System.Windows.Forms.CheckBox();
            this.checkBoxLamination = new System.Windows.Forms.CheckBox();
            this.grBoxBinding = new System.Windows.Forms.GroupBox();
            this.rBtn_HardCover = new System.Windows.Forms.RadioButton();
            this.rBtn_Perfect = new System.Windows.Forms.RadioButton();
            this.rBtn_Saddle = new System.Windows.Forms.RadioButton();
            this.btnCalc = new System.Windows.Forms.Button();
            this.bookModelBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.lbl_Polygraphy = new System.Windows.Forms.Label();
            this.lbl_Materials = new System.Windows.Forms.Label();
            this.lbl_Assembly = new System.Windows.Forms.Label();
            this.lbl_Total = new System.Windows.Forms.Label();
            this.lbl_PerItem = new System.Windows.Forms.Label();
            this.lbl_PolygraphyVal = new System.Windows.Forms.Label();
            this.lbl_MaterialsVal = new System.Windows.Forms.Label();
            this.lbl_AssemblyVal = new System.Windows.Forms.Label();
            this.lbl_TotalVal = new System.Windows.Forms.Label();
            this.lbl_PerItemVal = new System.Windows.Forms.Label();
            this.lbl_ValidPrintrun = new System.Windows.Forms.Label();
            this.lbl_ValidationPages = new System.Windows.Forms.Label();
            this.lbl_Message = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.grBoxBinding.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bookModelBindingSource)).BeginInit();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtPrintRun
            // 
            this.txtPrintRun.Location = new System.Drawing.Point(150, 33);
            this.txtPrintRun.Name = "txtPrintRun";
            this.txtPrintRun.Size = new System.Drawing.Size(94, 20);
            this.txtPrintRun.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(59, 27);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(85, 26);
            this.label2.TabIndex = 1;
            this.label2.Text = "Тираж издания\r\nIssue Printrun";
            // 
            // FormatLabel
            // 
            this.FormatLabel.AutoSize = true;
            this.FormatLabel.Location = new System.Drawing.Point(6, 30);
            this.FormatLabel.Name = "FormatLabel";
            this.FormatLabel.Size = new System.Drawing.Size(49, 26);
            this.FormatLabel.TabIndex = 3;
            this.FormatLabel.Text = "Формат\r\nFormat";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cBox_IB_Colors);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.cBox_IB_Paper);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.cBox_Format);
            this.groupBox1.Controls.Add(this.FormatLabel);
            this.groupBox1.Location = new System.Drawing.Point(12, 82);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(557, 74);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Внутренний блок / Internal Block";
            // 
            // cBox_IB_Colors
            // 
            this.cBox_IB_Colors.FormattingEnabled = true;
            this.cBox_IB_Colors.Location = new System.Drawing.Point(450, 33);
            this.cBox_IB_Colors.Name = "cBox_IB_Colors";
            this.cBox_IB_Colors.Size = new System.Drawing.Size(92, 21);
            this.cBox_IB_Colors.TabIndex = 9;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(383, 30);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(61, 26);
            this.label4.TabIndex = 8;
            this.label4.Text = "Цветность\r\nColorness";
            // 
            // cBox_IB_Paper
            // 
            this.cBox_IB_Paper.FormattingEnabled = true;
            this.cBox_IB_Paper.Location = new System.Drawing.Point(249, 33);
            this.cBox_IB_Paper.Name = "cBox_IB_Paper";
            this.cBox_IB_Paper.Size = new System.Drawing.Size(107, 21);
            this.cBox_IB_Paper.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(199, 30);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 26);
            this.label3.TabIndex = 6;
            this.label3.Text = "Бумага\r\nPaper";
            // 
            // cBox_Format
            // 
            this.cBox_Format.FormattingEnabled = true;
            this.cBox_Format.Location = new System.Drawing.Point(61, 33);
            this.cBox_Format.Name = "cBox_Format";
            this.cBox_Format.Size = new System.Drawing.Size(121, 21);
            this.cBox_Format.TabIndex = 5;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(300, 27);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(110, 26);
            this.label5.TabIndex = 6;
            this.label5.Text = "Количество страниц\r\nNumber of Pages";
            // 
            // txtPages
            // 
            this.txtPages.Location = new System.Drawing.Point(416, 33);
            this.txtPages.Name = "txtPages";
            this.txtPages.Size = new System.Drawing.Size(86, 20);
            this.txtPages.TabIndex = 7;
            // 
            // PrintrunValidation
            // 
            this.PrintrunValidation.AutoSize = true;
            this.PrintrunValidation.Location = new System.Drawing.Point(66, 60);
            this.PrintrunValidation.Name = "PrintrunValidation";
            this.PrintrunValidation.Size = new System.Drawing.Size(0, 13);
            this.PrintrunValidation.TabIndex = 8;
            // 
            // PagesNumberValidation
            // 
            this.PagesNumberValidation.AutoSize = true;
            this.PagesNumberValidation.Location = new System.Drawing.Point(303, 61);
            this.PagesNumberValidation.Name = "PagesNumberValidation";
            this.PagesNumberValidation.Size = new System.Drawing.Size(0, 13);
            this.PagesNumberValidation.TabIndex = 9;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.cBox_Cov_Colors);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.cBox_Cov_Paper);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Location = new System.Drawing.Point(12, 183);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(557, 71);
            this.groupBox2.TabIndex = 10;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Обложка / Cover";
            this.groupBox2.Enter += new System.EventHandler(this.groupBox2_Enter);
            // 
            // cBox_Cov_Colors
            // 
            this.cBox_Cov_Colors.FormattingEnabled = true;
            this.cBox_Cov_Colors.Location = new System.Drawing.Point(430, 31);
            this.cBox_Cov_Colors.Name = "cBox_Cov_Colors";
            this.cBox_Cov_Colors.Size = new System.Drawing.Size(110, 21);
            this.cBox_Cov_Colors.TabIndex = 3;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(354, 25);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(61, 26);
            this.label7.TabIndex = 2;
            this.label7.Text = "Цветность\r\nColorness";
            // 
            // cBox_Cov_Paper
            // 
            this.cBox_Cov_Paper.FormattingEnabled = true;
            this.cBox_Cov_Paper.Location = new System.Drawing.Point(61, 30);
            this.cBox_Cov_Paper.Name = "cBox_Cov_Paper";
            this.cBox_Cov_Paper.Size = new System.Drawing.Size(200, 21);
            this.cBox_Cov_Paper.TabIndex = 1;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(11, 27);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(44, 26);
            this.label6.TabIndex = 0;
            this.label6.Text = "Бумага\r\nPaper";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.checkBoxPackaging);
            this.groupBox3.Controls.Add(this.checkBoxLamination);
            this.groupBox3.Controls.Add(this.grBoxBinding);
            this.groupBox3.Location = new System.Drawing.Point(14, 268);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(554, 125);
            this.groupBox3.TabIndex = 11;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Сборка книги / Book assembly";
            // 
            // checkBoxPackaging
            // 
            this.checkBoxPackaging.AutoSize = true;
            this.checkBoxPackaging.Location = new System.Drawing.Point(345, 34);
            this.checkBoxPackaging.Name = "checkBoxPackaging";
            this.checkBoxPackaging.Size = new System.Drawing.Size(77, 30);
            this.checkBoxPackaging.TabIndex = 3;
            this.checkBoxPackaging.Text = "Упаковка\r\nPackaging";
            this.checkBoxPackaging.UseVisualStyleBackColor = true;
            // 
            // checkBoxLamination
            // 
            this.checkBoxLamination.AutoSize = true;
            this.checkBoxLamination.Location = new System.Drawing.Point(201, 34);
            this.checkBoxLamination.Name = "checkBoxLamination";
            this.checkBoxLamination.Size = new System.Drawing.Size(84, 30);
            this.checkBoxLamination.TabIndex = 2;
            this.checkBoxLamination.Text = "Ламинация\r\nLamination";
            this.checkBoxLamination.UseVisualStyleBackColor = true;
            // 
            // grBoxBinding
            // 
            this.grBoxBinding.Controls.Add(this.rBtn_HardCover);
            this.grBoxBinding.Controls.Add(this.rBtn_Perfect);
            this.grBoxBinding.Controls.Add(this.rBtn_Saddle);
            this.grBoxBinding.Location = new System.Drawing.Point(12, 23);
            this.grBoxBinding.Name = "grBoxBinding";
            this.grBoxBinding.Size = new System.Drawing.Size(168, 94);
            this.grBoxBinding.TabIndex = 1;
            this.grBoxBinding.TabStop = false;
            this.grBoxBinding.Text = "Переплет / Binding";
            // 
            // rBtn_HardCover
            // 
            this.rBtn_HardCover.AutoSize = true;
            this.rBtn_HardCover.Location = new System.Drawing.Point(17, 70);
            this.rBtn_HardCover.Name = "rBtn_HardCover";
            this.rBtn_HardCover.Size = new System.Drawing.Size(130, 17);
            this.rBtn_HardCover.TabIndex = 2;
            this.rBtn_HardCover.TabStop = true;
            this.rBtn_HardCover.Text = "твердый / hard cover";
            this.rBtn_HardCover.UseVisualStyleBackColor = true;
            // 
            // rBtn_Perfect
            // 
            this.rBtn_Perfect.AutoSize = true;
            this.rBtn_Perfect.Location = new System.Drawing.Point(17, 47);
            this.rBtn_Perfect.Name = "rBtn_Perfect";
            this.rBtn_Perfect.Size = new System.Drawing.Size(130, 17);
            this.rBtn_Perfect.TabIndex = 1;
            this.rBtn_Perfect.TabStop = true;
            this.rBtn_Perfect.Text = "клей / perfect binding";
            this.rBtn_Perfect.UseVisualStyleBackColor = true;
            // 
            // rBtn_Saddle
            // 
            this.rBtn_Saddle.AutoSize = true;
            this.rBtn_Saddle.Location = new System.Drawing.Point(17, 24);
            this.rBtn_Saddle.Name = "rBtn_Saddle";
            this.rBtn_Saddle.Size = new System.Drawing.Size(139, 17);
            this.rBtn_Saddle.TabIndex = 0;
            this.rBtn_Saddle.TabStop = true;
            this.rBtn_Saddle.Text = "скоба / saddle stitching";
            this.rBtn_Saddle.UseVisualStyleBackColor = true;
            // 
            // btnCalc
            // 
            this.btnCalc.Location = new System.Drawing.Point(454, 399);
            this.btnCalc.Name = "btnCalc";
            this.btnCalc.Size = new System.Drawing.Size(114, 40);
            this.btnCalc.TabIndex = 12;
            this.btnCalc.Text = "Рассчитать  Calculate";
            this.btnCalc.UseVisualStyleBackColor = true;
            this.btnCalc.Click += new System.EventHandler(this.button1_Click);
            // 
            // bookModelBindingSource
            // 
            this.bookModelBindingSource.DataSource = typeof(BookProduction.BookModel);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.lbl_PerItemVal);
            this.groupBox4.Controls.Add(this.lbl_PerItem);
            this.groupBox4.Controls.Add(this.lbl_TotalVal);
            this.groupBox4.Controls.Add(this.lbl_Total);
            this.groupBox4.Controls.Add(this.lbl_AssemblyVal);
            this.groupBox4.Controls.Add(this.lbl_Assembly);
            this.groupBox4.Controls.Add(this.lbl_MaterialsVal);
            this.groupBox4.Controls.Add(this.lbl_Materials);
            this.groupBox4.Controls.Add(this.lbl_PolygraphyVal);
            this.groupBox4.Controls.Add(this.lbl_Polygraphy);
            this.groupBox4.Location = new System.Drawing.Point(16, 404);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(426, 116);
            this.groupBox4.TabIndex = 14;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Расходы на тиражирование / Printing cost:";
            // 
            // lbl_Polygraphy
            // 
            this.lbl_Polygraphy.AutoSize = true;
            this.lbl_Polygraphy.Location = new System.Drawing.Point(19, 22);
            this.lbl_Polygraphy.Name = "lbl_Polygraphy";
            this.lbl_Polygraphy.Size = new System.Drawing.Size(220, 13);
            this.lbl_Polygraphy.TabIndex = 0;
            this.lbl_Polygraphy.Text = "Затраты на полиграфию / Polygraphy cost:";
            this.lbl_Polygraphy.Click += new System.EventHandler(this.label8_Click);
            // 
            // lbl_Materials
            // 
            this.lbl_Materials.AutoSize = true;
            this.lbl_Materials.Location = new System.Drawing.Point(19, 41);
            this.lbl_Materials.Name = "lbl_Materials";
            this.lbl_Materials.Size = new System.Drawing.Size(204, 13);
            this.lbl_Materials.TabIndex = 1;
            this.lbl_Materials.Text = "Затраты на материалы / Materials cost:";
            // 
            // lbl_Assembly
            // 
            this.lbl_Assembly.AutoSize = true;
            this.lbl_Assembly.Location = new System.Drawing.Point(19, 60);
            this.lbl_Assembly.Name = "lbl_Assembly";
            this.lbl_Assembly.Size = new System.Drawing.Size(184, 13);
            this.lbl_Assembly.TabIndex = 2;
            this.lbl_Assembly.Text = "Затраты на сборку / Assembly cost:";
            // 
            // lbl_Total
            // 
            this.lbl_Total.AutoSize = true;
            this.lbl_Total.Location = new System.Drawing.Point(19, 79);
            this.lbl_Total.Name = "lbl_Total";
            this.lbl_Total.Size = new System.Drawing.Size(160, 13);
            this.lbl_Total.TabIndex = 3;
            this.lbl_Total.Text = "Затраты на тираж / Total cost:";
            // 
            // lbl_PerItem
            // 
            this.lbl_PerItem.AutoSize = true;
            this.lbl_PerItem.Location = new System.Drawing.Point(19, 98);
            this.lbl_PerItem.Name = "lbl_PerItem";
            this.lbl_PerItem.Size = new System.Drawing.Size(208, 13);
            this.lbl_PerItem.TabIndex = 4;
            this.lbl_PerItem.Text = "Затраты на 1 экземпляр / Cost per item:";
            // 
            // lbl_PolygraphyVal
            // 
            this.lbl_PolygraphyVal.AutoSize = true;
            this.lbl_PolygraphyVal.Location = new System.Drawing.Point(245, 22);
            this.lbl_PolygraphyVal.Name = "lbl_PolygraphyVal";
            this.lbl_PolygraphyVal.Size = new System.Drawing.Size(0, 13);
            this.lbl_PolygraphyVal.TabIndex = 0;
            this.lbl_PolygraphyVal.Click += new System.EventHandler(this.label8_Click);
            // 
            // lbl_MaterialsVal
            // 
            this.lbl_MaterialsVal.AutoSize = true;
            this.lbl_MaterialsVal.Location = new System.Drawing.Point(229, 41);
            this.lbl_MaterialsVal.Name = "lbl_MaterialsVal";
            this.lbl_MaterialsVal.Size = new System.Drawing.Size(0, 13);
            this.lbl_MaterialsVal.TabIndex = 1;
            // 
            // lbl_AssemblyVal
            // 
            this.lbl_AssemblyVal.AutoSize = true;
            this.lbl_AssemblyVal.Location = new System.Drawing.Point(209, 60);
            this.lbl_AssemblyVal.Name = "lbl_AssemblyVal";
            this.lbl_AssemblyVal.Size = new System.Drawing.Size(0, 13);
            this.lbl_AssemblyVal.TabIndex = 2;
            // 
            // lbl_TotalVal
            // 
            this.lbl_TotalVal.AutoSize = true;
            this.lbl_TotalVal.Location = new System.Drawing.Point(185, 79);
            this.lbl_TotalVal.Name = "lbl_TotalVal";
            this.lbl_TotalVal.Size = new System.Drawing.Size(0, 13);
            this.lbl_TotalVal.TabIndex = 3;
            // 
            // lbl_PerItemVal
            // 
            this.lbl_PerItemVal.AutoSize = true;
            this.lbl_PerItemVal.Location = new System.Drawing.Point(233, 98);
            this.lbl_PerItemVal.Name = "lbl_PerItemVal";
            this.lbl_PerItemVal.Size = new System.Drawing.Size(0, 13);
            this.lbl_PerItemVal.TabIndex = 4;
            // 
            // lbl_ValidPrintrun
            // 
            this.lbl_ValidPrintrun.AutoSize = true;
            this.lbl_ValidPrintrun.ForeColor = System.Drawing.Color.Red;
            this.lbl_ValidPrintrun.Location = new System.Drawing.Point(63, 61);
            this.lbl_ValidPrintrun.Name = "lbl_ValidPrintrun";
            this.lbl_ValidPrintrun.Size = new System.Drawing.Size(0, 13);
            this.lbl_ValidPrintrun.TabIndex = 15;
            // 
            // lbl_ValidationPages
            // 
            this.lbl_ValidationPages.AutoSize = true;
            this.lbl_ValidationPages.ForeColor = System.Drawing.Color.Red;
            this.lbl_ValidationPages.Location = new System.Drawing.Point(306, 62);
            this.lbl_ValidationPages.Name = "lbl_ValidationPages";
            this.lbl_ValidationPages.Size = new System.Drawing.Size(0, 13);
            this.lbl_ValidationPages.TabIndex = 16;
            // 
            // lbl_Message
            // 
            this.lbl_Message.AutoSize = true;
            this.lbl_Message.Location = new System.Drawing.Point(456, 453);
            this.lbl_Message.Name = "lbl_Message";
            this.lbl_Message.Size = new System.Drawing.Size(0, 13);
            this.lbl_Message.TabIndex = 17;
            // 
            // Form1
            // 
            this.ClientSize = new System.Drawing.Size(580, 532);
            this.Controls.Add(this.lbl_Message);
            this.Controls.Add(this.lbl_ValidationPages);
            this.Controls.Add(this.lbl_ValidPrintrun);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.btnCalc);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.PagesNumberValidation);
            this.Controls.Add(this.PrintrunValidation);
            this.Controls.Add(this.txtPages);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtPrintRun);
            this.Name = "Form1";
            this.Text = "Polygraphy Calculator";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.grBoxBinding.ResumeLayout(false);
            this.grBoxBinding.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bookModelBindingSource)).EndInit();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtPrintRun;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label FormatLabel;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox cBox_Format;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cBox_IB_Colors;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cBox_IB_Paper;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtPages;
        private System.Windows.Forms.Label PrintrunValidation;
        private System.Windows.Forms.Label PagesNumberValidation;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ComboBox cBox_Cov_Paper;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cBox_Cov_Colors;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.CheckBox checkBoxLamination;
        private System.Windows.Forms.GroupBox grBoxBinding;
        private System.Windows.Forms.RadioButton rBtn_HardCover;
        private System.Windows.Forms.RadioButton rBtn_Perfect;
        private System.Windows.Forms.RadioButton rBtn_Saddle;
        private System.Windows.Forms.CheckBox checkBoxPackaging;
        private System.Windows.Forms.Button btnCalc;
        private System.Windows.Forms.BindingSource bookModelBindingSource;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Label lbl_Polygraphy;
        private System.Windows.Forms.Label lbl_PerItem;
        private System.Windows.Forms.Label lbl_Total;
        private System.Windows.Forms.Label lbl_Assembly;
        private System.Windows.Forms.Label lbl_Materials;
        private System.Windows.Forms.Label lbl_PerItemVal;
        private System.Windows.Forms.Label lbl_TotalVal;
        private System.Windows.Forms.Label lbl_AssemblyVal;
        private System.Windows.Forms.Label lbl_MaterialsVal;
        private System.Windows.Forms.Label lbl_PolygraphyVal;
        private System.Windows.Forms.Label lbl_ValidPrintrun;
        private System.Windows.Forms.Label lbl_ValidationPages;
        private System.Windows.Forms.Label lbl_Message;
    }
}

