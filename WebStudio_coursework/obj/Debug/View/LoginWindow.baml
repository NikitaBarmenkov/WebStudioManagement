   M S B A M L   `   `   `  ����O  KWebStudio_coursework, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null;"clr-namespace:WebStudio_courseworkWebStudio_coursework  5   	   &     WebStudio_coursework.LoginWindow   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   4local"clr-namespace:WebStudio_coursework     5   	     � Title$  LoginWindow��5   	   $��312.371��6   $��374.742��6.   .��5	      �  � RowDefinitions 5
   
   �� 5      $��2* �6   �� 5      $��1* �6   �� 5      $��1* �6   �� 5      $
��1.5* �6   �� 5      $��2* �6    � ColumnDefinitions 5   
   �� 5      $��1* �6   �� 5      $��0.75* �6   �� 5      $��1* �6   �� 5      $��1* �6   .+�5   
   �� $��Логин:��6   $��1��6!   $��1��6.   $��5q�6>   �� 5   
   $��Пароль:��6   $��2��6"   $��1��6/   $��5q�6?   �� 5   
   $��1��6)   $��2��66   $��5q�6F   ��6   �� *Login+6F   G� 5   
   -   5         G�Name$ passwordBox��5      $��2��6+   $��2��68   $��5q�6H   �� 5   
   -   5        $��
Войти��5   u   $��3��6�   $��1��6�   $��10q�6�   $��2��6�    �� 	IsDefault . ��6   �� *LoginCommand+ �� Mode$ OneTime=���6@   ��  �� ElementName$ passwordBox��6�   5      5      