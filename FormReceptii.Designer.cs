
namespace app
{
    partial class FormReceptii
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
            this.label1 = new System.Windows.Forms.Label();
            this.lb = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lbValFaraTVA = new System.Windows.Forms.Label();
            this.lbValTVA = new System.Windows.Forms.Label();
            this.lbValoareTotala = new System.Windows.Forms.Label();
            this.btnAddNIR = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.btnRaportExcel = new System.Windows.Forms.Button();
            this.dataGridViewNIR = new System.Windows.Forms.DataGridView();
            this.tbSearchFurnizor = new System.Windows.Forms.TextBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.lblNrNIR = new System.Windows.Forms.Label();
            this.btnWord = new System.Windows.Forms.Button();
            this.btnStergere = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnExportExcel = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewNIR)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(17, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(201, 18);
            this.label1.TabIndex = 25;
            this.label1.Text = "Receptii de la furnizori (NIR)";
            // 
            // lb
            // 
            this.lb.AutoSize = true;
            this.lb.Location = new System.Drawing.Point(62, 524);
            this.lb.Name = "lb";
            this.lb.Size = new System.Drawing.Size(115, 15);
            this.lb.TabIndex = 26;
            this.lb.Text = "Valoarea receptiilor:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(62, 550);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(511, 30);
            this.label3.TabIndex = 27;
            this.label3.Text = "Valoare fara TVA                             Valoare TVA                         " +
    "  Valoare TOTALA\r\n______________________________________________________________" +
    "__________";
            // 
            // lbValFaraTVA
            // 
            this.lbValFaraTVA.AutoSize = true;
            this.lbValFaraTVA.Location = new System.Drawing.Point(62, 580);
            this.lbValFaraTVA.Name = "lbValFaraTVA";
            this.lbValFaraTVA.Size = new System.Drawing.Size(14, 15);
            this.lbValFaraTVA.TabIndex = 28;
            this.lbValFaraTVA.Text = "0";
            // 
            // lbValTVA
            // 
            this.lbValTVA.AutoSize = true;
            this.lbValTVA.Location = new System.Drawing.Point(237, 580);
            this.lbValTVA.Name = "lbValTVA";
            this.lbValTVA.Size = new System.Drawing.Size(14, 15);
            this.lbValTVA.TabIndex = 29;
            this.lbValTVA.Text = "0";
            // 
            // lbValoareTotala
            // 
            this.lbValoareTotala.AutoSize = true;
            this.lbValoareTotala.Location = new System.Drawing.Point(382, 580);
            this.lbValoareTotala.Name = "lbValoareTotala";
            this.lbValoareTotala.Size = new System.Drawing.Size(14, 15);
            this.lbValoareTotala.TabIndex = 30;
            this.lbValoareTotala.Text = "0";
            // 
            // btnAddNIR
            // 
            this.btnAddNIR.BackColor = System.Drawing.Color.CornflowerBlue;
            this.btnAddNIR.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddNIR.ForeColor = System.Drawing.Color.White;
            this.btnAddNIR.Location = new System.Drawing.Point(765, 109);
            this.btnAddNIR.Name = "btnAddNIR";
            this.btnAddNIR.Size = new System.Drawing.Size(113, 27);
            this.btnAddNIR.TabIndex = 31;
            this.btnAddNIR.Text = "+ Receptie";
            this.btnAddNIR.UseVisualStyleBackColor = false;
            this.btnAddNIR.Click += new System.EventHandler(this.btnAddNIR_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(385, 99);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(157, 27);
            this.button1.TabIndex = 32;
            this.button1.Text = "Resetare filtre";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnRaportExcel
            // 
            this.btnRaportExcel.BackColor = System.Drawing.Color.ForestGreen;
            this.btnRaportExcel.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRaportExcel.ForeColor = System.Drawing.Color.White;
            this.btnRaportExcel.Location = new System.Drawing.Point(552, 478);
            this.btnRaportExcel.Name = "btnRaportExcel";
            this.btnRaportExcel.Size = new System.Drawing.Size(326, 33);
            this.btnRaportExcel.TabIndex = 33;
            this.btnRaportExcel.Text = "Raport NIR-uri (.xlsx)";
            this.btnRaportExcel.UseVisualStyleBackColor = false;
            this.btnRaportExcel.Click += new System.EventHandler(this.btnExportCSV_Click);
            // 
            // dataGridViewNIR
            // 
            this.dataGridViewNIR.AllowUserToAddRows = false;
            this.dataGridViewNIR.AllowUserToDeleteRows = false;
            this.dataGridViewNIR.AllowUserToOrderColumns = true;
            this.dataGridViewNIR.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewNIR.Location = new System.Drawing.Point(65, 148);
            this.dataGridViewNIR.MultiSelect = false;
            this.dataGridViewNIR.Name = "dataGridViewNIR";
            this.dataGridViewNIR.ReadOnly = true;
            this.dataGridViewNIR.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewNIR.Size = new System.Drawing.Size(961, 319);
            this.dataGridViewNIR.StandardTab = true;
            this.dataGridViewNIR.TabIndex = 39;
            // 
            // tbSearchFurnizor
            // 
            this.tbSearchFurnizor.Location = new System.Drawing.Point(120, 73);
            this.tbSearchFurnizor.Name = "tbSearchFurnizor";
            this.tbSearchFurnizor.Size = new System.Drawing.Size(422, 21);
            this.tbSearchFurnizor.TabIndex = 40;
            this.tbSearchFurnizor.TextChanged += new System.EventHandler(this.tbSearchFurnizor_TextChanged);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(199, 47);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(157, 21);
            this.dateTimePicker1.TabIndex = 41;
            this.dateTimePicker1.Value = new System.DateTime(2019, 1, 1, 0, 0, 0, 0);
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.Location = new System.Drawing.Point(385, 47);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(157, 21);
            this.dateTimePicker2.TabIndex = 42;
            this.dateTimePicker2.CloseUp += new System.EventHandler(this.dateTimePicker2_CloseUp);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(62, 478);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(61, 15);
            this.label4.TabIndex = 43;
            this.label4.Text = "Rezultate:";
            // 
            // lblNrNIR
            // 
            this.lblNrNIR.AutoSize = true;
            this.lblNrNIR.Location = new System.Drawing.Point(136, 478);
            this.lblNrNIR.Name = "lblNrNIR";
            this.lblNrNIR.Size = new System.Drawing.Size(14, 15);
            this.lblNrNIR.TabIndex = 44;
            this.lblNrNIR.Text = "0";
            // 
            // btnWord
            // 
            this.btnWord.BackColor = System.Drawing.Color.RoyalBlue;
            this.btnWord.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnWord.ForeColor = System.Drawing.Color.White;
            this.btnWord.Location = new System.Drawing.Point(896, 109);
            this.btnWord.Name = "btnWord";
            this.btnWord.Size = new System.Drawing.Size(129, 27);
            this.btnWord.TabIndex = 45;
            this.btnWord.Text = "Vizualizare .docx";
            this.btnWord.UseVisualStyleBackColor = false;
            this.btnWord.Click += new System.EventHandler(this.btnWord_Click);
            // 
            // btnStergere
            // 
            this.btnStergere.BackColor = System.Drawing.Color.IndianRed;
            this.btnStergere.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStergere.ForeColor = System.Drawing.Color.White;
            this.btnStergere.Location = new System.Drawing.Point(896, 43);
            this.btnStergere.Name = "btnStergere";
            this.btnStergere.Size = new System.Drawing.Size(129, 27);
            this.btnStergere.TabIndex = 46;
            this.btnStergere.Text = "Sterge X";
            this.btnStergere.UseVisualStyleBackColor = false;
            this.btnStergere.Click += new System.EventHandler(this.btnStergere_Click);
            // 
            // btnEdit
            // 
            this.btnEdit.BackColor = System.Drawing.Color.Olive;
            this.btnEdit.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEdit.ForeColor = System.Drawing.Color.White;
            this.btnEdit.Location = new System.Drawing.Point(896, 76);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(129, 27);
            this.btnEdit.TabIndex = 47;
            this.btnEdit.Text = "Modifica ✍";
            this.btnEdit.UseVisualStyleBackColor = false;
            // 
            // btnExportExcel
            // 
            this.btnExportExcel.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExportExcel.Location = new System.Drawing.Point(884, 482);
            this.btnExportExcel.Name = "btnExportExcel";
            this.btnExportExcel.Size = new System.Drawing.Size(141, 24);
            this.btnExportExcel.TabIndex = 48;
            this.btnExportExcel.Text = "Export (.xlsx)";
            this.btnExportExcel.UseVisualStyleBackColor = true;
            this.btnExportExcel.Click += new System.EventHandler(this.btnExportExcel_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(17, 52);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(166, 15);
            this.label2.TabIndex = 49;
            this.label2.Text = "Filtrare in functie de perioada";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(365, 47);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(11, 15);
            this.label5.TabIndex = 50;
            this.label5.Text = "-";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(19, 76);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(77, 15);
            this.label6.TabIndex = 51;
            this.label6.Text = "si de furnizor";
            // 
            // FormReceptii
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1040, 666);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnExportExcel);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.btnStergere);
            this.Controls.Add(this.btnWord);
            this.Controls.Add(this.lblNrNIR);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.dateTimePicker2);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.tbSearchFurnizor);
            this.Controls.Add(this.dataGridViewNIR);
            this.Controls.Add(this.btnRaportExcel);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnAddNIR);
            this.Controls.Add(this.lbValoareTotala);
            this.Controls.Add(this.lbValTVA);
            this.Controls.Add(this.lbValFaraTVA);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lb);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormReceptii";
            this.ShowInTaskbar = false;
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewNIR)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lb;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lbValFaraTVA;
        private System.Windows.Forms.Label lbValTVA;
        private System.Windows.Forms.Label lbValoareTotala;
        private System.Windows.Forms.Button btnAddNIR;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnRaportExcel;
        private System.Windows.Forms.DataGridView dataGridViewNIR;
        private System.Windows.Forms.TextBox tbSearchFurnizor;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.DateTimePicker dateTimePicker2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblNrNIR;
        private System.Windows.Forms.Button btnWord;
        private System.Windows.Forms.Button btnStergere;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Button btnExportExcel;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
    }
}

