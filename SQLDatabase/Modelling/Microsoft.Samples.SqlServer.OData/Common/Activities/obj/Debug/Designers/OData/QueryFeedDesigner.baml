   M S B A M L   `   `   `  ����e  aSystem.Activities.Presentation, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35wTclr-namespace:System.Activities.Presentation;assembly=System.Activities.PresentationSystem.Activities.Presentation  5      �Yclr-namespace:System.Activities.Presentation.View;assembly=System.Activities.Presentation#System.Activities.Presentation.View  5      m iMicrosoft.Samples.SqlServer.Activities, Version=1.0.0.0, Culture=neutral, PublicKeyToken=4c918fcf78b665b6_4clr-namespace:Microsoft.Samples.SqlServer.Activities&Microsoft.Samples.SqlServer.Activities 5      O Kmscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e0891&clr-namespace:System;assembly=mscorlibSystem 5      �_clr-namespace:System.Activities.Presentation.Converters;assembly=System.Activities.Presentation)System.Activities.Presentation.Converters  5      H   BMicrosoft.Samples.SqlServer.Activities.Designers.QueryFeedDesigner   5      W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35^ ZWindowsFormsIntegration, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      dsapTclr-namespace:System.Activities.Presentation;assembly=System.Activities.Presentation     5      jsapvYclr-namespace:System.Activities.Presentation.View;assembly=System.Activities.Presentation     5      Flocal4clr-namespace:Microsoft.Samples.SqlServer.Activities     5      4s&clr-namespace:System;assembly=mscorlib     5      psapc_clr-namespace:System.Activities.Presentation.Converters;assembly=System.Activities.Presentation     5      -   5          � 	Resources  5
      M   GSystem.Activities.Presentation.Converters.ArgumentToExpressionConverter !  ArgumentToExpressionConverterK   ESystem.Activities.Presentation.Converters.ModelToObjectValueConverter  ModelToObjectValueConverter  ShowAsCollapsed �� StringFormat �� Path  ShowAsExpanded � ColumnDefinitions � RowDefinitions �� 
IsEditable �� Text �� DisplayMemberPath �� 
IsReadOnly	 9� 
IsExpanded;   5System.Activities.Presentation.View.ExpressionTextBox
   HintText   ExpressionType   OwnerActivity   
Expression �� Mode �� 	Converter �� ConverterParameter;   5System.Activities.Presentation.WorkflowItemsPresenter   AllowedItemType3  -Microsoft.Samples.SqlServer.Activities.Filter   Items   SpacerTemplate �� TextAlignment   
ItemsPanel �� Orientation �� MaxDropDownHeight  StyleWithCollapse �� 
TargetType �� Property �� Value �� Triggers �� Binding �� Value��%  &	        &	      &	 &     &	 �     7   7   7   &	       5   
   6-     5   
   6+   �� 5   
   .R�5      �� 
���������5      `� 5      $ 	Query {0}��6#   .1�5      �� $ ModelItem.Resource�6"   5      5      5      �� 5   
   .R�5      �  5      �� 5      $��50��6(   �� 5       5      �� 5      �� 5       �� 5!      �� 5"      �� 5#      �� 5$      �� 5%      �� 5&      .+�5)      �� $	��Uri��6   $��0��6'   $��0��65   $
��Left=�6E   $��Center=�6`   �� 5+      $��urlComboBox��6*   $	��175��6   $��0��6=   $��1��6K    . $��3,3,0,5q�6�    6[   �� $ ModelItem.Uri�6�   �� 5-      $��Resource��6   $��1��6,   $��0��6:   $
��Left=�6J   $��Center=�6e   �� 5.      $��resourceComboBox��6V   -   5        $
 Name��5.      $	��175��65   $��3,3,0,5q�6D   $��1��6n   $��1��6|    .  .  6�   �� $ ModelItem.Resource���5/      �� 50      .R�51      �� .+�52   "   �� ��6,   �� $
 Name�53      54      56      9� 58      $��Filter��6�   $��Filter��6   $��2��6+   $��0��69   $��3��6I   $
��Auto��6^   $
��Left=�6m   $��0,0,0,0q�6�   $��Center=�6�   $	��235��6�   	 . .��59      � $
��Auto��6    5:      �� 5;      $��* �6,   �� 5<      $��* �6,    5>      �� 5?      $
��Auto �6/   �� 5@      $
��Auto �6/   �� 5A      $
��Auto �6/   �� 5B      $
��Auto �6/   .+�5E      �� $	��Top��6   $��0��6'   $��0��65   $
��Left=�6E   $��Center=�6`     5G      $	
 All��6*   $��50��69   $��50��6G   $��0��5H      $��1��6#   $��5q�63   " ��5M       5I      �� $ 	ModelItem� 5J      �� $ ModelItem.Top�$ TwoWay=�8   $ In��5M      �� 5O      $
��Skip��6   $��0��6(   $��2��66   $
��Left=�6F   $��Center=�6a     5Q      $

 None��6)   $��0��5R      $��4��6#   $��5q�63   $��50��6>   $��50��6L   " ��5W       5S      �� $ 	ModelItem� 5T      �� $ ModelItem.Skip�$ TwoWay=�8  $ In��5W        5Y      $��1��5Z      $��0��6#   $��4��63   $��0q�5[      $��30��6    "  6/    5\      �� $  ModelItem.FilterActivities� 5]      �� 5^      .R�5_   "   �� 
�������$	��200��6D   $��Center=�6P   $ Center=�6m   $��Italic$�6�   Drop Filter Here6�   5`       5c      �� 5d      .R�5e   "   �� $ Vertical=�6-   5f      5h      5i      5j      �� 5l      $��0,0,3,3q�6   $��Order By��6)   $��3��69   $��0��6G   $
��Left=�6W   $��Center=�6r   �� 5m      $��orderbyListBox��6k   -   5        $��0,0,0,3q�5m      $��3��6,   $��1��6:   $ Select Property Names ...��6J    .  . $	 200��6�   5n      �� 5p      $��Select��6   $��4��6&   $��0��64   $
��Left=�6D   $��Center=�6_   �� 5q      $��selectComboBox��6Z   -   5        $��4��5q      $��1��6)   $ Select Property Names ...��69    .  . $	 200��6�   5r      �� 5t      $��Returns��6   $��5��6+   $��0��69   $
��Left=�6I   $��Center=�6d   �� 5v      $��Center=�6   $��5��6/   $��1��6=   $��0,1,0,0q�5w   a   $��Italic$�6r   ��5v   M   �� $  ModelItem.EntityProperties�$ TwoWay=�8  $	 Out��5w   r   5x      5y      �� 5{   
   " ��6*   .�5|      ��  � ��# �  5}       5~      �� 5       6   �� $ ShowExpanded�	 False6D   .a�5�      ��  � ��# �  5�      5�      5�      5�      5   /System.Activities.Presentation.ActivityDesigner   Icon 5�      L� 5�   
    L� Drawing 5�      �� 5�        �� Rect  5�      � 5�      ! � Location$	! 0,0&�6   " � Size$" 16,16��6/   # �� ImageSource# 5�      �� 5�      $ �� 	UriSource$$ 	Items.png?�6"   5�      5�      .��5�      � .+�5�   
   �� #���  6   ��6G   �� 5�      5�      