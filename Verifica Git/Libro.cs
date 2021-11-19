using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Verifica_Git
{
    class Libro
    {
        private string _titolo;
        private string _autore;
        private string _editore;
        private int _pagine;
        private int _anno;

        public Libro(string titolo, string autore, string editore, int pagine, int anno)
        {
            Titolo = titolo;
            Autore = autore;
            Editore = editore;
            Pagine = pagine;
            Anno = anno;
        }

        public string Titolo
        {
            set { _titolo = value; }

            get { return _titolo; }
        }

        public string Autore
        {
            set { _autore = value; }

            get { return _autore; }
        }

        public string Editore
        {
            set { _editore = value; }

            get { return _editore; }
        }

        public int Pagine
        {
            set { _pagine = value; }

            get { return _pagine; }
        }

        public int Anno
        {
            set { _anno = value; }

            get { return _anno; }
        }

        public int readingTime(int pagine)
        {
            if (pagine < 100)
            {
                return 1;
            }
            else if (pagine >= 100 && pagine <= 200)
            {
                return 2;
            }
            else if (pagine > 200)
            {
                return 3;
            }

            return 0;
        }

        public override string ToString()
        {
            return Titolo + " " + Autore + " " + Editore + " " + Pagine + " " + Anno;
        }
    }
}
