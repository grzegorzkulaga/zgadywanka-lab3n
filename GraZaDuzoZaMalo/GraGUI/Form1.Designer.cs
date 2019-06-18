namespace GraGUI
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
            this.NowaGra = new System.Windows.Forms.Button();
            this.groupboxLosuj = new System.Windows.Forms.GroupBox();
            this.buttonlosuj = new System.Windows.Forms.Button();
            this.textBoxdo = new System.Windows.Forms.TextBox();
            this.labeldo = new System.Windows.Forms.Label();
            this.textBoxod = new System.Windows.Forms.TextBox();
            this.labelod = new System.Windows.Forms.Label();
            this.groupboxSprawdzanie = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.Liczba = new System.Windows.Forms.Label();
            this.buttonsprawdzenie = new System.Windows.Forms.Button();
            this.textBoxliczba = new System.Windows.Forms.TextBox();
            this.labelwprowadz = new System.Windows.Forms.Label();
            this.ZrezygnujZGry = new System.Windows.Forms.Button();
            this.LiczbaRuchow = new System.Windows.Forms.Label();
            this.labelRuch = new System.Windows.Forms.Label();
            this.groupboxLosuj.SuspendLayout();
            this.groupboxSprawdzanie.SuspendLayout();
            this.SuspendLayout();
            // 
            // NowaGra
            // 
            this.NowaGra.Location = new System.Drawing.Point(13, 13);
            this.NowaGra.Name = "NowaGra";
            this.NowaGra.Size = new System.Drawing.Size(75, 32);
            this.NowaGra.TabIndex = 0;
            this.NowaGra.Text = "Nowa gra";
            this.NowaGra.UseVisualStyleBackColor = true;
            this.NowaGra.Click += new System.EventHandler(this.NowaGra_Click);
            // 
            // groupboxLosuj
            // 
            this.groupboxLosuj.Controls.Add(this.buttonlosuj);
            this.groupboxLosuj.Controls.Add(this.textBoxdo);
            this.groupboxLosuj.Controls.Add(this.labeldo);
            this.groupboxLosuj.Controls.Add(this.textBoxod);
            this.groupboxLosuj.Controls.Add(this.labelod);
            this.groupboxLosuj.Location = new System.Drawing.Point(13, 64);
            this.groupboxLosuj.Name = "groupboxLosuj";
            this.groupboxLosuj.Size = new System.Drawing.Size(317, 143);
            this.groupboxLosuj.TabIndex = 1;
            this.groupboxLosuj.TabStop = false;
            this.groupboxLosuj.Text = "Losowanie";
            this.groupboxLosuj.Visible = false;
            this.groupboxLosuj.Enter += new System.EventHandler(this.GroupboxLosuj_Enter);
            // 
            // buttonlosuj
            // 
            this.buttonlosuj.Location = new System.Drawing.Point(225, 53);
            this.buttonlosuj.Name = "buttonlosuj";
            this.buttonlosuj.Size = new System.Drawing.Size(75, 23);
            this.buttonlosuj.TabIndex = 4;
            this.buttonlosuj.Text = "Wylosuj";
            this.buttonlosuj.UseVisualStyleBackColor = true;
            this.buttonlosuj.Click += new System.EventHandler(this.button1_Click);
            // 
            // textBoxdo
            // 
            this.textBoxdo.Location = new System.Drawing.Point(72, 79);
            this.textBoxdo.Name = "textBoxdo";
            this.textBoxdo.Size = new System.Drawing.Size(100, 20);
            this.textBoxdo.TabIndex = 3;
            // 
            // labeldo
            // 
            this.labeldo.AutoSize = true;
            this.labeldo.Location = new System.Drawing.Point(8, 86);
            this.labeldo.Name = "labeldo";
            this.labeldo.Size = new System.Drawing.Size(58, 13);
            this.labeldo.TabIndex = 2;
            this.labeldo.Text = "Zakres do:";
            // 
            // textBoxod
            // 
            this.textBoxod.Location = new System.Drawing.Point(72, 33);
            this.textBoxod.Name = "textBoxod";
            this.textBoxod.Size = new System.Drawing.Size(100, 20);
            this.textBoxod.TabIndex = 1;
            // 
            // labelod
            // 
            this.labelod.AutoSize = true;
            this.labelod.Location = new System.Drawing.Point(8, 40);
            this.labelod.Name = "labelod";
            this.labelod.Size = new System.Drawing.Size(58, 13);
            this.labelod.TabIndex = 0;
            this.labelod.Text = "Zakres od:";
            this.labelod.Click += new System.EventHandler(this.labelod_Click);
            // 
            // groupboxSprawdzanie
            // 
            this.groupboxSprawdzanie.Controls.Add(this.labelRuch);
            this.groupboxSprawdzanie.Controls.Add(this.LiczbaRuchow);
            this.groupboxSprawdzanie.Controls.Add(this.label2);
            this.groupboxSprawdzanie.Controls.Add(this.Liczba);
            this.groupboxSprawdzanie.Controls.Add(this.buttonsprawdzenie);
            this.groupboxSprawdzanie.Controls.Add(this.textBoxliczba);
            this.groupboxSprawdzanie.Controls.Add(this.labelwprowadz);
            this.groupboxSprawdzanie.Location = new System.Drawing.Point(12, 229);
            this.groupboxSprawdzanie.Name = "groupboxSprawdzanie";
            this.groupboxSprawdzanie.Size = new System.Drawing.Size(317, 130);
            this.groupboxSprawdzanie.TabIndex = 2;
            this.groupboxSprawdzanie.TabStop = false;
            this.groupboxSprawdzanie.Text = "Sprawdzanie";
            this.groupboxSprawdzanie.Visible = false;
            this.groupboxSprawdzanie.Enter += new System.EventHandler(this.GroupBox1_Enter);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(10, 84);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(88, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Twoja liczba jest:";
            this.label2.Click += new System.EventHandler(this.Label2_Click);
            // 
            // Liczba
            // 
            this.Liczba.AutoSize = true;
            this.Liczba.Location = new System.Drawing.Point(104, 84);
            this.Liczba.Name = "Liczba";
            this.Liczba.Size = new System.Drawing.Size(12, 13);
            this.Liczba.TabIndex = 3;
            this.Liczba.Text = "x";
            this.Liczba.Visible = false;
            this.Liczba.Click += new System.EventHandler(this.Liczba_Click);
            // 
            // buttonsprawdzenie
            // 
            this.buttonsprawdzenie.Location = new System.Drawing.Point(229, 23);
            this.buttonsprawdzenie.Name = "buttonsprawdzenie";
            this.buttonsprawdzenie.Size = new System.Drawing.Size(82, 39);
            this.buttonsprawdzenie.TabIndex = 2;
            this.buttonsprawdzenie.Text = "Sprawdź swoją liczbę!";
            this.buttonsprawdzenie.UseVisualStyleBackColor = true;
            this.buttonsprawdzenie.Click += new System.EventHandler(this.Button1_Click_1);
            // 
            // textBoxliczba
            // 
            this.textBoxliczba.Location = new System.Drawing.Point(106, 42);
            this.textBoxliczba.Name = "textBoxliczba";
            this.textBoxliczba.Size = new System.Drawing.Size(95, 20);
            this.textBoxliczba.TabIndex = 1;
            // 
            // labelwprowadz
            // 
            this.labelwprowadz.AutoSize = true;
            this.labelwprowadz.Location = new System.Drawing.Point(9, 49);
            this.labelwprowadz.Name = "labelwprowadz";
            this.labelwprowadz.Size = new System.Drawing.Size(91, 13);
            this.labelwprowadz.TabIndex = 0;
            this.labelwprowadz.Text = "Wprowadź liczbę:";
            // 
            // ZrezygnujZGry
            // 
            this.ZrezygnujZGry.Location = new System.Drawing.Point(100, 13);
            this.ZrezygnujZGry.Name = "ZrezygnujZGry";
            this.ZrezygnujZGry.Size = new System.Drawing.Size(113, 32);
            this.ZrezygnujZGry.TabIndex = 3;
            this.ZrezygnujZGry.Text = "Zrezygnuj z gry :(";
            this.ZrezygnujZGry.UseVisualStyleBackColor = true;
            this.ZrezygnujZGry.Visible = false;
            // 
            // LiczbaRuchow
            // 
            this.LiczbaRuchow.AutoSize = true;
            this.LiczbaRuchow.Location = new System.Drawing.Point(104, 109);
            this.LiczbaRuchow.Name = "LiczbaRuchow";
            this.LiczbaRuchow.Size = new System.Drawing.Size(12, 13);
            this.LiczbaRuchow.TabIndex = 5;
            this.LiczbaRuchow.Text = "x";
            this.LiczbaRuchow.Visible = false;
            this.LiczbaRuchow.Click += new System.EventHandler(this.LiczbaRuchow_Click);
            // 
            // labelRuch
            // 
            this.labelRuch.AutoSize = true;
            this.labelRuch.Location = new System.Drawing.Point(10, 109);
            this.labelRuch.Name = "labelRuch";
            this.labelRuch.Size = new System.Drawing.Size(79, 13);
            this.labelRuch.TabIndex = 6;
            this.labelRuch.Text = "Liczba ruchów:";
            this.labelRuch.Click += new System.EventHandler(this.LabelRuch_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(386, 450);
            this.Controls.Add(this.ZrezygnujZGry);
            this.Controls.Add(this.groupboxSprawdzanie);
            this.Controls.Add(this.groupboxLosuj);
            this.Controls.Add(this.NowaGra);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupboxLosuj.ResumeLayout(false);
            this.groupboxLosuj.PerformLayout();
            this.groupboxSprawdzanie.ResumeLayout(false);
            this.groupboxSprawdzanie.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button NowaGra;
        private System.Windows.Forms.GroupBox groupboxLosuj;
        private System.Windows.Forms.Label labelod;
        private System.Windows.Forms.TextBox textBoxdo;
        private System.Windows.Forms.Label labeldo;
        private System.Windows.Forms.TextBox textBoxod;
        private System.Windows.Forms.Button buttonlosuj;
        private System.Windows.Forms.GroupBox groupboxSprawdzanie;
        private System.Windows.Forms.Button buttonsprawdzenie;
        private System.Windows.Forms.TextBox textBoxliczba;
        private System.Windows.Forms.Label labelwprowadz;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label Liczba;
        private System.Windows.Forms.Button ZrezygnujZGry;
        private System.Windows.Forms.Label labelRuch;
        private System.Windows.Forms.Label LiczbaRuchow;
    }
}

