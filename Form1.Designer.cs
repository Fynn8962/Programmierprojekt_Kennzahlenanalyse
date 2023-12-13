namespace Kennzahlenanalyse
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            btnEigenfinanzierung = new Button();
            btnFremdfinanzierungsgrad = new Button();
            btnSelbstfinanzierungsgrad = new Button();
            label1 = new Label();
            label2 = new Label();
            btnZurück = new Button();
            Eingabe1 = new TextBox();
            Eingabe2 = new TextBox();
            Text1 = new Label();
            Text2 = new Label();
            Eingabe3 = new TextBox();
            Text3 = new Label();
            btnBerechnen = new Button();
            lblResultatzahl = new Label();
            btnIntensitätdesUmlaufvermögen = new Button();
            IntensitätdesAnlagevermögens = new Button();
            Liquiditätsgrad1 = new Button();
            btnLiquiditätsgrad2 = new Button();
            btnBeurteilung = new Button();
            btnLiquiditätsgrad3 = new Button();
            btnAnlagedeckungsgrad1 = new Button();
            btnAnlagedeckungsgrad2 = new Button();
            btnEigenkapitalrendite = new Button();
            btnGesamtkapitalrendite = new Button();
            btnUmsatzrendite = new Button();
            lblBeurteilung = new Label();
            lblkennzahlinfo = new Label();
            SuspendLayout();
            // 
            // btnEigenfinanzierung
            // 
            btnEigenfinanzierung.AutoSize = true;
            btnEigenfinanzierung.BackColor = Color.Silver;
            btnEigenfinanzierung.BackgroundImageLayout = ImageLayout.None;
            btnEigenfinanzierung.Cursor = Cursors.Hand;
            btnEigenfinanzierung.FlatStyle = FlatStyle.Flat;
            btnEigenfinanzierung.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            btnEigenfinanzierung.ForeColor = SystemColors.ActiveCaptionText;
            btnEigenfinanzierung.Location = new Point(15, 139);
            btnEigenfinanzierung.Name = "btnEigenfinanzierung";
            btnEigenfinanzierung.Size = new Size(223, 37);
            btnEigenfinanzierung.TabIndex = 0;
            btnEigenfinanzierung.Text = "Eigenfinanzierungsgrad";
            btnEigenfinanzierung.UseVisualStyleBackColor = false;
            btnEigenfinanzierung.Click += btnEigenfinanzierung_Click;
            // 
            // btnFremdfinanzierungsgrad
            // 
            btnFremdfinanzierungsgrad.AutoSize = true;
            btnFremdfinanzierungsgrad.BackColor = Color.Silver;
            btnFremdfinanzierungsgrad.Cursor = Cursors.Hand;
            btnFremdfinanzierungsgrad.FlatStyle = FlatStyle.Flat;
            btnFremdfinanzierungsgrad.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            btnFremdfinanzierungsgrad.Location = new Point(15, 182);
            btnFremdfinanzierungsgrad.Name = "btnFremdfinanzierungsgrad";
            btnFremdfinanzierungsgrad.Size = new Size(228, 37);
            btnFremdfinanzierungsgrad.TabIndex = 1;
            btnFremdfinanzierungsgrad.Text = "Fremdfinanzierungsgrad";
            btnFremdfinanzierungsgrad.UseVisualStyleBackColor = false;
            btnFremdfinanzierungsgrad.Click += btnFremdfinanzierungsgrad_Click;
            // 
            // btnSelbstfinanzierungsgrad
            // 
            btnSelbstfinanzierungsgrad.AutoSize = true;
            btnSelbstfinanzierungsgrad.BackColor = Color.Silver;
            btnSelbstfinanzierungsgrad.FlatStyle = FlatStyle.Flat;
            btnSelbstfinanzierungsgrad.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            btnSelbstfinanzierungsgrad.Location = new Point(15, 225);
            btnSelbstfinanzierungsgrad.Name = "btnSelbstfinanzierungsgrad";
            btnSelbstfinanzierungsgrad.RightToLeft = RightToLeft.Yes;
            btnSelbstfinanzierungsgrad.Size = new Size(226, 37);
            btnSelbstfinanzierungsgrad.TabIndex = 2;
            btnSelbstfinanzierungsgrad.Text = "Selbstfinanzierungsgrad";
            btnSelbstfinanzierungsgrad.UseVisualStyleBackColor = false;
            btnSelbstfinanzierungsgrad.Click += btnSelbstfinanzierungsgrad_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 14F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = SystemColors.ActiveCaptionText;
            label1.Location = new Point(12, 92);
            label1.Name = "label1";
            label1.Size = new Size(147, 32);
            label1.TabIndex = 3;
            label1.Text = "Kennzahlen:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = SystemColors.ActiveCaptionText;
            label2.Location = new Point(12, 9);
            label2.Name = "label2";
            label2.Size = new Size(324, 46);
            label2.TabIndex = 4;
            label2.Text = "Kennzahlenanalyse ";
            // 
            // btnZurück
            // 
            btnZurück.BackColor = Color.Transparent;
            btnZurück.Cursor = Cursors.Hand;
            btnZurück.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            btnZurück.ImageAlign = ContentAlignment.TopCenter;
            btnZurück.Location = new Point(15, 8);
            btnZurück.Name = "btnZurück";
            btnZurück.RightToLeft = RightToLeft.No;
            btnZurück.Size = new Size(48, 42);
            btnZurück.TabIndex = 5;
            btnZurück.Text = "<";
            btnZurück.UseVisualStyleBackColor = false;
            btnZurück.Visible = false;
            btnZurück.Click += btnZurück_Click;
            // 
            // Eingabe1
            // 
            Eingabe1.Cursor = Cursors.Hand;
            Eingabe1.Location = new Point(443, 289);
            Eingabe1.Name = "Eingabe1";
            Eingabe1.Size = new Size(125, 27);
            Eingabe1.TabIndex = 6;
            Eingabe1.Visible = false;
            // 
            // Eingabe2
            // 
            Eingabe2.Cursor = Cursors.Hand;
            Eingabe2.Location = new Point(642, 289);
            Eingabe2.Name = "Eingabe2";
            Eingabe2.Size = new Size(125, 27);
            Eingabe2.TabIndex = 7;
            Eingabe2.Visible = false;
            // 
            // Text1
            // 
            Text1.AutoSize = true;
            Text1.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Regular, GraphicsUnit.Point);
            Text1.ForeColor = SystemColors.ActiveCaptionText;
            Text1.Location = new Point(443, 266);
            Text1.Name = "Text1";
            Text1.Size = new Size(47, 23);
            Text1.TabIndex = 8;
            Text1.Text = "text1";
            Text1.Visible = false;
            // 
            // Text2
            // 
            Text2.AutoSize = true;
            Text2.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            Text2.ForeColor = SystemColors.ActiveCaptionText;
            Text2.Location = new Point(642, 266);
            Text2.Name = "Text2";
            Text2.Size = new Size(49, 23);
            Text2.TabIndex = 9;
            Text2.Text = "text2";
            Text2.Visible = false;
            // 
            // Eingabe3
            // 
            Eingabe3.Cursor = Cursors.Hand;
            Eingabe3.Location = new Point(833, 289);
            Eingabe3.Name = "Eingabe3";
            Eingabe3.Size = new Size(125, 27);
            Eingabe3.TabIndex = 10;
            Eingabe3.Visible = false;
            // 
            // Text3
            // 
            Text3.AutoSize = true;
            Text3.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            Text3.ForeColor = SystemColors.ActiveCaptionText;
            Text3.Location = new Point(833, 266);
            Text3.Name = "Text3";
            Text3.Size = new Size(49, 23);
            Text3.TabIndex = 11;
            Text3.Text = "text3";
            Text3.Visible = false;
            // 
            // btnBerechnen
            // 
            btnBerechnen.BackColor = Color.Silver;
            btnBerechnen.Cursor = Cursors.Hand;
            btnBerechnen.FlatStyle = FlatStyle.Flat;
            btnBerechnen.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnBerechnen.Location = new Point(1019, 289);
            btnBerechnen.Name = "btnBerechnen";
            btnBerechnen.Size = new Size(126, 40);
            btnBerechnen.TabIndex = 12;
            btnBerechnen.Text = "Berechnen";
            btnBerechnen.UseVisualStyleBackColor = false;
            btnBerechnen.Visible = false;
            btnBerechnen.Click += btnBerechnen_Click;
            // 
            // lblResultatzahl
            // 
            lblResultatzahl.AutoSize = true;
            lblResultatzahl.BackColor = SystemColors.ButtonShadow;
            lblResultatzahl.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lblResultatzahl.ForeColor = SystemColors.ActiveCaptionText;
            lblResultatzahl.Location = new Point(1151, 293);
            lblResultatzahl.Name = "lblResultatzahl";
            lblResultatzahl.Size = new Size(126, 28);
            lblResultatzahl.TabIndex = 14;
            lblResultatzahl.Text = "resultatZahl";
            lblResultatzahl.Visible = false;
            // 
            // btnIntensitätdesUmlaufvermögen
            // 
            btnIntensitätdesUmlaufvermögen.AutoSize = true;
            btnIntensitätdesUmlaufvermögen.BackColor = Color.Silver;
            btnIntensitätdesUmlaufvermögen.Cursor = Cursors.Hand;
            btnIntensitätdesUmlaufvermögen.FlatStyle = FlatStyle.Flat;
            btnIntensitätdesUmlaufvermögen.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            btnIntensitätdesUmlaufvermögen.Location = new Point(15, 268);
            btnIntensitätdesUmlaufvermögen.Name = "btnIntensitätdesUmlaufvermögen";
            btnIntensitätdesUmlaufvermögen.RightToLeft = RightToLeft.Yes;
            btnIntensitätdesUmlaufvermögen.Size = new Size(296, 37);
            btnIntensitätdesUmlaufvermögen.TabIndex = 15;
            btnIntensitätdesUmlaufvermögen.Text = "Intensität des Umlaufvermögens";
            btnIntensitätdesUmlaufvermögen.UseVisualStyleBackColor = false;
            btnIntensitätdesUmlaufvermögen.Click += btnIntensitätdesUmlaufvermögen_Click;
            // 
            // IntensitätdesAnlagevermögens
            // 
            IntensitätdesAnlagevermögens.AutoSize = true;
            IntensitätdesAnlagevermögens.BackColor = Color.Silver;
            IntensitätdesAnlagevermögens.Cursor = Cursors.Hand;
            IntensitätdesAnlagevermögens.FlatStyle = FlatStyle.Flat;
            IntensitätdesAnlagevermögens.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            IntensitätdesAnlagevermögens.Location = new Point(15, 311);
            IntensitätdesAnlagevermögens.Name = "IntensitätdesAnlagevermögens";
            IntensitätdesAnlagevermögens.RightToLeft = RightToLeft.Yes;
            IntensitätdesAnlagevermögens.Size = new Size(294, 37);
            IntensitätdesAnlagevermögens.TabIndex = 16;
            IntensitätdesAnlagevermögens.Text = "Intensität des Anlagevermögens";
            IntensitätdesAnlagevermögens.UseVisualStyleBackColor = false;
            IntensitätdesAnlagevermögens.Click += IntensitätdesAnlagevermögens_Click;
            // 
            // Liquiditätsgrad1
            // 
            Liquiditätsgrad1.AutoSize = true;
            Liquiditätsgrad1.BackColor = Color.Silver;
            Liquiditätsgrad1.Cursor = Cursors.Hand;
            Liquiditätsgrad1.FlatStyle = FlatStyle.Flat;
            Liquiditätsgrad1.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            Liquiditätsgrad1.Location = new Point(15, 354);
            Liquiditätsgrad1.Name = "Liquiditätsgrad1";
            Liquiditätsgrad1.RightToLeft = RightToLeft.Yes;
            Liquiditätsgrad1.Size = new Size(194, 37);
            Liquiditätsgrad1.TabIndex = 17;
            Liquiditätsgrad1.Text = "Liquiditätsgrad 1";
            Liquiditätsgrad1.UseVisualStyleBackColor = false;
            Liquiditätsgrad1.Click += Liquiditätsgrad1_Click;
            // 
            // btnLiquiditätsgrad2
            // 
            btnLiquiditätsgrad2.AutoSize = true;
            btnLiquiditätsgrad2.BackColor = Color.Silver;
            btnLiquiditätsgrad2.Cursor = Cursors.Hand;
            btnLiquiditätsgrad2.FlatStyle = FlatStyle.Flat;
            btnLiquiditätsgrad2.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            btnLiquiditätsgrad2.Location = new Point(15, 397);
            btnLiquiditätsgrad2.Name = "btnLiquiditätsgrad2";
            btnLiquiditätsgrad2.RightToLeft = RightToLeft.Yes;
            btnLiquiditätsgrad2.Size = new Size(194, 37);
            btnLiquiditätsgrad2.TabIndex = 18;
            btnLiquiditätsgrad2.Text = "Liquiditätsgrad 2";
            btnLiquiditätsgrad2.UseVisualStyleBackColor = false;
            btnLiquiditätsgrad2.Click += btnLiquiditätsgrad2_Click;
            // 
            // btnBeurteilung
            // 
            btnBeurteilung.AutoSize = true;
            btnBeurteilung.BackColor = Color.Silver;
            btnBeurteilung.Cursor = Cursors.Hand;
            btnBeurteilung.FlatStyle = FlatStyle.Flat;
            btnBeurteilung.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnBeurteilung.Location = new Point(1019, 335);
            btnBeurteilung.Name = "btnBeurteilung";
            btnBeurteilung.RightToLeft = RightToLeft.No;
            btnBeurteilung.Size = new Size(126, 40);
            btnBeurteilung.TabIndex = 19;
            btnBeurteilung.Text = "Beurteilung";
            btnBeurteilung.UseVisualStyleBackColor = false;
            btnBeurteilung.Visible = false;
            btnBeurteilung.Click += btnBeurteilung_Click;
            // 
            // btnLiquiditätsgrad3
            // 
            btnLiquiditätsgrad3.AutoSize = true;
            btnLiquiditätsgrad3.BackColor = Color.Silver;
            btnLiquiditätsgrad3.Cursor = Cursors.Hand;
            btnLiquiditätsgrad3.FlatStyle = FlatStyle.Flat;
            btnLiquiditätsgrad3.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            btnLiquiditätsgrad3.Location = new Point(15, 440);
            btnLiquiditätsgrad3.Name = "btnLiquiditätsgrad3";
            btnLiquiditätsgrad3.RightToLeft = RightToLeft.Yes;
            btnLiquiditätsgrad3.Size = new Size(194, 37);
            btnLiquiditätsgrad3.TabIndex = 20;
            btnLiquiditätsgrad3.Text = "Liquiditätsgrad 3";
            btnLiquiditätsgrad3.UseVisualStyleBackColor = false;
            btnLiquiditätsgrad3.Click += btnLiquiditätsgrad3_Click;
            // 
            // btnAnlagedeckungsgrad1
            // 
            btnAnlagedeckungsgrad1.AutoSize = true;
            btnAnlagedeckungsgrad1.BackColor = Color.Silver;
            btnAnlagedeckungsgrad1.Cursor = Cursors.Hand;
            btnAnlagedeckungsgrad1.FlatStyle = FlatStyle.Flat;
            btnAnlagedeckungsgrad1.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            btnAnlagedeckungsgrad1.Location = new Point(15, 483);
            btnAnlagedeckungsgrad1.Name = "btnAnlagedeckungsgrad1";
            btnAnlagedeckungsgrad1.RightToLeft = RightToLeft.Yes;
            btnAnlagedeckungsgrad1.Size = new Size(211, 37);
            btnAnlagedeckungsgrad1.TabIndex = 21;
            btnAnlagedeckungsgrad1.Text = "Anlagedeckungsgrad 1";
            btnAnlagedeckungsgrad1.UseVisualStyleBackColor = false;
            btnAnlagedeckungsgrad1.Click += btnAnlagedeckungsgrad1_Click;
            // 
            // btnAnlagedeckungsgrad2
            // 
            btnAnlagedeckungsgrad2.AutoSize = true;
            btnAnlagedeckungsgrad2.BackColor = Color.Silver;
            btnAnlagedeckungsgrad2.Cursor = Cursors.Hand;
            btnAnlagedeckungsgrad2.FlatStyle = FlatStyle.Flat;
            btnAnlagedeckungsgrad2.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            btnAnlagedeckungsgrad2.Location = new Point(15, 526);
            btnAnlagedeckungsgrad2.Name = "btnAnlagedeckungsgrad2";
            btnAnlagedeckungsgrad2.RightToLeft = RightToLeft.Yes;
            btnAnlagedeckungsgrad2.Size = new Size(214, 37);
            btnAnlagedeckungsgrad2.TabIndex = 22;
            btnAnlagedeckungsgrad2.Text = "Anlagedeckungsgrad 2";
            btnAnlagedeckungsgrad2.UseVisualStyleBackColor = false;
            btnAnlagedeckungsgrad2.Click += btnAnlagedeckungsgrad2_Click;
            // 
            // btnEigenkapitalrendite
            // 
            btnEigenkapitalrendite.AutoSize = true;
            btnEigenkapitalrendite.BackColor = Color.Silver;
            btnEigenkapitalrendite.Cursor = Cursors.Hand;
            btnEigenkapitalrendite.FlatStyle = FlatStyle.Flat;
            btnEigenkapitalrendite.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            btnEigenkapitalrendite.Location = new Point(15, 569);
            btnEigenkapitalrendite.Name = "btnEigenkapitalrendite";
            btnEigenkapitalrendite.RightToLeft = RightToLeft.Yes;
            btnEigenkapitalrendite.Size = new Size(194, 37);
            btnEigenkapitalrendite.TabIndex = 23;
            btnEigenkapitalrendite.Text = "Eigenkapitalrendite";
            btnEigenkapitalrendite.UseVisualStyleBackColor = false;
            btnEigenkapitalrendite.Click += btnEigenkapitalrendite_Click;
            // 
            // btnGesamtkapitalrendite
            // 
            btnGesamtkapitalrendite.AutoSize = true;
            btnGesamtkapitalrendite.BackColor = Color.Silver;
            btnGesamtkapitalrendite.Cursor = Cursors.Hand;
            btnGesamtkapitalrendite.FlatStyle = FlatStyle.Flat;
            btnGesamtkapitalrendite.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            btnGesamtkapitalrendite.Location = new Point(15, 612);
            btnGesamtkapitalrendite.Name = "btnGesamtkapitalrendite";
            btnGesamtkapitalrendite.RightToLeft = RightToLeft.Yes;
            btnGesamtkapitalrendite.Size = new Size(203, 37);
            btnGesamtkapitalrendite.TabIndex = 24;
            btnGesamtkapitalrendite.Text = "Gesamtkapitalrendite";
            btnGesamtkapitalrendite.UseVisualStyleBackColor = false;
            btnGesamtkapitalrendite.Click += btnGesamtkapitalrendite_Click;
            // 
            // btnUmsatzrendite
            // 
            btnUmsatzrendite.AutoSize = true;
            btnUmsatzrendite.BackColor = Color.Silver;
            btnUmsatzrendite.Cursor = Cursors.Hand;
            btnUmsatzrendite.FlatStyle = FlatStyle.Flat;
            btnUmsatzrendite.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            btnUmsatzrendite.Location = new Point(15, 655);
            btnUmsatzrendite.Name = "btnUmsatzrendite";
            btnUmsatzrendite.RightToLeft = RightToLeft.Yes;
            btnUmsatzrendite.Size = new Size(194, 37);
            btnUmsatzrendite.TabIndex = 25;
            btnUmsatzrendite.Text = "Umsatzrendite";
            btnUmsatzrendite.UseVisualStyleBackColor = false;
            btnUmsatzrendite.Click += btnUmsatzrendite_Click;
            // 
            // lblBeurteilung
            // 
            lblBeurteilung.AutoSize = true;
            lblBeurteilung.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lblBeurteilung.ForeColor = SystemColors.ActiveCaptionText;
            lblBeurteilung.Location = new Point(1151, 338);
            lblBeurteilung.Name = "lblBeurteilung";
            lblBeurteilung.Size = new Size(124, 28);
            lblBeurteilung.TabIndex = 26;
            lblBeurteilung.Text = "Beurteilung";
            lblBeurteilung.Visible = false;
            // 
            // lblkennzahlinfo
            // 
            lblkennzahlinfo.AutoSize = true;
            lblkennzahlinfo.Font = new Font("Segoe UI Semibold", 18F, FontStyle.Bold, GraphicsUnit.Point);
            lblkennzahlinfo.Location = new Point(526, 14);
            lblkennzahlinfo.Name = "lblkennzahlinfo";
            lblkennzahlinfo.Size = new Size(264, 41);
            lblkennzahlinfo.TabIndex = 27;
            lblkennzahlinfo.Text = "kennzahlidentitity";
            lblkennzahlinfo.Visible = false;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ButtonShadow;
            ClientSize = new Size(1316, 700);
            Controls.Add(lblkennzahlinfo);
            Controls.Add(lblBeurteilung);
            Controls.Add(btnUmsatzrendite);
            Controls.Add(btnGesamtkapitalrendite);
            Controls.Add(btnEigenkapitalrendite);
            Controls.Add(btnAnlagedeckungsgrad2);
            Controls.Add(btnAnlagedeckungsgrad1);
            Controls.Add(btnLiquiditätsgrad3);
            Controls.Add(btnBeurteilung);
            Controls.Add(btnLiquiditätsgrad2);
            Controls.Add(Liquiditätsgrad1);
            Controls.Add(IntensitätdesAnlagevermögens);
            Controls.Add(btnIntensitätdesUmlaufvermögen);
            Controls.Add(lblResultatzahl);
            Controls.Add(btnBerechnen);
            Controls.Add(Text3);
            Controls.Add(Eingabe3);
            Controls.Add(Text2);
            Controls.Add(Text1);
            Controls.Add(Eingabe2);
            Controls.Add(Eingabe1);
            Controls.Add(btnZurück);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(btnSelbstfinanzierungsgrad);
            Controls.Add(btnFremdfinanzierungsgrad);
            Controls.Add(btnEigenfinanzierung);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Form1";
            Text = "Kennzahlenanalyse";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnEigenfinanzierung;
        private Button btnFremdfinanzierungsgrad;
        private Button btnSelbstfinanzierungsgrad;
        private Label label1;
        private Label label2;
        private Button btnZurück;
        private TextBox Eingabe1;
        private TextBox Eingabe2;
        private Label Text1;
        private Label Text2;
        private TextBox Eingabe3;
        private Label Text3;
        private Button btnBerechnen;
        private Label lblResultatzahl;
        private Button btnIntensitätdesUmlaufvermögen;
        private Button IntensitätdesAnlagevermögens;
        private Button Liquiditätsgrad1;
        private Button btnLiquiditätsgrad2;
        private Button btnBeurteilung;
        private Button btnLiquiditätsgrad3;
        private Button btnAnlagedeckungsgrad1;
        private Button btnAnlagedeckungsgrad2;
        private Button btnEigenkapitalrendite;
        private Button btnGesamtkapitalrendite;
        private Button btnUmsatzrendite;
        private Label lblBeurteilung;
        private Label lblkennzahlinfo;
    }
}