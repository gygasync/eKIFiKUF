namespace EKIFKUF
{
    partial class DataForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label1 = new System.Windows.Forms.Label();
            this.lblPDV = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblPeriod = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lblTIP = new System.Windows.Forms.Label();
            this.dataGrid = new System.Windows.Forms.DataGridView();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.lblUkupnoBezPDV = new System.Windows.Forms.Label();
            this.lblUkupnoSaPDV = new System.Windows.Forms.Label();
            this.lblUkupnoPDV = new System.Windows.Forms.Label();
            this.btnSacuvaj = new System.Windows.Forms.Button();
            this.redniBroj = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.brojFakture = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.datumFakture = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nazivDobavljaca = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sjedisteDobavljaca = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PDVbroj = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iznosBezPDV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iznosPDV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iznosSaPdv = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnPDF = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "PDV: ";
            // 
            // lblPDV
            // 
            this.lblPDV.AutoSize = true;
            this.lblPDV.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPDV.Location = new System.Drawing.Point(68, 9);
            this.lblPDV.Name = "lblPDV";
            this.lblPDV.Size = new System.Drawing.Size(117, 20);
            this.lblPDV.TabIndex = 1;
            this.lblPDV.Text = "000000000000";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(223, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Period: ";
            // 
            // lblPeriod
            // 
            this.lblPeriod.AutoSize = true;
            this.lblPeriod.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPeriod.Location = new System.Drawing.Point(291, 9);
            this.lblPeriod.Name = "lblPeriod";
            this.lblPeriod.Size = new System.Drawing.Size(57, 20);
            this.lblPeriod.TabIndex = 3;
            this.lblPeriod.Text = "YYMM";
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(1012, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(34, 20);
            this.label4.TabIndex = 4;
            this.label4.Text = "Tip:";
            // 
            // lblTIP
            // 
            this.lblTIP.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblTIP.AutoSize = true;
            this.lblTIP.BackColor = System.Drawing.SystemColors.Desktop;
            this.lblTIP.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTIP.ForeColor = System.Drawing.SystemColors.Control;
            this.lblTIP.Location = new System.Drawing.Point(1052, 9);
            this.lblTIP.Name = "lblTIP";
            this.lblTIP.Size = new System.Drawing.Size(37, 20);
            this.lblTIP.TabIndex = 5;
            this.lblTIP.Text = "KIF";
            // 
            // dataGrid
            // 
            this.dataGrid.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.redniBroj,
            this.brojFakture,
            this.datumFakture,
            this.nazivDobavljaca,
            this.sjedisteDobavljaca,
            this.PDVbroj,
            this.iznosBezPDV,
            this.iznosPDV,
            this.iznosSaPdv});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGrid.DefaultCellStyle = dataGridViewCellStyle2;
            this.dataGrid.Location = new System.Drawing.Point(16, 32);
            this.dataGrid.Name = "dataGrid";
            this.dataGrid.Size = new System.Drawing.Size(1073, 437);
            this.dataGrid.TabIndex = 6;
            this.dataGrid.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGrid_CellContentClick);
            this.dataGrid.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGrid_CellEndEdit);
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(12, 484);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(149, 20);
            this.label3.TabIndex = 7;
            this.label3.Text = "Ukupno bez PDVa: ";
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(265, 484);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(149, 20);
            this.label5.TabIndex = 8;
            this.label5.Text = "Ukupno sa PDVom:";
            // 
            // label6
            // 
            this.label6.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(535, 484);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(106, 20);
            this.label6.TabIndex = 9;
            this.label6.Text = "Ukupno PDV:";
            // 
            // lblUkupnoBezPDV
            // 
            this.lblUkupnoBezPDV.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblUkupnoBezPDV.AutoSize = true;
            this.lblUkupnoBezPDV.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUkupnoBezPDV.Location = new System.Drawing.Point(167, 485);
            this.lblUkupnoBezPDV.Name = "lblUkupnoBezPDV";
            this.lblUkupnoBezPDV.Size = new System.Drawing.Size(40, 20);
            this.lblUkupnoBezPDV.TabIndex = 10;
            this.lblUkupnoBezPDV.Text = "0.00";
            // 
            // lblUkupnoSaPDV
            // 
            this.lblUkupnoSaPDV.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblUkupnoSaPDV.AutoSize = true;
            this.lblUkupnoSaPDV.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUkupnoSaPDV.Location = new System.Drawing.Point(420, 485);
            this.lblUkupnoSaPDV.Name = "lblUkupnoSaPDV";
            this.lblUkupnoSaPDV.Size = new System.Drawing.Size(40, 20);
            this.lblUkupnoSaPDV.TabIndex = 11;
            this.lblUkupnoSaPDV.Text = "0.00";
            // 
            // lblUkupnoPDV
            // 
            this.lblUkupnoPDV.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblUkupnoPDV.AutoSize = true;
            this.lblUkupnoPDV.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUkupnoPDV.Location = new System.Drawing.Point(647, 484);
            this.lblUkupnoPDV.Name = "lblUkupnoPDV";
            this.lblUkupnoPDV.Size = new System.Drawing.Size(40, 20);
            this.lblUkupnoPDV.TabIndex = 12;
            this.lblUkupnoPDV.Text = "0.00";
            // 
            // btnSacuvaj
            // 
            this.btnSacuvaj.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSacuvaj.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSacuvaj.Location = new System.Drawing.Point(970, 475);
            this.btnSacuvaj.Name = "btnSacuvaj";
            this.btnSacuvaj.Size = new System.Drawing.Size(119, 30);
            this.btnSacuvaj.TabIndex = 13;
            this.btnSacuvaj.Text = "Sačuvaj";
            this.btnSacuvaj.UseVisualStyleBackColor = true;
            this.btnSacuvaj.Click += new System.EventHandler(this.btnSacuvaj_Click);
            // 
            // redniBroj
            // 
            this.redniBroj.HeaderText = "Broj";
            this.redniBroj.Name = "redniBroj";
            this.redniBroj.ReadOnly = true;
            this.redniBroj.Width = 40;
            // 
            // brojFakture
            // 
            this.brojFakture.HeaderText = "Broj Fakture";
            this.brojFakture.MaxInputLength = 100;
            this.brojFakture.Name = "brojFakture";
            // 
            // datumFakture
            // 
            dataGridViewCellStyle1.NullValue = "GGGG-MM-DD";
            this.datumFakture.DefaultCellStyle = dataGridViewCellStyle1;
            this.datumFakture.HeaderText = "Datum Fakture";
            this.datumFakture.MaxInputLength = 10;
            this.datumFakture.Name = "datumFakture";
            // 
            // nazivDobavljaca
            // 
            this.nazivDobavljaca.HeaderText = "Naziv Firme";
            this.nazivDobavljaca.MaxInputLength = 100;
            this.nazivDobavljaca.Name = "nazivDobavljaca";
            this.nazivDobavljaca.Width = 180;
            // 
            // sjedisteDobavljaca
            // 
            this.sjedisteDobavljaca.HeaderText = "Sjediste Firme";
            this.sjedisteDobavljaca.MaxInputLength = 100;
            this.sjedisteDobavljaca.Name = "sjedisteDobavljaca";
            this.sjedisteDobavljaca.Width = 150;
            // 
            // PDVbroj
            // 
            this.PDVbroj.HeaderText = "PDV Broj";
            this.PDVbroj.MaxInputLength = 12;
            this.PDVbroj.Name = "PDVbroj";
            // 
            // iznosBezPDV
            // 
            this.iznosBezPDV.HeaderText = "Iznos bez PDV";
            this.iznosBezPDV.MaxInputLength = 25;
            this.iznosBezPDV.Name = "iznosBezPDV";
            // 
            // iznosPDV
            // 
            this.iznosPDV.HeaderText = "Iznos PDV";
            this.iznosPDV.MaxInputLength = 25;
            this.iznosPDV.Name = "iznosPDV";
            // 
            // iznosSaPdv
            // 
            this.iznosSaPdv.HeaderText = "Iznos sa PDV";
            this.iznosSaPdv.MaxInputLength = 25;
            this.iznosSaPdv.Name = "iznosSaPdv";
            // 
            // btnPDF
            // 
            this.btnPDF.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnPDF.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPDF.Location = new System.Drawing.Point(831, 475);
            this.btnPDF.Name = "btnPDF";
            this.btnPDF.Size = new System.Drawing.Size(120, 30);
            this.btnPDF.TabIndex = 14;
            this.btnPDF.Text = "Sačuvaj PDF";
            this.btnPDF.UseVisualStyleBackColor = true;
            this.btnPDF.Click += new System.EventHandler(this.btnPDF_Click);
            // 
            // DataForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1101, 513);
            this.Controls.Add(this.btnPDF);
            this.Controls.Add(this.btnSacuvaj);
            this.Controls.Add(this.lblUkupnoPDV);
            this.Controls.Add(this.lblUkupnoSaPDV);
            this.Controls.Add(this.lblUkupnoBezPDV);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dataGrid);
            this.Controls.Add(this.lblTIP);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lblPeriod);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblPDV);
            this.Controls.Add(this.label1);
            this.MinimumSize = new System.Drawing.Size(950, 536);
            this.Name = "DataForm";
            this.Text = "DataForm";
            this.Load += new System.EventHandler(this.DataForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblPDV;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblPeriod;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblTIP;
        private System.Windows.Forms.DataGridView dataGrid;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lblUkupnoBezPDV;
        private System.Windows.Forms.Label lblUkupnoSaPDV;
        private System.Windows.Forms.Label lblUkupnoPDV;
        private System.Windows.Forms.Button btnSacuvaj;
        private System.Windows.Forms.DataGridViewTextBoxColumn redniBroj;
        private System.Windows.Forms.DataGridViewTextBoxColumn brojFakture;
        private System.Windows.Forms.DataGridViewTextBoxColumn datumFakture;
        private System.Windows.Forms.DataGridViewTextBoxColumn nazivDobavljaca;
        private System.Windows.Forms.DataGridViewTextBoxColumn sjedisteDobavljaca;
        private System.Windows.Forms.DataGridViewTextBoxColumn PDVbroj;
        private System.Windows.Forms.DataGridViewTextBoxColumn iznosBezPDV;
        private System.Windows.Forms.DataGridViewTextBoxColumn iznosPDV;
        private System.Windows.Forms.DataGridViewTextBoxColumn iznosSaPdv;
        private System.Windows.Forms.Button btnPDF;
    }
}