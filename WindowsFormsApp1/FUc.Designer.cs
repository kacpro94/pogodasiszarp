namespace WindowsFormsApp1
{
    partial class FUc
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

        #region Kod wygenerowany przez Projektanta składników

        /// <summary> 
        /// Metoda wymagana do obsługi projektanta — nie należy modyfikować 
        /// jej zawartości w edytorze kodu.
        /// </summary>
        private void InitializeComponent()
        {
            this.picWeatherIcon = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.labelDT = new System.Windows.Forms.Label();
            this.labelMainWeather = new System.Windows.Forms.Label();
            this.labWeatherDescription = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.picWeatherIcon)).BeginInit();
            this.SuspendLayout();
            // 
            // picWeatherIcon
            // 
            this.picWeatherIcon.Location = new System.Drawing.Point(105, 3);
            this.picWeatherIcon.Name = "picWeatherIcon";
            this.picWeatherIcon.Size = new System.Drawing.Size(122, 110);
            this.picWeatherIcon.TabIndex = 0;
            this.picWeatherIcon.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(367, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "label1";
            // 
            // labelDT
            // 
            this.labelDT.AutoSize = true;
            this.labelDT.Location = new System.Drawing.Point(233, 3);
            this.labelDT.Name = "labelDT";
            this.labelDT.Size = new System.Drawing.Size(32, 16);
            this.labelDT.TabIndex = 2;
            this.labelDT.Text = "Day";
            this.labelDT.Click += new System.EventHandler(this.label2_Click);
            // 
            // labelMainWeather
            // 
            this.labelMainWeather.AutoSize = true;
            this.labelMainWeather.Location = new System.Drawing.Point(233, 32);
            this.labelMainWeather.Name = "labelMainWeather";
            this.labelMainWeather.Size = new System.Drawing.Size(39, 16);
            this.labelMainWeather.TabIndex = 3;
            this.labelMainWeather.Text = "Clear";
            // 
            // labWeatherDescription
            // 
            this.labWeatherDescription.AutoSize = true;
            this.labWeatherDescription.Location = new System.Drawing.Point(233, 57);
            this.labWeatherDescription.Name = "labWeatherDescription";
            this.labWeatherDescription.Size = new System.Drawing.Size(75, 16);
            this.labWeatherDescription.TabIndex = 4;
            this.labWeatherDescription.Text = "Description";
            this.labWeatherDescription.Click += new System.EventHandler(this.labWeatherDescription_Click);
            // 
            // FUc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.labWeatherDescription);
            this.Controls.Add(this.labelMainWeather);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.picWeatherIcon);
            this.Controls.Add(this.labelDT);
            this.Name = "FUc";
            this.Size = new System.Drawing.Size(457, 166);
            this.Load += new System.EventHandler(this.FUc_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picWeatherIcon)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.PictureBox picWeatherIcon;
        public System.Windows.Forms.Label labelDT;
        public System.Windows.Forms.Label labelMainWeather;
        public System.Windows.Forms.Label labWeatherDescription;
    }
}
