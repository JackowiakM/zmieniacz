using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Diagnostics;

namespace Projekt
{
    public partial class Zmieniacz : Form
    {
        public Zmieniacz()
        {
            InitializeComponent();
        }
        public int z;
        public string b;
        public int ilość_plików, rozmiar_tablicy = 1, czy_znaleziono = 0, liczba_zero = 0, liczba_jeden = 1;
        protected string[] tablica_do_przechowywania = new string[1000];
        public string ścieżka="", szukana, czy_zawiera, ścieżka_do_zapisu, dodawanie_do_listbox;
        private bool czy_zawiera_bool;
        public void wybranie_katalogu_Click(object sender, EventArgs e)
        {
            nowa abc = new nowa(b, z);
            FolderBrowserDialog ścieżka_katalogu = new FolderBrowserDialog();
            if (ścieżka_katalogu.ShowDialog() == DialogResult.OK)
            {
                wyświetlanie_katalogu.Items.Clear();
                string[] pliki = Directory.GetFiles(ścieżka_katalogu.SelectedPath, "*.txt");
                MessageBox.Show("Wybrano katalog " + ścieżka_katalogu.SelectedPath);
                ścieżka = ścieżka_katalogu.SelectedPath;
                foreach (string plik in pliki)
                {
                    nazwy_plików.Items.Add(Path.GetFileName(plik));
                    tablica_do_przechowywania[rozmiar_tablicy] = plik;
                    rozmiar_tablicy++;
                    ilość_plików++;
                }
            }
        }

        public void szukanie_Click(object sender, EventArgs e)
        {
            string do_stringa;
            rozmiar_tablicy = 1;
            szukana = wpisywanie_szukanej.Text;
            try
            {
                if(ścieżka=="")
                {
                    int podzielone_przez = liczba_jeden / liczba_zero;
                }
            }
            catch (DivideByZeroException)
            {
                MessageBox.Show("Nie wybrałeś katalogu.");
                return;
            }
            if(szukana=="")
            {
                MessageBox.Show("Nic nie podałeś. Podaj jeszcze raz.");
                return;
            }
            wyświetlanie_katalogu.Items.Clear();
            for(int i=1; i<=ilość_plików;i++)
            {
                sprawdzanie_czy_zawiera.Text = File.ReadAllText(tablica_do_przechowywania[rozmiar_tablicy]);
                czy_zawiera = sprawdzanie_czy_zawiera.Text;
                czy_zawiera_bool = czy_zawiera.Contains(szukana);
                do_stringa = czy_zawiera_bool.ToString();
                if(do_stringa=="True")
                {
                    czy_znaleziono++;
                    dodawanie_do_listbox = tablica_do_przechowywania[rozmiar_tablicy];
                    dodawanie_do_listbox = Path.GetFileName(dodawanie_do_listbox);
                    wyświetlanie_katalogu.Items.Add(dodawanie_do_listbox);
                }
                rozmiar_tablicy++;
            }
            if (czy_znaleziono == 0)
            {
                MessageBox.Show("Nie znaleziono plików z tym kluczem.");
            }
            else
            {
                MessageBox.Show("Znaleziono " + czy_znaleziono + " pliki.");
            }
            czy_znaleziono = 0;
        }

        public void wyświetlanie_katalogu_SelectedIndexChanged(object sender, EventArgs e)
        {
            string zaznaczony_element, nowa_ścieżka;
            zaznaczony_element = wyświetlanie_katalogu.GetItemText(wyświetlanie_katalogu.SelectedItem);
            ścieżka = ścieżka + @"\";
            nowa_ścieżka = ścieżka + zaznaczony_element;
            if(zaznaczony_element=="")
            {
                return;
            }
            linie liczby = new linie(nowa_ścieżka, wyświetlenie_pliku);
            Kolor słowa = new Kolor(wyświetlenie_pliku, szukana, Color.Red);
            ścieżka_do_zapisu = nowa_ścieżka;
        }

        public void zamiana_Click(object sender, EventArgs e)
        {
            string zmiana = zmiana_słowa.Text;
            if (ścieżka == "")
            {
                MessageBox.Show("Nie wybrałeś katalogu.");
                return;
            }
            if (wyświetlenie_pliku.Text == "")
            {
                MessageBox.Show("Nie wybrałeś pliku.");
                return;
            }
            if (zmiana == "")
            {
                MessageBox.Show("Nic nie podałeś. Podaj jeszcze raz.");
                return;
            }
            wyświetlenie_pliku.Text = wyświetlenie_pliku.Text.Replace(szukana, zmiana);
            MessageBox.Show("Zamieniono");
        }

        public void zapis_Click(object sender, EventArgs e)
        {
            try
            {
                if (ścieżka == "")
                {
                    int a = liczba_jeden / liczba_zero;
                }
            }
            catch (DivideByZeroException)
            {
                MessageBox.Show("Nie wybrałeś katalogu.");
                return;
            }
            if (szukana == "")
            {
                MessageBox.Show("Nic nie podałeś. Podaj jeszcze raz.");
                return;
            }
            if (wyświetlenie_pliku.Text == "")
            {
                MessageBox.Show("Nie wybrałeś pliku.");
                return;
            }
            StreamWriter zapis = new StreamWriter(ścieżka_do_zapisu);
            zapis.Write(wyświetlenie_pliku.Text);
            zapis.Close();
            MessageBox.Show("Zapisano");
        }

        public void oProgramieToolStripMenuItem_Click(object sender, EventArgs e)
        {
            O_Programie form = new O_Programie();
            form.Show();
        }

        private void pomocToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Help.ShowHelp(this, System.IO.Path.Combine(Application.StartupPath, "Pomoc.chm"));
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Chuj w dupe siwej");
        }    
    }
}