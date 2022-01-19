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
using System.Diagnostics;

namespace Probleme
{
    /// <summary>
    /// Logique d'interaction pour GestionCommande.xaml
    /// </summary>
    public partial class GestionCommande : Window
    {
        string reponseCommande;
        List<Commande> listeCommande = new List<Commande>();
        public GestionCommande()
        {
            this.DataContext = this;
            InitializeComponent();
            RequeteSQL sql = new RequeteSQL();
                
            reponseCommande = sql.SQL("SELECT * FROM probleme.commande");

            if (reponseCommande != "")
            {
                string[] subCommande = reponseCommande.Split('\n');
                foreach (string sub in subCommande)
                {
                    string[] data = sub.Split('~');

                    Commande c = new Commande(Convert.ToInt32(data[0]),Convert.ToDateTime(data[3]),data[4], Convert.ToDateTime(data[5]));
                    listeCommande.Add(c);
                }
                ListViewCommande.ItemsSource = listeCommande;
            }
        }

        private void AjouterCommande(object sender, RoutedEventArgs e)
        {
            CommandeEditor w = new CommandeEditor(new Commande());
            w.Show();
            this.Close();
        }

        private void SupprimerCommande(object sender, RoutedEventArgs e)
        {
            RequeteSQL sql = new RequeteSQL();
            Commande c = ListViewCommande.SelectedItem as Commande;
            if (c != null)
            {
                string requete = "DELETE FROM probleme.commande WHERE numero=" + Convert.ToString(c.Numero);
                sql.SQLDELETE(requete);
            }

            List<Piece> listePiece = new List<Piece>();
            reponseCommande = sql.SQL("SELECT * FROM probleme.commande");
            if (reponseCommande != "")
            {
                string[] subsCommande = reponseCommande.Split('\n');
                foreach (string sub in subsCommande)
                {
                    
                    string[] data = sub.Split('~');
                    Debug.WriteLine("  ");
                    Debug.WriteLine(data[3]);
                    Debug.WriteLine(data[5]);
                    Debug.WriteLine("  ");

                    //DateDebutTextBox.Text).Date.ToString("yyyy-MM-dd")

                    Commande c1 = new Commande(Convert.ToInt32(data[0]),Convert.ToDateTime(data[3]),data[4],Convert.ToDateTime(data[5]));
                    listeCommande.Add(c1);
                }
                ListViewCommande.ItemsSource = listeCommande;
            }
            else
            {
                ListViewCommande.ItemsSource = new List<Commande>();
            }

        }

        private void ModifierCommande(object sender, RoutedEventArgs e)
        {
            Commande c = ListViewCommande.SelectedItem as Commande;
            CommandeEditor w = new CommandeEditor(c);
            w.Show();
            this.Close();
        }
    }
}
