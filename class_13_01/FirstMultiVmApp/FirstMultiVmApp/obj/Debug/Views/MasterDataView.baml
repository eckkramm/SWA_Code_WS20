   M S B A M L   `   `   `  ����J  FFirstMultiVmApp, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null=#clr-namespace:FirstMultiVmApp.ViewsFirstMultiVmApp.Views  5      E'clr-namespace:FirstMultiVmApp.ViewModelFirstMultiVmApp.ViewModel  5      *    $FirstMultiVmApp.Views.MasterDataView   5      R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      5local#clr-namespace:FirstMultiVmApp.Views     5      =	ViewModel'clr-namespace:FirstMultiVmApp.ViewModel     5        � DataContext  5      �� *
MasterData+ �� Mode$ OneWay=�   Provider �� Source# [  .��5      �� 
������.+�5   
   �� $��
Stammdaten��6   $��Center=�6%   $��Center=�6@   �� 5   
   $	��150��6Q   $��10q�6]   $��25��6i   ��6   �� *
DemoData+ �� UpdateSourceTrigger$ PropertyChanged=�6i   �� 5   
   $��35��67   $	��100��6C   $
��Save��6O   $��10q�6^   ��6   �� *SaveBtnClickedCmd+6^   5      5      