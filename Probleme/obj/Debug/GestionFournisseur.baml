   M S B A M L   `   `   `  ����C  ?Probleme, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null#clr-namespace:ProblemeProbleme  5   	   !    Probleme.GestionFournisseur   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   (localclr-namespace:Probleme     5   	     � Title$  GestionFournisseur��5   	   $	��450��6$   $	��800��61   .��5	      � .+�5
   
   �� -   5         ��Name$ CreerButton��5
      $��Créer��6&   $
��Left=�66   $��
104,94,0,0q�6Q   $	��Top=�6e   $��75��6}   6�   �� 5   
   -   5        $ SupprimerButton��5      $��	Supprimer��6*   $
��Left=�6>   $��104,171,0,0q�6Y   $	��Top=�6n   $��75��6�   6�   �� 5   
   -   5        $ Modifier��5      $��Modifier��6#   $
��Left=�66   $��104,254,0,0q�6Q   $	��Top=�6f   $��75��6~   6�   �� 5   
   -   5         ��Name$ ListViewFournisseur��5      $
��Left=�60   $	��383��6K   $��
209,10,0,0q�6X   $	��Top=�6l   $	��532��6�   ��6�   �� *listeFournisseur+ �� Mode$ TwoWay=� �� UpdateSourceTrigger$ PropertyChanged=� �� View 5      �� 5      .P�5      �� $��Siret��6%    �� Width$ 80��64    �� DisplayMemberBinding 6?   �� *Siret+$ TwoWay=��� 5      $��Nom Entreprise��6%   $	 140��6=    6I   �� *NomEntreprise+$ TwoWay=��� 5      $��Contact��6%   $	 170��66    6B   �� *	Contact+$ TwoWay=��� 5      $��Adresse��6%   $	 100��66    6B   �� *	Adresse+$ TwoWay=��� 5      $
��Note��6%   $ 30��63    6>   �� *Note+$ TwoWay=��� 5      5      5      5      5      