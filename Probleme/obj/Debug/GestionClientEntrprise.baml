   M S B A M L   `   `   `  ����C  ?Probleme, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null#clr-namespace:ProblemeProbleme  5   	   %    Probleme.GestionClientEntrprise   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   (localclr-namespace:Probleme     5   	     � Title$  GestionClientEntrprise��5   	   $	��450��6(   $	��800��65   .��5	      � .+�5
   
   �� -   5         ��Name$ CreerClientButton��5
      $��Créer Client��6,   $
��Left=�6C   $��
62,376,0,0q�6^   $	��Top=�6r   $	��116��6�   6�   �� 5   
   -   5        $ SupprimerButton��5      $��	Supprimer��6*   $
��Left=�6>   $��361,172,0,0q�6Y   $	��Top=�6n   $��75��6�   6�   �� 5   
   -   5        $ ModifierButton��5      $��Modifier��6)   $
��Left=�6<   $��361,258,0,0q�6W   $	��Top=�6l   $��75��6�   6�   �� 5   
   -   5         ��Name$ ListViewClient��5      $
��Left=�6+   $	��303��6F   $��	19,53,0,0q�6S   $	��Top=�6f   $	��293��6~   ��6�   �� *listeClient+ �� Mode$ TwoWay=� �� UpdateSourceTrigger$ PropertyChanged=� �� View 5      �� 5      .P�5      �� $	��Nom��6%    �� Width$ 50��62    �� DisplayMemberBinding 6=   �� *Nom+$ TwoWay=��� 5      $��Prenom��6%   $ 50��65    6@   �� *Prenom+$ TwoWay=��� 5      $��Adresse��6%   $ 50��66    6A   �� *	Adresse+$ TwoWay=��� 5      $��	Telephone��6%   $ 50��68    6C   �� *	Telephone+$ TwoWay=��� 5      $��Courriel��6%   $ 50��67    6B   �� *
Courriel+$ TwoWay=��� 5      $��Fidelio��6%   $ 40��66    6A   �� *	Fidelio+$ TwoWay=��� 5      5      5      �� 5   
   -   5        $ ListViewEntreprise��5      $
��Left=�6/   $	��303��6J   $��
458,53,0,0q�6W   $	��Top=�6k   $	��298��6�   ��6�   �� *listeEntreprise+$ TwoWay=�$ PropertyChanged=� 5      �� 5      .P�5      �� $	��Nom��6%   $ 50��62    6=   �� *Nom+$ TwoWay=��� 5      $��Adresse��6%   $ 50��66    6A   �� *	Adresse+$ TwoWay=��� 5      $��	Telephone��6%   $ 50��68    6C   �� *	Telephone+$ TwoWay=��� 5       $��Courriel��6%   $ 50��67    6B   �� *
Courriel+$ TwoWay=��� 5!      $��Contact��6%   $ 50��66    6A   �� *
NomContact+$ TwoWay=��� 5"      $��Remise��6%   $ 50��65    6@   �� *Remise+$ TwoWay=��� 5#      5$      5&      �� 5'   
   $��Clients��6   $
��Left=�6"   $��
108,22,0,0q�6=   $	��Top=�6Q   �� 5(   
   $��Entreprises��6   $
��Left=�6&   $��
562,22,0,0q�6A   $	��Top=�6U   �� 5)   
   -   5        $ CreerEntrepriseButton��5)      $��Créer Entreprise��60   $
��Left=�6K   $��534,381,0,0q�6f   $	��Top=�6{   $	��125��6�   6�   5+      5,      