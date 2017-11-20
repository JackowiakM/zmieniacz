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
    class nowa : Kolor
    {
        public nowa(string nazwa_koloru, int nr_koloru)
        {
            nazwa_koloru = "";
            nr_koloru = 0;
        }
        //nowa ac = new nowa(b, z);
    }
    class Kolor
    {
        public string nazwa_koloru, b;
        public int nr_koloru, z ;
        nowa fafadf = new nowa(b, z);
        public Kolor(RichTextBox cały_box, string słowo, Color kolor)
        {
            int pozycja = cały_box.SelectionStart;
            string tekst = cały_box.Text;
            for (int zmienna_pętli = 0; ; )
            {
                int tekst_index = tekst.IndexOf(słowo, zmienna_pętli);
                if (tekst_index < 0) break;
                cały_box.SelectionStart = tekst_index;
                cały_box.SelectionLength = słowo.Length;
                cały_box.SelectionBackColor = kolor;
                zmienna_pętli = tekst_index + 1;
            }
            cały_box.SelectionStart = pozycja;
            cały_box.SelectionLength = 0;
        }
        public Kolor(){ }
    }
    class linie : Kolor
    {
        public linie(string nowa_ścieżka, RichTextBox wyświetlenie_pliku) : base()
        {
            wyświetlenie_pliku.Text = File.ReadAllText(nowa_ścieżka);
            string[] linie = wyświetlenie_pliku.Lines;
            for (int i = 0; i < linie.Length; i++)
            {
                linie[i] = " " + linie[i];
            }
            wyświetlenie_pliku.Lines = linie;
        }
        ~linie(){return;}
    }
}
