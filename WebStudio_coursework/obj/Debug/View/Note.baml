   M S B A M L   `   `   `  ����O  KWebStudio_coursework, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null;"clr-namespace:WebStudio_courseworkWebStudio_coursework  5   	       WebStudio_coursework.Note   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   4local"clr-namespace:WebStudio_coursework     5   	     � Title$
  Note��5   	   $	��400��6   $	��500��6#   .��5	      �  � RowDefinitions 5
   
   �� 5      $��1* �6   �� 5      $
��0.2* �6   �� 5      $
��0.3* �6    � ColumnDefinitions 5   
   �� 5      $��1* �6   �� 5      $��1* �6   .+�5   
   �� -   5         ��Name$
 note��5      $��0��6?   $��0��6L   $��10q�6\   $��3��6h    �� TextWrapping$
 Wrap=�6|    �� AcceptsReturn . ��6    �� *notebind.Note+6�   �� 5   
   -   5        $ author��5      $��1��6G   $��0��6T   $��5q�6d    J� IsHitTestVisible .  ��6"   �� *notebind.AuthorName+6o   �� 5   
   -   5        $
 date��5      $��1��6?   $��1��6L   $��5q�6\    .  ��6    �� *notebind.Date+6g   �� 5   
   -   5        $��OK��5      $��2��6   $��0��6+   $��10q�6;   $��2��6G    �� 	IsDefault . 6l   5      5      