   M S B A M L   `   `   `  ����O  KWebStudio_coursework, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null;"clr-namespace:WebStudio_courseworkWebStudio_coursework  5   	        WebStudio_coursework.Notes   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   4local"clr-namespace:WebStudio_coursework     5   	     � Title$  Notes��5   	   $	��450��6   $	��800��6$   .��5	      �  � RowDefinitions 5
   
   �� 5      $��0.15* �6   �� 5      $��1* �6    � ColumnDefinitions 5   
   �� 5      $
��0.3* �6   �� 5      $
��0.3* �6   �� 5      $
��0.3* �6   �� 5      $��1* �6   .+�5   
   �� $��1��6X   $��0��6e   $��4��6u   $��5q�6�   ��6   �� *d.Notations+ �� SelectedItem 66   �� *
sel_note+��5      �� 5      .R�5      �� .+�5      �  5      �� 5   "   $��1* �60   �� 5   "   $��0.15* �60    5      �� 5   "   $��1* �63   �� 5   "   $��1* �63   �� 5    "   $��1* �63   �� 5!   "   $��1* �63   .+�5#      �� $��0��6A   $��0��6N   $��5q�6^   $��4��6i   $	��500��6}    J� IsHitTestVisible .   �� TextWrapping$
 Wrap=�6�    �� AcceptsReturn . ��6&   ��  �� Path$
 Note�6�   �� 5$      $��
Автор��6$   $��1��64   $��0��6A   $��5q�6Q   �� 5%      $��1��6G   $��1��6T   $��5q�6d    .  ��6&   �� $ 
AuthorName�6o   �� 5&      $��Дата��6$   $��1��63   $��2��6@   $��5q�6P   �� 5'      $��1��6A   $��3��6N   $��5q�6^    .  ��6&   �� $
 Date�6i   5(      5)      5*      5,      �� 5-   
   -   5         ��Name$ add_note��5-      $��Добавить��6@   $��0��6S   $��0��6`   $��5q�6p   ��6#   �� *
add_note+6p   �� 5.   
   -   5        $ 	edit_note��5.      $��Изменить��6B   $��0��6U   $��1��6b   $��5q�6r   ��6$   �� *	edit_note+6r   �� 5/   
   -   5        $ del_note��5/      $��Удалить��6@   $��0��6R   $��2��6_   $��5q�6o   ��6#   �� *
del_note+6o   51      52      