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
using MySql.Data.MySqlClient;

namespace Probleme
{
    /// <summary>
    /// Logique d'interaction pour VeloEditor.xaml
    /// </summary>
    public partial class VeloEditor : Window
    {
        public Velo vel;
        public VeloEditor(Velo vel)
        {
            this.vel = vel;
            this.DataContext = this;
            InitializeComponent();
            if ((vel!=null)&&(vel.Numero != -1))
            {   
                NumeroTextBox.Text = Convert.ToString(vel.Numero);
                NomTextBox.Text = vel.Nom;
                GrandeurTextBox.Text = vel.Grandeur;
                PrixTextBox.Text = Convert.ToString(vel.Prix);
                GammeTextBox.Text = vel.Gamme;
            }
        }

        private void Valider(object sender, RoutedEventArgs e)
        {
            string requete;
            RequeteSQL sql = new RequeteSQL();
            if ((vel != null)&&(vel.Numero != -1))
            {
                requete="DELETE FROM probleme.velo WHERE numero_modele=" + Convert.ToString(vel.Numero);
                sql.SQLDELETE(requete);
            }
            
            if ((NumeroTextBox.Text!="")&&(NomTextBox.Text != "")&&(GrandeurTextBox.Text != "")&&(PrixTextBox.Text != "")&&(GammeTextBox.Text != ""))
            {
                requete = "INSERT INTO `probleme`.`velo` (`numero_modele`,`nom`,`grandeur`,`prix`,`gamme`) VALUES ('"+NumeroTextBox.Text+"','" + NomTextBox.Text + "','" + GrandeurTextBox.Text+ "','" + PrixTextBox.Text+"','"+ GammeTextBox.Text+"');";
                sql.SQLINSERT(requete);
            }
            GestionPieceVelo w = new GestionPieceVelo();
            w.Show();
            this.Close();
        }

        private void Annuler(object sender, RoutedEventArgs e)
        {
            GestionPieceVelo w = new GestionPieceVelo();
            w.Show();
            this.Close();
        }
    }
}
