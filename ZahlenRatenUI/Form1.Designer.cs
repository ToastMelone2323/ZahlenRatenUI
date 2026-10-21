namespace ZahlenRatenUI
{
    partial class Zahlraten
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            txtTipp = new TextBox();
            btnRaten = new Button();
            lblMeldung = new Label();
            lblVersuche = new Label();
            btnNewGame = new Button();
            lblhuk = new Label();
            SuspendLayout();
            // 
            // txtTipp
            // 
            txtTipp.Location = new Point(766, 377);
            txtTipp.Name = "txtTipp";
            txtTipp.Size = new Size(101, 31);
            txtTipp.TabIndex = 0;
            // 
            // btnRaten
            // 
            btnRaten.Location = new Point(766, 423);
            btnRaten.Name = "btnRaten";
            btnRaten.Size = new Size(101, 37);
            btnRaten.TabIndex = 1;
            btnRaten.Text = "Raten";
            btnRaten.UseVisualStyleBackColor = true;
            btnRaten.Click += btnRaten_Click;
            // 
            // lblMeldung
            // 
            lblMeldung.AutoSize = true;
            lblMeldung.Location = new Point(759, 268);
            lblMeldung.Name = "lblMeldung";
            lblMeldung.Size = new Size(94, 25);
            lblMeldung.TabIndex = 2;
            lblMeldung.Text = "platzhalter";
            lblMeldung.Click += lblMeldung_Click;
            // 
            // lblVersuche
            // 
            lblVersuche.AutoSize = true;
            lblVersuche.Location = new Point(1165, 268);
            lblVersuche.Name = "lblVersuche";
            lblVersuche.Size = new Size(101, 25);
            lblVersuche.TabIndex = 3;
            lblVersuche.Text = "Versuche: 0";
            // 
            // btnNewGame
            // 
            btnNewGame.Location = new Point(759, 466);
            btnNewGame.Name = "btnNewGame";
            btnNewGame.Size = new Size(112, 34);
            btnNewGame.TabIndex = 5;
            btnNewGame.Text = "Neues Spiel";
            btnNewGame.UseVisualStyleBackColor = true;
            btnNewGame.Click += btnNewGame_Click;
            // 
            // lblhuk
            // 
            lblhuk.AutoSize = true;
            lblhuk.Location = new Point(789, 156);
            lblhuk.Name = "lblhuk";
            lblhuk.Size = new Size(59, 25);
            lblhuk.TabIndex = 6;
            lblhuk.Text = "label1";
            // 
            // Zahlraten
            // 
            AcceptButton = btnRaten;
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1548, 732);
            Controls.Add(lblhuk);
            Controls.Add(btnNewGame);
            Controls.Add(lblVersuche);
            Controls.Add(lblMeldung);
            Controls.Add(btnRaten);
            Controls.Add(txtTipp);
            Name = "Zahlraten";
            Text = "Zahl Raten";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtTipp;
        private Button btnRaten;
        private Label lblMeldung;
        private Label lblVersuche;
        private Button btnNewGame;
        private Label lblhuk;
    }
}
