   M S B A M L   `   `   `  ����O  KWebStudio_coursework, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null;"clr-namespace:WebStudio_courseworkWebStudio_coursework  5   	   D @ViewModel, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null8*clr-namespace:ViewModel;assembly=ViewModel	ViewModel 5   	   )    #WebStudio_coursework.CustomerWindow   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   4local"clr-namespace:WebStudio_coursework     5   	   >binding*clr-namespace:ViewModel;assembly=ViewModel     5   	     � Title$  CustomerWindowAdd��5	   	   $	��200��6#   $	��400��60   .��5      �  � RowDefinitions 5   
   �� 5      $
��0.2* �6   �� 5      $��1* �6   �� 5      $��1* �6   �� 5      $��1* �6   �� 5      $��1* �6   �� 5      $��1* �6   �� 5      $
��0.2* �6    � ColumnDefinitions 5   
   �� 5      $
��0.3* �6   �� 5      $��1* �6   �� 5      $��1* �6   �� 5      $
��0.3* �6   .+�5   
   �� -   5         ��Name$ 
tb_cs_name��5      $��1��6D   $��2��6Q   $��2q�6a   ��6&   ��  �� Path$ cs.Name�6a   �� 5   
   -   5        $ tb_cs_phone��5      $��2��6F   $��2��6S   $��2q�6c   ��6'   �� $ cs.Phone�6c   �� 5   
   -   5        $ tb_cs_email��5      $��3��6F   $��2��6S   $��2q�6c   ��6'   �� $ cs.Email�6c   �� 5    
   $��Имя��6   $��1��6   $��1��6+   $��2q�6;   $��Center=�6F   �� 5!   
   $��Телефон��6   $��2��6"   $��1��6/   $��2q�6?   $��Center=�6J   �� 5"   
   $��Email��6   $��3��6    $��1��6-   $��2q�6=   $��Center=�6H   �� 5#   
   -   5        $��OK��5#      $��4��6   $��2��6+   $��1��6?   $��2q�6O    �� 	IsDefault . 6k   5$      5%      