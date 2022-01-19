#!python

nomvar="pie"
nomtable="piece"
nomTextBox=["Numero","Type","Nom","Quantite","Description","DateDebut","DateFin","Approvisionnement","Prix","NoFournisseur","NomFournisseur"]
nomSQL=["numero","nomType","referenceNom","quantite","descriptions","dateDebut","dateFin","approvisionnement","prix","noFournisseur","nomFournisseur"]

nomvar="com"
nomtable="commande"
nomTextBox=["Numero","dateCommande","Adresse","dateLivraison"]
nomSQL=["numero","dateCommande","adresse","dateLivraison"]

nomvar="fou"
nomtable="fournisseur"
nomTextBox=["Siret","NomEntreprise","Contact","Adresse","Note"]
nomSQL=["siret","nomEntreprise","contact","adresse","note"]

nomvar="cli"
nomtable="individu"
nomTextBox=["Nom","Prenom","Adresse","Telephone","Courriel","Fidelio"]
nomSQL=["nom","prenom","adresse","telephone","courriel","fidelioNumero"]

nomvar="ent"
nomtable="boutique"
nomTextBox=["Nom","Adresse","Telephone","Courriel","Contact","Remise"]
nomSQL=["nom","adresse","telephone","courriel","nomContact","remise"]

text="if ("
for i in nomTextBox:
    text=text+'('+i+'TextBox.Text != "") && '
text=text[:-4]+")"
text=text+"\n{\n"
text=text+'requete="INSERT INTO `probleme`.`'+nomtable+'` ('

for i in nomSQL:
    text=text+"`"+i+"`,"

text=text[:-1]+") VALUES ('"
text=text+'"+'

separator="','"
separator2='"'
separator=separator2+separator+separator2+" + "

for i in nomTextBox:
    text=text+i+"TextBox.Text + "+separator

text=text[:-6]

text=text+");"+separator2+";"+"\n}"

print(text)

text=""
for i in nomTextBox:
    text=text+i+"TextBox.Text = "+nomvar+"."+i+";\n"

print(text)