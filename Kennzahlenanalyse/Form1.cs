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
            btnIntensitätdesUmlaufvermögen.Visible = false;
            IntensitätdesAnlagevermögens.Visible = false;
            Liquiditätsgrad1.Visible = false;
            btnLiquiditätsgrad2.Visible = false;
            btnLiquiditätsgrad3.Visible = false;
            btnAnlagedeckungsgrad1.Visible = false;
            btnAnlagedeckungsgrad2.Visible = false;
            btnEigenkapitalrendite.Visible = false;
            btnGesamtkapitalrendite.Visible = false;
            btnUmsatzrendite.Visible = false;


            label1.Visible = false;
            label2.Visible = false;
            btnZurück.Visible = true;
            btnBerechnen.Visible = false;
            lblBeurteilung.Visible = false;
            lblkennzahlinfo.Visible = true;

        }

        private void Main()
        {
            btnEigenfinanzierung.Visible = true;
            btnFremdfinanzierungsgrad.Visible = true;
            btnSelbstfinanzierungsgrad.Visible = true;
            btnIntensitätdesUmlaufvermögen.Visible = true;
            IntensitätdesAnlagevermögens.Visible = true;
            Liquiditätsgrad1.Visible = true;
            btnLiquiditätsgrad2.Visible = true;
            btnLiquiditätsgrad3.Visible = true;
            btnAnlagedeckungsgrad1.Visible = true;
            btnAnlagedeckungsgrad2.Visible = true;
            btnEigenkapitalrendite.Visible = true;
            btnGesamtkapitalrendite.Visible = true;
            btnUmsatzrendite.Visible = true;
            lblkennzahlinfo.Visible = false;



            label1.Visible = true;
            label2.Visible = true;
            btnZurück.Visible = false;
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
        private void btnZurück_Click(object sender, EventArgs e)
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


        private void btnIntensitätdesUmlaufvermögen_Click(object sender, EventArgs e)
        {
            ClearAll();
            lblkennzahlinfo.Text = "Intensität des Umlaufvermögens";
            btnBerechnen.Visible = true;
            Text1.Visible = true;
            Eingabe1.Visible = true;
            Text1.Text = "Umlaufvermögen";

            Text2.Visible = true;
            Eingabe2.Visible = true;
            Text2.Text = "Gesamtvermögen";

            Kennzahl = 4;

        }

        private void IntensitätdesAnlagevermögens_Click(object sender, EventArgs e)
        {
            ClearAll();
            lblkennzahlinfo.Text = "Intensität des Anlagevermögens";
            btnBerechnen.Visible = true;
            Text1.Visible = true;
            Eingabe1.Visible = true;
            Text1.Text = "Anlagevermögen";

            Text2.Visible = true;
            Eingabe2.Visible = true;
            Text2.Text = "Gesamtvermögen";

            Kennzahl = 5;
        }

        private void Liquiditätsgrad1_Click(object sender, EventArgs e)
        {
            ClearAll();
            lblkennzahlinfo.Text = "Liquiditätsgrad 1";
            btnBerechnen.Visible = true;
            Text1.Visible = true;
            Eingabe1.Visible = true;
            Text1.Text = "Flüssige Mittel";

            Text2.Visible = true;
            Eingabe2.Visible = true;
            Text2.Text = "Kurzfristiges Fremdkapital";

            Kennzahl = 6;
        }

        private void btnLiquiditätsgrad2_Click(object sender, EventArgs e)
        {
            ClearAll();
            lblkennzahlinfo.Text = "Liquiditätsgrad 2";
            btnBerechnen.Visible = true;
            Text1.Visible = true;
            Eingabe1.Visible = true;
            Text1.Text = "Flüssige Mittel";

            Text2.Visible = true;
            Eingabe2.Visible = true;
            Text2.Text = "Forderungen";

            Text3.Visible = true;
            Eingabe3.Visible = true;
            Text3.Text = "Kurzfristiges Fremdkapital";

            Kennzahl = 7;
        }

        private void btnLiquiditätsgrad3_Click(object sender, EventArgs e)
        {
            ClearAll();
            lblkennzahlinfo.Text = "Liquiditätsgrad 3";
            btnBerechnen.Visible = true;
            Text1.Visible = true;
            Eingabe1.Visible = true;
            Text1.Text = "Umlaufvermögen";

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
            Text2.Text = "Anlagevermögen";

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
            Text3.Text = "Anlagevermögen";

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
                        lblBeurteilung.Text = "genügend";
                    }
                    else
                    {
                        lblBeurteilung.Text = "ungenügend";
                    }
                    break;
                case 2:
                    if (ergebniss <= 70)
                    {
                        lblBeurteilung.Text = "genügend";
                    }
                    else
                    {
                        lblBeurteilung.Text = "ungenügend";
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
                        lblBeurteilung.Text = "genügend";
                    }
                    else
                    {
                        lblBeurteilung.Text = "ungenügend";
                    }
                    break;
                case 7:
                    if (ergebniss >= 100)
                    {
                        lblBeurteilung.Text = "genügend";
                    }
                    else
                    {
                        lblBeurteilung.Text = "ungenügend";
                    }
                    break;
                case 8:
                    if (ergebniss >= 150)
                    {
                        lblBeurteilung.Text = "genügend";
                    }
                    else
                    {
                        lblBeurteilung.Text = "ungenügend";
                    }
                    break;
                case 9:
                    if (ergebniss >= 75)
                    {
                        lblBeurteilung.Text = "genügend";
                    }
                    else
                    {
                        lblBeurteilung.Text = "ungenügend";
                    }
                    break;
                case 10:
                    if (ergebniss >= 100)
                    {
                        lblBeurteilung.Text = "genügend";
                    }
                    else
                    {
                        lblBeurteilung.Text = "ungenügend";
                    }
                    break;
                case 11:
                    if (ergebniss >= 8)
                    {
                        lblBeurteilung.Text = "genügend";
                    }
                    else
                    {
                        lblBeurteilung.Text = "ungenügend";
                    }
                    break;
                case 12:
                    if (ergebniss >= 6)
                    {
                        lblBeurteilung.Text = "genügend";
                    }
                    else
                    {
                        lblBeurteilung.Text = "ungenügend";
                    }
                    break;
                case 13:
                    break;



            }
            if (lblBeurteilung.Text == "genügend")
            {
                lblBeurteilung.Visible = true;
                lblBeurteilung.ForeColor = System.Drawing.Color.Green;

            }
            else if (lblBeurteilung.Text == "ungenügend")
            {
                lblBeurteilung.Visible = true;
                lblBeurteilung.ForeColor = System.Drawing.Color.Red;
            }


        }








    }


}
