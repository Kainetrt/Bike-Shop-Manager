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

namespace Probleme
{
    /// <summary>
    /// Logique d'interaction pour MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void GestionCommande(object sender, RoutedEventArgs e)
        {
            GestionCommande w = new GestionCommande();
            w.Show();
        }

        private void GestionFournisseur(object sender, RoutedEventArgs e)
        {
            GestionFournisseur w = new GestionFournisseur();
            w.Show();
        }

        private void GestionStock(object sender, RoutedEventArgs e)
        {
            GestionStock w = new GestionStock();
            w.Show();
        }

        private void ModuleStatistique(object sender, RoutedEventArgs e)
        {
            ModuleStatistique w = new ModuleStatistique();
            w.Show();
        }

        private void GestionPieceVelo(object sender, RoutedEventArgs e)
        {
            GestionPieceVelo w = new GestionPieceVelo();
            w.Show();
        }

        private void GestionClientEntrprise(object sender, RoutedEventArgs e)
        {
            GestionClientEntrprise w = new GestionClientEntrprise();
            w.Show();
        }

        private void Export(object sender, RoutedEventArgs e)
        {
            Export w = new Export();
            w.Show();
        }

        private void Demo(object sender, RoutedEventArgs e)
        {
            Demo w = new Demo();
            w.Show();
        }
    }
}
