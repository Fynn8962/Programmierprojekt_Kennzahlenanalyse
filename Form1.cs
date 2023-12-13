namespace Kennzahlenanalyse
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public double a = 0;
        public double b = 0;
        public double c = 0;
        public double ergebniss = 0;



        public int Kennzahl;

        private void ClearAll()
        {
            btnEigenfinanzierung.Visible = false;
            btnFremdfinanzierungsgrad.Visible = false;
            btnSelbstfinanzierungsgrad.Visible = false;
            btnIntensit�tdesUmlaufverm�gen.Visible = false;
            Intensit�tdesAnlageverm�gens.Visible = false;
            Liquidit�tsgrad1.Visible = false;
            btnLiquidit�tsgrad2.Visible = false;
            btnLiquidit�tsgrad3.Visible = false;
            btnAnlagedeckungsgrad1.Visible = false;
            btnAnlagedeckungsgrad2.Visible = false;
            btnEigenkapitalrendite.Visible = false;
            btnGesamtkapitalrendite.Visible = false;
            btnUmsatzrendite.Visible = false;


            label1.Visible = false;
            label2.Visible = false;
            btnZur�ck.Visible = true;
            btnBerechnen.Visible = false;
            lblBeurteilung.Visible = false;
            lblkennzahlinfo.Visible = true;

        }

        private void Main()
        {
            btnEigenfinanzierung.Visible = true;
            btnFremdfinanzierungsgrad.Visible = true;
            btnSelbstfinanzierungsgrad.Visible = true;
            btnIntensit�tdesUmlaufverm�gen.Visible = true;
            Intensit�tdesAnlageverm�gens.Visible = true;
            Liquidit�tsgrad1.Visible = true;
            btnLiquidit�tsgrad2.Visible = true;
            btnLiquidit�tsgrad3.Visible = true;
            btnAnlagedeckungsgrad1.Visible = true;
            btnAnlagedeckungsgrad2.Visible = true;
            btnEigenkapitalrendite.Visible = true;
            btnGesamtkapitalrendite.Visible = true;
            btnUmsatzrendite.Visible = true;
            lblkennzahlinfo.Visible = false;



            label1.Visible = true;
            label2.Visible = true;
            btnZur�ck.Visible = false;
            Eingabe1.Visible = false;
            Eingabe2.Visible = false;
            Eingabe3.Visible = false;
            Text1.Visible = false;
            Text2.Visible = false;
            Text3.Visible = false;
            btnBerechnen.Visible = false;
            lblResultatzahl.Visible = false;
            lblBeurteilung.Visible = false;
            btnBeurteilung.Visible = false;
            Eingabe1.Text = "";
            Eingabe2.Text = "";
            Eingabe3.Text = "";

        }
        private void btnZur�ck_Click(object sender, EventArgs e)
        {
            Main();
        }


        private void btnEigenfinanzierung_Click(object sender, EventArgs e)
        {

            ClearAll();
            lblkennzahlinfo.Text = "Eigenfinanzierung";
            btnBerechnen.Visible = true;
            Text1.Text = "Eigenkapital";
            Text1.Visible = true;
            Eingabe1.Visible = true;

            Text2.Text = "Gesamtkapital";
            Text2.Visible = true;
            Eingabe2.Visible = true;

            Kennzahl = 1;


        }



        private void btnFremdfinanzierungsgrad_Click(object sender, EventArgs e)
        {
            ClearAll();
            lblkennzahlinfo.Text = "Fremdfinanzierungsgrad";
            btnBerechnen.Visible = true;
            Text1.Visible = true;
            Eingabe1.Visible = true;
            Text1.Text = "Fremdkapital";

            Text2.Visible = true;
            Eingabe2.Visible = true;
            Text2.Text = "Gesamtkapital";

            Kennzahl = 2;
        }



        private void btnSelbstfinanzierungsgrad_Click(object sender, EventArgs e)
        {
            ClearAll();
            lblkennzahlinfo.Text = "Selbstfinanzierungsgrad";
            btnBerechnen.Visible = true;
            Text1.Visible = true;
            Eingabe1.Visible = true;
            Text1.Text = "Zuwachskapital";

            Text2.Visible = true;
            Eingabe2.Visible = true;
            Text2.Text = "Grundkapital";

            Kennzahl = 3;

        }


        private void btnIntensit�tdesUmlaufverm�gen_Click(object sender, EventArgs e)
        {
            ClearAll();
            lblkennzahlinfo.Text = "Intensit�t des Umlaufverm�gens";
            btnBerechnen.Visible = true;
            Text1.Visible = true;
            Eingabe1.Visible = true;
            Text1.Text = "Umlaufverm�gen";

            Text2.Visible = true;
            Eingabe2.Visible = true;
            Text2.Text = "Gesamtverm�gen";

            Kennzahl = 4;

        }

        private void Intensit�tdesAnlageverm�gens_Click(object sender, EventArgs e)
        {
            ClearAll();
            lblkennzahlinfo.Text = "Intensit�t des Anlageverm�gens";
            btnBerechnen.Visible = true;
            Text1.Visible = true;
            Eingabe1.Visible = true;
            Text1.Text = "Anlageverm�gen";

            Text2.Visible = true;
            Eingabe2.Visible = true;
            Text2.Text = "Gesamtverm�gen";

            Kennzahl = 5;
        }

        private void Liquidit�tsgrad1_Click(object sender, EventArgs e)
        {
            ClearAll();
            lblkennzahlinfo.Text = "Liquidit�tsgrad 1";
            btnBerechnen.Visible = true;
            Text1.Visible = true;
            Eingabe1.Visible = true;
            Text1.Text = "Fl�ssige Mittel";

            Text2.Visible = true;
            Eingabe2.Visible = true;
            Text2.Text = "Kurzfristiges Fremdkapital";

            Kennzahl = 6;
        }

        private void btnLiquidit�tsgrad2_Click(object sender, EventArgs e)
        {
            ClearAll();
            lblkennzahlinfo.Text = "Liquidit�tsgrad 2";
            btnBerechnen.Visible = true;
            Text1.Visible = true;
            Eingabe1.Visible = true;
            Text1.Text = "Fl�ssige Mittel";

            Text2.Visible = true;
            Eingabe2.Visible = true;
            Text2.Text = "Forderungen";

            Text3.Visible = true;
            Eingabe3.Visible = true;
            Text3.Text = "Kurzfristiges Fremdkapital";

            Kennzahl = 7;
        }

        private void btnLiquidit�tsgrad3_Click(object sender, EventArgs e)
        {
            ClearAll();
            lblkennzahlinfo.Text = "Liquidit�tsgrad 3";
            btnBerechnen.Visible = true;
            Text1.Visible = true;
            Eingabe1.Visible = true;
            Text1.Text = "Umlaufverm�gen";

            Text2.Visible = true;
            Eingabe2.Visible = true;
            Text2.Text = "Kurzfristiges Fremdkapital";

            Kennzahl = 8;
        }

        private void btnAnlagedeckungsgrad1_Click(object sender, EventArgs e)
        {
            ClearAll();
            lblkennzahlinfo.Text = "Anlagedeckungsgrad 1";
            btnBerechnen.Visible = true;
            Text1.Visible = true;
            Eingabe1.Visible = true;
            Text1.Text = "Eigenkapital";

            Text2.Visible = true;
            Eingabe2.Visible = true;
            Text2.Text = "Anlageverm�gen";

            Kennzahl = 9;
        }

        private void btnAnlagedeckungsgrad2_Click(object sender, EventArgs e)
        {
            ClearAll();
            lblkennzahlinfo.Text = "Anlagedeckungsgrad 2";
            btnBerechnen.Visible = true;
            Text1.Visible = true;
            Eingabe1.Visible = true;
            Text1.Text = "Eigenkapital";

            Text2.Visible = true;
            Eingabe2.Visible = true;
            Text2.Text = "Langfristiges Eigenkapital";

            Text3.Visible = true;
            Eingabe3.Visible = true;
            Text3.Text = "Anlageverm�gen";

            Kennzahl = 10;
        }

        private void btnEigenkapitalrendite_Click(object sender, EventArgs e)
        {
            ClearAll();
            lblkennzahlinfo.Text = "Eigenkapitalrendite";
            btnBerechnen.Visible = true;
            Text1.Visible = true;
            Eingabe1.Visible = true;
            Text1.Text = "Reingewinn";

            Text2.Visible = true;
            Eingabe2.Visible = true;
            Text2.Text = "Eigenkapital";

            Kennzahl = 11;
        }

        private void btnGesamtkapitalrendite_Click(object sender, EventArgs e)
        {
            ClearAll();
            lblkennzahlinfo.Text = "Gesamtkapitalrendite";
            btnBerechnen.Visible = true;
            Text1.Visible = true;
            Eingabe1.Visible = true;
            Text1.Text = "Reingewinn";

            Text2.Visible = true;
            Eingabe2.Visible = true;
            Text2.Text = "Fremdkapitalzinsen";

            Text3.Visible = true;
            Eingabe3.Visible = true;
            Text3.Text = "Gesamtkapital";

            Kennzahl = 12;
        }

        private void btnUmsatzrendite_Click(object sender, EventArgs e)
        {
            ClearAll();
            lblkennzahlinfo.Text = "Umsatzrendite";
            btnBerechnen.Visible = true;
            Text1.Visible = true;
            Eingabe1.Visible = true;
            Text1.Text = "Reingewinn";

            Text2.Visible = true;
            Eingabe2.Visible = true;
            Text2.Text = "Betriebsertrag";

            Kennzahl = 13;
        }

        private void btnBerechnen_Click(object sender, EventArgs e)
        {
            btnBeurteilung.Visible = true;

            try
            {


                double a = double.Parse(Eingabe1.Text);
                double b = double.Parse(Eingabe2.Text);
                double c;



                if (Eingabe3.Text == "")
                {
                    c = 0;
                }
                else
                {
                    c = double.Parse(Eingabe3.Text);
                }

                switch (Kennzahl)
                {
                    case 1:
                        if (Eingabe1.Text != "" && Eingabe2.Text != "")
                        {
                            ergebniss = (a / b) * 100;
                            lblResultatzahl.Text = ergebniss.ToString();
                        }

                        break;

                    case 2:
                        if (Eingabe1.Text != "" && Eingabe2.Text != "")
                        {
                            ergebniss = (a / b) * 100;
                            lblResultatzahl.Text = ergebniss.ToString();
                        }
                        break;

                    case 3:
                        if (Eingabe1.Text != "" && Eingabe2.Text != "")
                        {
                            ergebniss = (a / b) * 100;
                            lblResultatzahl.Text = ergebniss.ToString();
                            btnBerechnen.Visible = true;
                        }
                        break;

                    case 4:
                        btnBeurteilung.Visible = false;
                        if (Eingabe1.Text != "" && Eingabe2.Text != "")
                        {
                            ergebniss = (a / b) * 100;
                            lblResultatzahl.Text = ergebniss.ToString();
                        }
                        break;

                    case 5:
                        btnBeurteilung.Visible = false;
                        if (Eingabe1.Text != "" && Eingabe2.Text != "")
                        {
                            ergebniss = (a / b) * 100;
                            lblResultatzahl.Text = ergebniss.ToString();
                        }
                        break;

                    case 6:
                        if (Eingabe1.Text != "" && Eingabe2.Text != "")
                        {
                            ergebniss = (a / b) * 100;
                            lblResultatzahl.Text = ergebniss.ToString();
                        }
                        break;

                    case 7:
                        if (Eingabe1.Text != "" && Eingabe2.Text != "")
                        {
                            ergebniss = ((a + b) / c) * 100;
                            lblResultatzahl.Text = ergebniss.ToString();
                        }
                        break;

                    case 8:
                        if (Eingabe1.Text != "" && Eingabe2.Text != "")
                        {
                            ergebniss = (a / b) * 100;
                            lblResultatzahl.Text = ergebniss.ToString();
                        }
                        break;

                    case 9:
                        if (Eingabe1.Text != "" && Eingabe2.Text != "")
                        {
                            ergebniss = (a / b) * 100;
                            lblResultatzahl.Text = ergebniss.ToString();
                        }
                        break;

                    case 10:
                        if (Eingabe1.Text != "" && Eingabe2.Text != "")
                        {
                            ergebniss = ((a + b) / c) * 100;
                            lblResultatzahl.Text = ergebniss.ToString();
                        }
                        break;

                    case 11:
                        if (Eingabe1.Text != "" && Eingabe2.Text != "")
                        {
                            ergebniss = (a / b) * 100;
                            lblResultatzahl.Text = ergebniss.ToString();
                        }
                        break;

                    case 12:
                        if (Eingabe1.Text != "" && Eingabe2.Text != "")
                        {
                            ergebniss = ((a + b) / c) * 100;
                            lblResultatzahl.Text = ergebniss.ToString();
                        }
                        break;

                    case 13:
                        btnBeurteilung.Visible = false;
                        if (Eingabe1.Text != "" && Eingabe2.Text != "")
                        {
                            ergebniss = (a / b) * 100;
                            lblResultatzahl.Text = ergebniss.ToString();
                        }
                        break;


                }
                ergebniss = Math.Round(ergebniss, 2);
                lblResultatzahl.Visible = true;
                lblResultatzahl.Text = ergebniss + "%";



            }
            catch
            {
                MessageBox.Show("FEHLERHAFTE EINGABE!");

                Eingabe1.Text = "";
                Eingabe2.Text = "";
                Eingabe3.Text = "";
                lblResultatzahl.Visible = false;
                btnBeurteilung.Visible = false;
                lblBeurteilung.Visible = false;
            }

        }

        private void btnBeurteilung_Click(object sender, EventArgs e)
        {



            switch (Kennzahl)
            {
                case 1:
                    if (ergebniss >= 30)
                    {
                        lblBeurteilung.Text = "gen�gend";
                    }
                    else
                    {
                        lblBeurteilung.Text = "ungen�gend";
                    }
                    break;
                case 2:
                    if (ergebniss <= 70)
                    {
                        lblBeurteilung.Text = "gen�gend";
                    }
                    else
                    {
                        lblBeurteilung.Text = "ungen�gend";
                    }
                    break;
                case 3:
                    break;
                case 4:

                    break;
                case 5:
                    break;
                case 6:
                    if (ergebniss >= 20)
                    {
                        lblBeurteilung.Text = "gen�gend";
                    }
                    else
                    {
                        lblBeurteilung.Text = "ungen�gend";
                    }
                    break;
                case 7:
                    if (ergebniss >= 100)
                    {
                        lblBeurteilung.Text = "gen�gend";
                    }
                    else
                    {
                        lblBeurteilung.Text = "ungen�gend";
                    }
                    break;
                case 8:
                    if (ergebniss >= 150)
                    {
                        lblBeurteilung.Text = "gen�gend";
                    }
                    else
                    {
                        lblBeurteilung.Text = "ungen�gend";
                    }
                    break;
                case 9:
                    if (ergebniss >= 75)
                    {
                        lblBeurteilung.Text = "gen�gend";
                    }
                    else
                    {
                        lblBeurteilung.Text = "ungen�gend";
                    }
                    break;
                case 10:
                    if (ergebniss >= 100)
                    {
                        lblBeurteilung.Text = "gen�gend";
                    }
                    else
                    {
                        lblBeurteilung.Text = "ungen�gend";
                    }
                    break;
                case 11:
                    if (ergebniss >= 8)
                    {
                        lblBeurteilung.Text = "gen�gend";
                    }
                    else
                    {
                        lblBeurteilung.Text = "ungen�gend";
                    }
                    break;
                case 12:
                    if (ergebniss >= 6)
                    {
                        lblBeurteilung.Text = "gen�gend";
                    }
                    else
                    {
                        lblBeurteilung.Text = "ungen�gend";
                    }
                    break;
                case 13:
                    break;



            }
            if (lblBeurteilung.Text == "gen�gend")
            {
                lblBeurteilung.Visible = true;
                lblBeurteilung.ForeColor = System.Drawing.Color.Green;

            }
            else if (lblBeurteilung.Text == "ungen�gend")
            {
                lblBeurteilung.Visible = true;
                lblBeurteilung.ForeColor = System.Drawing.Color.Red;
            }


        }








    }


}
