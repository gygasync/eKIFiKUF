namespace EKIFKUF
{
    partial class Main
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
            this.txtPDV = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.comboMjesec = new System.Windows.Forms.ComboBox();
            this.txtGodina = new System.Windows.Forms.TextBox();
            this.btnUlaz = new System.Windows.Forms.Button();
            this.btnIzlaz = new System.Windows.Forms.Button();
            this.btnOtvori = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(44, 49);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "PDV:";
            // 
            // txtPDV
            // 
            this.txtPDV.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtPDV.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPDV.Location = new System.Drawing.Point(177, 46);
            this.txtPDV.MaxLength = 12;
            this.txtPDV.Name = "txtPDV";
            this.txtPDV.Size = new System.Drawing.Size(360, 35);
            this.txtPDV.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(45, 123);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(76, 24);
            this.label2.TabIndex = 2;
            this.label2.Text = "Mjesec:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(341, 123);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(76, 24);
            this.label3.TabIndex = 3;
            this.label3.Text = "Godina:";
            // 
            // comboMjesec
            // 
            this.comboMjesec.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboMjesec.FormattingEnabled = true;
            this.comboMjesec.Items.AddRange(new object[] {
            "Januar",
            "Februar",
            "Mart",
            "April",
            "Maj",
            "Jun",
            "Jul",
            "Avgust",
            "Septembar",
            "Oktobar",
            "Novembar",
            "Decembar"});
            this.comboMjesec.Location = new System.Drawing.Point(177, 120);
            this.comboMjesec.MaxDropDownItems = 12;
            this.comboMjesec.Name = "comboMjesec";
            this.comboMjesec.Size = new System.Drawing.Size(121, 32);
            this.comboMjesec.TabIndex = 4;
            // 
            // txtGodina
            // 
            this.txtGodina.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtGodina.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtGodina.Location = new System.Drawing.Point(437, 120);
            this.txtGodina.MaxLength = 4;
            this.txtGodina.Name = "txtGodina";
            this.txtGodina.Size = new System.Drawing.Size(100, 29);
            this.txtGodina.TabIndex = 5;
            // 
            // btnUlaz
            // 
            this.btnUlaz.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUlaz.Location = new System.Drawing.Point(168, 199);
            this.btnUlaz.Name = "btnUlaz";
            this.btnUlaz.Size = new System.Drawing.Size(171, 46);
            this.btnUlaz.TabIndex = 6;
            this.btnUlaz.Text = "Ulaz";
            this.btnUlaz.UseVisualStyleBackColor = true;
            this.btnUlaz.Click += new System.EventHandler(this.btnUlaz_Click);
            // 
            // btnIzlaz
            // 
            this.btnIzlaz.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnIzlaz.Location = new System.Drawing.Point(345, 199);
            this.btnIzlaz.Name = "btnIzlaz";
            this.btnIzlaz.Size = new System.Drawing.Size(192, 46);
            this.btnIzlaz.TabIndex = 7;
            this.btnIzlaz.Text = "Izlaz";
            this.btnIzlaz.UseVisualStyleBackColor = true;
            this.btnIzlaz.Click += new System.EventHandler(this.btnIzlaz_Click);
            // 
            // btnOtvori
            // 
            this.btnOtvori.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.btnOtvori.Location = new System.Drawing.Point(277, 251);
            this.btnOtvori.Name = "btnOtvori";
            this.btnOtvori.Size = new System.Drawing.Size(140, 50);
            this.btnOtvori.TabIndex = 8;
            this.btnOtvori.Text = "Otvori .csv";
            this.btnOtvori.UseVisualStyleBackColor = true;
            this.btnOtvori.Click += new System.EventHandler(this.btnOtvori_Click);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(637, 315);
            this.Controls.Add(this.btnOtvori);
            this.Controls.Add(this.btnIzlaz);
            this.Controls.Add(this.btnUlaz);
            this.Controls.Add(this.txtGodina);
            this.Controls.Add(this.comboMjesec);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtPDV);
            this.Controls.Add(this.label1);
            this.MinimumSize = new System.Drawing.Size(653, 335);
            this.Name = "Main";
            this.Text = "Elektronski KIF i KUF";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtPDV;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox comboMjesec;
        private System.Windows.Forms.TextBox txtGodina;
        private System.Windows.Forms.Button btnUlaz;
        private System.Windows.Forms.Button btnIzlaz;
        private System.Windows.Forms.Button btnOtvori;
    }
}

