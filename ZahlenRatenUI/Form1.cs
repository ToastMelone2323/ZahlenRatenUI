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
            txtTipp.Text = "";
            txtTipp.Focus();
        }

        private void btnNewGame_Click(object sender, EventArgs e)
        {
            NeuesSpiel();
        }
    }
}

