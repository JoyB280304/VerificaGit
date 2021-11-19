using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Verifica_Git
{
    class Biblioteca
    {
        private string _nome;
        private string _indirizzo;
        private string _apertura;
        private string _chiusura;
        private List<Libro> _listaLibri;

        public Biblioteca(string nome, string indirizzo, string apertura, string chiusura, List<Libro> libri)
        {
            Nome = nome;
            Indirizzo = indirizzo;
            Apertura = apertura;
            Chiusura = chiusura;
            _listaLibri = libri;
        }

        public string Nome
        {
            set { _nome = value; }

            get { return _nome; }
        }

        public string Indirizzo
        {
            set { _indirizzo = value; }

            get { return _indirizzo; }
        }

        public string Apertura
        {
            set { _apertura = value; }

            get { return _apertura; }
        }

        public string Chiusura
        {
            set { _chiusura = value; }

            get { return _chiusura; }
        }
    }
}