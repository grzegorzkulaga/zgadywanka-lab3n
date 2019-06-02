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
            this.labelod = new System.Windows.Forms.Label();
            this.textBoxod = new System.Windows.Forms.TextBox();
            this.labeldo = new System.Windows.Forms.Label();
            this.textBoxdo = new System.Windows.Forms.TextBox();
            this.buttonlosuj = new System.Windows.Forms.Button();
            this.groupboxLosuj.SuspendLayout();
            this.SuspendLayout();
            // 
            // NowaGra
            // 
            this.NowaGra.Location = new System.Drawing.Point(13, 13);
            this.NowaGra.Name = "NowaGra";
            this.NowaGra.Size = new System.Drawing.Size(75, 23);
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
            // textBoxod
            // 
            this.textBoxod.Location = new System.Drawing.Point(72, 33);
            this.textBoxod.Name = "textBoxod";
            this.textBoxod.Size = new System.Drawing.Size(100, 20);
            this.textBoxod.TabIndex = 1;
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
            // textBoxdo
            // 
            this.textBoxdo.Location = new System.Drawing.Point(72, 79);
            this.textBoxdo.Name = "textBoxdo";
            this.textBoxdo.Size = new System.Drawing.Size(100, 20);
            this.textBoxdo.TabIndex = 3;
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
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(386, 450);
            this.Controls.Add(this.groupboxLosuj);
            this.Controls.Add(this.NowaGra);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupboxLosuj.ResumeLayout(false);
            this.groupboxLosuj.PerformLayout();
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
    }
}

