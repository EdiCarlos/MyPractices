   M S B A M L   `   `   `  ����T  PAvalonDock, Version=2.0.1320.0, Culture=neutral, PublicKeyToken=96637cf0d3eefdfbU9clr-namespace:Microsoft.Windows.Shell;assembly=AvalonDockMicrosoft.Windows.Shell  5   	   Q MAvalonDock.MVVMTestApp, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null?$clr-namespace:AvalonDock.MVVMTestAppAvalonDock.MVVMTestApp 5   	   O Kmscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e0891&clr-namespace:System;assembly=mscorlibSystem 5   	   W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35I6clr-namespace:System.Windows;assembly=PresentationCoreSystem.Windows 5   	   '   !AvalonDock.MVVMTestApp.MainWindow   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   T PAvalonDock.Themes.Aero, Version=2.0.1320.0, Culture=neutral, PublicKeyToken=nullV RAvalonDock.Themes.VS2010, Version=2.0.1320.0, Culture=neutral, PublicKeyToken=null3
avalonDockhttp://avalondock.codeplex.com     5   	   Ishell9clr-namespace:Microsoft.Windows.Shell;assembly=AvalonDock     5   	   4local$clr-namespace:AvalonDock.MVVMTestApp     5   	   4sys&clr-namespace:System;assembly=mscorlib     5   	   K
sysWindows6clr-namespace:System.Windows;assembly=PresentationCore     5   	   -   5          �Name$  
mainWindow��5	   	    � Title$ 
MainWindow��5
   	   $	��350��6   $	��525��6)    � 	Resources 5      4 .AvalonDock.MVVMTestApp.ActiveDocumentConverter   ActiveDocumentConverter5   /AvalonDock.Converters.BoolToVisibilityConverter  BoolToVisibilityConverter��%:   &	        &	        5   
   6(     5   
   6/   5      .��5      �  � RowDefinitions 5   
   �� 5      $
��Auto �6   �� 5      $��* �6   .+�5   
   o� .@�5      m� $
��File��6   .@�5      m� $	��New��6    m� Command 6(   �� *
NewCommand+m� 5      $
��Open��6    6)   �� *OpenCommand+�� 5      m� 5      $
��Save��6    6)   �� *ActiveDocument.SaveCommand+m� 5      $��
Save As...��6    6/   �� *ActiveDocument.SaveAsCommand+�� 5      m� 5      $��Close��6    6*   �� *ActiveDocument.CloseCommand+5      m� 5      $��Tools��6   .@�5      m� $��
Properties��6    m� IsCheckable .  m� 	IsChecked 6/   �� *FileStats.IsVisible+ �� Mode$ TwoWay=�6f   5       m� 5!      $��Layout��6   .@�5"      m� $
��Load��6    6)   �� *LoadLayoutCommand+ �� ElementName$ 
mainWindow��m� 5#      $
��Save��6    6)   �� *SaveLayoutCommand+$ 
mainWindow��5$      5%         AvalonDock.DockingManager  5&   
   -   5        	  Name$	 dockManager��5&   $   $��1��5*   $   
   AnchorablesSource
 5'   $   �� *Tools+   DocumentsSource 5(   $   �� *Files+   ActiveContent 5)   $   �� *ActiveDocument+$ TwoWay=� �� 	Converter# [     Theme 5+      !  AvalonDock.Themes.AeroTheme  5,      !   LayoutItemTemplateSelector 5.      2 ,AvalonDock.MVVMTestApp.PanesTemplateSelector  5/         FileViewTemplate 50      �� 51      .R�52      �� ��6&   �� *TextContent+ �� UpdateSourceTrigger$ PropertyChanged=�53         FileStatsViewTemplate 55      �� 56      .R�57      ��  �� Orientation$ Vertical=�6)   .+�58   "   �� ��6,   �� *
FileSize+�� 59   "   ��6,   �� *LastModified+5:      5;      5=      '    LayoutItemContainerStyleSelector 5@      / )AvalonDock.MVVMTestApp.PanesStyleSelector  5A         	ToolStyle 5B      �� 5C       �� 
TargetType.   (AvalonDock.Controls.LayoutAnchorableItem"  6    .�5D      �� $   AvalonDock.Controls.LayoutItem �� Property �@ Title �� Value 66   �� *Model.Title+�� 5E       �@ 
IconSource 6;   �� *Model.IconSource+�� 5F       � y� 6;   �� *Model.IsVisible+$ TwoWay=�# [ 	  System.Windows.Visibility 	  Hidden �� ConverterParameter# Z �� 5G       �@ 	ContentId 6:   �� *Model.ContentId+�� 5H       �@ 
IsSelected 6;   �� *Model.IsSelected+$ TwoWay=��� 5I       �@ IsActive 69   �� *Model.IsActive+$ TwoWay=�5J         	FileStyle 5L      �� 5M      "  6    .�5N      ��  �@ Title 66   �� *Model.Title+�� 5O       �@�ToolTip 68   �� *Model.FilePath+�� 5P       �@ CloseCommand 6=   �� *Model.CloseCommand+�� 5Q       �@ 
IconSource 6;   �� *Model.IconSource+�� 5R       �@ 	ContentId 6:   �� *Model.ContentId+5S      5U         LayoutUpdateStrategy 5W      .
 (AvalonDock.MVVMTestApp.LayoutInitializer
  5X         Layout. 5[      "   AvalonDock.Layout.LayoutRoot     	RootPanel. 5\      #   AvalonDock.Layout.LayoutPanel     Orientation$ Vertical=�6)   �   �AvalonDock.Layout.LayoutGroup`1[[AvalonDock.Layout.ILayoutPanelElement, AvalonDock, Version=2.0.1320.0, Culture=neutral, PublicKeyToken=96637cf0d3eefdfb]]    Children.  5]      *   $AvalonDock.Layout.LayoutDocumentPane  ,   &AvalonDock.Layout.LayoutAnchorablePane  5^      !   Name$! 	ToolsPane��66   �   �AvalonDock.Layout.LayoutPositionableGroup`1[[AvalonDock.Layout.LayoutAnchorable, AvalonDock, Version=2.0.1320.0, Culture=neutral, PublicKeyToken=96637cf0d3eefdfb]]"   
DockHeight$	" 150 �6G   5_      5`      5a      5b      5c      5d      