CREATE DATABASE Probleme;
use Probleme;

CREATE TABLE velo (
numero_modele int PRIMARY KEY,
nom varchar(40),
grandeur varchar(20),
prix double(7,2),
gamme varchar(20),
quantite int);
DROP TABLE VELO;

CREATE TABLE fidelio (
numero_programme int PRIMARY KEY,
nom varchar(20),
prix double(5,2),
duree int,
rabais double(4,2));

CREATE TABLE individu(
nom varchar(20) PRIMARY KEY,
prenom varchar(20),
adresse varchar(40),
telephone varchar(12),
courriel varchar(20),
fidelioNumero int);

CREATE TABLE boutique(
nom varchar(20) PRIMARY KEY,
adresse varchar(40),
telephone varchar(12),
courriel varchar(20),
nomContact varchar(20),
remise double);
DROP TABLE boutique;

CREATE TABLE assemblage (
nom varchar(40),
grandeur varchar(20),
cadre varchar(5),
guidon varchar(5),
frein varchar(5),
selle varchar(5),
derailleur_avant varchar(5),
derailleur_arriere varchar(5),
roue_avant varchar(5),
roue_arriere varchar(5),
reflecteur varchar(5),
pedalier varchar(5),
ordinateur varchar(5),
panier varchar(5));

CREATE TABLE fournisseur (
siret int PRIMARY KEY,
nomEntreprise varchar(40),
contact varchar(40),
adresse varchar(40),
note int);

CREATE TABLE commande (
numero int PRIMARY KEY,
numeroPiece varchar(40),
numeroVelo varchar(40),
dateCommande date,
adresse varchar(40),
dateLivraison date);

CREATE TABLE piece (
numero int PRIMARY KEY,
nomType varchar(20),
referenceNom varchar(20),
quantite int,
descriptions varchar(40),
dateDebut date,
dateFin date,
approvisionnement date,
prix double(4,2),
noFournisseur int,
nomFournisseur varchar(20));

INSERT INTO individu VALUES ('nomindividu','prenomindividu','adresseindividu','0645872659','courrielindividu',2);
INSERT INTO individu VALUES ('nomindividu2','prenomindividu','adresseindividu','0645872659','courrielindividu',2);
SELECT * from individu;

INSERT INTO boutique VALUES ('nomboutique','adresseboutique','0645896236','courrielboutique','ContactBoutique',25.63);
INSERT INTO boutique VALUES ('nomboutique2','adresseboutique2','0645896236','courrielboutique','ContactBoutique',25.63);
SELECT * from boutique;

INSERT INTO commande VALUES (0,"1;25;69;78","1;5;9;8;7",'1000-01-01',"14 rue des peupliers",'1000-01-01');
INSERT INTO commande VALUES (5,"1;25;45;78","1;5;9;8;7",'1000-01-01',"14 rue des peupliers",'1000-01-01');
SELECT * from commande;

INSERT INTO piece VALUES (0,"Cadre","C32",0,"CADRE TRES SOLIDE",'1000-01-01','1000-01-01','1000-01-01',12.2,1,"CadrePro");
INSERT INTO piece VALUES (2,"Cadre2","C34",0,"CADRE TRES ROBUSTE",'1000-01-01','1000-01-01','1000-01-01',14.3,1,"CadrePro");
INSERT INTO piece VALUES (3,"Cadre3","C34",0,"CADRE TRES ROBUSTE",'1000-01-01','1000-01-01','1000-01-01',14.3,1,"CadrePro");
INSERT INTO piece VALUES (8,"Cadre3","G7",0,"CADRE TRES ROBUSTE",'1000-01-01','1000-01-01','1000-01-01',14.3,1,"CadrePro");
SELECT * from piece;

INSERT INTO fournisseur VALUES (2,"Cadre2","Jacques@gmail.com","19 rue des fleurs",5);
INSERT INTO fournisseur VALUES (3,"BoutiquePro","Jacques@gmail.com","19 rue des fleurs",5);
SELECT * from fournisseur;

