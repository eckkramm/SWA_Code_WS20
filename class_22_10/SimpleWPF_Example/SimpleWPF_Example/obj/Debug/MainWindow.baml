   M S B A M L   `   `   `  ����L  HSimpleWPF_Example, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null5clr-namespace:SimpleWPF_ExampleSimpleWPF_Example  5   	   "    SimpleWPF_Example.MainWindow   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   1localclr-namespace:SimpleWPF_Example     5   	     � Title$  
MainWindow��5   	   $	��450��6   $	��800��6)    � DataContext 5	         SimpleWPF_Example.UILogic  5
   
   .��5      �  � RowDefinitions 5   
   �� 5      $��40 �6   �� 5      $��40 �6   �� 5      $��* �6    � ColumnDefinitions 5   
   �� 5      $	��200 �6   �� 5      $	��200 �6   �� 5      $	��100 �6   �� 5      $��* �6   .+�5   
   �� $��3��6   $��Start generating��6!   $��10q�6d   ��6<   �� *StartBtnClickedcmd+6d   �� 5   
   $��0��6   $��1��6    $��Waiting��6-   $
��10,5q�6?   �� 5   
   $��1��6   $��1��6    $��Ready��6-   $
��10,5q�6=   �� 5   
   $��3��6   $��1��6    $��Details��6-   $
��10,5q�6?   �� 5   
   $��0��6   $��2��6#   $��10q�60   ��6<   �� *WaitingList+�� 5   
   $��1��6   $��2��6#   $��10q�60    �� SelectedItem 6<   �� *SelectedReadyEntry+��6h   �� *	ReadyList+6�   �� 5   
   $��2��6   $��2��6   $��>>��6.   $��Center=�6;   $��50��6~   $��50��6�   ��6V   �� *DetailBtnClickedCmd+6�   &   System.Windows.Controls.DataGrid  5   
      AutoGenerateColumns .  $��3��6/   $��2��6?   $��10q�6L   ��6X   �� *SelectedCargo+   Columns 5       0  *System.Windows.Controls.DataGridTextColumn  5!      ,  &System.Windows.Controls.DataGridColumn   Header$ Description��6%   1  +System.Windows.Controls.DataGridBoundColumn   Binding 6:   �� *Description+  5"      $ Amount��6%    65   �� *Amount+  5#      $ Weight��6%    65   �� *Weight+5%      5'      5(      