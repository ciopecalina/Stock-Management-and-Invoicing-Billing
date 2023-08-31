
namespace app
{
    partial class FormEmiteri
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
            this.btnExportExcel = new System.Windows.Forms.Button();
            this.btnEditFactura = new System.Windows.Forms.Button();
            this.btnStergereFactura = new System.Windows.Forms.Button();
            this.btnFacturaWord = new System.Windows.Forms.Button();
            this.lblNrFacturi = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.tbSearchClient = new System.Windows.Forms.TextBox();
            this.dgvFacturi = new System.Windows.Forms.DataGridView();
            this.btnStergeFiltre = new System.Windows.Forms.Button();
            this.btnAddFactura = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.lbValoareTotala = new System.Windows.Forms.Label();
            this.lbValTVA = new System.Windows.Forms.Label();
            this.lbValFaraTVA = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFacturi)).BeginInit();
            this.SuspendLayout();
            // 
            // btnExportExcel
            // 
            this.btnExportExcel.Location = new System.Drawing.Point(779, 530);
            this.btnExportExcel.Name = "btnExportExcel";
            this.btnExportExcel.Size = new System.Drawing.Size(247, 27);
            this.btnExportExcel.TabIndex = 61;
            this.btnExportExcel.Text = "Export Excel";
            this.btnExportExcel.UseVisualStyleBackColor = true;
            // 
            // btnEditFactura
            // 
            this.btnEditFactura.Location = new System.Drawing.Point(874, 125);
            this.btnEditFactura.Name = "btnEditFactura";
            this.btnEditFactura.Size = new System.Drawing.Size(152, 27);
            this.btnEditFactura.TabIndex = 60;
            this.btnEditFactura.Text = "Editeaza";
            this.btnEditFactura.UseVisualStyleBackColor = true;
            // 
            // btnStergereFactura
            // 
            this.btnStergereFactura.Location = new System.Drawing.Point(874, 92);
            this.btnStergereFactura.Name = "btnStergereFactura";
            this.btnStergereFactura.Size = new System.Drawing.Size(152, 27);
            this.btnStergereFactura.TabIndex = 59;
            this.btnStergereFactura.Text = "Sterge";
            this.btnStergereFactura.UseVisualStyleBackColor = true;
            this.btnStergereFactura.Click += new System.EventHandler(this.btnStergereFactura_Click);
            // 
            // btnFacturaWord
            // 
            this.btnFacturaWord.Location = new System.Drawing.Point(726, 125);
            this.btnFacturaWord.Name = "btnFacturaWord";
            this.btnFacturaWord.Size = new System.Drawing.Size(131, 27);
            this.btnFacturaWord.TabIndex = 58;
            this.btnFacturaWord.Text = "Vizual  Fact Word";
            this.btnFacturaWord.UseVisualStyleBackColor = true;
            // 
            // lblNrFacturi
            // 
            this.lblNrFacturi.AutoSize = true;
            this.lblNrFacturi.Location = new System.Drawing.Point(185, 516);
            this.lblNrFacturi.Name = "lblNrFacturi";
            this.lblNrFacturi.Size = new System.Drawing.Size(14, 15);
            this.lblNrFacturi.TabIndex = 57;
            this.lblNrFacturi.Text = "0";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(54, 516);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(122, 15);
            this.label4.TabIndex = 56;
            this.label4.Text = "Numar facturi emise:";
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.Location = new System.Drawing.Point(203, 52);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(175, 21);
            this.dateTimePicker2.TabIndex = 55;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(384, 52);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(179, 21);
            this.dateTimePicker1.TabIndex = 54;
            this.dateTimePicker1.Value = new System.DateTime(2019, 1, 1, 0, 0, 0, 0);
            // 
            // tbSearchClient
            // 
            this.tbSearchClient.Location = new System.Drawing.Point(93, 86);
            this.tbSearchClient.Name = "tbSearchClient";
            this.tbSearchClient.Size = new System.Drawing.Size(470, 21);
            this.tbSearchClient.TabIndex = 53;
            // 
            // dgvFacturi
            // 
            this.dgvFacturi.AllowUserToAddRows = false;
            this.dgvFacturi.AllowUserToDeleteRows = false;
            this.dgvFacturi.AllowUserToOrderColumns = true;
            this.dgvFacturi.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvFacturi.Location = new System.Drawing.Point(57, 166);
            this.dgvFacturi.MultiSelect = false;
            this.dgvFacturi.Name = "dgvFacturi";
            this.dgvFacturi.ReadOnly = true;
            this.dgvFacturi.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvFacturi.Size = new System.Drawing.Size(969, 344);
            this.dgvFacturi.StandardTab = true;
            this.dgvFacturi.TabIndex = 52;
            // 
            // btnStergeFiltre
            // 
            this.btnStergeFiltre.Location = new System.Drawing.Point(387, 112);
            this.btnStergeFiltre.Name = "btnStergeFiltre";
            this.btnStergeFiltre.Size = new System.Drawing.Size(176, 27);
            this.btnStergeFiltre.TabIndex = 51;
            this.btnStergeFiltre.Text = "Reseteaza filtre";
            this.btnStergeFiltre.UseVisualStyleBackColor = true;
            // 
            // btnAddFactura
            // 
            this.btnAddFactura.Location = new System.Drawing.Point(874, 59);
            this.btnAddFactura.Name = "btnAddFactura";
            this.btnAddFactura.Size = new System.Drawing.Size(152, 27);
            this.btnAddFactura.TabIndex = 50;
            this.btnAddFactura.Text = "ADAUGA ";
            this.btnAddFactura.UseVisualStyleBackColor = true;
            this.btnAddFactura.Click += new System.EventHandler(this.btnAddFactura_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(21, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(157, 15);
            this.label1.TabIndex = 49;
            this.label1.Text = "Documente emise (Facturi)";
            // 
            // lbValoareTotala
            // 
            this.lbValoareTotala.AutoSize = true;
            this.lbValoareTotala.Location = new System.Drawing.Point(384, 587);
            this.lbValoareTotala.Name = "lbValoareTotala";
            this.lbValoareTotala.Size = new System.Drawing.Size(14, 15);
            this.lbValoareTotala.TabIndex = 66;
            this.lbValoareTotala.Text = "0";
            // 
            // lbValTVA
            // 
            this.lbValTVA.AutoSize = true;
            this.lbValTVA.Location = new System.Drawing.Point(215, 587);
            this.lbValTVA.Name = "lbValTVA";
            this.lbValTVA.Size = new System.Drawing.Size(14, 15);
            this.lbValTVA.TabIndex = 65;
            this.lbValTVA.Text = "0";
            // 
            // lbValFaraTVA
            // 
            this.lbValFaraTVA.AutoSize = true;
            this.lbValFaraTVA.Location = new System.Drawing.Point(73, 587);
            this.lbValFaraTVA.Name = "lbValFaraTVA";
            this.lbValFaraTVA.Size = new System.Drawing.Size(14, 15);
            this.lbValFaraTVA.TabIndex = 64;
            this.lbValFaraTVA.Text = "0";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(54, 547);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(511, 30);
            this.label3.TabIndex = 63;
            this.label3.Text = "Valoare fara TVA                             Valoare TVA                         " +
    "  Valoare TOTALA\r\n______________________________________________________________" +
    "__________";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(21, 52);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(166, 15);
            this.label2.TabIndex = 67;
            this.label2.Text = "Filtrare in functie de perioada";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(33, 92);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(49, 15);
            this.label6.TabIndex = 68;
            this.label6.Text = "si client";
            // 
            // FormEmiteri
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1040, 666);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lbValoareTotala);
            this.Controls.Add(this.lbValTVA);
            this.Controls.Add(this.lbValFaraTVA);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnExportExcel);
            this.Controls.Add(this.btnEditFactura);
            this.Controls.Add(this.btnStergereFactura);
            this.Controls.Add(this.btnFacturaWord);
            this.Controls.Add(this.lblNrFacturi);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.dateTimePicker2);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.tbSearchClient);
            this.Controls.Add(this.dgvFacturi);
            this.Controls.Add(this.btnStergeFiltre);
            this.Controls.Add(this.btnAddFactura);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormEmiteri";
            this.Text = "FormEmiteri";
            ((System.ComponentModel.ISupportInitialize)(this.dgvFacturi)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnExportExcel;
        private System.Windows.Forms.Button btnEditFactura;
        private System.Windows.Forms.Button btnStergereFactura;
        private System.Windows.Forms.Button btnFacturaWord;
        private System.Windows.Forms.Label lblNrFacturi;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker dateTimePicker2;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.TextBox tbSearchClient;
        private System.Windows.Forms.DataGridView dgvFacturi;
        private System.Windows.Forms.Button btnStergeFiltre;
        private System.Windows.Forms.Button btnAddFactura;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbValoareTotala;
        private System.Windows.Forms.Label lbValTVA;
        private System.Windows.Forms.Label lbValFaraTVA;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label6;
    }
}