INSERT INTO velo VALUES (101,"Kilimandjaro","Adultes",569.00,"VTT",1);
INSERT INTO velo VALUES (102,"NorthPole","Adultes",329.00,"VTT",1);
INSERT INTO velo VALUES (103,"MontBlanc","Jeunes",399.00,"VTT",8);
INSERT INTO velo VALUES (104,"Hooligan","Jeunes",199.00,"VTT",8);
INSERT INTO velo VALUES (105,"Orléans","Hommes",229.00,"Vélo de course",9);
INSERT INTO velo VALUES (106,"Orléans","Dames",229.00,"Vélo de course",8);
INSERT INTO velo VALUES (107,"BlueJay","Hommes",349.00,"Vélo de course",0);
INSERT INTO velo VALUES (108,"BlueJay","Dames",349.00,"Vélo de course",5);
INSERT INTO velo VALUES (109,"Trail Explorer","Filles",129.00,"Classique",6);
INSERT INTO velo VALUES (110,"Trail Explorer","Garçons",129.00,"Classique",7);
INSERT INTO velo VALUES (111,"Night Hawk","Jeunes",189.00,"Classique",1);
INSERT INTO velo VALUES (112,"Tierra Verde","Hommes",199.00,"Classique",8);
INSERT INTO velo VALUES (113,"Tierra Verde","Dames",199.00,"Classique",4);
INSERT INTO velo VALUES (114,"Mud Zinger I","Jeunes",279.00,"BMX",1);
INSERT INTO velo VALUES (115,"Mud Zinger II","Adultes",359.00,"BMX",0);
SELECT * FROM velo;

INSERT INTO fidelio VALUES (0,"Non Fidélio",0,0,0);
INSERT INTO fidelio VALUES (1,"Fidélio",15.00,1,5.00);
INSERT INTO fidelio VALUES (2,"Fidélio Or",25.00,1,8.00);
INSERT INTO fidelio VALUES (3,"Fidélio Platine",60.00,1,10.00);
INSERT INTO fidelio VALUES (4,"Fidélio Max",100.00,1,12.00);
SELECT * from fidelio;

DROP TABLE assemblage;
INSERT INTO assemblage VALUES ("Kilimandjaro","Adultes","C32","G7","F3","S88","DV133","DR56","R45","R46",null,"P12","O2",null);
INSERT INTO assemblage VALUES ("NorthPole","Adultes","C34","G7","F3","S88","DV17","DR87","R48","R47",null,"P12",null,null);
INSERT INTO assemblage VALUES ("MontBlanc","Jeunes","C76","G7","F3","S88","DV17","DR87","R48","R47",null,"P12","O2",null);
INSERT INTO assemblage VALUES ("Hooligan","Jeunes","C76","G7","F3","S88","DV87","DR86","R12","R32",null,"P12",null,null);
INSERT INTO assemblage VALUES ("Orléans","Hommes","C43","G9","F9","S37","DV57","DR86","R19","R18","R02","P34",null,null);
INSERT INTO assemblage VALUES ("Orléans","Dames","C44f","G9","F9","S35","DV57","DR86","R19","R18","R02","P34",null,null);
INSERT INTO assemblage VALUES ("BlueJay","Hommes","C43","G9","F9","S37","DV57","DR87","R19","R18","R02","P34","O4",null);
INSERT INTO assemblage VALUES ("BlueJay","Dames","C43f","G9","F9","S35","DV57","DR87","R19","R18","R02","P34","O4",null);
INSERT INTO assemblage VALUES ("Trail Explorer","Filles","C01","G12",null,"S02",null,null,"R1","R2",null,"P1",null,null);
INSERT INTO assemblage VALUES ("Trail Explorer","Garçons","C02","G12",null,"S03",null,null,"R1","R2",null,"P1",null,null);
INSERT INTO assemblage VALUES ("Night Hawk","Jeunes","C15","G12","F9","S36","DV15","DR23","R11","R12","R10","P15",null,null);
INSERT INTO assemblage VALUES ("Tierra Verde","Hommes","C87","G12","F9","S36","DV41","DR76","R11","R12","R10","P15",null,null);
INSERT INTO assemblage VALUES ("Tierra Verde","Dames","C87f","G12","F9","S34","DV41","DR76","R11","R12","R10","P15",null,null);
INSERT INTO assemblage VALUES ("Mud Zinger I","Jeunes","C25","G7","F3","S87","DV132","DR52","R44","R47",null,"P12",null,null);
INSERT INTO assemblage VALUES ("Mud Zinger II","Adultes","C26","G7","F3","S87","DV133","DR52","R44","R47",null,"P12",null,null);
SELECT * from assemblage;
