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
using MySql.Data.MySqlClient;

namespace Probleme
{
    /// <summary>
    /// Logique d'interaction pour GestionPieceVelo.xaml
    /// </summary>
    public partial class GestionPieceVelo : Window
    {
        string reponsePiece;
        string reponseVelo;
        List<Piece> listePiece=new List<Piece>();
        List<Velo> listeVelo = new List<Velo>();
        public GestionPieceVelo()
        {
            this.DataContext = this;
            InitializeComponent();
            RequeteSQL sql = new RequeteSQL();

            reponsePiece = sql.SQL("SELECT * FROM probleme.piece");
            if (reponsePiece != "")
            {
                string[] subPiece = reponsePiece.Split('\n');
                foreach (string sub in subPiece)
                {
                    string[] data=sub.Split('~');

                    Piece p = new Piece(Convert.ToInt32(data[0]),data[4],data[10],Convert.ToInt32(data[9]),Convert.ToDouble(data[8]),Convert.ToDateTime(data[5]), Convert.ToDateTime(data[6]), Convert.ToDateTime(data[7]));
                    listePiece.Add(p);
                }
                ListViewPiece.ItemsSource = listePiece;
            }

            reponseVelo = sql.SQL("SELECT * FROM probleme.velo");
            if (reponseVelo!="")
            {
                string[] subsVelo = reponseVelo.Split('\n');
                foreach (string sub in subsVelo)
                {
                    string[] data = sub.Split('~');

                    Velo v = new Velo(Convert.ToInt32(data[0]), data[1], data[2], Convert.ToDouble(data[3]), data[4]);
                    listeVelo.Add(v);
                }

                ListViewVelo.ItemsSource = listeVelo;
            }
        }

        private void SupprimerVelo(object sender, RoutedEventArgs e)
        {
            Velo v = ListViewVelo.SelectedItem as Velo;
            RequeteSQL sql = new RequeteSQL();
            if (v != null)
            {
                string requete="DELETE FROM probleme.velo WHERE numero_modele="+Convert.ToString(v.Numero);
                sql.SQLDELETE(requete);
            }

            List<Velo> listeVelo=new List<Velo>();
            reponseVelo = sql.SQL("SELECT * FROM probleme.velo");
            if (reponseVelo != "")
            {
                string[] subsVelo = reponseVelo.Split('\n');
                foreach (string sub in subsVelo)
                {
                    string[] data = sub.Split('~');

                    Velo v1 = new Velo(Convert.ToInt32(data[0]), data[1], data[2], Convert.ToDouble(data[3]), data[4]);
                    listeVelo.Add(v1);
                }
                ListViewVelo.ItemsSource = listeVelo;
            }
            else
            {
                ListViewVelo.ItemsSource = new List<Velo>();
            }
            
        }

        private void SupprimerPiece(object sender, RoutedEventArgs e)
        {
            RequeteSQL sql = new RequeteSQL();
            Piece p = ListViewPiece.SelectedItem as Piece;
            if (p != null)
            {
                string requete = "DELETE FROM probleme.piece WHERE numero=" + Convert.ToString(p.Numero);
                sql.SQLDELETE(requete);
            }

            List<Piece> listePiece = new List<Piece>();
            reponsePiece = sql.SQL("SELECT * FROM probleme.piece");
            if (reponsePiece != "")
            {
                string[] subsPiece = reponsePiece.Split('\n');
                foreach (string sub in subsPiece)
                {
                    string[] data = sub.Split('~');

                    Piece p1 = new Piece(Convert.ToInt32(data[0]), data[4], data[10], Convert.ToInt32(data[9]), Convert.ToDouble(data[8]), Convert.ToDateTime(data[5]), Convert.ToDateTime(data[6]), Convert.ToDateTime(data[7]));
                    listePiece.Add(p1);
                }
                ListViewPiece.ItemsSource = listePiece;
            }
            else
            {
                ListViewPiece.ItemsSource = new List<Piece>();
            }
        }

        private void AjouterVelo(object sender, RoutedEventArgs e)
        {
            VeloEditor w = new VeloEditor(new Velo());
            w.Show();
            this.Close();
        }

        private void ModifierVelo(object sender, RoutedEventArgs e)
        {
            Velo v = ListViewVelo.SelectedItem as Velo;
            VeloEditor w = new VeloEditor(v);
            w.Show();
            this.Close();
        }

        private void ModifierPiece(object sender, RoutedEventArgs e)
        {
            Piece p = ListViewPiece.SelectedItem as Piece;
            PieceEditor w = new PieceEditor(p);
            w.Show();
            this.Close();
        }

        private void AjouterPiece(object sender, RoutedEventArgs e)
        {
            PieceEditor w = new PieceEditor(new Piece());
            w.Show();
            this.Close();
        }
    }
}
