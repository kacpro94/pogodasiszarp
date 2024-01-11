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
            this.components = new System.ComponentModel.Container();
            this.dupa = new System.Windows.Forms.Button();
            this.wpiszmiasto = new System.Windows.Forms.TextBox();
            this.LabTemp = new System.Windows.Forms.Label();
            this.LabTemp1 = new System.Windows.Forms.Label();
            this.labelMiasto = new System.Windows.Forms.Label();
            this.tekstpodajmiasto = new System.Windows.Forms.Label();
            this.labelWiatr = new System.Windows.Forms.Label();
            this.flp = new System.Windows.Forms.FlowLayoutPanel();
            this.labelwschod = new System.Windows.Forms.Label();
            this.labelzachod = new System.Windows.Forms.Label();
            this.labelcisnienie = new System.Windows.Forms.Label();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.pictureikona = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureikona)).BeginInit();
            this.SuspendLayout();
            // 
            // dupa
            // 
            this.dupa.Cursor = System.Windows.Forms.Cursors.Hand;
            this.dupa.Location = new System.Drawing.Point(367, 49);
            this.dupa.Name = "dupa";
            this.dupa.Size = new System.Drawing.Size(161, 41);
            this.dupa.TabIndex = 0;
            this.dupa.Text = "Pokaż pogodę";
            this.dupa.UseVisualStyleBackColor = true;
            this.dupa.Click += new System.EventHandler(this.button1_Click);
            // 
            // wpiszmiasto
            // 
            this.wpiszmiasto.Location = new System.Drawing.Point(154, 57);
            this.wpiszmiasto.Name = "wpiszmiasto";
            this.wpiszmiasto.Size = new System.Drawing.Size(132, 22);
            this.wpiszmiasto.TabIndex = 1;
            this.wpiszmiasto.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // LabTemp
            // 
            this.LabTemp.AutoSize = true;
            this.LabTemp.Location = new System.Drawing.Point(435, 88);
            this.LabTemp.Name = "LabTemp";
            this.LabTemp.Size = new System.Drawing.Size(0, 16);
            this.LabTemp.TabIndex = 2;
            // 
            // LabTemp1
            // 
            this.LabTemp1.AutoSize = true;
            this.LabTemp1.BackColor = System.Drawing.Color.Transparent;
            this.LabTemp1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.LabTemp1.ForeColor = System.Drawing.Color.White;
            this.LabTemp1.Location = new System.Drawing.Point(28, 142);
            this.LabTemp1.Name = "LabTemp1";
            this.LabTemp1.Size = new System.Drawing.Size(54, 32);
            this.LabTemp1.TabIndex = 3;
            this.LabTemp1.Text = "n/a";
            this.LabTemp1.Click += new System.EventHandler(this.LabTemp1_Click);
            // 
            // labelMiasto
            // 
            this.labelMiasto.AutoSize = true;
            this.labelMiasto.BackColor = System.Drawing.Color.Transparent;
            this.labelMiasto.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelMiasto.ForeColor = System.Drawing.Color.White;
            this.labelMiasto.Location = new System.Drawing.Point(587, 53);
            this.labelMiasto.Name = "labelMiasto";
            this.labelMiasto.Size = new System.Drawing.Size(40, 25);
            this.labelMiasto.TabIndex = 4;
            this.labelMiasto.Text = "n/a";
            this.labelMiasto.Click += new System.EventHandler(this.labelMiasto_Click);
            // 
            // tekstpodajmiasto
            // 
            this.tekstpodajmiasto.AutoSize = true;
            this.tekstpodajmiasto.BackColor = System.Drawing.Color.Transparent;
            this.tekstpodajmiasto.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.tekstpodajmiasto.ForeColor = System.Drawing.Color.White;
            this.tekstpodajmiasto.Location = new System.Drawing.Point(159, 35);
            this.tekstpodajmiasto.Name = "tekstpodajmiasto";
            this.tekstpodajmiasto.Size = new System.Drawing.Size(111, 20);
            this.tekstpodajmiasto.TabIndex = 5;
            this.tekstpodajmiasto.Text = "Podaj miasto:";
            this.tekstpodajmiasto.Click += new System.EventHandler(this.tekst_Click);
            // 
            // labelWiatr
            // 
            this.labelWiatr.AutoSize = true;
            this.labelWiatr.BackColor = System.Drawing.Color.Transparent;
            this.labelWiatr.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelWiatr.ForeColor = System.Drawing.Color.White;
            this.labelWiatr.Location = new System.Drawing.Point(28, 202);
            this.labelWiatr.Name = "labelWiatr";
            this.labelWiatr.Size = new System.Drawing.Size(54, 32);
            this.labelWiatr.TabIndex = 6;
            this.labelWiatr.Text = "n/a";
            // 
            // flp
            // 
            this.flp.AutoScroll = true;
            this.flp.BackColor = System.Drawing.Color.Transparent;
            this.flp.ForeColor = System.Drawing.Color.White;
            this.flp.Location = new System.Drawing.Point(438, 117);
            this.flp.Name = "flp";
            this.flp.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.flp.Size = new System.Drawing.Size(456, 313);
            this.flp.TabIndex = 7;
            this.flp.Paint += new System.Windows.Forms.PaintEventHandler(this.flowLayoutPanel1_Paint);
            // 
            // labelwschod
            // 
            this.labelwschod.AutoSize = true;
            this.labelwschod.BackColor = System.Drawing.Color.Transparent;
            this.labelwschod.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelwschod.ForeColor = System.Drawing.Color.White;
            this.labelwschod.Location = new System.Drawing.Point(28, 305);
            this.labelwschod.Name = "labelwschod";
            this.labelwschod.Size = new System.Drawing.Size(54, 32);
            this.labelwschod.TabIndex = 8;
            this.labelwschod.Text = "n/a";
            // 
            // labelzachod
            // 
            this.labelzachod.AutoSize = true;
            this.labelzachod.BackColor = System.Drawing.Color.Transparent;
            this.labelzachod.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelzachod.ForeColor = System.Drawing.Color.White;
            this.labelzachod.Location = new System.Drawing.Point(28, 355);
            this.labelzachod.Name = "labelzachod";
            this.labelzachod.Size = new System.Drawing.Size(54, 32);
            this.labelzachod.TabIndex = 9;
            this.labelzachod.Text = "n/a";
            // 
            // labelcisnienie
            // 
            this.labelcisnienie.AutoSize = true;
            this.labelcisnienie.BackColor = System.Drawing.Color.Transparent;
            this.labelcisnienie.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelcisnienie.ForeColor = System.Drawing.Color.White;
            this.labelcisnienie.Location = new System.Drawing.Point(28, 256);
            this.labelcisnienie.Name = "labelcisnienie";
            this.labelcisnienie.Size = new System.Drawing.Size(54, 32);
            this.labelcisnienie.TabIndex = 10;
            this.labelcisnienie.Text = "n/a";
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // pictureikona
            // 
            this.pictureikona.BackColor = System.Drawing.Color.Transparent;
            this.pictureikona.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pictureikona.Location = new System.Drawing.Point(21, 22);
            this.pictureikona.Name = "pictureikona";
            this.pictureikona.Size = new System.Drawing.Size(111, 98);
            this.pictureikona.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureikona.TabIndex = 13;
            this.pictureikona.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.BackgroundImage = global::WindowsFormsApp1.Properties.Resources.lightning_bolts;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(898, 462);
            this.Controls.Add(this.pictureikona);
            this.Controls.Add(this.labelcisnienie);
            this.Controls.Add(this.labelzachod);
            this.Controls.Add(this.labelwschod);
            this.Controls.Add(this.flp);
            this.Controls.Add(this.labelWiatr);
            this.Controls.Add(this.tekstpodajmiasto);
            this.Controls.Add(this.labelMiasto);
            this.Controls.Add(this.LabTemp1);
            this.Controls.Add(this.LabTemp);
            this.Controls.Add(this.wpiszmiasto);
            this.Controls.Add(this.dupa);
            this.Name = "Form1";
            this.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureikona)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button dupa;
        private System.Windows.Forms.TextBox wpiszmiasto;
        private System.Windows.Forms.Label LabTemp;
        private System.Windows.Forms.Label LabTemp1;
        private System.Windows.Forms.Label tekstpodajmiasto;
        private System.Windows.Forms.Label labelWiatr;
        private System.Windows.Forms.FlowLayoutPanel flp;
        private System.Windows.Forms.Label labelwschod;
        private System.Windows.Forms.Label labelzachod;
        private System.Windows.Forms.Label labelcisnienie;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        public System.Windows.Forms.PictureBox pictureikona;
        public System.Windows.Forms.Label labelMiasto;
    }
}

