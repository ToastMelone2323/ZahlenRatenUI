using System;

namespace ZahlenRatenUI
{
    public partial class Zahlraten : Form
    {

        int versuche;
        int randomNumber;
        public Zahlraten()
        {
            InitializeComponent();
            NeuesSpiel();
        }

        private void lblMeldung_Click(object sender, EventArgs e)
        {

        }

        private void btnRaten_Click(object sender, EventArgs e)
        {
            int number;
            bool isNum = int.TryParse(txtTipp.Text, out number);

            if (isNum)
            {
                versuche++;
                lblVersuche.Text = $"Versuche: {versuche}";
                string outcome = Pruefen(number, randomNumber);
                if (outcome == "gleich")
                {
                    lblMeldung.Text = $"Du hast die Zahl gefunden und {versuche} Versuche gebraucht";
                    btnRaten.Enabled = false;
                }
                else if (outcome == "kleiner")
                {
                    lblMeldung.Text = "Die Zahl ist zu klein";
                }
                else
                {
                    lblMeldung.Text = "Die Zahl ist zu groß";
                }

                string huk = HeisKalt(number, randomNumber);
                if (huk == "sehr")
                {
                    lblhuk.Text = "Du bist sehr nah dran";
                }
                else if (huk == "nah")
                {
                    lblhuk.Text = "Du bist nah dran";
                }
                else
                {
                    lblhuk.Text = "";
                }
            }
            else
            {
                lblMeldung.Text = "Ungültige Eingabe";
            }
            txtTipp.Clear();
            txtTipp.Focus();
        }

        static string Pruefen(int number, int randomNumber)
        {
            if (number == randomNumber)
            {
                return "gleich";
            }
            else if (number < randomNumber)
            {
                return "kleiner";
            }
            else
            {
                return "groesser";
            }
        }

        private void NeuesSpiel()
        {
            Random random = new Random();
            randomNumber = random.Next(1, 101);
            versuche = 0;
            btnRaten.Enabled = true;
            lblMeldung.Text = "Willkommen";
            lblVersuche.Text = $"Versuche: {versuche}";
            lblhuk.Text = "";
            txtTipp.Text = "";
            txtTipp.Focus();
            this.Text = $"Zahl Raten (Lösung: {randomNumber})";
        }

        static string HeisKalt(int number, int randomNumber)
        {
            int diff = Math.Abs(number - randomNumber);
            if (diff < 6 && number != randomNumber)
            {
                return "sehr";
            }
            else if (diff < 11 && number != randomNumber)
            {
                return "nah";
            }
            else return "";
        }

        private void btnNewGame_Click(object sender, EventArgs e)
        {
            NeuesSpiel();
        }
    }
}

