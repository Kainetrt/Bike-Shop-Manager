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
    /// Logique d'interaction pour PieceEditor.xaml
    /// </summary>
    public partial class PieceEditor : Window
    {
        public Piece pie;
        public PieceEditor(Piece pie)
        {
            this.pie = pie;
            this.DataContext = this;
            InitializeComponent();
            if ((pie != null) && (pie.Numero != -1))
            {
                NumeroTextBox.Text = Convert.ToString(pie.Numero);
                TypeTextBox.Text = pie.Categorie;
                NomTextBox.Text = pie.Nom;
                QuantiteTextBox.Text = Convert.ToString(pie.Quantite);
                DescriptionTextBox.Text = pie.Description;
                DateDebutTextBox.Text = Convert.ToString(pie.DateDebut);
                DateFinTextBox.Text = Convert.ToString(pie.DateFin);
                ApprovisionnementTextBox.Text = Convert.ToString(pie.Approvisionnement);
                PrixTextBox.Text = Convert.ToString(pie.Prix);
                NoFournisseurTextBox.Text = Convert.ToString(pie.NoFournisseur);
                NomFournisseurTextBox.Text = pie.NomFournisseur;
            }
        }

        private void Annuler(object sender, RoutedEventArgs e)
        {
            GestionPieceVelo w = new GestionPieceVelo();
            w.Show();
            this.Close();
        }

        private void Valider(object sender, RoutedEventArgs e)
        {
            string requete;
            RequeteSQL sql = new RequeteSQL();
            if ((pie != null) && (pie.Numero != -1))
            {
                requete = "DELETE FROM probleme.piece WHERE numero=" + Convert.ToString(pie.Numero);
                sql.SQLDELETE(requete);
            }

            if ((NumeroTextBox.Text != "") && (TypeTextBox.Text != "") && (NomTextBox.Text != "") && (QuantiteTextBox.Text != "") && (DescriptionTextBox.Text != "") && (DateDebutTextBox.Text != "") && (DateFinTextBox.Text != "") && (ApprovisionnementTextBox.Text != "") && (PrixTextBox.Text != "") && (NoFournisseurTextBox.Text != "") && (NomFournisseurTextBox.Text != ""))
            {
                requete = "INSERT INTO `probleme`.`piece` (`numero`,`nomType`,`referenceNom`,`quantite`,`descriptions`,`dateDebut`,`dateFin`,`approvisionnement`,`prix`,`noFournisseur`,`nomFournisseur`) VALUES ('"+NumeroTextBox.Text + "','" + TypeTextBox.Text + "','" + NomTextBox.Text + "','" + QuantiteTextBox.Text + "','" + DescriptionTextBox.Text + "','" + Convert.ToString(Convert.ToDateTime(DateDebutTextBox.Text).Date.ToString("yyyy-MM-dd")) + "','" + Convert.ToString(Convert.ToDateTime(DateFinTextBox.Text).Date.ToString("yyyy-MM-dd")) + "','" + Convert.ToString(Convert.ToDateTime(ApprovisionnementTextBox.Text).Date.ToString("yyyy-MM-dd")) + "','" + PrixTextBox.Text + "','" + NoFournisseurTextBox.Text + "','" + NomFournisseurTextBox.Text + "');";
                sql.SQLINSERT(requete);
            }
            GestionPieceVelo w = new GestionPieceVelo();
            w.Show();
            this.Close();
        }
    }
}
