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
    /// Logique d'interaction pour GestionStock.xaml
    /// </summary>
    /// 
    public partial class GestionStock : Window
    {
        List<Piece> listePiece = new List<Piece>();
        List<Velo> listeVelo = new List<Velo>();
        RequeteSQL sql = new RequeteSQL();
        string requete;
        string reponse;
        public GestionStock()
        {
            listePiece = new List<Piece>();
            listeVelo = new List<Velo>();
            this.DataContext = this;
            InitializeComponent();
            RequeteSQL sql = new RequeteSQL();
            string reponsePiece;
            string reponseVelo;

            reponsePiece = sql.SQL("SELECT * FROM probleme.piece");
            if (reponsePiece != "")
            {
                string[] subPiece = reponsePiece.Split('\n');
                foreach (string sub in subPiece)
                {
                    string[] data = sub.Split('~');

                    Piece p = new Piece(Convert.ToInt32(data[0]),data[2],Convert.ToInt32(data[3]));
                    listePiece.Add(p);
                }
                ListViewPiece.ItemsSource = listePiece;
            }

            reponseVelo = sql.SQL("SELECT * FROM probleme.velo");
            if (reponseVelo != "")
            {
                string[] subsVelo = reponseVelo.Split('\n');
                foreach (string sub in subsVelo)
                {
                    string[] data = sub.Split('~');

                    Velo v = new Velo(Convert.ToInt32(data[0]), data[1], Convert.ToInt32(data[5]));
                    listeVelo.Add(v);
                }

                ListViewVelo.ItemsSource = listeVelo;
            }
        }

        private void PieceTriPiece(object sender, RoutedEventArgs e)
        {
            requete = "SELECT * FROM probleme.piece WHERE referenceNom='"+SearchTextBox.Text+"'";
            ListViewPieceUpdate(sql.SQL(requete));
        }

        private void FournisseurTriPiece(object sender, RoutedEventArgs e)
        {
            //requete = SearchTextBox.Text;
            //ListViewPieceUpdate(sql.SQL(requete));
        }

        private void VeloTriPiece(object sender, RoutedEventArgs e)
        {
            requete = "SELECT p.numero,p.nomType,p.referenceNom,p.quantite,p.descriptions,p.dateDebut,p.dateFin,p.approvisionnement,p.prix,p.noFournisseur,p.nomFournisseur FROM probleme.piece p INNER JOIN probleme.assemblage a ON a.guidon = p.referenceNom OR a.cadre = p.referenceNom OR a.frein = p.referenceNom OR a.selle = p.referenceNom OR a.derailleur_avant = p.referenceNom OR a.derailleur_arriere = p.referenceNom OR a.roue_avant = p.referenceNom OR a.roue_arriere = p.referenceNom OR a.reflecteur = p.referenceNom OR a.pedalier = p.referenceNom OR a.ordinateur = p.referenceNom OR a.panier = p.referenceNom WHERE a.nom ='"+SearchTextBox+"'";
            ListViewPieceUpdate(sql.SQL(requete));
        }

        private void PrixTriPiece(object sender, RoutedEventArgs e)
        {
            requete = "SELECT * FROM probleme.piece WHERE prix>" + SearchTextBox.Text;
            ListViewPieceUpdate(sql.SQL(requete));
        }

        private void PieceTriVelo(object sender, RoutedEventArgs e)
        {
            requete = "SELECT v.numero_modele,v.nom,v.grandeur,v.prix,v.gamme,v.quantite FROM probleme.velo v INNER JOIN probleme.assemblage a ON a.nom=v.nom WHERE a.cadre='" + SearchTextBox.Text + "' OR a.guidon='" + SearchTextBox.Text + "' OR a.frein='" + SearchTextBox.Text + "' OR a.selle='" + SearchTextBox.Text + "' OR a.derailleur_avant='" + SearchTextBox.Text + "' OR a.derailleur_arriere='" + SearchTextBox.Text + "' OR a.roue_avant='" + SearchTextBox.Text + "' OR a.roue_arriere='" + SearchTextBox.Text + "' OR a.reflecteur='" + SearchTextBox.Text + "' OR a.pedalier='" + SearchTextBox.Text + "' OR a.ordinateur='" + SearchTextBox.Text + "' OR a.panier='" + SearchTextBox.Text + "'";
            ListViewVeloUpdate(sql.SQL(requete));
        }

        private void FournisseurTriVelo(object sender, RoutedEventArgs e)
        {
            //requete = SearchTextBox.Text;
            //ListViewVeloUpdate(sql.SQL(requete));
        }

        private void VeloTriVelo(object sender, RoutedEventArgs e)
        {
            requete = "SELECT * FROM probleme.velo WHERE nom='" + SearchTextBox.Text+"'";
            ListViewVeloUpdate(sql.SQL(requete));
        }

        private void CategorieTriVelo(object sender, RoutedEventArgs e)
        {
            requete = "SELECT * FROM probleme.velo WHERE gamme='" + SearchTextBox.Text + "'";
            ListViewVeloUpdate(sql.SQL(requete));
        }

        private void GrandeurTriVelo(object sender, RoutedEventArgs e)
        {
            requete = "SELECT * FROM probleme.velo WHERE grandeur='" + SearchTextBox.Text + "'";
            ListViewVeloUpdate(sql.SQL(requete));
        }

        private void PrixTriVelo(object sender, RoutedEventArgs e)
        {
            requete = "SELECT * FROM probleme.velo WHERE prix>" + SearchTextBox.Text;
            ListViewVeloUpdate(sql.SQL(requete));
        }

        private void ListViewVeloUpdate(string reponse)
        {
            if (reponse != "")
            {
                List<Velo> listeVelo = new List<Velo>();
                string[] subsVelo = reponse.Split('\n');
                foreach (string sub in subsVelo)
                {
                    string[] data = sub.Split('~');

                    Velo v = new Velo(Convert.ToInt32(data[0]), data[1], Convert.ToInt32(data[5]));
                    listeVelo.Add(v);
                }

                ListViewVelo.ItemsSource = listeVelo;
            }
        }

        private void ListViewPieceUpdate(string reponse)
        {
            if (reponse != "")
            {
                List<Piece> listePiece = new List<Piece>();
                string[] subPiece = reponse.Split('\n');
                foreach (string sub in subPiece)
                {
                    string[] data = sub.Split('~');

                    Piece p = new Piece(Convert.ToInt32(data[0]), data[2], Convert.ToInt32(data[3]));
                    listePiece.Add(p);
                }
                ListViewPiece.ItemsSource = listePiece;
            }
        }

        
    }
}
