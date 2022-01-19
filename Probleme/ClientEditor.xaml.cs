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
    /// Logique d'interaction pour ClientEditor.xaml
    /// </summary>
    public partial class ClientEditor : Window
    {
        public Individu cli;
        public ClientEditor(Individu cli)
        {
            this.cli = cli;
            this.DataContext = this;
            InitializeComponent();
            RequeteSQL sql = new RequeteSQL();

            if ((cli != null) && (cli.Nom != ""))
            {
                NomTextBox.Text = cli.Nom;
                PrenomTextBox.Text = cli.Prenom;
                AdresseTextBox.Text = cli.Adresse;
                TelephoneTextBox.Text = cli.Telephone;
                CourrielTextBox.Text = cli.Courriel;
                FidelioTextBox.Text = Convert.ToString(cli.Fidelio);
            }

            string reponseFidelio = sql.SQL("SELECT * FROM probleme.fidelio");
            List<Fidelio> listeFidelio = new List<Fidelio>();
            if (reponseFidelio != "")
            {
                string[] subsFidelio = reponseFidelio.Split('\n');
                foreach (string sub in subsFidelio)
                {
                    string[] data = sub.Split('~');

                    Fidelio f = new Fidelio(Convert.ToInt32(data[0]), data[1], Convert.ToDouble(data[2]), Convert.ToInt32(data[3]), Convert.ToDouble(data[4]));
                    listeFidelio.Add(f);
                }
                FidelioListView.ItemsSource = listeFidelio;
            }
        }

        private void Annuler(object sender, RoutedEventArgs e)
        {
            GestionClientEntrprise w = new GestionClientEntrprise();
            w.Show();
            this.Close();
        }

        private void Valider(object sender, RoutedEventArgs e)
        {
            string requete;
            RequeteSQL sql = new RequeteSQL();
            if ((cli != null) && (cli.Nom != ""))
            {
                requete = "DELETE FROM probleme.individu WHERE nom='" + Convert.ToString(cli.Nom)+"' AND prenom='"+ Convert.ToString(cli.Prenom)+"'";
                sql.SQLDELETE(requete);
            }

            if ((NomTextBox.Text != "") && (PrenomTextBox.Text != "") && (AdresseTextBox.Text != "") && (TelephoneTextBox.Text != "") && (CourrielTextBox.Text != "") && (FidelioTextBox.Text != ""))
            {
                requete = "INSERT INTO `probleme`.`individu` (`nom`,`prenom`,`adresse`,`telephone`,`courriel`,`fidelioNumero`) VALUES ('" + NomTextBox.Text + "','" + PrenomTextBox.Text + "','" + AdresseTextBox.Text + "','" + TelephoneTextBox.Text + "','" + CourrielTextBox.Text + "','" + FidelioTextBox.Text + "');";
                sql.SQLINSERT(requete);
            }
            GestionClientEntrprise w = new GestionClientEntrprise();
            w.Show();
            this.Close();
        }
    }
}
