   M S B A M L   `   `   `  ����  DataProviderSample"    DataProviderSample.RSSReader   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	     � Title$  
RSS Reader��5   	   $	��500��6   $	��700��6)    � 	Resources 5         Blog � Source��%W   &	        � 5   
   $0 *http://blogs.msdn.com/adam_nathan/rss.aspx?�6'   5      5      .��5	      ]�  � DataContext 6   ��  �� Source# [   �� XPath$ /rss/channel/item��.+�5
   
   �� $	��Top=�6   ��6'   �� # [   �� BindsDirectlyToSource .  �� Path$ Source� �� UpdateSourceTrigger$ PropertyChanged=��� 5   
   $	��Top=�6   $��14(�6R   $
��Bold"�6`   ��6%   �� $ /rss/channel/title��6`   �� 5   
   $	��Top=�6   ��6%   �� $ /rss/channel/description���� 5   
   $
��Left=�6   	 �� DisplayMemberPath$	 title��6(   $
 �� IsSynchronizedWithCurrentItem$

 TrueY�6Z   $	��300��6   ��6B   �� 6    � 5   
     � Source 6   �� $
 link��5      5      