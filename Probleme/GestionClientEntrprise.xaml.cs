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
    /// Logique d'interaction pour GestionClientEntrprise.xaml
    /// </summary>
    /// 
    public partial class GestionClientEntrprise : Window
    {
        string reponseClient;
        string reponseEntreprise;
        List<Individu> listeClient = new List<Individu>();
        List<Boutique> listeEntreprise = new List<Boutique>();

        public GestionClientEntrprise()
        {
            this.DataContext = this;
            InitializeComponent();
            RequeteSQL sql = new RequeteSQL();

            reponseClient = sql.SQL("SELECT * FROM probleme.individu");
            if (reponseClient != "")
            {
                string[] subClient = reponseClient.Split('\n');
                foreach (string sub in subClient)
                {
                    string[] data = sub.Split('~');

                    Individu i = new Individu(data[0],data[1],data[2],data[3],data[4],Convert.ToInt32(data[5]));
                    listeClient.Add(i);
                }
                ListViewClient.ItemsSource = listeClient;
            }

            reponseEntreprise = sql.SQL("SELECT * FROM probleme.boutique");
            if (reponseEntreprise != "")
            {
                string[] subsEntreprise = reponseEntreprise.Split('\n');
                foreach (string sub in subsEntreprise)
                {
                    string[] data = sub.Split('~');

                    Boutique e = new Boutique(data[0],data[1],data[2],data[3],data[4],Convert.ToDouble(data[5]));
                    listeEntreprise.Add(e);
                }
                ListViewEntreprise.ItemsSource = listeEntreprise;
            }
        }

        private void Supprimer(object sender, RoutedEventArgs e)
        {
            string requete;
            RequeteSQL sql = new RequeteSQL();

            if (ListViewClient.SelectedItem != null)
            {
                Individu i = ListViewClient.SelectedItem as Individu;
                if (i != null)
                {
                    requete = "DELETE FROM probleme.individu WHERE nom='" + Convert.ToString(i.Nom)+"' AND prenom='"+ Convert.ToString(i.Prenom)+"'";
                    sql.SQLDELETE(requete);
                }

                List<Individu> listeClient= new List<Individu>();
                reponseClient = sql.SQL("SELECT * FROM probleme.individu");
                if (reponseClient != "")
                {
                    string[] subsClient = reponseClient.Split('\n');
                    foreach (string sub in subsClient)
                    {
                        string[] data = sub.Split('~');

                        Individu i1 = new Individu(data[0], data[1], data[2], data[3], data[4], Convert.ToInt32(data[5]));
                        listeClient.Add(i1);
                    }
                    ListViewClient.ItemsSource = listeClient;
                }
                else
                {
                    ListViewClient.ItemsSource = new List<Individu>();
                }

            }
            else
            {
                if (ListViewEntreprise.SelectedItem != null)
                {
                    Boutique e0 = ListViewEntreprise.SelectedItem as Boutique;
                    if (e0 != null)
                    {
                        requete = "DELETE FROM probleme.boutique WHERE nom='" + Convert.ToString(e0.Nom) + "' AND adresse='" + Convert.ToString(e0.Adresse) + "'";
                        sql.SQLDELETE(requete);
                    }

                    List<Boutique> listeEntreprise = new List<Boutique>();
                    reponseEntreprise = sql.SQL("SELECT * FROM probleme.boutique");
                    if (reponseEntreprise != "")
                    {
                        string[] subsEntreprise = reponseEntreprise.Split('\n');
                        foreach (string sub in subsEntreprise)
                        {
                            string[] data = sub.Split('~');

                            Boutique e1 = new Boutique(data[0], data[1], data[2], data[3], data[4], Convert.ToInt32(data[5]));
                            listeEntreprise.Add(e1);
                        }
                        ListViewEntreprise.ItemsSource = listeEntreprise;
                    }
                    else
                    {
                        ListViewEntreprise.ItemsSource = new List<Boutique>();
                    }

                }
            }
        }

        private void Modifier(object sender, RoutedEventArgs e)
        {
            if (ListViewClient.SelectedItem != null)
            {
                Individu i0 = ListViewClient.SelectedItem as Individu;
                ClientEditor w = new ClientEditor(i0);
                w.Show();
                this.Close();
            }
            else
            {
                if (ListViewEntreprise.SelectedItem != null)
                {
                    Boutique e0 = ListViewEntreprise.SelectedItem as Boutique;
                    EntrepriseEditor w = new EntrepriseEditor(e0);
                    w.Show();
                    this.Close();
                }
            }
        }

        private void CreerClient(object sender, RoutedEventArgs e)
        {
            ClientEditor w = new ClientEditor(new Individu());
            w.Show();
            this.Close();
        }

        private void CreerEntreprise(object sender, RoutedEventArgs e)
        {
            EntrepriseEditor w = new EntrepriseEditor(new Boutique());
            w.Show();
            this.Close();
        }
    }
}
