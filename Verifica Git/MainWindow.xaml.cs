using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Verifica_Git
{
    /// <summary>
    /// Logica di interazione per MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private List<Libro> _libri;
        private Biblioteca _biblioteca;

        public MainWindow()
        {
            InitializeComponent();
            _libri = new List<Libro>();
            _biblioteca = new Biblioteca("nome", "indirizzo", "8:00", "20:00", _libri);
            RiempiLista();
        }


        private void btnAdd_Click(object sender, RoutedEventArgs e)
        {
            Libro l = new Libro(txbTitolo.Text, txbAutore.Text, txbEditore.Text, int.Parse(txbPagine.Text), int.Parse(txbEditore.Text));

            _libri.Add(l);
        }

        public void RiempiLista(List<Libro> lista)
        {
            foreach (Libro libro in lista)
            {
                lsbLibri.Items.Add(libro);
            }
        }
    }
}
