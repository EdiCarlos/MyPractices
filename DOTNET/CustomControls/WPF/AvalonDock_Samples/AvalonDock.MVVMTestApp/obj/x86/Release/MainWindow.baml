   M S B A M L   `   `   `  ���� T  PAvalonDock, Version=2.0.1320.0, Culture=neutral, PublicKeyToken=96637cf0d3eefdfbU9clr-namespace:Microsoft.Windows.Shell;assembly=AvalonDockMicrosoft.Windows.Shell  Q MAvalonDock.MVVMTestApp, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null?$clr-namespace:AvalonDock.MVVMTestAppAvalonDock.MVVMTestApp O Kmscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e0891&clr-namespace:System;assembly=mscorlibSystem W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35I6clr-namespace:System.Windows;assembly=PresentationCoreSystem.Windows '   !AvalonDock.MVVMTestApp.MainWindow   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     T PAvalonDock.Themes.Aero, Version=2.0.1320.0, Culture=neutral, PublicKeyToken=nullV RAvalonDock.Themes.VS2010, Version=2.0.1320.0, Culture=neutral, PublicKeyToken=null3
avalonDockhttp://avalondock.codeplex.com     Ishell9clr-namespace:Microsoft.Windows.Shell;assembly=AvalonDock     4local$clr-namespace:AvalonDock.MVVMTestApp     4sys&clr-namespace:System;assembly=mscorlib     K
sysWindows6clr-namespace:System.Windows;assembly=PresentationCore     -     �Name$  
mainWindow�� � Title$ 
MainWindow��$	��350��$	��525�� � 	Resources 4 .AvalonDock.MVVMTestApp.ActiveDocumentConverter   ActiveDocumentConverter5   /AvalonDock.Converters.BoolToVisibilityConverter  BoolToVisibilityConverter��%   &	        &	          .���  � RowDefinitions �� $
��Auto ��� $��* �.+�o� .@�m� $
��File��.@�m� $	��New�� m� Command �� *
NewCommand+m� $
��Open�� �� *OpenCommand+�� m� $
��Save�� �� *ActiveDocument.SaveCommand+m� $��
Save As...�� �� *ActiveDocument.SaveAsCommand+�� m� $��Close�� �� *ActiveDocument.CloseCommand+m� $��Tools��.@�m� $��
Properties�� m� IsCheckable .  m� 	IsChecked �� *FileStats.IsVisible+ �� Mode$ TwoWay=�m� $��Layout��.@�m� $
��Load�� �� *LoadLayoutCommand+ �� ElementName$ 
mainWindow��m� $
��Save�� �� *SaveLayoutCommand+$ 
mainWindow��   AvalonDock.DockingManager  -   	  Name$	 dockManager��$��1��
   AnchorablesSource
 �� *Tools+   DocumentsSource �� *Files+   ActiveContent �� *ActiveDocument+$ TwoWay=� �� 	Converter# [     Theme !  AvalonDock.Themes.AeroTheme  !   LayoutItemTemplateSelector 2 ,AvalonDock.MVVMTestApp.PanesTemplateSelector     FileViewTemplate �� .R��� ���� *TextContent+ �� UpdateSourceTrigger$ PropertyChanged=�   FileStatsViewTemplate �� .R���  �� Orientation$ Vertical=�.+��� ���� *
FileSize+�� ���� *LastModified+'    LayoutItemContainerStyleSelector / )AvalonDock.MVVMTestApp.PanesStyleSelector     	ToolStyle ��  �� 
TargetType.   (AvalonDock.Controls.LayoutAnchorableItem"  .��� $   AvalonDock.Controls.LayoutItem �� Property �@ Title �� Value �� *Model.Title+��  �@ 
IconSource �� *Model.IconSource+��  � y� �� *Model.IsVisible+$ TwoWay=�# [ 	  System.Windows.Visibility 	  Hidden �� ConverterParameter# Z ��  �@ 	ContentId �� *Model.ContentId+��  �@ 
IsSelected �� *Model.IsSelected+$ TwoWay=���  �@ IsActive �� *Model.IsActive+$ TwoWay=�   	FileStyle �� "  .���  �@ Title �� *Model.Title+��  �@�ToolTip �� *Model.FilePath+��  �@ CloseCommand �� *Model.CloseCommand+��  �@ 
IconSource �� *Model.IconSource+��  �@ 	ContentId �� *Model.ContentId+   LayoutUpdateStrategy .
 (AvalonDock.MVVMTestApp.LayoutInitializer
     Layout. "   AvalonDock.Layout.LayoutRoot     	RootPanel. #   AvalonDock.Layout.LayoutPanel     Orientation$ Vertical=��   �AvalonDock.Layout.LayoutGroup`1[[AvalonDock.Layout.ILayoutPanelElement, AvalonDock, Version=2.0.1320.0, Culture=neutral, PublicKeyToken=96637cf0d3eefdfb]]    Children.  *   $AvalonDock.Layout.LayoutDocumentPane  ,   &AvalonDock.Layout.LayoutAnchorablePane  !   Name$! 	ToolsPane���   �AvalonDock.Layout.LayoutPositionableGroup`1[[AvalonDock.Layout.LayoutAnchorable, AvalonDock, Version=2.0.1320.0, Culture=neutral, PublicKeyToken=96637cf0d3eefdfb]]"   
DockHeight$	" 150 