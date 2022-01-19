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
//using System.Text.Json;
using System.Text.Json.Serialization;
using System.IO;
using Newtonsoft.Json;
using System.Xml;

namespace Probleme
{
    /// <summary>
    /// Logique d'interaction pour Export.xaml
    /// </summary>
    public partial class Export : Window
    {
        RequeteSQL sql = new RequeteSQL();
        public Export()
        {
            InitializeComponent();
            LabelJASON.Visibility = Visibility.Hidden;
            LabelXML.Visibility = Visibility.Hidden;
        }

        private void XML(object sender, RoutedEventArgs e)
        {
            LabelXML.Visibility = Visibility.Visible;
        }

        private void JSONEXPORTATION(object sender, RoutedEventArgs e)
        {
            LabelJASON.Visibility = Visibility.Visible;
            List<Individu> listeClient = new List<Individu>();
            List<Piece> listePiece = new List<Piece>();
            List<Boutique> listeEntreprise = new List<Boutique>();
            List<Fidelio> listeFidelio = new List<Fidelio>();
            List<Velo> listeVelo = new List<Velo>();
            List<Fournisseur> listeFournisseur = new List<Fournisseur>();
            List<Commande> listeCommande = new List<Commande>();

            string reponseClient = sql.SQL("SELECT * FROM probleme.individu");
            if (reponseClient != "")
            {
                string[] subClient = reponseClient.Split('\n');
                foreach (string sub in subClient)
                {
                    string[] data = sub.Split('~');

                    Individu i = new Individu(data[0], data[1], data[2], data[3], data[4], Convert.ToInt32(data[5]));
                    listeClient.Add(i);
                }
            }

            string reponsePiece = sql.SQL("SELECT * FROM probleme.piece");
            if (reponseClient != "")
            {
                string[] subPiece = reponsePiece.Split('\n');
                foreach (string sub in subPiece)
                {
                    string[] data = sub.Split('~');

                    Piece p = new Piece(Convert.ToInt32(data[0]), data[4], data[10], Convert.ToInt32(data[9]), Convert.ToDouble(data[8]),Convert.ToDateTime(data[5]), Convert.ToDateTime(data[6]),Convert.ToDateTime(data[7]),data[1],data[2],Convert.ToInt32(data[3]));
                    listePiece.Add(p);
                }
            }

            string reponseEntreprise = sql.SQL("SELECT * FROM probleme.boutique");
            if (reponseEntreprise != "")
            {
                string[] subEntreprise = reponseEntreprise.Split('\n');
                foreach (string sub in subEntreprise)
                {
                    string[] data = sub.Split('~');

                    Boutique b = new Boutique(data[0], data[1], data[2], data[3], data[4], Convert.ToDouble(data[5]));
                    listeEntreprise.Add(b);
                }
            }

            string reponseFidelio = sql.SQL("SELECT * FROM probleme.fidelio");
            if (reponseFidelio != "")
            {
                string[] subFidelio = reponseFidelio.Split('\n');
                foreach (string sub in subFidelio)
                {
                    string[] data = sub.Split('~');

                    Fidelio f = new Fidelio(Convert.ToInt32(data[0]), data[1], Convert.ToDouble(data[2]), Convert.ToInt32(data[3]), Convert.ToDouble(data[4]));
                    listeFidelio.Add(f);
                }
            }

            string reponseVelo = sql.SQL("SELECT * FROM probleme.velo");
            if (reponseVelo != "")
            {
                string[] subVelo = reponseVelo.Split('\n');
                foreach (string sub in subVelo)
                {
                    string[] data = sub.Split('~');

                    Velo v = new Velo(Convert.ToInt32(data[0]), data[1],data[2], Convert.ToDouble(data[3]),data[4],Convert.ToInt32(data[5]));
                    listeVelo.Add(v);
                }
            }

            string reponseFournisseur = sql.SQL("SELECT * FROM probleme.fournisseur");
            if (reponseFournisseur != "")
            {
                string[] subFournisseur = reponseFournisseur.Split('\n');
                foreach (string sub in subFournisseur)
                {
                    string[] data = sub.Split('~');

                    Fournisseur f = new Fournisseur(Convert.ToInt32(data[0]), data[1], data[2], data[3], Convert.ToInt32(data[4]));
                    listeFournisseur.Add(f);
                }
            }

            string reponseCommande = sql.SQL("SELECT * FROM probleme.commande");
            if (reponseCommande != "")
            {
                string[] subCommande = reponseCommande.Split('\n');
                foreach (string sub in subCommande)
                {
                    string[] data = sub.Split('~');

                    Commande c = new Commande(Convert.ToInt32(data[0]), data[1], data[2], Convert.ToDateTime(data[3]),data[4], Convert.ToDateTime(data[5]));
                    listeCommande.Add(c);
                }
            }

            using (StreamWriter file = File.CreateText(@"C:\Users\alan7\Documents\Cours\BDD\Probleme\Probleme\JASON\individu.json"))
            {
                JsonSerializer serializer = new JsonSerializer();
                serializer.Serialize(file, listeClient);
            }

            using (StreamWriter file = File.CreateText(@"C:\Users\alan7\Documents\Cours\BDD\Probleme\Probleme\JASON\piece.json"))
            {
                JsonSerializer serializer = new JsonSerializer();
                serializer.Serialize(file, listePiece);
            }

            using (StreamWriter file = File.CreateText(@"C:\Users\alan7\Documents\Cours\BDD\Probleme\Probleme\JASON\boutique.json"))
            {
                JsonSerializer serializer = new JsonSerializer();
                serializer.Serialize(file, listeEntreprise);
            }

            using (StreamWriter file = File.CreateText(@"C:\Users\alan7\Documents\Cours\BDD\Probleme\Probleme\JASON\fidelio.json"))
            {
                JsonSerializer serializer = new JsonSerializer();
                serializer.Serialize(file, listeFidelio);
            }

            using (StreamWriter file = File.CreateText(@"C:\Users\alan7\Documents\Cours\BDD\Probleme\Probleme\JASON\velo.json"))
            {
                JsonSerializer serializer = new JsonSerializer();
                serializer.Serialize(file, listeVelo);
            }

            using (StreamWriter file = File.CreateText(@"C:\Users\alan7\Documents\Cours\BDD\Probleme\Probleme\JASON\fournisseur.json"))
            {
                JsonSerializer serializer = new JsonSerializer();
                serializer.Serialize(file, listeFournisseur);
            }

            using (StreamWriter file = File.CreateText(@"C:\Users\alan7\Documents\Cours\BDD\Probleme\Probleme\JASON\commande.json"))
            {
                JsonSerializer serializer = new JsonSerializer();
                serializer.Serialize(file, listeCommande);
            }
        }
    }
}
