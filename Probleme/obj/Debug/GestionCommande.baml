   M S B A M L   `   `   `  ����C  ?Probleme, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null#clr-namespace:ProblemeProbleme  5   	       Probleme.GestionCommande   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   (localclr-namespace:Probleme     5   	     � Title$  GestionCommande��5   	   $	��450��6!   $	��800��6.   .��5	      � .+�5
   
   �� -   5         ��Name$ AjouterCommandeButton��5
      $��Ajouter��60   $
��Left=�6B   $��	29,54,0,0q�6]   $	��Top=�6p   $��75��6�   6�   �� 5   
   -   5        $ SupprimerCommandeButton��5      $��	Supprimer��62   $
��Left=�6F   $��
29,126,0,0q�6a   $	��Top=�6u   $��75��6�   6�   �� 5   
   -   5        $ ModifierCommandeButton��5      $��Modifier��61   $
��Left=�6D   $��
29,215,0,0q�6_   $	��Top=�6s   $��75��6�   6�   �� 5   
   -   5         ��Name$ ListViewCommande��5      $
��Left=�6-   $	��400��6H   $��
121,10,0,0q�6U   $	��Top=�6i   $	��663��6�   ��6�   �� *listeCommande+ �� Mode$ TwoWay=� �� UpdateSourceTrigger$ PropertyChanged=� �� View 5      �� 5      .P�5      �� $	��N°��6%    �� Width$ 40��61    �� DisplayMemberBinding 6<   �� *Numero+$ TwoWay=��� 5      $��Date Commande��6%   $	 100��6<    6H   �� *DateCommande+$ TwoWay=��� 5      $��Date Livraison��6%   $	 100��6=    6I   �� *DateLivraison+$ TwoWay=��� 5      $��Adresse��6%   $	 500��66    6B   �� *	Adresse+$ TwoWay=��� 5      5      5      5      5      