   M S B A M L   `   `   `  ����J  F3.csapt_projekt, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null3clr-namespace:_3.csapt_projekt_3.csapt_projekt  5      $    _3.csapt_projekt.StartMenuDark   5      R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      0localclr-namespace:_3.csapt_projekt     5      .��5	      � ��5
   
   �� 5        �� ImageSource$'  !Resources/StartMenuBackground.jpg��6    j� Stretch$
 Fill=�6I   .+�5   
   � $	��800��6   $	��450��6   .+�5      �� $��Center=�6   $	��450��65   
�������$��Center=�6Q   $	��232��6l   �� 5      -   5        $
��Play��5      $��70��6%   $��0,60,0,0q�61   $	��Top=�6C   $	��145��6[   $��Center=�6g   
�������$��Impact)�6�   $��30(�6�   $��3,1,1,1q�6�   ��6�   Z� ��6�   Z� 6   �� 5      -   5        $
��Jobs��5      $��70��6%   $	��Top=�61   $	��145��6I   $��Center=�6U   $��	0,190,0,0q�6r   $��Impact)�6�   $��30(�6�   
���������6�   Z� ��6�   Z� 6�   �� 5      -   5        $��Scores��5      $��70��6&   $��	0,320,0,0q�62   $	��Top=�6E   $	��144��6]   $��Center=�6i   $��Impact)�6�   $��30(�6�   
���������6�   Z� ��6�   Z� 6�   �� 5      $����Játék indítása: 
 Az alkalmazás indítása után azonnal 
elérhető a főmenü:  Play: Azonnal 
kezdhetsz egy alap pályán.
 Jobs: Itt választhatod ki, hogy melyik 
nehézségi szinten szeretnél játszani: 
Map1: Könnyű 
Map2: Közepes 
Map3: Nehéz
 A nehézségi szint kiválasztása után 
ismét a Play gomb megnyomásával 
indul el az adott pálya. 
A Jobs ablakban láthatod, hogy 
aktuálisan melyik map van kiválasztva. 
Pontozás és eredmény mentése:
 Csak a győztes játékaid eredményei 
kerülnek elmentésre. Az elért 
eredményeket a Scores menüpontban 
tudod megtekinteni.��6   $
��Left=�5      $	��430��6/   $��10,0,0,0q�6<   $��Center=�6N   $	��269��6i   
�������$��Impact)�6�   $��16(�6�   ��5      �� 5        �� Color$ Black��6&    �� Opacity$	 0.4Q�64   5"      �� 5#      $����Nehézségi szintek:
A különböző elemek különböző 
nehézségű kérdések 
megválaszolásával győzhetők le: 
PC és Telefon:    1. szint    Könnyű 
Laptop:    2. szint   Közepes 
Szerver:    3. szint    Nehéz 
Minél magasabb szintű az eszköz, 
annál nehezebb kérdést kell 
megválaszolnod a legyőzéséhez.
Map3-nál további nehezítés a rendőr,
aki a kék vonallal jelölt gépeket 
figyeli, ezeknél a gépeknél csak 1-et
lehet hibázni.��6   $
��Left=�6�  $	��430��6  $��	521,0,0,0q�6  $��Center=�62  $	��269��6M  
�������$��Impact)�6l  $��16(�6�  ��5$      �� 5%      $ Black��6&   $	 0.4Q�64   5'      5(      5)      5*      