   M S B A M L   `   `   `  ����  Sample1    Sample1.ExpenseReportPage   5      \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5        N� Title$  ExpenseIt - View Expense��5      .��5      �  � 	Resources 5   
      typeItemTemplate �� XPath  amountItemTemplate��%�   &	        &	 I     �� 5      .R�5      �� ��6   �� $ @ExpenseType��5      �� 5      .R�5      �� ��6   �� $ @Amount��5      5      ��5   
   �� 5       �� ImageSource$ watermark.png��6    � ColumnDefinitions 5   
   �� 5      $	��230 �6   �� 5       � RowDefinitions 5   
   �� 5      $
��Auto �6   �� 5      .+�5    
   �� $��1��6     headerTextStyle#��[ 6    .��6I   Expense Report For:5"      � 5$   
   $��10q�6   $��1��6   $��1��6+    5%      �� 5&      �� 5'       5)      �� 5*      $
��Auto �6    �� 5+      $
��Auto �6    �� 5,      .+�5.      �� $��0��6   $��2��6)   $��0��6=    �� Orientation$ 
Horizontal=�6J   .+�5/      �� $��0,0,0,5q�6   $
��Bold"�6)   $��Name:��6;     
labelStyle#��[ 6L   �� 50      $��0,0,0,5q�6   $
��Bold"�6)   #��[ 6<   ��6`   �� $ @Name��51      �� 52   
   $��0��6   $��2��6%   $��1��69   $ 
Horizontal=�6F   .+�53      �� $��0,0,0,5q�6   $
��Bold"�6)   #��[ 6<   .��6`   Department:6m   �� 54      $��0,0,0,5q�6   $
��Bold"�6)   #��[ 6<   ��6`   �� $ @Department��6�   55      � 56   
   $��0��6   $��2��6    $	��Top=�6-   $
��Left=�6E   .+�57      &   System.Windows.Controls.DataGrid     AutoGenerateColumns .     RowHeaderWidth$ 0Q�63   ��6F   �� $ Expense��	   ColumnHeaderStyle	 58      �� 59      
 �� 
TargetType=  7System.Windows.Controls.Primitives.DataGridColumnHeader"
  6   .�5:      ��  �� Property � �� �� Value$ 35��63   �� 5;       � ��$ 5q�64   �� 5<       � �� �#4E87D467   �� 5=       � ��
 �����67   5>         Columns 5@      0  *System.Windows.Controls.DataGridTextColumn  5A      ,  &System.Windows.Controls.DataGridColumn   Header$ ExpenseType��6)   1  +System.Windows.Controls.DataGridBoundColumn   Binding 6>   �� $ @ExpenseType��  5B      $ Amount��6)    69   �� $ @Amount��5D      5E      5F      5G      5H      