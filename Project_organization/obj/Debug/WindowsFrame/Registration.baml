   M S B A M L   `   `   `  ����O  KProject_organization, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullU/clr-namespace:Project_organization.WindowsFrame!Project_organization.WindowsFrame  5   	   4    .Project_organization.WindowsFrame.Registration   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   Alocal/clr-namespace:Project_organization.WindowsFrame     5   	     � Title$/  )Проектная организация��5   	   $	��450��6'   $	��300��64    � WindowStartupLocation$ CenterScreen=�6@    � 
ResizeMode$ NoResize=�6e   .��5	      � ���	#FFC5E9FF � ColumnDefinitions 5
   
   �� 5      $��50 �6   �� 5      �� 5      $��50 �6    � RowDefinitions 5   
   �� 5      �� 5      �� 5      �� 5      �� 5      .+�5   
   �� $��Регистрация��6   $��1��6'   $��Center=�67   $��Center=�6T   $��18(�6o   6   �� 5   
   $��1��6   $��1��6!   $��0,0,0,59q�61   !Придумайте логин6U   �� 5   
   -   5         ��Name$ 	Tbx_Login��5   <   $��1��6   $��1��6    $��30��60   6Q   �� 5   
   $��2��6   $��1��6!   $'��!Придумайте пароль��61   $��0,0,0,58q�6J   6^   G� 5   
   -   5         G�Name$ Tbx_Password��5   ?   $��2��6   $��30��6#   $��1��6/   6W   �� 5   
   $��3��6   $��1��6!   $%��Повторите пароль��61   $��0,0,0,58q�6I   6]   G� 5    
   -   5        $ Tbx_PasswordRemember��5    ?   $��3��6   $��30��6#   $��1��6/   6_   �� 5!   
   -   5        $��Регистрация��5!      $��1��6'   $��4��67   $	��100��6D   $��30��6P   ���	#FF91ACFF � 	Resources 5"       �� 
TargetType	 �� Property
 �� Value��%_   '��       �� 5#      " ��6   .�5$      �� 	 �@��CornerRadius$
 10��65   5%      5&      5'      5(      5)      