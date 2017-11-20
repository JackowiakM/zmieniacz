namespace Projekt
{
    partial class O_Programie
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(O_Programie));
            this.obrazek_o_programie = new System.Windows.Forms.PictureBox();
            this.wersja = new System.Windows.Forms.Label();
            this.autorzy = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.informacja_1 = new System.Windows.Forms.Label();
            this.informacja_2 = new System.Windows.Forms.Label();
            this.informacja_3 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.linki = new System.Windows.Forms.Label();
            this.link_up = new System.Windows.Forms.LinkLabel();
            this.link_instytut = new System.Windows.Forms.LinkLabel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.licencja = new System.Windows.Forms.Label();
            this.wyjście = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.obrazek_o_programie)).BeginInit();
            this.SuspendLayout();
            // 
            // obrazek_o_programie
            // 
            this.obrazek_o_programie.Image = ((System.Drawing.Image)(resources.GetObject("obrazek_o_programie.Image")));
            this.obrazek_o_programie.Location = new System.Drawing.Point(1, -1);
            this.obrazek_o_programie.Name = "obrazek_o_programie";
            this.obrazek_o_programie.Size = new System.Drawing.Size(305, 87);
            this.obrazek_o_programie.TabIndex = 0;
            this.obrazek_o_programie.TabStop = false;
            // 
            // wersja
            // 
            this.wersja.AutoSize = true;
            this.wersja.Location = new System.Drawing.Point(12, 89);
            this.wersja.Name = "wersja";
            this.wersja.Size = new System.Drawing.Size(108, 13);
            this.wersja.TabIndex = 1;
            this.wersja.Text = "Wersja programu: 1.0";
            // 
            // autorzy
            // 
            this.autorzy.AutoSize = true;
            this.autorzy.Location = new System.Drawing.Point(12, 106);
            this.autorzy.Name = "autorzy";
            this.autorzy.Size = new System.Drawing.Size(216, 13);
            this.autorzy.TabIndex = 2;
            this.autorzy.Text = "Autorzy: Marcin Jackowiak, Tomasz Grzelak";
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Location = new System.Drawing.Point(12, 122);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(290, 1);
            this.panel1.TabIndex = 3;
            // 
            // informacja_1
            // 
            this.informacja_1.AutoSize = true;
            this.informacja_1.Location = new System.Drawing.Point(10, 125);
            this.informacja_1.Name = "informacja_1";
            this.informacja_1.Size = new System.Drawing.Size(243, 13);
            this.informacja_1.TabIndex = 4;
            this.informacja_1.Text = "Program powstał w ramach ćwiczeń z przedmiotu ";
            // 
            // informacja_2
            // 
            this.informacja_2.AutoSize = true;
            this.informacja_2.Location = new System.Drawing.Point(10, 138);
            this.informacja_2.Name = "informacja_2";
            this.informacja_2.Size = new System.Drawing.Size(272, 13);
            this.informacja_2.TabIndex = 5;
            this.informacja_2.Text = "\"Programowanie obiektowe\" realizowanego w Instytucie";
            // 
            // informacja_3
            // 
            this.informacja_3.AutoSize = true;
            this.informacja_3.Location = new System.Drawing.Point(10, 151);
            this.informacja_3.Name = "informacja_3";
            this.informacja_3.Size = new System.Drawing.Size(296, 13);
            this.informacja_3.TabIndex = 6;
            this.informacja_3.Text = "Inżynerii Rolniczej Uniwersystetu Przyrodniczego w Poznaniu.";
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Location = new System.Drawing.Point(12, 167);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(290, 1);
            this.panel2.TabIndex = 7;
            // 
            // linki
            // 
            this.linki.AutoSize = true;
            this.linki.Location = new System.Drawing.Point(13, 175);
            this.linki.Name = "linki";
            this.linki.Size = new System.Drawing.Size(32, 13);
            this.linki.TabIndex = 8;
            this.linki.Text = "Linki:";
            // 
            // link_up
            // 
            this.link_up.AutoSize = true;
            this.link_up.Location = new System.Drawing.Point(52, 175);
            this.link_up.Name = "link_up";
            this.link_up.Size = new System.Drawing.Size(187, 13);
            this.link_up.TabIndex = 9;
            this.link_up.TabStop = true;
            this.link_up.Text = "Uniwersystet Przyrodniczy w Poznaniu";
            this.link_up.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.link_up_LinkClicked);
            // 
            // link_instytut
            // 
            this.link_instytut.AutoSize = true;
            this.link_instytut.Location = new System.Drawing.Point(55, 192);
            this.link_instytut.Name = "link_instytut";
            this.link_instytut.Size = new System.Drawing.Size(128, 13);
            this.link_instytut.TabIndex = 10;
            this.link_instytut.TabStop = true;
            this.link_instytut.Text = "Instytut Inżynerii Rolniczej";
            this.link_instytut.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.link_instytut_LinkClicked);
            // 
            // panel3
            // 
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Location = new System.Drawing.Point(12, 218);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(290, 1);
            this.panel3.TabIndex = 4;
            // 
            // licencja
            // 
            this.licencja.AutoSize = true;
            this.licencja.Location = new System.Drawing.Point(13, 222);
            this.licencja.Name = "licencja";
            this.licencja.Size = new System.Drawing.Size(226, 13);
            this.licencja.TabIndex = 11;
            this.licencja.Text = "Licencja: NeedWare (treść w pliku licencja.txt)";
            // 
            // wyjście
            // 
            this.wyjście.Location = new System.Drawing.Point(207, 250);
            this.wyjście.Name = "wyjście";
            this.wyjście.Size = new System.Drawing.Size(75, 23);
            this.wyjście.TabIndex = 12;
            this.wyjście.Text = "OK";
            this.wyjście.UseVisualStyleBackColor = true;
            this.wyjście.Click += new System.EventHandler(this.wyjście_Click);
            // 
            // O_Programie
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(305, 285);
            this.Controls.Add(this.wyjście);
            this.Controls.Add(this.licencja);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.link_instytut);
            this.Controls.Add(this.link_up);
            this.Controls.Add(this.linki);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.informacja_3);
            this.Controls.Add(this.informacja_2);
            this.Controls.Add(this.informacja_1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.autorzy);
            this.Controls.Add(this.wersja);
            this.Controls.Add(this.obrazek_o_programie);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "O_Programie";
            this.ShowIcon = false;
            this.Text = "O programie";
            ((System.ComponentModel.ISupportInitialize)(this.obrazek_o_programie)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox obrazek_o_programie;
        private System.Windows.Forms.Label wersja;
        private System.Windows.Forms.Label autorzy;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label informacja_1;
        private System.Windows.Forms.Label informacja_2;
        private System.Windows.Forms.Label informacja_3;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label linki;
        private System.Windows.Forms.LinkLabel link_up;
        private System.Windows.Forms.LinkLabel link_instytut;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label licencja;
        private System.Windows.Forms.Button wyjście;
    }
}