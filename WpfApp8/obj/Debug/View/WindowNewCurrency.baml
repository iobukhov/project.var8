   M S B A M L   `   `   `  ����B  >WpfApp8, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null+clr-namespace:WpfApp8.ViewWpfApp8.View  5   	   $    WpfApp8.View.WindowNewCurrency   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   ,localclr-namespace:WpfApp8.View     5   	     � Title$  WindowNewCurrency��5   	   $	��200��6#   $	��350��60   ���#FEF2E4.��5	      �  � RowDefinitions 5
   
   �� 5      $	��40* �6   �� 5      $	��40* �6   �� 5      $	��40* �6   �� 5      $	��40* �6    � ColumnDefinitions 5   
   �� 5      $	��55* �6   �� 5      $	��70* �6   .+�5   
   �� $��0��6   $��0��6!   $��Код:��61   $��Right=�6=   $��Center=�6Y   $��5q�6t   �� 5   
   $��1��6   $��0��6!   $,��&Полное наименование:��61   $��Right=�6M   $��Center=�6i   $��5q�6�   �� 5   
   $��2��6   $��0��6!   $.��(Краткое наименование:��61   $��Right=�6N   $��Center=�6j   $��5q�6�   �� 5   
   -   5         ��Name$
 TbId��5      $��0��6    $��1��6-   $��20��6=   $��50��6I   $
��Left=�6T   $��Center=�6o   $��5q�6�   {�.  ��6�   �� *ID+6�   �� 5   
   -   5        $ TbRole��5      $��1��6"   $��1��6/   $��20��6?   $	��130��6K   $
��Left=�6W   $��Center=�6r   $��5q�6�   ��6�   �� *CurrencyFull+�� 5   
   -   5        $ TbRole2��5      $��2��6#   $��1��60   $��20��6@   $	��130��6L   $
��Left=�6X   $��Center=�6s   $��5q�6�   ��6�   �� *CurrencyShort+�� 5   
   $��1��6   $��3��6%    �� Orientation$ 
Horizontal=�62   $��Right=�6K   $��0,1,0,0q�6g   .+�5      �� -   5         ��Name$ BtSave��5      $��Сохранить��6%   $��25��69   $��Right=�6E   $	��Top=�6a   $��	5,10,10,5q�6y    �� 	IsDefault . ���#FEF2E46�   �� 5      -   5        $ BtCansel��5      $��Отменить��6'   $��25��6:   $��Right=�6F   $	��Top=�6b   $��	5,10,10,5q�6z    �� IsCancel . ���#FEF2E46�   5      5      5      