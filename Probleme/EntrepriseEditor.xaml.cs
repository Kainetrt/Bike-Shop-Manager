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
    /// Logique d'interaction pour EntrepriseEditor.xaml
    /// </summary>
    public partial class EntrepriseEditor : Window
    {
        public Boutique ent;
        public EntrepriseEditor(Boutique ent)
        {
            this.ent = ent;
            this.DataContext = this;
            InitializeComponent();

            if ((ent != null) && (ent.Nom != ""))
            {
                NomTextBox.Text = ent.Nom;
                AdresseTextBox.Text = ent.Adresse;
                TelephoneTextBox.Text = ent.Telephone;
                CourrielTextBox.Text = ent.Courriel;
                ContactTextBox.Text = ent.NomContact;
                RemiseTextBox.Text = Convert.ToString(ent.Remise);
            }

        }

        private void Valider(object sender, RoutedEventArgs e)
        {
            string requete;
            RequeteSQL sql = new RequeteSQL();
            if ((ent != null) && (ent.Nom != ""))
            {
                requete = "DELETE FROM probleme.boutique WHERE nom='" + Convert.ToString(ent.Nom) + "' AND adresse='" + Convert.ToString(ent.Adresse) + "'";
                sql.SQLDELETE(requete);
            }

            if ((NomTextBox.Text != "") && (AdresseTextBox.Text != "") && (TelephoneTextBox.Text != "") && (CourrielTextBox.Text != "") && (ContactTextBox.Text != "") && (RemiseTextBox.Text != ""))
            {
                requete = "INSERT INTO `probleme`.`boutique` (`nom`,`adresse`,`telephone`,`courriel`,`nomContact`,`remise`) VALUES ('" + NomTextBox.Text + "','" + AdresseTextBox.Text + "','" + TelephoneTextBox.Text + "','" + CourrielTextBox.Text + "','" + ContactTextBox.Text + "','" + Convert.ToString(Convert.ToDouble(RemiseTextBox.Text)) + "');";
                sql.SQLINSERT(requete);
            }
            GestionClientEntrprise w = new GestionClientEntrprise();
            w.Show();
            this.Close();
        }

        private void Annuler(object sender, RoutedEventArgs e)
        {
            GestionClientEntrprise w = new GestionClientEntrprise();
            w.Show();
            this.Close();
        }
    }
}
