namespace Tron_PW_PG
{
    partial class Menu
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
        /// Wymagana metoda obsługi projektanta — nie należy modyfikować 
        /// zawartość tej metody z edytorem kodu.
        /// </summary>
        private void InitializeComponent()
        {
            this.IntroInfo = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // IntroInfo
            // 
            this.IntroInfo.Font = new System.Drawing.Font("Monotype Corsiva", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.IntroInfo.Location = new System.Drawing.Point(100, 20);
            this.IntroInfo.Name = "IntroInfo";
            this.IntroInfo.Size = new System.Drawing.Size(300, 300);
            this.IntroInfo.TabIndex = 0;
            this.IntroInfo.Text = "Klon gry Tron \r\nProjekt zaliczeniowy WPA PG\r\n\r\nautor:Patryk Wyżgowski\r\n\r\nWciśnij " +
    "Enter, by rozpocząć grę.\r\n\r\nSterowanie:\r\nGracz 1: Strzałki\r\nGracz 2: WSAD";
            this.IntroInfo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(484, 461);
            this.Controls.Add(this.IntroInfo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Menu";
            this.Text = "Tron PW PG";
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.Menu_Paint);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Menu_KeyDown);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label IntroInfo;
    }
}

