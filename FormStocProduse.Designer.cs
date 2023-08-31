
namespace app
{
    partial class FormStocProduse
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
            this.dgvProduse = new System.Windows.Forms.DataGridView();
            this.lblNrProduse = new System.Windows.Forms.Label();
            this.lblNrProduse2 = new System.Windows.Forms.Label();
            this.tbSearchProdus = new System.Windows.Forms.TextBox();
            this.cbUM = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.tbPretMin = new System.Windows.Forms.TextBox();
            this.tbValMin = new System.Windows.Forms.TextBox();
            this.tbPretMax = new System.Windows.Forms.TextBox();
            this.tbValMax = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.btnAddFiltru = new System.Windows.Forms.Button();
            this.btnStergeFiltru = new System.Windows.Forms.Button();
            this.tbCantMin = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.tbCantMax = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.btnAddProdus = new System.Windows.Forms.Button();
            this.btnSterge = new System.Windows.Forms.Button();
            this.btnEditProdus = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.tbDenumireProdus = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.cbUMProdus = new System.Windows.Forms.ComboBox();
            this.label11 = new System.Windows.Forms.Label();
            this.tbCantitateProdus = new System.Windows.Forms.TextBox();
            this.tbPretProdus = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.tbValoareProdus = new System.Windows.Forms.TextBox();
            this.tbFaraTVAProdus = new System.Windows.Forms.TextBox();
            this.tbTVAProdus = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnExportExcel = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProduse)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvProduse
            // 
            this.dgvProduse.AllowUserToAddRows = false;
            this.dgvProduse.AllowUserToDeleteRows = false;
            this.dgvProduse.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProduse.Location = new System.Drawing.Point(246, 342);
            this.dgvProduse.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dgvProduse.Name = "dgvProduse";
            this.dgvProduse.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvProduse.Size = new System.Drawing.Size(759, 238);
            this.dgvProduse.TabIndex = 0;
            // 
            // lblNrProduse
            // 
            this.lblNrProduse.AutoSize = true;
            this.lblNrProduse.Location = new System.Drawing.Point(107, 344);
            this.lblNrProduse.Name = "lblNrProduse";
            this.lblNrProduse.Size = new System.Drawing.Size(97, 15);
            this.lblNrProduse.TabIndex = 1;
            this.lblNrProduse.Text = "Numar produse:";
            // 
            // lblNrProduse2
            // 
            this.lblNrProduse2.AutoSize = true;
            this.lblNrProduse2.Location = new System.Drawing.Point(210, 344);
            this.lblNrProduse2.Name = "lblNrProduse2";
            this.lblNrProduse2.Size = new System.Drawing.Size(14, 15);
            this.lblNrProduse2.TabIndex = 2;
            this.lblNrProduse2.Text = "0";
            // 
            // tbSearchProdus
            // 
            this.tbSearchProdus.Location = new System.Drawing.Point(167, 29);
            this.tbSearchProdus.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tbSearchProdus.Name = "tbSearchProdus";
            this.tbSearchProdus.Size = new System.Drawing.Size(242, 21);
            this.tbSearchProdus.TabIndex = 3;
            this.tbSearchProdus.TextChanged += new System.EventHandler(this.tbSearchProdus_TextChanged);
            // 
            // cbUM
            // 
            this.cbUM.FormattingEnabled = true;
            this.cbUM.Items.AddRange(new object[] {
            "Toate",
            "buc",
            "ml",
            "mp"});
            this.cbUM.Location = new System.Drawing.Point(167, 63);
            this.cbUM.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cbUM.Name = "cbUM";
            this.cbUM.Size = new System.Drawing.Size(140, 23);
            this.cbUM.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(97, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 15);
            this.label1.TabIndex = 5;
            this.label1.Text = "Denumire:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(97, 72);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(34, 15);
            this.label2.TabIndex = 6;
            this.label2.Text = "U.M.:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(419, 53);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(32, 15);
            this.label3.TabIndex = 7;
            this.label3.Text = "Pret:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(419, 74);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(51, 15);
            this.label4.TabIndex = 8;
            this.label4.Text = "Valoare:";
            // 
            // tbPretMin
            // 
            this.tbPretMin.Location = new System.Drawing.Point(492, 45);
            this.tbPretMin.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tbPretMin.Name = "tbPretMin";
            this.tbPretMin.Size = new System.Drawing.Size(90, 21);
            this.tbPretMin.TabIndex = 9;
            // 
            // tbValMin
            // 
            this.tbValMin.Location = new System.Drawing.Point(492, 69);
            this.tbValMin.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tbValMin.Name = "tbValMin";
            this.tbValMin.Size = new System.Drawing.Size(90, 21);
            this.tbValMin.TabIndex = 10;
            // 
            // tbPretMax
            // 
            this.tbPretMax.Location = new System.Drawing.Point(608, 44);
            this.tbPretMax.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tbPretMax.Name = "tbPretMax";
            this.tbPretMax.Size = new System.Drawing.Size(116, 21);
            this.tbPretMax.TabIndex = 11;
            // 
            // tbValMax
            // 
            this.tbValMax.Location = new System.Drawing.Point(608, 69);
            this.tbValMax.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tbValMax.Name = "tbValMax";
            this.tbValMax.Size = new System.Drawing.Size(116, 21);
            this.tbValMax.TabIndex = 12;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(590, 50);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(11, 15);
            this.label5.TabIndex = 13;
            this.label5.Text = "-";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(590, 73);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(11, 15);
            this.label6.TabIndex = 14;
            this.label6.Text = "-";
            // 
            // btnAddFiltru
            // 
            this.btnAddFiltru.Location = new System.Drawing.Point(820, 20);
            this.btnAddFiltru.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnAddFiltru.Name = "btnAddFiltru";
            this.btnAddFiltru.Size = new System.Drawing.Size(87, 26);
            this.btnAddFiltru.TabIndex = 15;
            this.btnAddFiltru.Text = "Aplica filtru";
            this.btnAddFiltru.UseVisualStyleBackColor = true;
            this.btnAddFiltru.Click += new System.EventHandler(this.btnAddFiltru_Click);
            // 
            // btnStergeFiltru
            // 
            this.btnStergeFiltru.Location = new System.Drawing.Point(820, 53);
            this.btnStergeFiltru.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnStergeFiltru.Name = "btnStergeFiltru";
            this.btnStergeFiltru.Size = new System.Drawing.Size(87, 26);
            this.btnStergeFiltru.TabIndex = 16;
            this.btnStergeFiltru.Text = "Sterge filtru";
            this.btnStergeFiltru.UseVisualStyleBackColor = true;
            this.btnStergeFiltru.Click += new System.EventHandler(this.btnStergeFiltru_Click);
            // 
            // tbCantMin
            // 
            this.tbCantMin.Location = new System.Drawing.Point(492, 18);
            this.tbCantMin.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tbCantMin.Name = "tbCantMin";
            this.tbCantMin.Size = new System.Drawing.Size(90, 21);
            this.tbCantMin.TabIndex = 17;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(590, 18);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(11, 15);
            this.label7.TabIndex = 18;
            this.label7.Text = "-";
            // 
            // tbCantMax
            // 
            this.tbCantMax.Location = new System.Drawing.Point(608, 18);
            this.tbCantMax.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tbCantMax.Name = "tbCantMax";
            this.tbCantMax.Size = new System.Drawing.Size(116, 21);
            this.tbCantMax.TabIndex = 19;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(419, 22);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(59, 15);
            this.label8.TabIndex = 20;
            this.label8.Text = "Cantitate:";
            // 
            // btnAddProdus
            // 
            this.btnAddProdus.Location = new System.Drawing.Point(754, 35);
            this.btnAddProdus.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnAddProdus.Name = "btnAddProdus";
            this.btnAddProdus.Size = new System.Drawing.Size(153, 26);
            this.btnAddProdus.TabIndex = 21;
            this.btnAddProdus.Text = "Adauga";
            this.btnAddProdus.UseVisualStyleBackColor = true;
            this.btnAddProdus.Click += new System.EventHandler(this.btnAddProdus_Click);
            // 
            // btnSterge
            // 
            this.btnSterge.Location = new System.Drawing.Point(754, 69);
            this.btnSterge.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnSterge.Name = "btnSterge";
            this.btnSterge.Size = new System.Drawing.Size(153, 26);
            this.btnSterge.TabIndex = 22;
            this.btnSterge.Text = "Sterge";
            this.btnSterge.UseVisualStyleBackColor = true;
            this.btnSterge.Click += new System.EventHandler(this.btnSterge_Click);
            // 
            // btnEditProdus
            // 
            this.btnEditProdus.Location = new System.Drawing.Point(754, 104);
            this.btnEditProdus.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnEditProdus.Name = "btnEditProdus";
            this.btnEditProdus.Size = new System.Drawing.Size(153, 26);
            this.btnEditProdus.TabIndex = 23;
            this.btnEditProdus.Text = "Editeaza";
            this.btnEditProdus.UseVisualStyleBackColor = true;
            this.btnEditProdus.Click += new System.EventHandler(this.btnEditProdus_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(29, 30);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(107, 15);
            this.label9.TabIndex = 25;
            this.label9.Text = "Denumire produs:";
            // 
            // tbDenumireProdus
            // 
            this.tbDenumireProdus.Location = new System.Drawing.Point(184, 26);
            this.tbDenumireProdus.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tbDenumireProdus.Name = "tbDenumireProdus";
            this.tbDenumireProdus.Size = new System.Drawing.Size(339, 21);
            this.tbDenumireProdus.TabIndex = 24;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(65, 63);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(34, 15);
            this.label10.TabIndex = 27;
            this.label10.Text = "U.M.:";
            // 
            // cbUMProdus
            // 
            this.cbUMProdus.FormattingEnabled = true;
            this.cbUMProdus.Items.AddRange(new object[] {
            "buc",
            "ml",
            "mp"});
            this.cbUMProdus.Location = new System.Drawing.Point(184, 53);
            this.cbUMProdus.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cbUMProdus.Name = "cbUMProdus";
            this.cbUMProdus.Size = new System.Drawing.Size(140, 23);
            this.cbUMProdus.TabIndex = 26;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(63, 86);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(59, 15);
            this.label11.TabIndex = 29;
            this.label11.Text = "Cantitate:";
            // 
            // tbCantitateProdus
            // 
            this.tbCantitateProdus.Location = new System.Drawing.Point(184, 82);
            this.tbCantitateProdus.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tbCantitateProdus.Name = "tbCantitateProdus";
            this.tbCantitateProdus.Size = new System.Drawing.Size(140, 21);
            this.tbCantitateProdus.TabIndex = 28;
            this.tbCantitateProdus.TextChanged += new System.EventHandler(this.tbCantitateProdus_TextChanged);
            // 
            // tbPretProdus
            // 
            this.tbPretProdus.Location = new System.Drawing.Point(184, 110);
            this.tbPretProdus.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tbPretProdus.Name = "tbPretProdus";
            this.tbPretProdus.Size = new System.Drawing.Size(140, 21);
            this.tbPretProdus.TabIndex = 31;
            this.tbPretProdus.TextChanged += new System.EventHandler(this.tbPretProdus_TextChanged);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(63, 118);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(32, 15);
            this.label12.TabIndex = 30;
            this.label12.Text = "Pret:";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(361, 58);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(51, 15);
            this.label13.TabIndex = 37;
            this.label13.Text = "Valoare:";
            // 
            // tbValoareProdus
            // 
            this.tbValoareProdus.Location = new System.Drawing.Point(433, 54);
            this.tbValoareProdus.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tbValoareProdus.Name = "tbValoareProdus";
            this.tbValoareProdus.Size = new System.Drawing.Size(90, 21);
            this.tbValoareProdus.TabIndex = 36;
            // 
            // tbFaraTVAProdus
            // 
            this.tbFaraTVAProdus.Location = new System.Drawing.Point(433, 111);
            this.tbFaraTVAProdus.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tbFaraTVAProdus.Name = "tbFaraTVAProdus";
            this.tbFaraTVAProdus.Size = new System.Drawing.Size(90, 21);
            this.tbFaraTVAProdus.TabIndex = 35;
            // 
            // tbTVAProdus
            // 
            this.tbTVAProdus.Location = new System.Drawing.Point(433, 82);
            this.tbTVAProdus.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tbTVAProdus.Name = "tbTVAProdus";
            this.tbTVAProdus.Size = new System.Drawing.Size(90, 21);
            this.tbTVAProdus.TabIndex = 34;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(361, 115);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(35, 15);
            this.label14.TabIndex = 33;
            this.label14.Text = "Fara:";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(361, 91);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(30, 15);
            this.label15.TabIndex = 32;
            this.label15.Text = "TVA:";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(51, 18);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(134, 15);
            this.label16.TabIndex = 50;
            this.label16.Text = "Stoc produse (Inventar)";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.tbSearchProdus);
            this.groupBox1.Controls.Add(this.cbUM);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.tbPretMin);
            this.groupBox1.Controls.Add(this.tbValMin);
            this.groupBox1.Controls.Add(this.tbPretMax);
            this.groupBox1.Controls.Add(this.tbValMax);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.btnAddFiltru);
            this.groupBox1.Controls.Add(this.btnStergeFiltru);
            this.groupBox1.Controls.Add(this.tbCantMin);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.tbCantMax);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Location = new System.Drawing.Point(79, 212);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(926, 102);
            this.groupBox1.TabIndex = 51;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Filtrare produse in functie de";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.tbDenumireProdus);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.tbPretProdus);
            this.groupBox2.Controls.Add(this.btnEditProdus);
            this.groupBox2.Controls.Add(this.label14);
            this.groupBox2.Controls.Add(this.btnSterge);
            this.groupBox2.Controls.Add(this.cbUMProdus);
            this.groupBox2.Controls.Add(this.btnAddProdus);
            this.groupBox2.Controls.Add(this.label15);
            this.groupBox2.Controls.Add(this.label12);
            this.groupBox2.Controls.Add(this.label13);
            this.groupBox2.Controls.Add(this.tbTVAProdus);
            this.groupBox2.Controls.Add(this.label11);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Controls.Add(this.tbFaraTVAProdus);
            this.groupBox2.Controls.Add(this.tbCantitateProdus);
            this.groupBox2.Controls.Add(this.tbValoareProdus);
            this.groupBox2.Location = new System.Drawing.Point(79, 57);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(926, 149);
            this.groupBox2.TabIndex = 52;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Adauga/Modifica produs";
            // 
            // btnExportExcel
            // 
            this.btnExportExcel.Location = new System.Drawing.Point(860, 588);
            this.btnExportExcel.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnExportExcel.Name = "btnExportExcel";
            this.btnExportExcel.Size = new System.Drawing.Size(145, 26);
            this.btnExportExcel.TabIndex = 53;
            this.btnExportExcel.Text = "Export Excel";
            this.btnExportExcel.UseVisualStyleBackColor = true;
            // 
            // FormStocProduse
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1040, 666);
            this.Controls.Add(this.btnExportExcel);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.lblNrProduse2);
            this.Controls.Add(this.lblNrProduse);
            this.Controls.Add(this.dgvProduse);
            this.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "FormStocProduse";
            this.Text = "FormStocProduse";
            ((System.ComponentModel.ISupportInitialize)(this.dgvProduse)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvProduse;
        private System.Windows.Forms.Label lblNrProduse;
        private System.Windows.Forms.Label lblNrProduse2;
        private System.Windows.Forms.TextBox tbSearchProdus;
        private System.Windows.Forms.ComboBox cbUM;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tbPretMin;
        private System.Windows.Forms.TextBox tbValMin;
        private System.Windows.Forms.TextBox tbPretMax;
        private System.Windows.Forms.TextBox tbValMax;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnAddFiltru;
        private System.Windows.Forms.Button btnStergeFiltru;
        private System.Windows.Forms.TextBox tbCantMin;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox tbCantMax;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btnAddProdus;
        private System.Windows.Forms.Button btnSterge;
        private System.Windows.Forms.Button btnEditProdus;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox tbDenumireProdus;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ComboBox cbUMProdus;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox tbCantitateProdus;
        private System.Windows.Forms.TextBox tbPretProdus;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox tbValoareProdus;
        private System.Windows.Forms.TextBox tbFaraTVAProdus;
        private System.Windows.Forms.TextBox tbTVAProdus;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnExportExcel;
    }
}