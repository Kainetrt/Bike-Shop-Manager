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
using System.Windows.Shapes;

namespace Probleme
{
    /// <summary>
    /// Logique d'interaction pour ModuleStatistique.xaml
    /// </summary>
    public partial class ModuleStatistique : Window
    {
        List<Piece> listePiece = new List<Piece>();
        List<Velo> listeVelo = new List<Velo>();
        List<Fidelio> listeFidelio = new List<Fidelio>();
        List<Boutique> listeEntreprise = new List<Boutique>();
        List<Individu> listeClient = new List<Individu>();
        List<Commande> listeCommande = new List<Commande>();
        public ModuleStatistique()
        {
            this.DataContext = this;
            InitializeComponent();
            RequeteSQL sql = new RequeteSQL();
        }

        private void Selectionner(object sender, RoutedEventArgs e)
        {
            Fidelio f = ListViewFidelio.SelectedItem as Fidelio;
            if (f != null)
            {

            }
        }
    }
}
