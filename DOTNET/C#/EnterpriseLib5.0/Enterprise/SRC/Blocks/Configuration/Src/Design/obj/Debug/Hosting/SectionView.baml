   M S B A M L   `   `   `  ����{  wMicrosoft.Practices.EnterpriseLibrary.Configuration.DesignTime, Version=5.0.414.0, Culture=neutral, PublicKeyToken=null�Sclr-namespace:Microsoft.Practices.EnterpriseLibrary.Configuration.Design.ConvertersEMicrosoft.Practices.EnterpriseLibrary.Configuration.Design.Converters  5      �Pclr-namespace:Microsoft.Practices.EnterpriseLibrary.Configuration.Design.HostingBMicrosoft.Practices.EnterpriseLibrary.Configuration.Design.Hosting  5      T    NMicrosoft.Practices.EnterpriseLibrary.Configuration.Design.Hosting.SectionView   5      \ XPresentationFramework, Version=3.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=3.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35^ ZWindowsFormsIntegration, Version=3.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=3.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5      8x,http://schemas.microsoft.com/winfx/2006/xaml    5      >d2http://schemas.microsoft.com/expression/blend/2008    5      Hmc;http://schemas.openxmlformats.org/markup-compatibility/2006    5      h
ConvertersSclr-namespace:Microsoft.Practices.EnterpriseLibrary.Configuration.Design.Converters    5      bHostingPclr-namespace:Microsoft.Practices.EnterpriseLibrary.Configuration.Design.Hosting    5      _   YMicrosoft.Practices.EnterpriseLibrary.Configuration.Design.Hosting.ConfigurationResources    MergedDictionaries$B  <ExpanderDictionary;ViewModelDataTemplates;ExtendedDictionary��5	       � 	Resources 5
      n   hMicrosoft.Practices.EnterpriseLibrary.Configuration.Design.Converters.InverseBooleanToCollapsedConverter &  "InverseBooleanToCollapsedConverter  BackgroundSectionStyle �� 
TargetType �� Property �� Value �� Triggers P� Property P� Value �� Angle��%�  &	        &	        5   
   68   �� 5   
   " ��6/   .�5      ��  � ��$
 Left=�64   �� 5       � ��$	 Top=�62   �� 5       �@J�Opacity$
 0.35Q�6(   �� 5       � ��$ 16(�6)   �� 5       � ��$ 	ExtraBold"�6+   �� 5       �@J�IsHitTestVisible .  6#   �� 5       � ��# � ��6+   �� 5       �@��TextAlignment$ Right=�6.   �� 5       � ��$ Expanded&�6,   �� 5       � ��$ NoWrap=�6-   �� 5       � |� .  6*   �� 5       � ��$	 0,5q�6'   �� 5       � ��$ 0��6'   �� 5       � ��$ 0��6&    5      P� 5       � y�$ Visible=�60   . �5      ��  � ��$
 Auto��6.   �� 5       � ��$
 Auto��6/   �� 5        �@�LayoutTransform 5!      V� 5"      .~�5#   "   �� �� 5$   "   �� 5%   "   $	 -90Q�62   T� 5&   "   5'      5)      5*      5,      5-      .��5/      � 	 � RowDefinitions	 50   
   �� 51      $
��Auto �6   �� 52      $
��Auto �6   �� 53      $��* �6   .+�56   
   �� -   5        
 ��Name$
 scrollViewer��56      $
��Auto=�6-   $
��Auto=�6R   .��57      � -   5         �Name$ Environments��57      $��0��6)    � DataContext 66   �� *Environments+y�6[   �� *	IsEmpty+ �� 	Converter# [  .+�58      �� -   5         ��Name$ 	TextBlock��58      #���  59      $
��Left=�6>   $��Stretch=�6Y   Environments5;      �� 5=      |�.  $��20,0,0,0q�5?   C   y�5>      �� *
Visibility+ �� ElementName$ Environments����5?   +   �� 6C   5@      5A      �� 5B   
   $��1��6    �� ResizeDirection$
 Rows=�6$   $��6��6;   $��Stretch=�6F   $��Stretch=�6d   #��� ��6�   $	��0,1q�67  y�6�   �� *Environments.IsEmpty+# [  67  �� 5C   
   $��2��6   $
��Auto=�6$   $
��Auto=�6I   .��5D      � $��2��6    6    �� *CurrentConfigurationSource+.+�5E      �� $��Center=�6   $��40,0,0,0q�69   $��24(�6K   ���	#FFD8E2F4 �� Padding$ 3q�6p   $��Center=�6|   $��SemiBold"�6�    �� TextAlignment$ Center=�6�   y�6�   �� *
HasItems+# [  $ itemsControl�� �� Mode$ Default=�DBGet started by adding a block or selecting a wizard from the menu.6�  �� 5F      #���  6   �� 6N   $�Blocks Configuration��6R   6q   �� 5G      -   5         ��Name$ itemsControl��5G      |�.  $��20,0,0,0q�6h   ��6G   �� *
Sections+6h   5H      5I      5J      5K      