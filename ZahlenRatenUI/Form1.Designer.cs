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
            cmbSchwierigkeit = new ComboBox();
            SuspendLayout();
            // 
            // txtTipp
            // 
            txtTipp.Location = new Point(182, 385);
            txtTipp.Name = "txtTipp";
            txtTipp.Size = new Size(101, 31);
            txtTipp.TabIndex = 0;
            // 
            // btnRaten
            // 
            btnRaten.Location = new Point(182, 460);
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
            lblMeldung.Location = new Point(12, 199);
            lblMeldung.Name = "lblMeldung";
            lblMeldung.Size = new Size(83, 25);
            lblMeldung.TabIndex = 2;
            lblMeldung.Text = "meldung";
            lblMeldung.Click += lblMeldung_Click;
            // 
            // lblVersuche
            // 
            lblVersuche.AutoSize = true;
            lblVersuche.Location = new Point(198, 243);
            lblVersuche.Name = "lblVersuche";
            lblVersuche.Size = new Size(101, 25);
            lblVersuche.TabIndex = 3;
            lblVersuche.Text = "Versuche: 0";
            // 
            // btnNewGame
            // 
            btnNewGame.Location = new Point(176, 523);
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
            lblhuk.Location = new Point(101, 131);
            lblhuk.Name = "lblhuk";
            lblhuk.Size = new Size(59, 25);
            lblhuk.TabIndex = 6;
            lblhuk.Text = "label1";
            // 
            // cmbSchwierigkeit
            // 
            cmbSchwierigkeit.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbSchwierigkeit.FormattingEnabled = true;
            cmbSchwierigkeit.Items.AddRange(new object[] { "Leicht", "Mittel", "Schwer" });
            cmbSchwierigkeit.Location = new Point(101, 46);
            cmbSchwierigkeit.Name = "cmbSchwierigkeit";
            cmbSchwierigkeit.Size = new Size(182, 33);
            cmbSchwierigkeit.TabIndex = 7;
            cmbSchwierigkeit.SelectedIndexChanged += cmbSchwierigkeit_SelectedIndexChanged_1;
            // 
            // Zahlraten
            // 
            AcceptButton = btnRaten;
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(460, 732);
            Controls.Add(cmbSchwierigkeit);
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
        private ComboBox cmbSchwierigkeit;
    }
}
