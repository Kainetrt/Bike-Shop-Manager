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
    /// Logique d'interaction pour CommandeEditor.xaml
    /// </summary>
    public partial class CommandeEditor : Window
    {
        string reponsePiece;
        string reponseVelo;
        public Commande com;
        List<Piece> listePiece = new List<Piece>();
        List<Velo> listeVelo = new List<Velo>();

        public CommandeEditor(Commande com)
        {
            this.com = com;
            listePiece = new List<Piece>();
            listeVelo = new List<Velo>();
            this.DataContext = this;
            InitializeComponent();
            RequeteSQL sql = new RequeteSQL();

            if ((com != null) && (com.Numero != -1))
            {
                NumeroTextBox.Text = Convert.ToString(com.Numero);
                dateCommandeTextBox.Text = Convert.ToString(com.DateCommande);
                dateLivraisonTextBox.Text = Convert.ToString(com.DateLivraison);
                AdresseTextBox.Text = com.Adresse;

                reponsePiece = sql.SQL("SELECT numeroPiece FROM probleme.commande WHERE numero=" + com.Numero);

                if (reponsePiece != "~")
                {
                    string[] tabPiece = reponsePiece.Remove(reponsePiece.Length - 1).Split(';');
                    foreach (string num in tabPiece)
                    {
                        Piece p = new Piece(Convert.ToInt32(num));
                        listePiece.Add(p);
                    }
                    ListViewPiece.ItemsSource = listePiece;
                }

                reponseVelo = sql.SQL("SELECT numeroVelo FROM probleme.commande WHERE numero=" + com.Numero);
                Debug.WriteLine(reponseVelo);
                if (reponseVelo != "~")
                {
                    string[] tabVelo = reponseVelo.Remove(reponseVelo.Length - 1).Split(';');
                    foreach (string num in tabVelo)
                    {
                        Velo v = new Velo(Convert.ToInt32(num));
                        listeVelo.Add(v);
                    }
                    ListViewVelo.ItemsSource = listeVelo;
                }
            }
            else
            {
                AjouterPieceButton.IsEnabled = false;
                AjouterVeloButton.IsEnabled = false;
            }

            
        }

        private void Valider(object sender, RoutedEventArgs e)
        {
            string requete;
            string numvel;
            string numpie;
            RequeteSQL sql = new RequeteSQL();

            requete = "SELECT numeroPiece FROM probleme.commande WHERE numero=" + Convert.ToString(com.Numero);
            numpie = sql.SQL(requete);
            Debug.WriteLine("Piece");
            Debug.WriteLine(numpie);
            if (numpie != "")
            {
                numpie = numpie.Remove(numpie.Length - 1);
            }
            requete = "SELECT numeroVelo FROM probleme.commande WHERE numero=" + Convert.ToString(com.Numero);
            numvel = sql.SQL(requete);
            if (numvel != "")
            {
                numvel = numvel.Remove(numvel.Length - 1);
            }
            Debug.WriteLine("Velo");
            Debug.WriteLine(numvel);
            
            if ((com != null) && (com.Numero != -1))
            {
                requete = "DELETE FROM probleme.commande WHERE numero=" + Convert.ToString(com.Numero);
                sql.SQLDELETE(requete);
            }

            if ((NumeroTextBox.Text != "") && (dateCommandeTextBox.Text != "") && (AdresseTextBox.Text != "") && (dateLivraisonTextBox.Text != ""))
            {
                requete = "INSERT INTO `probleme`.`commande` (`numero`,`numeroPiece`,`numeroVelo`,`dateCommande`,`adresse`,`dateLivraison`) VALUES ('" + NumeroTextBox.Text + "','"+ numpie+ "','" + numvel+ "','" + Convert.ToDateTime(dateCommandeTextBox.Text).Date.ToString("yyyy-MM-dd") + "','" + AdresseTextBox.Text + "','" + Convert.ToDateTime(dateLivraisonTextBox.Text).Date.ToString("yyyy-MM-dd") + "');";
                sql.SQLINSERT(requete);
            }
            GestionCommande w = new GestionCommande();
            w.Show();
            this.Close();
        }

        private void Annuler(object sender, RoutedEventArgs e)
        {
            GestionCommande w = new GestionCommande();
            w.Show();
            this.Close();
        }

        private void Supprimer(object sender, RoutedEventArgs e)
        {
            string requete;
            string reponseCommande;
            RequeteSQL sql = new RequeteSQL();

            if (ListViewPiece.SelectedItem != null)
            {
                Piece p0 = ListViewPiece.SelectedItem as Piece;
                string numeroPiece =Convert.ToString(p0.Numero);

                requete = "SELECT numeroPiece from probleme.commande WHERE numero="+Convert.ToString(com.Numero);
                reponseCommande=sql.SQL(requete);

                if (reponseCommande != "")
                {
                    string[] tabpiece = reponseCommande.Remove(reponseCommande.Length - 1).Split(';');
                    string text = convertListe(tabpiece, numeroPiece);
                    if (tabpiece.Length <= 1)
                    {
                        text = "";
                    }
                    Debug.WriteLine(text);
                    requete = "UPDATE probleme.commande SET numeroPiece = '"+text+"' WHERE numero = "+com.Numero;
                    sql.SQLINSERT(requete);
                }

                List<Piece> listePiece2 = new List<Piece>();
                reponsePiece = sql.SQL("SELECT numeroPiece FROM probleme.commande WHERE numero=" + com.Numero);
                if (reponsePiece != "~")
                {
                    string[] tabPiece = reponsePiece.Remove(reponsePiece.Length - 1).Split(';');
                    foreach (string num in tabPiece)
                    {
                        Piece p = new Piece(Convert.ToInt32(num));
                        listePiece2.Add(p);
                    }
                }
                else
                {
                    listePiece2 = new List<Piece>();
                }
                ListViewPiece.ItemsSource = listePiece2;

            }
            else
            {
                if (ListViewVelo.SelectedItem != null)
                {
                    Velo v0 = ListViewVelo.SelectedItem as Velo;
                    string numeroVelo = Convert.ToString(v0.Numero);
                    Debug.WriteLine(numeroVelo);
                    requete = "SELECT numeroVelo from probleme.commande WHERE numero=" + Convert.ToString(com.Numero);
                    reponseCommande = sql.SQL(requete);

                    if (reponseCommande != "")
                    {
                        string[] tabvelo = reponseCommande.Remove(reponseCommande.Length - 1).Split(';');
                        string text = convertListe(tabvelo, numeroVelo);
                        if (tabvelo.Length <= 1)
                        {
                            text = "";
                        }
                        
                        requete = "UPDATE probleme.commande SET numeroVelo='" + text + "' WHERE numero=" + com.Numero;
                        sql.SQLINSERT(requete);
                    }

                    List<Velo> listeVelo2 = new List<Velo>();
                    reponseVelo = sql.SQL("SELECT numeroVelo FROM probleme.commande WHERE numero=" + com.Numero);
                    if (reponseVelo != "~")
                    {
                        string[] tabVelo = reponseVelo.Remove(reponseVelo.Length - 1).Split(';');
                        foreach (string num in tabVelo)
                        {
                            Velo v = new Velo(Convert.ToInt32(num));
                            listeVelo2.Add(v);
                        }
                    }
                    else
                    {
                        listeVelo2 = new List<Velo>();
                    }
                    ListViewVelo.ItemsSource = listeVelo2;
                }
            }
        }

        private void AjouterPiece(object sender, RoutedEventArgs e)
        {
            if (NumeroPieceTextBox.Text != "")
            {
                string numpie = NumeroPieceTextBox.Text;
                string requete;
                string reponseCommande;
                RequeteSQL sql = new RequeteSQL();

                requete = "SELECT numeroPiece from probleme.commande WHERE numero=" + Convert.ToString(com.Numero);
                reponseCommande = sql.SQL(requete);
                string[] tabpiece = reponseCommande.Remove(reponseCommande.Length - 1).Split(';');
                string text = convertString(tabpiece) + numpie;

                requete = "UPDATE probleme.commande SET numeroPiece = '" + text + "' WHERE numero = " + com.Numero;
                sql.SQLINSERT(requete);

                List<Piece> listePiece2 = new List<Piece>();
                reponsePiece = sql.SQL("SELECT numeroPiece FROM probleme.commande WHERE numero=" + com.Numero);
                string[] tabPiece = reponsePiece.Remove(reponsePiece.Length - 1).Split(';');
                foreach (string num in tabPiece)
                {
                    Debug.WriteLine(num);
                    Piece p = new Piece(Convert.ToInt32(num));
                    listePiece2.Add(p);
                }
                ListViewPiece.ItemsSource = listePiece2;
            }
        }

        private void AjouterVelo(object sender, RoutedEventArgs e)
        {
            if (NumeroVeloTextBox.Text != "")
            {
                string numvel = NumeroVeloTextBox.Text;
                string requete;
                string reponseCommande;
                RequeteSQL sql = new RequeteSQL();

                requete = "SELECT numeroVelo from probleme.commande WHERE numero=" + Convert.ToString(com.Numero);
                reponseCommande = sql.SQL(requete);
                string[] tabvelo = reponseCommande.Remove(reponseCommande.Length - 1).Split(';');
                string text = convertString(tabvelo) + numvel;

                requete = "UPDATE probleme.commande SET numeroVelo = '" + text + "' WHERE numero = " + com.Numero;
                sql.SQLINSERT(requete);

                List<Velo> listeVelo2 = new List<Velo>();
                reponseVelo = sql.SQL("SELECT numeroVelo FROM probleme.commande WHERE numero=" + com.Numero);
                string[] tabVelo = reponseVelo.Remove(reponseVelo.Length - 1).Split(';');
                foreach (string num in tabVelo)
                {
                    Debug.WriteLine(num);
                    Velo v = new Velo(Convert.ToInt32(num));
                    listeVelo2.Add(v);
                }
                ListViewVelo.ItemsSource = listeVelo2;
            }   
        }

        public string convertListe(string[] liste, string toRemove = "")
        {
            List<string> listeNew = new List<string>();
            string text = "";
            int compteur = 0;
            if (liste.Length > 1)
            {
                if (toRemove != "")
                {
                    foreach (string sub in liste)
                    {
                        if ((sub != toRemove)||(compteur==1))
                        {
                            listeNew.Add(sub);
                        }
                        else
                        {
                            compteur++;
                        }
                    }
                }
                foreach (string sub in listeNew)
                {
                    text = text + sub + ";";
                }
                text = text.Remove(text.Length - 1);
            }
            return text;
        }

        public string convertString(string[] liste)
        {
            string text = "";
            if (liste.Length > 1)
            {
                foreach (string s in liste)
                {
                    text = text + s + ";";
                }
            }
            return text;
        }
    }
}
