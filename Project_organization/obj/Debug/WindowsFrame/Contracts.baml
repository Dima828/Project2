   M S B A M L   `   `   `  ����O  KProject_organization, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullU/clr-namespace:Project_organization.WindowsFrame!Project_organization.WindowsFrame  5   	   1    +Project_organization.WindowsFrame.Contracts   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   Alocal/clr-namespace:Project_organization.WindowsFrame     5   	     � Title$/  )Проектная организация��5      $	��450��6+   $	��300��68    � WindowStartupLocation$ CenterScreen=�6D    � 
ResizeMode$ NoResize=�6i   .��5	      � ���	#FFC5E9FF � ColumnDefinitions 5
   
   �� 5      $��50 �6   �� 5      �� 5      $��50 �6    � RowDefinitions 5   
   �� 5      �� 5      �� 5      �� 5      �� 5      .+�5   
   �� $'��!Оформить контракт��6   $��1��6-   $��Center=�6=   $��Center=�6Z   $��18(�6u   6�   �� 5   
   $��1��6   $��1��6!   $��0,0,0,59q�61   Имя заказчика6R   �� 5   
   -   5         ��Name$ Tbx_Name��5   <   $��1��6   $��1��6    $��30��60   6P   �� 5   
   $��2��6   $��1��6!   $��Тип проекта��61   $��0,0,0,58q�6D   6X   �� 5   
   -   5         ��Name$ Cbx_type��5       $��2��6   $��1��62   $��30��6B   .@�5      �� Частный дом6%   �� 5      ,*Строение на территории60   �� 5       Квартира6"   5!      �� 5#   
   $��3��6   $��1��6!   $��Адресс��61   $��0,0,0,58q�6?   6S   �� 5$   
   -   5        $ 
Tbx_Adress��5$   ;   $��3��6   $��30��6   $��1��6+   6Q   �� 5%   
   -   5        $��Офромить��5%      $��1��6$   $��4��64   $	��100��6A   $��30��6M   ���	#FF91ACFF � 	Resources 5&       �� 
TargetType	 �� Property
 �� Value��%_   '��       �� 5'      " ��6   .�5(      �� 	 �@��CornerRadius$
 10��65   5)      5*      5+      5,      5-      