   M S B A M L   `   `   `  ����B  >WpfApp2, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null!clr-namespace:WpfApp2WpfApp2  5   	       WpfApp2.MainWindow   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   'localclr-namespace:WpfApp2     5   	     � Title$  	Prilajuha��5   	   $	��716��6   $	��908��6(   .��5	      � 
������� � ColumnDefinitions 5
   
   �� 5      $	��45* �6   �� 5      $
��754* �6    � RowDefinitions 5   
   �� 5      $
��667* �6   �� 5      $	��33* �6   .+�5   
   �� -   5         ��Name$ TextBoxVvodTexta��5      $
��Left=�6,   $��	18,18,0,0q�6G    �� TextWrapping$
 Wrap=�6Z   $(��"Введите для поиска��6n   $	��Top=�6�   $	��409��6�   $��48��6�   $��2��6�   ���	#FFE6E6E6$��20(�6�   $��Normal"�6�   $��Normal$�6  6  �� 5   
   -   5         ��Name$ ComboBoxSortirovka��5      $��1��6/   $
��Left=�6?   $��
412,18,0,0q�6Z   $	��Top=�6n   $	��158��6�   $��48��6�   5      �� 5   
   -   5        $ ComboBonFiltraciya��5      $��1��6/   $
��Left=�6?   $��
590,20,0,0q�6Z   $	��Top=�6n   $	��148��6�   $��46��6�   5      �� 5   
   $��1��6   $��Сортировка��6    $
��Left=�65   $��
412,18,0,0q�6P   $	��Top=�6d   $��48��6|   $	��134��6�   $��20(�6�   �� 5   
   $��1��6   $��Фильтрация��6    $
��Left=�65   $��
590,20,0,0q�6P   $	��Top=�6d   $��46��6|   $	��125��6�   $��20(�6�   �� 5   
   -   5         ��Name$ People��5      $��
0,90,-1,59q�6%   $��2��69   �� 5   
   -   5        $ People1��5      $��2��6&    �� Orientation$ 
Horizontal=�6:   $��	0,643,0,0q�6S   $��2��6f   5      5       