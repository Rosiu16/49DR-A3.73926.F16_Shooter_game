
namespace F16_game
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.pillar1 = new System.Windows.Forms.PictureBox();
            this.pillar2 = new System.Windows.Forms.PictureBox();
            this.Player1 = new System.Windows.Forms.PictureBox();
            this.ufo = new System.Windows.Forms.PictureBox();
            this.GameTimer = new System.Windows.Forms.Timer(this.components);
            this.txtScore = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pillar1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pillar2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Player1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ufo)).BeginInit();
            this.SuspendLayout();
            // 
            // pillar1
            // 
            this.pillar1.Image = ((System.Drawing.Image)(resources.GetObject("pillar1.Image")));
            this.pillar1.Location = new System.Drawing.Point(600, -32);
            this.pillar1.Name = "pillar1";
            this.pillar1.Size = new System.Drawing.Size(75, 232);
            this.pillar1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pillar1.TabIndex = 0;
            this.pillar1.TabStop = false;
            // 
            // pillar2
            // 
            this.pillar2.Image = ((System.Drawing.Image)(resources.GetObject("pillar2.Image")));
            this.pillar2.Location = new System.Drawing.Point(273, 265);
            this.pillar2.Name = "pillar2";
            this.pillar2.Size = new System.Drawing.Size(75, 232);
            this.pillar2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pillar2.TabIndex = 1;
            this.pillar2.TabStop = false;
            // 
            // Player1
            // 
            this.Player1.Image = ((System.Drawing.Image)(resources.GetObject("Player1.Image")));
            this.Player1.Location = new System.Drawing.Point(60, 133);
            this.Player1.Name = "Player1";
            this.Player1.Size = new System.Drawing.Size(119, 100);
            this.Player1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Player1.TabIndex = 2;
            this.Player1.TabStop = false;
            // 
            // ufo
            // 
            this.ufo.Image = ((System.Drawing.Image)(resources.GetObject("ufo.Image")));
            this.ufo.Location = new System.Drawing.Point(768, 230);
            this.ufo.Name = "ufo";
            this.ufo.Size = new System.Drawing.Size(68, 72);
            this.ufo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.ufo.TabIndex = 3;
            this.ufo.TabStop = false;
            // 
            // GameTimer
            // 
            this.GameTimer.Enabled = true;
            this.GameTimer.Interval = 20;
            this.GameTimer.Tick += new System.EventHandler(this.MainTimerEvent);
            // 
            // txtScore
            // 
            this.txtScore.AutoSize = true;
            this.txtScore.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.txtScore.Location = new System.Drawing.Point(1, 0);
            this.txtScore.Name = "txtScore";
            this.txtScore.Size = new System.Drawing.Size(110, 29);
            this.txtScore.TabIndex = 4;
            this.txtScore.Text = "Score: 0";
            // 
            // F16_game
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SkyBlue;
            this.ClientSize = new System.Drawing.Size(923, 470);
            this.Controls.Add(this.txtScore);
            this.Controls.Add(this.ufo);
            this.Controls.Add(this.Player1);
            this.Controls.Add(this.pillar2);
            this.Controls.Add(this.pillar1);
            this.Name = "F16_game";
            this.Text = "F16 Shooter Game";
            this.Load += new System.EventHandler(this.F16_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.KeyIsDown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.KeyIsUp);
            ((System.ComponentModel.ISupportInitialize)(this.pillar1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pillar2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Player1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ufo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pillar1;
        private System.Windows.Forms.PictureBox pillar2;
        private System.Windows.Forms.PictureBox Player1;
        private System.Windows.Forms.PictureBox ufo;
        private System.Windows.Forms.Timer GameTimer;
        private System.Windows.Forms.Label txtScore;
    }
}

