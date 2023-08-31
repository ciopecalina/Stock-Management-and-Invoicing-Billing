
namespace app
{
    partial class FormAddNIR
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
            this.label21 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cbFurnizor = new System.Windows.Forms.ComboBox();
            this.cbTip = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tbId = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.dtpData = new System.Windows.Forms.DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.cbGestiune = new System.Windows.Forms.ComboBox();
            this.cbComisie = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.lvNIRuri = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader7 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnAdaugaProdus = new System.Windows.Forms.Button();
            this.tbPret = new System.Windows.Forms.TextBox();
            this.tbCant = new System.Windows.Forms.TextBox();
            this.cbUm = new System.Windows.Forms.ComboBox();
            this.tbDenProdus = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.btnSaveNIR = new System.Windows.Forms.Button();
            this.btnSalveazaNIRWord = new System.Windows.Forms.Button();
            this.btnStergeProdus = new System.Windows.Forms.Button();
            this.btnEditProdus = new System.Windows.Forms.Button();
            this.label12 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Location = new System.Drawing.Point(62, 209);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(323, 16);
            this.label21.TabIndex = 37;
            this.label21.Text = "Adauga produse pe NIR completand datele de mai jos.";
            this.label21.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(520, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(88, 16);
            this.label1.TabIndex = 38;
            this.label1.Text = "Nume furnizor";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(539, 88);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 32);
            this.label2.TabIndex = 40;
            this.label2.Text = "Document\r\njustificativ";
            // 
            // cbFurnizor
            // 
            this.cbFurnizor.FormattingEnabled = true;
            this.cbFurnizor.Location = new System.Drawing.Point(611, 31);
            this.cbFurnizor.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cbFurnizor.Name = "cbFurnizor";
            this.cbFurnizor.Size = new System.Drawing.Size(325, 24);
            this.cbFurnizor.TabIndex = 41;
            // 
            // cbTip
            // 
            this.cbTip.FormattingEnabled = true;
            this.cbTip.Items.AddRange(new object[] {
            "Factura",
            "Aviz",
            "Bon fiscal",
            "Carnet comercializare",
            "Fara doc"});
            this.cbTip.Location = new System.Drawing.Point(612, 88);
            this.cbTip.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cbTip.Name = "cbTip";
            this.cbTip.Size = new System.Drawing.Size(325, 24);
            this.cbTip.TabIndex = 42;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 39);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(67, 16);
            this.label3.TabIndex = 43;
            this.label3.Text = "Nr. factura";
            // 
            // tbId
            // 
            this.tbId.Location = new System.Drawing.Point(100, 36);
            this.tbId.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tbId.Name = "tbId";
            this.tbId.Size = new System.Drawing.Size(201, 22);
            this.tbId.TabIndex = 44;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 91);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(85, 32);
            this.label4.TabIndex = 45;
            this.label4.Text = "Data emiterii\r\ndocumentului";
            // 
            // dtpData
            // 
            this.dtpData.Location = new System.Drawing.Point(100, 98);
            this.dtpData.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dtpData.Name = "dtpData";
            this.dtpData.Size = new System.Drawing.Size(364, 22);
            this.dtpData.TabIndex = 46;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 138);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(60, 16);
            this.label5.TabIndex = 47;
            this.label5.Text = "Gestiune";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(554, 134);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(55, 16);
            this.label6.TabIndex = 49;
            this.label6.Text = "Comisie";
            // 
            // cbGestiune
            // 
            this.cbGestiune.FormattingEnabled = true;
            this.cbGestiune.Items.AddRange(new object[] {
            "Sos. de Centura nr. 32, Stefanestii de Jos, Ilfov, 077175",
            "Str. Nicolae Iorga nr. 17, Chiajna, Ilfov, 077041",
            "Str. Campului nr. 45A, Chiajna, Ilfov, 077040"});
            this.cbGestiune.Location = new System.Drawing.Point(100, 134);
            this.cbGestiune.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cbGestiune.Name = "cbGestiune";
            this.cbGestiune.Size = new System.Drawing.Size(364, 24);
            this.cbGestiune.TabIndex = 51;
            // 
            // cbComisie
            // 
            this.cbComisie.FormattingEnabled = true;
            this.cbComisie.Items.AddRange(new object[] {
            "Radu Mihai Robert",
            "Moisescu Andrei",
            "Anton George",
            "Popescu Mihai Ion"});
            this.cbComisie.Location = new System.Drawing.Point(611, 130);
            this.cbComisie.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cbComisie.Name = "cbComisie";
            this.cbComisie.Size = new System.Drawing.Size(325, 24);
            this.cbComisie.TabIndex = 52;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(66, 497);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(129, 16);
            this.label7.TabIndex = 53;
            this.label7.Text = "Lista produse/servicii";
            // 
            // lvNIRuri
            // 
            this.lvNIRuri.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader5,
            this.columnHeader6,
            this.columnHeader7});
            this.lvNIRuri.FullRowSelect = true;
            this.lvNIRuri.GridLines = true;
            this.lvNIRuri.HideSelection = false;
            this.lvNIRuri.Location = new System.Drawing.Point(59, 365);
            this.lvNIRuri.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.lvNIRuri.Name = "lvNIRuri";
            this.lvNIRuri.Size = new System.Drawing.Size(787, 160);
            this.lvNIRuri.TabIndex = 54;
            this.lvNIRuri.UseCompatibleStateImageBehavior = false;
            this.lvNIRuri.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Produs";
            this.columnHeader1.Width = 241;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "U.M.";
            this.columnHeader2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader2.Width = 69;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Cant.";
            this.columnHeader3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader3.Width = 75;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Pret";
            this.columnHeader4.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader4.Width = 66;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Valoare TOTALA";
            this.columnHeader5.Width = 114;
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "Valoare TVA";
            this.columnHeader6.Width = 85;
            // 
            // columnHeader7
            // 
            this.columnHeader7.Text = "Valoare Fara TVA";
            this.columnHeader7.Width = 115;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.tbId);
            this.groupBox1.Controls.Add(this.cbTip);
            this.groupBox1.Controls.Add(this.dtpData);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.cbFurnizor);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.cbComisie);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.cbGestiune);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Location = new System.Drawing.Point(58, 15);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox1.Size = new System.Drawing.Size(953, 190);
            this.groupBox1.TabIndex = 56;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Detalii NIR nou";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnAdaugaProdus);
            this.groupBox2.Controls.Add(this.tbPret);
            this.groupBox2.Controls.Add(this.tbCant);
            this.groupBox2.Controls.Add(this.cbUm);
            this.groupBox2.Controls.Add(this.tbDenProdus);
            this.groupBox2.Controls.Add(this.label11);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Location = new System.Drawing.Point(58, 256);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox2.Size = new System.Drawing.Size(953, 74);
            this.groupBox2.TabIndex = 57;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Detalii produse";
            // 
            // btnAdaugaProdus
            // 
            this.btnAdaugaProdus.Location = new System.Drawing.Point(775, 40);
            this.btnAdaugaProdus.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnAdaugaProdus.Name = "btnAdaugaProdus";
            this.btnAdaugaProdus.Size = new System.Drawing.Size(161, 28);
            this.btnAdaugaProdus.TabIndex = 8;
            this.btnAdaugaProdus.Text = "Adauga produs";
            this.btnAdaugaProdus.UseVisualStyleBackColor = true;
            this.btnAdaugaProdus.Click += new System.EventHandler(this.btnAdaugaProdus_Click);
            // 
            // tbPret
            // 
            this.tbPret.Location = new System.Drawing.Point(480, 45);
            this.tbPret.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tbPret.Name = "tbPret";
            this.tbPret.Size = new System.Drawing.Size(88, 22);
            this.tbPret.TabIndex = 7;
            // 
            // tbCant
            // 
            this.tbCant.Location = new System.Drawing.Point(376, 45);
            this.tbCant.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tbCant.Name = "tbCant";
            this.tbCant.Size = new System.Drawing.Size(98, 22);
            this.tbCant.TabIndex = 6;
            // 
            // cbUm
            // 
            this.cbUm.FormattingEnabled = true;
            this.cbUm.Items.AddRange(new object[] {
            "buc",
            "ml",
            "mp"});
            this.cbUm.Location = new System.Drawing.Point(273, 43);
            this.cbUm.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cbUm.Name = "cbUm";
            this.cbUm.Size = new System.Drawing.Size(97, 24);
            this.cbUm.TabIndex = 5;
            // 
            // tbDenProdus
            // 
            this.tbDenProdus.Location = new System.Drawing.Point(11, 46);
            this.tbDenProdus.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tbDenProdus.Name = "tbDenProdus";
            this.tbDenProdus.Size = new System.Drawing.Size(242, 22);
            this.tbDenProdus.TabIndex = 4;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(477, 25);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(68, 16);
            this.label11.TabIndex = 3;
            this.label11.Text = "Pret unitar";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(376, 25);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(60, 16);
            this.label10.TabIndex = 2;
            this.label10.Text = "Cantitate";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(270, 25);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(36, 16);
            this.label9.TabIndex = 1;
            this.label9.Text = "U.M.";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(8, 25);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(153, 16);
            this.label8.TabIndex = 0;
            this.label8.Text = "Denumire produs/serviciu";
            // 
            // btnSaveNIR
            // 
            this.btnSaveNIR.Location = new System.Drawing.Point(410, 542);
            this.btnSaveNIR.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnSaveNIR.Name = "btnSaveNIR";
            this.btnSaveNIR.Size = new System.Drawing.Size(284, 28);
            this.btnSaveNIR.TabIndex = 58;
            this.btnSaveNIR.Text = "Salvare NIR";
            this.btnSaveNIR.UseVisualStyleBackColor = true;
            this.btnSaveNIR.Click += new System.EventHandler(this.btnSaveNIR_Click);
            // 
            // btnSalveazaNIRWord
            // 
            this.btnSalveazaNIRWord.Location = new System.Drawing.Point(700, 542);
            this.btnSalveazaNIRWord.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnSalveazaNIRWord.Name = "btnSalveazaNIRWord";
            this.btnSalveazaNIRWord.Size = new System.Drawing.Size(294, 28);
            this.btnSalveazaNIRWord.TabIndex = 60;
            this.btnSalveazaNIRWord.Text = "Salvare NIR (.docx)";
            this.btnSalveazaNIRWord.UseVisualStyleBackColor = true;
            this.btnSalveazaNIRWord.Click += new System.EventHandler(this.btnSalveazaNIRWord_Click);
            // 
            // btnStergeProdus
            // 
            this.btnStergeProdus.Location = new System.Drawing.Point(852, 401);
            this.btnStergeProdus.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnStergeProdus.Name = "btnStergeProdus";
            this.btnStergeProdus.Size = new System.Drawing.Size(142, 28);
            this.btnStergeProdus.TabIndex = 61;
            this.btnStergeProdus.Text = "Sterge produs";
            this.btnStergeProdus.UseVisualStyleBackColor = true;
            this.btnStergeProdus.Click += new System.EventHandler(this.btnStergeProdus_Click);
            // 
            // btnEditProdus
            // 
            this.btnEditProdus.Location = new System.Drawing.Point(852, 365);
            this.btnEditProdus.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnEditProdus.Name = "btnEditProdus";
            this.btnEditProdus.Size = new System.Drawing.Size(142, 28);
            this.btnEditProdus.TabIndex = 62;
            this.btnEditProdus.Text = "Modifica produs";
            this.btnEditProdus.UseVisualStyleBackColor = true;
            this.btnEditProdus.Click += new System.EventHandler(this.btnEditProdus_Click);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(56, 345);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(129, 16);
            this.label12.TabIndex = 63;
            this.label12.Text = "Lista produse/servicii";
            this.label12.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // FormAddNIR
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(1034, 622);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.btnEditProdus);
            this.Controls.Add(this.btnStergeProdus);
            this.Controls.Add(this.btnSalveazaNIRWord);
            this.Controls.Add(this.btnSaveNIR);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.lvNIRuri);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label21);
            this.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "FormAddNIR";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Inregistrare Nota de Intrare de Receptie (NIR)";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cbFurnizor;
        private System.Windows.Forms.ComboBox cbTip;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbId;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker dtpData;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cbGestiune;
        private System.Windows.Forms.ComboBox cbComisie;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ListView lvNIRuri;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnAdaugaProdus;
        private System.Windows.Forms.TextBox tbPret;
        private System.Windows.Forms.TextBox tbCant;
        private System.Windows.Forms.ComboBox cbUm;
        private System.Windows.Forms.TextBox tbDenProdus;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btnSaveNIR;
        private System.Windows.Forms.Button btnSalveazaNIRWord;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.ColumnHeader columnHeader6;
        private System.Windows.Forms.ColumnHeader columnHeader7;
        private System.Windows.Forms.Button btnStergeProdus;
        private System.Windows.Forms.Button btnEditProdus;
        private System.Windows.Forms.Label label12;
    }
}