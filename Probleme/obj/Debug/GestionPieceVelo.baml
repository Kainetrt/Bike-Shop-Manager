   M S B A M L   `   `   `  ����C  ?Probleme, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null#clr-namespace:ProblemeProbleme  5   	       Probleme.GestionPieceVelo   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   (localclr-namespace:Probleme     5   	     � Title$  GestionPieceVelo��5   	   $	��450��6"   $	��800��6/   .��5	      � .+�5
   
   �� -   5         ��Name$ AjouterVeloButton��5
      $��Ajouter��6,   $
��Left=�6>   $��	10,75,0,0q�6Y   $	��Top=�6l   $��75��6�   6�   �� 5   
   -   5        $ AjouterPieceButton��5      $��Ajouter��6-   $
��Left=�6?   $��
404,75,0,0q�6Z   $	��Top=�6n   $��75��6�   6�   �� 5   
   -   5        $ SupprimerVeloButton��5      $��	Supprimer��6.   $
��Left=�6B   $��
10,133,0,0q�6]   $	��Top=�6q   $��75��6�   6�   �� 5   
   -   5        $ SupprimerPieceButton��5      $��	Supprimer��6/   $
��Left=�6C   $��404,133,0,0q�6^   $	��Top=�6s   $��75��6�   6�   �� 5   
   -   5        $ ModifierVeloButton��5      $��Modifier��6-   $
��Left=�6@   $��
10,190,0,0q�6[   $	��Top=�6o   $��75��6�   6�   �� 5   
   -   5        $ ModifierPieceButton��5      $��Modifier��6.   $
��Left=�6A   $��404,190,0,0q�6\   $	��Top=�6q   $��75��6�   6�   �� 5   
   -   5         ��Name$ ListViewVelo��5      $
��Left=�6)   $	��345��6D   $��
108,75,0,0q�6Q   $	��Top=�6e   $	��275��6}   ��6�   �� *	listeVelo+ �� Mode$ TwoWay=� �� UpdateSourceTrigger$ PropertyChanged=� �� View 5      �� 5      .P�5      �� $	��N°��6%    �� Width$ 40��61    �� DisplayMemberBinding 6<   �� *Numero+$ TwoWay=��� 5      $	��Nom��6%   $ 40��62    6=   �� *Nom+$ TwoWay=��� 5      $��Grandeur��6%   $ 40��67    6B   �� *
Grandeur+$ TwoWay=��� 5      $
��Prix��6%   $ 40��63    6>   �� *Prix+$ TwoWay=��� 5      $��Date de début��6%   $ 40��6<    6G   �� *	DateDebut+$ TwoWay=��� 5      $��Date de fin��6%   $ 40��6:    6E   �� *	DateFin+$ TwoWay=��� 5      5      5      �� 5   
   -   5        $ ListViewPiece��5      $
��Left=�6*   $	��361��6E   $��
496,59,0,0q�6R   $	��Top=�6f   $	��288��6~   ��6�   �� *
listePiece+$ TwoWay=�$ PropertyChanged=� 5      �� 5      .P�5       �� $	��N°��6%   $ 40��61    6<   �� *Numero+$ TwoWay=��� 5!      $��Description��6%   $ 40��6:    6E   �� *Description+$ TwoWay=��� 5"      $��Nom Fournisseur��6%   $ 40��6>    6I   �� *NomFournisseur+$ TwoWay=��� 5#      $��Numero Fournisseur��6%   $ 40��6A    6L   �� *NoFournisseur+$ TwoWay=��� 5$      $
��Prix��6%   $ 40��63    6>   �� *Prix+$ TwoWay=��� 5%      $��Date début��6%   $ 40��69    6D   �� *	DateDebut+$ TwoWay=��� 5&      $��Date Fin��6%   $ 40��67    6B   �� *	DateFin+$ TwoWay=��� 5'      $��Approvisionnement��6%   $ 40��6@    6K   �� *Approvisionnement+$ TwoWay=��� 5(      5)      5+      �� 5,   
   $��Vélos��6   $
��Left=�6    $��
192,32,0,0q�6;   $	��Top=�6O   �� 5-   
   $��Pièces��6   $
��Left=�6!   $��
578,32,0,0q�6<   $	��Top=�6P   5/      50      