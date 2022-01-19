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
    /// Logique d'interaction pour GestionFournisseur.xaml
    /// </summary>
    public partial class GestionFournisseur : Window
    {
        string reponseFournisseur;
        List<Fournisseur> listeFournisseur = new List<Fournisseur>();
        public GestionFournisseur()
        {
            this.DataContext = this;
            InitializeComponent();
            RequeteSQL sql = new RequeteSQL();

            reponseFournisseur = sql.SQL("SELECT * FROM probleme.fournisseur");

            if (reponseFournisseur != "")
            {
                string[] subFournisseur = reponseFournisseur.Split('\n');
                foreach (string sub in subFournisseur)
                {
                    string[] data = sub.Split('~');

                    Fournisseur f = new Fournisseur(Convert.ToInt32(data[0]), data[1], data[2],data[3], Convert.ToInt32(data[4]));
                    listeFournisseur.Add(f);
                }
                ListViewFournisseur.ItemsSource = listeFournisseur;
            }
        }

        private void Creer(object sender, RoutedEventArgs e)
        {
           FournisseurEditor w = new FournisseurEditor(new Fournisseur());
            w.Show();
            this.Close();
        }

        private void Supprimer(object sender, RoutedEventArgs e)
        {
            RequeteSQL sql = new RequeteSQL();
            Fournisseur f = ListViewFournisseur.SelectedItem as Fournisseur;
            if (f != null)
            {
                string requete = "DELETE FROM probleme.fournisseur WHERE siret=" + Convert.ToString(f.Siret);
                sql.SQLDELETE(requete);
            }

            List<Fournisseur> listeFournisseur = new List<Fournisseur>();
            reponseFournisseur = sql.SQL("SELECT * FROM probleme.fournisseur");
            if (reponseFournisseur != "")
            {
                string[] subsFournisseur = reponseFournisseur.Split('\n');
                foreach (string sub in subsFournisseur)
                {

                    string[] data = sub.Split('~');

                    Fournisseur f1 = new Fournisseur(Convert.ToInt32(data[0]), data[1], data[2], data[3], Convert.ToInt32(data[4]));
                    listeFournisseur.Add(f1);
                }
                ListViewFournisseur.ItemsSource = listeFournisseur;
            }
            else
            {
                ListViewFournisseur.ItemsSource = new List<Fournisseur>();
            }
        }

        private void ModifierEntreprise(object sender, RoutedEventArgs e)
        {
            Fournisseur f = ListViewFournisseur.SelectedItem as Fournisseur;
            FournisseurEditor w = new FournisseurEditor(f);
            w.Show();
            this.Close();
        }
    }
}
