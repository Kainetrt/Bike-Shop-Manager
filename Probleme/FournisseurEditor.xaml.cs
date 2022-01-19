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
    /// Logique d'interaction pour FournisseurEditor.xaml
    /// </summary>
    public partial class FournisseurEditor : Window
    {
        public Fournisseur fou;
        public FournisseurEditor(Fournisseur fou)
        {
            this.fou = fou;
            this.DataContext = this;
            InitializeComponent();

            if ((fou != null) && (fou.Siret != -1))
            {
                SiretTextBox.Text = Convert.ToString(fou.Siret);
                NomEntrepriseTextBox.Text = fou.NomEntreprise;
                ContactTextBox.Text = fou.Contact;
                AdresseTextBox.Text = fou.Adresse;
                NoteTextBox.Text = Convert.ToString(fou.Note);
            }
        }

        private void Annuler(object sender, RoutedEventArgs e)
        {
            GestionFournisseur w = new GestionFournisseur();
            w.Show();
            this.Close();
        }

        private void Valider(object sender, RoutedEventArgs e)
        {
            string requete;
            RequeteSQL sql = new RequeteSQL();
            if ((fou != null) && (fou.Siret != -1))
            {
                requete = "DELETE FROM probleme.fournisseur WHERE siret=" + Convert.ToString(fou.Siret);
                sql.SQLDELETE(requete);
            }

            if ((SiretTextBox.Text != "") && (NomEntrepriseTextBox.Text != "") && (ContactTextBox.Text != "") && (AdresseTextBox.Text != "") && (NoteTextBox.Text != ""))
            {
                requete = "INSERT INTO `probleme`.`fournisseur` (`siret`,`nomEntreprise`,`contact`,`adresse`,`note`) VALUES ('" + SiretTextBox.Text + "','" + NomEntrepriseTextBox.Text + "','" + ContactTextBox.Text + "','" + AdresseTextBox.Text + "','" + NoteTextBox.Text + "');";
                sql.SQLINSERT(requete);
            }
            GestionFournisseur w = new GestionFournisseur();
            w.Show();
            this.Close();
        }
    }
}
