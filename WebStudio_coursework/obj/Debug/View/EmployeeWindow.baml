   M S B A M L   `   `   `  ����O  KWebStudio_coursework, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null;"clr-namespace:WebStudio_courseworkWebStudio_coursework  5   	   )    #WebStudio_coursework.EmployeeWindow   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   4local"clr-namespace:WebStudio_coursework     5   	     � Title$  EmployeeWindow��5   	   $	��450��6    $	��800��6-   .��5	      �  � RowDefinitions 5
   
   �� 5      $��1* �6   �� 5      $��1* �6   �� 5      $��1* �6   �� 5      $��1* �6   �� 5      $��1* �6   �� 5      $��1* �6    � ColumnDefinitions 5   
   �� 5      $
��0.7* �6   �� 5      $
��0.7* �6   �� 5      $
��0.5* �6   �� 5      $
��0.7* �6   �� 5      $
��0.7* �6   .+�5   
   �� $��ФИО��6   $��0��6   $��0��6+   $
��5 20q�6;   $��Right=�6I   �� 5   
   $��0��6-   $��1��6:   $
��5 20q�6J   ��6   �� *	user.Name+6J   �� 5   
   $��Должность��6   $��1��6$   $��0��61   $��5q�6A   $��Right=�6L   �� 5   
    �� SelectedValuePath$ ID��67    �� DisplayMemberPath$
 Name��6N   $��1��6�   $��1��6�   $��5 5 5 30q�6�   ��6   �� *d.Positions+ �� SelectedValue 6g   ��  �� Path$ user.Position_ID�6�   �� 5   
   $��Зарплата��6   $��2��6#   $��0��60   $��5q�6@   $��Right=�6K   �� 5   
   $��2��6/   $��1��6<   $��5 5 5 30q�6L   ��6   �� *user.Salary+6L   �� 5   
   $��
Отдел��6   $��3��6    $��0��6-   $��5q�6=   $��Right=�6H   �� 5    
   $ ID��69   $
 Name��6P   $��3��6�   $��1��6�   $��5 5 5 30q�6�   ��6   �� *d.Departments+ 6i   �� $ user.Department_ID�6�   �� 5!   
   $��Дата рождения��6   $��0��6(   $��3��65   $
��5 20q�6E   $��Right=�6S   (  "System.Windows.Controls.DatePicker  5"   
   $��0��6?   $��4��6L   $��
5 20 20 20q�6\      SelectedDate 6   �� *user.DateOfBirth+6\   �� 5#   
   $��Телефон��6   $��1��6"   $��3��6/   $��5q�6?   $��Right=�6J   �� 5$   
   $��1��6/   $��4��6<   $��	5 5 20 30q�6L   ��6   �� *
user.Phone+6L   �� 5%   
   $��
Почта��6   $��2��6    $��3��6-   $��5q�6=   $��Right=�6H   �� 5&   
   $��2��6.   $��4��6;   $��	5 5 20 30q�6K   ��6   �� *
user.Email+6K   �� 5'   
   $��
Адрес��6   $��3��6    $��3��6-   $��5q�6=   $��Right=�6H   �� 5(   
   $��3��60   $��4��6=   $��	5 5 20 30q�6M   ��6   �� *user.Address+6M   �� 5)   
   $��
Логин��6   $��4��6    $��0��6-   $��5q�6=   $��Right=�6H   �� 5*   
   $��4��6.   $��1��6;   $��5 5 5 30q�6K   ��6   �� *
user.Login+6K   �� 5+   
   $��Пароль��6   $��4��6!   $��3��6.   $��5q�6>   $��Right=�6I   �� 5,   
   $��4��61   $��4��6>   $��	5 5 20 30q�6N   ��6   �� *user.Password+6N   �� 5-   
   -   5        $��OK��5-      $��5��6   $��1��6+   $��3��6;   $��5 5 5 30q�6O    �� 	IsDefault . 6r   5.      5/      