   M S B A M L   `   `   `  ����C  ?Probleme, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null#clr-namespace:ProblemeProbleme  5   	       Probleme.CommandeEditor   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   (localclr-namespace:Probleme     5   	     � Title$  CommandeEditor��5   	   $	��450��6    $	��800��6-   .��5	      � .+�5
   
   �� $��Numero��6   $
��Left=�6!   $��	22,25,0,0q�6<   $	��Top=�6O   �� 5   
   -   5         ��Name$ ValiderButton��5      $��Valider��6(   $
��Left=�6:   $��
18,239,0,0q�6U   $	��Top=�6i   $��75��6�   6�   �� 5   
   -   5        $ AnnulerButton��5      $��Annuler��6(   $
��Left=�6:   $��
18,291,0,0q�6U   $	��Top=�6i   $��75��6�   6�   �� 5   
   $��date Commande��6   $
��Left=�6(   $��	10,65,0,0q�6C   $	��Top=�6V   �� 5   
   $��date Livraison��6   $
��Left=�6)   $��
10,106,0,0q�6D   $	��Top=�6X   �� 5   
   $��Adresse��6   $
��Left=�6"   $��
22,163,0,0q�6=   $	��Top=�6Q   �� 5   
   -   5         ��Name$ NumeroTextBox��5      $
��Left=�6)   $��23��6D   $��
144,25,0,0q�6P    �� TextWrapping$
 Wrap=�6d   $	��Top=�6x   $	��120��6�   �� 5   
   -   5        $ dateCommandeTextBox��5      $
��Left=�6/   $��23��6J   $��
125,68,0,0q�6V   $
 Wrap=�6j   $��
01/02/2021��6~   $	��Top=�6�   $	��120��6�   �� 5   
   -   5        $ dateLivraisonTextBox��5      $
��Left=�60   $��23��6K   $��125,110,0,0q�6W   $
 Wrap=�6l   $��
01/02/2021��6�   $	��Top=�6�   $	��120��6�   �� 5   
   -   5        $ AdresseTextBox��5      $
��Left=�6*   $��23��6E   $��
98,163,0,0q�6Q   $
 Wrap=�6e   $	��Top=�6y   $	��120��6�   �� 5   
   -   5         ��Name$ ListViewPiece��5      $
��Left=�6*   $	��276��6E   $��
289,59,0,0q�6R   $	��Top=�6f   $	��170��6~   ��6�   �� *
listePiece+ �� Mode$ TwoWay=� �� UpdateSourceTrigger$ PropertyChanged=� �� View 5      �� 5      .P�5      �� $	��N°��6%    �� Width$	 170��61   	 �� DisplayMemberBinding	 6=   �� *Numero+$ TwoWay=��� 5      5      5      �� 5   
   -   5        $ ListViewVelo��5      $
��Left=�6)   $	��273��6D   $��
580,68,0,0q�6Q   $	��Top=�6e   $	��180��6}   ��6�   �� *	listeVelo+$ TwoWay=�$ PropertyChanged=� 5      �� 5      .P�5      �� $	��N°��6%   $	 170��61   	 6=   �� *Numero+$ TwoWay=��� 5       5!      5#      �� 5$   
   $��Pièces��6   $
��Left=�6!   $��
357,33,0,0q�6<   $	��Top=�6P   
 J� RenderTransformOrigin$
 0.831,0.438&�6h   �� 5%   
   $��Vélos��6   $
��Left=�6    $��
641,25,0,0q�6;   $	��Top=�6O   �� 5&   
   -	   5        $ AjouterPieceButton��5&      $��Ajouer Pièces��6-   $
��Left=�6E   $��289,357,0,0q�6`   $	��Top=�6u   $��75��6�   6�   �� 5'   
   -
   5        $ AjouterVeloButton��5'      $��Ajouter Vélos��6,   $
��Left=�6D   $��580,357,0,0q�6_   $	��Top=�6t   $��75��6�   6�   �� 5(   
   -   5        $ SupprimerButton��5(      $��	Supprimer��6*   $
��Left=�6>   $��484,174,0,0q�6Y   $	��Top=�6n   $��75��6�   6�   �� 5)   
   -   5        $ NumeroPieceTextBox��5)      $
��Left=�6.   $��23��6I   $��381,357,0,0q�6U   $
 Wrap=�6j   $	��Top=�6~   $	��120��6�   �� 5*   
   -   5        $ NumeroVeloTextBox��5*      $
��Left=�6-   $��23��6H   $��664,357,0,0q�6T   $
 Wrap=�6i   $	��Top=�6}   $	��120��6�   5,      5-      