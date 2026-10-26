using System;

namespace ZahlenRatenUI
{
    public partial class Zahlraten : Form
    {

        int versuche;
        int maxVersuche;
        int randomNumber;
        int siege;
        int loss;
        int bestLeistung;
        List<Ergebnis> bestenListe = new List<Ergebnis>();
        public Zahlraten()
        {
            InitializeComponent();
            cmbSchwierigkeit.SelectedIndex = 0;
            NeuesSpiel();
        }

        private void btnRaten_Click(object sender, EventArgs e)
        {
            int number;
            bool isNum = int.TryParse(txtTipp.Text, out number);

            if (isNum)
            {
                versuche++;
                lblVersuche.Text = $"Versuche: {versuche}/{maxVersuche}";
                string outcome = Pruefen(number, randomNumber);
                if (outcome == "gleich")
                {
                    lblMeldung.Text = $"Du hast die Zahl gefunden und {versuche} Versuche gebraucht";
                    siege++;
                    bestenListe.Add(new Ergebnis { Versuche = versuche, Schwiereigkeit = cmbSchwierigkeit.SelectedItem.ToString(), Datum = DateTime.Now });
                    ZeigeBestenliste();
                    if (bestLeistung == 0 || versuche < bestLeistung)
                    {
                        bestLeistung = versuche;
                    }
                    ZeigeStatistik();
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

                if (versuche >= maxVersuche && number != randomNumber)
                {
                    btnRaten.Enabled = false;
                    lblMeldung.Text = $"Du hast keine Versuche mehr. Die Zahl war: {randomNumber}";
                    loss++;
                    ZeigeStatistik();
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
            if (cmbSchwierigkeit.SelectedIndex == 0)
            {
                maxVersuche = 10;
            }
            else if (cmbSchwierigkeit.SelectedIndex == 1)
            {
                maxVersuche = 5;
            }
            else
            {
                maxVersuche = 3;
            }
            btnRaten.Enabled = true;
            lblMeldung.Text = "Willkommen";
            lblVersuche.Text = $"Versuche: {versuche}/{maxVersuche}";
            lblhuk.Text = "";
            txtTipp.Text = "";
            txtTipp.Focus();
            ZeigeStatistik();

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

        private void ZeigeStatistik()
        {
            if (bestLeistung > 0)
            {
                lblStatistik.Text = $"Deine Bestleistung: {bestLeistung} Siege: {siege} Niederlagen: {loss}";
            }
            else
            {
                lblStatistik.Text = $"Siege: {siege} Niederlagen: {loss}";
            }
        }

        public void ZeigeBestenliste()
        {
            lstBestenliste.Items.Clear();
            foreach (Ergebnis eintrag in bestenListe)
            {
                lstBestenliste.Items.Add(eintrag);
            }
            int maxBreite = 0;
            foreach (Ergebnis eintrag in bestenListe)
            {
                int breite = TextRenderer.MeasureText(eintrag.ToString(), lstBestenliste.Font).Width;
                if (breite > maxBreite)
                {
                    maxBreite = breite;
                }
            }
            lstBestenliste.Width = Math.Max(maxBreite + 20, 150);
        }

        private void btnNewGame_Click(object sender, EventArgs e)
        {
            NeuesSpiel();
        }

        private void cmbSchwierigkeit_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            NeuesSpiel();
        }

        private void lstBestenliste_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}

