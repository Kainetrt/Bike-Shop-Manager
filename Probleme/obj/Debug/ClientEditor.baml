   M S B A M L   `   `   `  ����C  ?Probleme, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null#clr-namespace:ProblemeProbleme  5   	       Probleme.ClientEditor   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   (localclr-namespace:Probleme     5   	     � Title$  ClientEditor��5   	   $	��450��6   $	��800��6+   .��5	      � .+�5
   
   �� $��Prenom��6   $
��Left=�6!   $��	63,84,0,0q�6<   $	��Top=�6O   �� 5   
   $��Adresse��6   $
��Left=�6"   $��
63,136,0,0q�6=   $	��Top=�6Q   �� 5   
   $��	Telephone��6   $
��Left=�6$   $��
63,197,0,0q�6?   $	��Top=�6S   �� 5   
   $��Courriel��6   $
��Left=�6#   $��
63,260,0,0q�6>   $	��Top=�6R   �� 5   
   $	��Nom��6   $
��Left=�6   $��	63,40,0,0q�69   $	��Top=�6L   �� 5   
   $��Programme fidelio��6   $
��Left=�6,   $��
10,303,0,0q�6G   $	��Top=�6[   �� 5   
   -   5         ��Name$ ValiderButton��5      $��Valider��6(   $
��Left=�6:   $��
598,84,0,0q�6U   $	��Top=�6i   $��75��6�   6�   �� 5   
   -   5        $ AnnulerButton��5      $��Annuler��6(   $
��Left=�6:   $��598,245,0,0q�6U   $	��Top=�6j   $��75��6�   6�   �� 5   
   -   5         ��Name$ 
NomTextBox��5      $
��Left=�6&   $��23��6A   $��
130,40,0,0q�6M    �� TextWrapping$
 Wrap=�6a   $	��Top=�6u   $	��120��6�   �� 5   
   -   5        $ PrenomTextBox��5      $
��Left=�6)   $��23��6D   $��
130,84,0,0q�6P   $
 Wrap=�6d   $	��Top=�6x   $	��120��6�   �� 5   
   -   5        $ AdresseTextBox��5      $
��Left=�6*   $��23��6E   $��130,136,0,0q�6Q   $
 Wrap=�6f   $	��Top=�6z   $	��120��6�   �� 5   
   -   5        $ TelephoneTextBox��5      $
��Left=�6,   $��23��6G   $��130,197,0,0q�6S   $
 Wrap=�6h   $	��Top=�6|   $	��120��6�   �� 5   
   -   5        $ CourrielTextBox��5      $
��Left=�6+   $��23��6F   $��130,264,0,0q�6R   $
 Wrap=�6g   $	��Top=�6{   $	��120��6�   �� 5   
   -   5        $ FidelioTextBox��5      $
��Left=�6*   $��23��6E   $��130,307,0,0q�6Q   $
 Wrap=�6f   $	��Top=�6z   $	��120��6�   �� 5   
   -	   5         ��Name$ FidelioListView��5      $
��Left=�6,   $	��267��6G   $��
314,62,0,0q�6T   $	��Top=�6h   $	��236��6�   ��6�   �� *listeFidelio+ �� Mode$ TwoWay=� �� UpdateSourceTrigger$ PropertyChanged=� �� View 5      �� 5      .P�5      �� $	��N°��6%    �� Width$ 20��61   	 �� DisplayMemberBinding	 6<   �� *Numero+$ TwoWay=��� 5      $	��Nom��6%   $ 60��62   	 6=   �� *Nom+$ TwoWay=��� 5      $
��Prix��6%   $ 40��63   	 6>   �� *Prix+$ TwoWay=��� 5      $��Duree��6%   $ 40��64   	 6?   �� *Duree+$ TwoWay=��� 5      $��Rabais��6%   $ 30��65   	 6@   �� *Rabais+$ TwoWay=��� 5       5!      5#      �� 5$   
   $��Fidelio��6   $
��Left=�6"   $��
415,22,0,0q�6=   $	��Top=�6Q   5&      5'      