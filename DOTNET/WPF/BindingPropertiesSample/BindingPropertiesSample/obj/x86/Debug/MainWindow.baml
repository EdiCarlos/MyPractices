   M S B A M L   `   `   `  ����  BindingPropertiesSample(    "BindingPropertiesSample.MainWindow   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	     � Title$  
MainWindow��5   	   $	��350��6   $	��525��6)   .��5      �  � ColumnDefinitions 5   
   �� 5      6!   �� 5      6!   �� 5	      6!    � RowDefinitions 5   
   �� 5      $��30 �6   �� 5      $��30 �6   .+�5   
   �� $��0��5      ��5      �� 5       �� ElementName$ txtFirstName��6    �� Path$
 Text�65   ��5      �� 5      $ txtFirstName��6   $ 
Background�65   5      �� 5   
   -   5         ��Name$ txtFirstName��5      $��1��6(   
�������6Q   �� 5   
   -   5         ��Name$ txtFirstNameCopy��5      $��2��6.   ��6>   �� $ txtFirstName��$ 
Background���6   ��  �� RelativeSource �� *Self+$ 
Background�6�   �� 5   
   -   5         ��Name$ btnChangeProperties��5      $��1��6.   $��2��6;   $	��100��6O   $��Change��6}   5       5!      