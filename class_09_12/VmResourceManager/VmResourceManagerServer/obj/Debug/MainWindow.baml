   M S B A M L   `   `   `  ����R  NVmResourceManagerServer, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullA%clr-namespace:VmResourceManagerServerVmResourceManagerServer  5   	   U/clr-namespace:VmResourceManagerServer.ViewModel!VmResourceManagerServer.ViewModel  5   	   W0clr-namespace:VmResourceManagerServer.Converters"VmResourceManagerServer.Converters  6K   (    "VmResourceManagerServer.MainWindow   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   7local%clr-namespace:VmResourceManagerServer     5   	   E	ViewModel/clr-namespace:VmResourceManagerServer.ViewModel     5   	   G
Converters0clr-namespace:VmResourceManagerServer.Converters     6K     � Title$  VM Instance Manager��5	   	   $	��600��6%   $
��1024��62    � 	Resources 5
      >   8VmResourceManagerServer.Converters.StateToImageConverter   StateToImageConverter��%   &	          5   
   6+   5       � DataContext 5      5   /VmResourceManagerServer.ViewModel.MainViewModel  5   
   .��5      �  � ColumnDefinitions 5   
   �� 5      $	��330 �6   �� 5      $��80 �6   �� 5      $��2* �6   .+�5   
   �� $��5q�6   $��Center=�6I   ��6   �� *DeployableInstances+ �� SelectedItem 6f   �� *SelectedDeployableInstance+��5      �� 5      .R�5      �� $��60��6   $	��300��6)   
���   �$��1q�6I   $��5q�6]    �� CornerRadius$ 5��6h   ._�5      ��  �� Orientation$ Vertical=�6%   .+�5      �� $ 
Horizontal=�6)   .+�5   "   �� $��Type:��6(   �� 5   "   $
��Bold"�6A   ��6(   �� *Type+6A   5      �� 5      $ 
Horizontal=�6)   .+�5    "   �� $
��CPU:��6(   �� 5!   "   ��6(   �� *CPUs+�� 5"   "   $
��RAM:��6(   �� 5#   "   ��6(   �� *RAM+5$      5%      5&      5(      5*      �� 5+   
   $��1��6   $��30��6!   $��5q�6-   $��Center=�68   $��Deploy��6S   ��6d   �� *DeployBtnClickCmd+�� 5,   
   $��2��6   $��5q�6'   ��62   �� *DeployedInstances+��5-      �� 5.      .R�5/      �� 
���   �$��1q�61   $ 5��6E   $��80��6V   $��5q�6b   ._�50      �  � RowDefinitions 51      �� 52   "   $��* �60   �� 53   "   $��* �60    55      �� 56   "   $��* �63   �� 57   "   $��* �63   �� 58   "   $��2* �63   �� 59   "   $��* �63   .+�5;      �� $��5q�6=   ��6$   �� *Type+6=   �� 5<      $ 
Horizontal=�6)   $��1��6D   .+�5=   "   �� $��No. of CPUs:��6(   $��5q�6?   �� 5>   "   $��5q�6A   ��6(   �� *CPUs+6A   5?      �� 5@      $ 
Horizontal=�6)   $��1��6D   $��1��6Q   .+�5A   "   �� $
��RAM:��6(   $��5q�67   �� 5B   "   $��5q�6@   ��6(   �� *RAM+6@   5C      �� 5D      $ 
Horizontal=�6)   $��1��6D   $��2��6Q   .+�5E   "   �� $��5q�6H   ��6(   �� *StorageSize+6H   �� 5F   "   $��
GB Storage��6(   $��5q�6=   5G      �� 5H      $ 
Horizontal=�6)   $��1��6D   $��3��6Q   .+�5I   "   �� $��Uptime:��6(   $��5q�6:   �� 5J   "   $��5q�6C   ��6(   �� *UpTime+6C   5K      �� 5L      $��3��6%   ��65   �� *StateChangeBtnClickCmd+.��5M   "   �� $��35��6(   $��35��64   ��6?   �� *State+ �� 	Converter# [  5N      5O      5P      5Q      5S      5T      5U      