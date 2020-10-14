namespace Praca_domowa_2_Zadanie_dodatkowe
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
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.dlugosc = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.szerokosc = new System.Windows.Forms.TextBox();
            this.glebokosc = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.murek = new System.Windows.Forms.TextBox();
            this.podstawa = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.wysokosc = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(362, 192);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(131, 64);
            this.button1.TabIndex = 0;
            this.button1.Text = "Oblicz!";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(38, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(730, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "Program obliczający ilość soli wymaganej do zasolenia basenu o danych parametrach" +
    "";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // dlugosc
            // 
            this.dlugosc.Location = new System.Drawing.Point(150, 69);
            this.dlugosc.Name = "dlugosc";
            this.dlugosc.Size = new System.Drawing.Size(100, 22);
            this.dlugosc.TabIndex = 6;
            this.dlugosc.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(75, 46);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(124, 17);
            this.label2.TabIndex = 7;
            this.label2.Text = "Parametry basenu";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(39, 72);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 17);
            this.label3.TabIndex = 8;
            this.label3.Text = "Długość";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(39, 103);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(74, 17);
            this.label4.TabIndex = 9;
            this.label4.Text = "Szerokość";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(39, 134);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(75, 17);
            this.label5.TabIndex = 10;
            this.label5.Text = "Głębokość";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // szerokosc
            // 
            this.szerokosc.Location = new System.Drawing.Point(150, 103);
            this.szerokosc.Name = "szerokosc";
            this.szerokosc.Size = new System.Drawing.Size(100, 22);
            this.szerokosc.TabIndex = 11;
            // 
            // glebokosc
            // 
            this.glebokosc.Location = new System.Drawing.Point(150, 134);
            this.glebokosc.Name = "glebokosc";
            this.glebokosc.Size = new System.Drawing.Size(100, 22);
            this.glebokosc.TabIndex = 12;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(637, 46);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(131, 17);
            this.label6.TabIndex = 13;
            this.label6.Text = "Parametry brodzika";
            // 
            // murek
            // 
            this.murek.Location = new System.Drawing.Point(737, 134);
            this.murek.Name = "murek";
            this.murek.Size = new System.Drawing.Size(100, 22);
            this.murek.TabIndex = 19;
            // 
            // podstawa
            // 
            this.podstawa.Location = new System.Drawing.Point(737, 103);
            this.podstawa.Name = "podstawa";
            this.podstawa.Size = new System.Drawing.Size(100, 22);
            this.podstawa.TabIndex = 18;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(569, 134);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(84, 17);
            this.label7.TabIndex = 17;
            this.label7.Text = "Szer. murku";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(569, 103);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(127, 17);
            this.label8.TabIndex = 16;
            this.label8.Text = "Średnica podstawy";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(569, 72);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(72, 17);
            this.label9.TabIndex = 15;
            this.label9.Text = "Wysokość";
            this.label9.Click += new System.EventHandler(this.label9_Click);
            // 
            // wysokosc
            // 
            this.wysokosc.Location = new System.Drawing.Point(737, 69);
            this.wysokosc.Name = "wysokosc";
            this.wysokosc.Size = new System.Drawing.Size(100, 22);
            this.wysokosc.TabIndex = 14;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(882, 553);
            this.Controls.Add(this.murek);
            this.Controls.Add(this.podstawa);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.wysokosc);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.glebokosc);
            this.Controls.Add(this.szerokosc);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dlugosc);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Licz mą sól";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox dlugosc;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox szerokosc;
        private System.Windows.Forms.TextBox glebokosc;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox murek;
        private System.Windows.Forms.TextBox podstawa;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox wysokosc;
    }
}

