namespace Projekt
{
    partial class Zmieniacz
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Zmieniacz));
            this.wybranie_katalogu = new System.Windows.Forms.Button();
            this.wpisywanie_szukanej = new System.Windows.Forms.TextBox();
            this.szukanie = new System.Windows.Forms.Button();
            this.zmiana_słowa = new System.Windows.Forms.TextBox();
            this.zamiana = new System.Windows.Forms.Button();
            this.zapis = new System.Windows.Forms.Button();
            this.wyświetlanie_katalogu = new System.Windows.Forms.ListBox();
            this.sprawdzanie_czy_zawiera = new System.Windows.Forms.TextBox();
            this.nazwy_plików = new System.Windows.Forms.ListBox();
            this.wyświetlenie_pliku = new System.Windows.Forms.RichTextBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.oProgramieToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pomocToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.linie = new LineNumbers.LineNumbers_For_RichTextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // wybranie_katalogu
            // 
            this.wybranie_katalogu.Location = new System.Drawing.Point(12, 38);
            this.wybranie_katalogu.Name = "wybranie_katalogu";
            this.wybranie_katalogu.Size = new System.Drawing.Size(75, 23);
            this.wybranie_katalogu.TabIndex = 0;
            this.wybranie_katalogu.Text = "Katalog";
            this.wybranie_katalogu.UseVisualStyleBackColor = true;
            this.wybranie_katalogu.Click += new System.EventHandler(this.wybranie_katalogu_Click);
            // 
            // wpisywanie_szukanej
            // 
            this.wpisywanie_szukanej.Location = new System.Drawing.Point(12, 205);
            this.wpisywanie_szukanej.Name = "wpisywanie_szukanej";
            this.wpisywanie_szukanej.Size = new System.Drawing.Size(100, 20);
            this.wpisywanie_szukanej.TabIndex = 3;
            // 
            // szukanie
            // 
            this.szukanie.Location = new System.Drawing.Point(12, 244);
            this.szukanie.Name = "szukanie";
            this.szukanie.Size = new System.Drawing.Size(75, 23);
            this.szukanie.TabIndex = 4;
            this.szukanie.Text = "Wyszukaj";
            this.szukanie.UseVisualStyleBackColor = true;
            this.szukanie.Click += new System.EventHandler(this.szukanie_Click);
            // 
            // zmiana_słowa
            // 
            this.zmiana_słowa.Location = new System.Drawing.Point(154, 205);
            this.zmiana_słowa.Name = "zmiana_słowa";
            this.zmiana_słowa.Size = new System.Drawing.Size(100, 20);
            this.zmiana_słowa.TabIndex = 5;
            // 
            // zamiana
            // 
            this.zamiana.Location = new System.Drawing.Point(154, 244);
            this.zamiana.Name = "zamiana";
            this.zamiana.Size = new System.Drawing.Size(75, 23);
            this.zamiana.TabIndex = 6;
            this.zamiana.Text = "Zmień";
            this.zamiana.UseVisualStyleBackColor = true;
            this.zamiana.Click += new System.EventHandler(this.zamiana_Click);
            // 
            // zapis
            // 
            this.zapis.Location = new System.Drawing.Point(519, 38);
            this.zapis.Name = "zapis";
            this.zapis.Size = new System.Drawing.Size(75, 23);
            this.zapis.TabIndex = 7;
            this.zapis.Text = "Zapisz";
            this.zapis.UseVisualStyleBackColor = true;
            this.zapis.Click += new System.EventHandler(this.zapis_Click);
            // 
            // wyświetlanie_katalogu
            // 
            this.wyświetlanie_katalogu.FormattingEnabled = true;
            this.wyświetlanie_katalogu.Location = new System.Drawing.Point(12, 67);
            this.wyświetlanie_katalogu.Name = "wyświetlanie_katalogu";
            this.wyświetlanie_katalogu.Size = new System.Drawing.Size(124, 121);
            this.wyświetlanie_katalogu.TabIndex = 8;
            this.wyświetlanie_katalogu.SelectedIndexChanged += new System.EventHandler(this.wyświetlanie_katalogu_SelectedIndexChanged);
            // 
            // sprawdzanie_czy_zawiera
            // 
            this.sprawdzanie_czy_zawiera.Location = new System.Drawing.Point(387, 191);
            this.sprawdzanie_czy_zawiera.Multiline = true;
            this.sprawdzanie_czy_zawiera.Name = "sprawdzanie_czy_zawiera";
            this.sprawdzanie_czy_zawiera.Size = new System.Drawing.Size(100, 99);
            this.sprawdzanie_czy_zawiera.TabIndex = 9;
            this.sprawdzanie_czy_zawiera.Visible = false;
            // 
            // nazwy_plików
            // 
            this.nazwy_plików.FormattingEnabled = true;
            this.nazwy_plików.Location = new System.Drawing.Point(493, 205);
            this.nazwy_plików.Name = "nazwy_plików";
            this.nazwy_plików.Size = new System.Drawing.Size(120, 95);
            this.nazwy_plików.TabIndex = 10;
            this.nazwy_plików.Visible = false;
            // 
            // wyświetlenie_pliku
            // 
            this.wyświetlenie_pliku.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.wyświetlenie_pliku.Location = new System.Drawing.Point(201, 67);
            this.wyświetlenie_pliku.Name = "wyświetlenie_pliku";
            this.wyświetlenie_pliku.ReadOnly = true;
            this.wyświetlenie_pliku.Size = new System.Drawing.Size(393, 109);
            this.wyświetlenie_pliku.TabIndex = 11;
            this.wyświetlenie_pliku.Text = "";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.oProgramieToolStripMenuItem,
            this.pomocToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(625, 24);
            this.menuStrip1.TabIndex = 12;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // oProgramieToolStripMenuItem
            // 
            this.oProgramieToolStripMenuItem.Name = "oProgramieToolStripMenuItem";
            this.oProgramieToolStripMenuItem.Size = new System.Drawing.Size(86, 20);
            this.oProgramieToolStripMenuItem.Text = "O programie";
            this.oProgramieToolStripMenuItem.Click += new System.EventHandler(this.oProgramieToolStripMenuItem_Click);
            // 
            // pomocToolStripMenuItem
            // 
            this.pomocToolStripMenuItem.Name = "pomocToolStripMenuItem";
            this.pomocToolStripMenuItem.Size = new System.Drawing.Size(57, 20);
            this.pomocToolStripMenuItem.Text = "Pomoc";
            this.pomocToolStripMenuItem.Click += new System.EventHandler(this.pomocToolStripMenuItem_Click);
            // 
            // linie
            // 
            this.linie._SeeThroughMode_ = false;
            this.linie.AutoSizing = true;
            this.linie.BackgroundGradient_AlphaColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.linie.BackgroundGradient_BetaColor = System.Drawing.Color.LightSteelBlue;
            this.linie.BackgroundGradient_Direction = System.Drawing.Drawing2D.LinearGradientMode.Horizontal;
            this.linie.BorderLines_Color = System.Drawing.Color.SlateGray;
            this.linie.BorderLines_Style = System.Drawing.Drawing2D.DashStyle.Dot;
            this.linie.BorderLines_Thickness = 1F;
            this.linie.DockSide = LineNumbers.LineNumbers_For_RichTextBox.LineNumberDockSide.Left;
            this.linie.GridLines_Color = System.Drawing.Color.SlateGray;
            this.linie.GridLines_Style = System.Drawing.Drawing2D.DashStyle.Dot;
            this.linie.GridLines_Thickness = 1F;
            this.linie.LineNrs_Alignment = System.Drawing.ContentAlignment.TopRight;
            this.linie.LineNrs_AntiAlias = true;
            this.linie.LineNrs_AsHexadecimal = false;
            this.linie.LineNrs_ClippedByItemRectangle = true;
            this.linie.LineNrs_LeadingZeroes = true;
            this.linie.LineNrs_Offset = new System.Drawing.Size(0, 0);
            this.linie.Location = new System.Drawing.Point(183, 67);
            this.linie.Margin = new System.Windows.Forms.Padding(0);
            this.linie.MarginLines_Color = System.Drawing.Color.SlateGray;
            this.linie.MarginLines_Side = LineNumbers.LineNumbers_For_RichTextBox.LineNumberDockSide.Right;
            this.linie.MarginLines_Style = System.Drawing.Drawing2D.DashStyle.Solid;
            this.linie.MarginLines_Thickness = 1F;
            this.linie.Name = "linie";
            this.linie.Padding = new System.Windows.Forms.Padding(0, 0, 2, 0);
            this.linie.ParentRichTextBox = this.wyświetlenie_pliku;
            this.linie.Show_BackgroundGradient = true;
            this.linie.Show_BorderLines = true;
            this.linie.Show_GridLines = true;
            this.linie.Show_LineNrs = true;
            this.linie.Show_MarginLines = true;
            this.linie.Size = new System.Drawing.Size(17, 109);
            this.linie.TabIndex = 13;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(334, 38);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 14;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Zmieniacz
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(625, 302);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.linie);
            this.Controls.Add(this.wyświetlenie_pliku);
            this.Controls.Add(this.nazwy_plików);
            this.Controls.Add(this.sprawdzanie_czy_zawiera);
            this.Controls.Add(this.wyświetlanie_katalogu);
            this.Controls.Add(this.zapis);
            this.Controls.Add(this.zamiana);
            this.Controls.Add(this.zmiana_słowa);
            this.Controls.Add(this.szukanie);
            this.Controls.Add(this.wpisywanie_szukanej);
            this.Controls.Add(this.wybranie_katalogu);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Zmieniacz";
            this.Text = "Zmieniacz";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button wybranie_katalogu;
        private System.Windows.Forms.TextBox wpisywanie_szukanej;
        private System.Windows.Forms.Button szukanie;
        private System.Windows.Forms.TextBox zmiana_słowa;
        private System.Windows.Forms.Button zamiana;
        private System.Windows.Forms.Button zapis;
        private System.Windows.Forms.ListBox wyświetlanie_katalogu;
        private System.Windows.Forms.TextBox sprawdzanie_czy_zawiera;
        private System.Windows.Forms.ListBox nazwy_plików;
        private System.Windows.Forms.RichTextBox wyświetlenie_pliku;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem oProgramieToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pomocToolStripMenuItem;
        private LineNumbers.LineNumbers_For_RichTextBox linie;
        private System.Windows.Forms.Button button1;
    }
}

