namespace WindowsFormsApp1
{
    partial class Form1
    {
        /// <summary>
        /// Wymagana zmienna projektanta.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Wyczyść wszystkie używane zasoby.
        /// </summary>
        /// <param name="disposing">prawda, jeżeli zarządzane zasoby powinny zostać zlikwidowane; Fałsz w przeciwnym wypadku.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kod generowany przez Projektanta formularzy systemu Windows

        /// <summary>
        /// Metoda wymagana do obsługi projektanta — nie należy modyfikować
        /// jej zawartości w edytorze kodu.
        /// </summary>
        private void InitializeComponent()
        {
            this.dupa = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.LabTemp = new System.Windows.Forms.Label();
            this.LabTemp1 = new System.Windows.Forms.Label();
            this.labelMiasto = new System.Windows.Forms.Label();
            this.tekst = new System.Windows.Forms.Label();
            this.labelWiatr = new System.Windows.Forms.Label();
            this.flp = new System.Windows.Forms.FlowLayoutPanel();
            this.SuspendLayout();
            // 
            // dupa
            // 
            this.dupa.Location = new System.Drawing.Point(168, 22);
            this.dupa.Name = "dupa";
            this.dupa.Size = new System.Drawing.Size(161, 41);
            this.dupa.TabIndex = 0;
            this.dupa.Text = "Pokaż pogodę";
            this.dupa.UseVisualStyleBackColor = true;
            this.dupa.Click += new System.EventHandler(this.button1_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(17, 41);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(132, 22);
            this.textBox1.TabIndex = 1;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // LabTemp
            // 
            this.LabTemp.AutoSize = true;
            this.LabTemp.Location = new System.Drawing.Point(440, 79);
            this.LabTemp.Name = "LabTemp";
            this.LabTemp.Size = new System.Drawing.Size(0, 16);
            this.LabTemp.TabIndex = 2;
            // 
            // LabTemp1
            // 
            this.LabTemp1.AutoSize = true;
            this.LabTemp1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.LabTemp1.Location = new System.Drawing.Point(33, 146);
            this.LabTemp1.Name = "LabTemp1";
            this.LabTemp1.Size = new System.Drawing.Size(54, 32);
            this.LabTemp1.TabIndex = 3;
            this.LabTemp1.Text = "n/a";
            this.LabTemp1.Click += new System.EventHandler(this.LabTemp1_Click);
            // 
            // labelMiasto
            // 
            this.labelMiasto.AutoSize = true;
            this.labelMiasto.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelMiasto.Location = new System.Drawing.Point(361, 79);
            this.labelMiasto.Name = "labelMiasto";
            this.labelMiasto.Size = new System.Drawing.Size(40, 25);
            this.labelMiasto.TabIndex = 4;
            this.labelMiasto.Text = "n/a";
            // 
            // tekst
            // 
            this.tekst.AutoSize = true;
            this.tekst.Location = new System.Drawing.Point(36, 22);
            this.tekst.Name = "tekst";
            this.tekst.Size = new System.Drawing.Size(89, 16);
            this.tekst.TabIndex = 5;
            this.tekst.Text = "Podaj miasto:";
            this.tekst.Click += new System.EventHandler(this.tekst_Click);
            // 
            // labelWiatr
            // 
            this.labelWiatr.AutoSize = true;
            this.labelWiatr.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelWiatr.Location = new System.Drawing.Point(33, 206);
            this.labelWiatr.Name = "labelWiatr";
            this.labelWiatr.Size = new System.Drawing.Size(54, 32);
            this.labelWiatr.TabIndex = 6;
            this.labelWiatr.Text = "n/a";
            // 
            // flp
            // 
            this.flp.AutoScroll = true;
            this.flp.BackColor = System.Drawing.Color.Transparent;
            this.flp.Location = new System.Drawing.Point(250, 193);
            this.flp.Name = "flp";
            this.flp.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.flp.Size = new System.Drawing.Size(489, 233);
            this.flp.TabIndex = 7;
            this.flp.Paint += new System.Windows.Forms.PaintEventHandler(this.flowLayoutPanel1_Paint);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(764, 462);
            this.Controls.Add(this.flp);
            this.Controls.Add(this.labelWiatr);
            this.Controls.Add(this.tekst);
            this.Controls.Add(this.labelMiasto);
            this.Controls.Add(this.LabTemp1);
            this.Controls.Add(this.LabTemp);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.dupa);
            this.Name = "Form1";
            this.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button dupa;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label LabTemp;
        private System.Windows.Forms.Label LabTemp1;
        private System.Windows.Forms.Label labelMiasto;
        private System.Windows.Forms.Label tekst;
        private System.Windows.Forms.Label labelWiatr;
        private System.Windows.Forms.FlowLayoutPanel flp;
    }
}

