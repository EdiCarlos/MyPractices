   M S B A M L   `   `   `  ����  SampleWindowsApp%    SampleWindowsApp.CommandsSample   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	     � Title$  CommandsSample��5   	   $	��300��6    $	��373��6-   .��5      ��  �� Orientation$ 
Horizontal=�6   $��25��6*   .+�5   
   �� $	��Cut��6   ��6   ��  �� ElementName$ 	textBlock����6O   ��  �� RelativeSource �� *Self+ �� Path$ Command.Text��� 5   
   $
��Copy��6   ��6    �� $ 	textBlock����6P   ��  �� *Self+$ Command.Text��� 5	   
   $��Paste��6   ��6!   �� $ 	textBlock����6Q   ��  �� *Self+$ Command.Text��� 5
   
   $
��Undo��6   ��6    �� $ 	textBlock����6P   ��  �� *Self+$ Command.Text��� 5   
   $
��Redo��6   ��6    �� $ 	textBlock����6P   ��  �� *Self+$ Command.Text��� 5   
   -   5         ��Name$ 	textBlock��5      $	��200��6%   
����� �61   5      5      