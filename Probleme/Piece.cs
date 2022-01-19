using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Probleme
{
    public class Piece
    {
        private int numero;
        private string description;
        private string nomFournisseur;
        private int noFournisseur;
        private double prix;
        private DateTime dateDebut;
        private DateTime dateFin;
        private DateTime approvisionnement;
        public string categorie;
        public string nom;
        private int quantite;

        public Piece()
        {
            this.numero = -1;
        }

        public Piece(int numero)
        {
            this.numero = numero;
        }

        public Piece(int numero,string nom,int quantite)
        {
            this.numero = numero;
            this.nom = nom;
            this.quantite = quantite;
        }

        public Piece(int numero, string description, string nomFournisseur,int noFournisseur,double prix,DateTime dateDebut,DateTime dateFin,DateTime approvisionnement,string categorie,string nom,int quantite)
        {
            this.numero = numero;
            this.description = description;
            this.nomFournisseur = nomFournisseur;
            this.noFournisseur = noFournisseur;
            this.prix = prix;
            this.dateDebut = dateDebut;
            this.dateFin = dateFin;
            this.approvisionnement = approvisionnement;
            this.categorie = categorie;
            this.nom = nom;
            this.quantite = quantite;
        }

        public Piece(int numero, string description, string nomFournisseur, int noFournisseur, double prix, DateTime dateDebut, DateTime dateFin, DateTime approvisionnement)
        {
            this.numero = numero;
            this.description = description;
            this.nomFournisseur = nomFournisseur;
            this.noFournisseur = noFournisseur;
            this.prix = prix;
            this.dateDebut = dateDebut;
            this.dateFin = dateFin;
            this.approvisionnement = approvisionnement;
        }

        public int Numero
        {
            get { return this.numero; }
            set { this.numero = value; }
        }

        public string Description
        {
            get { return this.description; }
            set { this.description  = value; }
        }

        public string NomFournisseur
        {
            get { return this.nomFournisseur; }
            set { this.nomFournisseur = value; }
        }

        public int NoFournisseur
        {
            get { return this.noFournisseur; }
            set { this.noFournisseur = value; }
        }

        public double Prix
        {
            get { return this.prix; }
            set { this.prix = value; }
        }

        public DateTime DateDebut
        {
            get { return this.dateDebut; }
            set { this.dateDebut = value; }
        }

        public DateTime DateFin
        {
            get { return this.dateFin; }
            set { this.dateFin = value; }
        }

        public DateTime Approvisionnement
        {
            get { return this.approvisionnement; }
            set { this.approvisionnement = value; }
        }

        public string Categorie
        {
            get { return this.categorie; }
            set { this.categorie = value; }
        }

        public string Nom
        {
            get { return this.nom; }
            set { this.nom = value; }
        }

        public int Quantite
        {
            get { return this.quantite; }
            set { this.quantite = value; }
        }
    }
}
