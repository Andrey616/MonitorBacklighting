   M S B A M L   `   `   `  ����Q  MMonitorBacklightingWPF, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null?$clr-namespace:MonitorBacklightingWPFMonitorBacklightingWPF  5   	   '    !MonitorBacklightingWPF.MainWindow   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   6local$clr-namespace:MonitorBacklightingWPF     5   	     � Title$  
MainWindow��5   	   $	��450��6   $	��800��6)   .��5
      � -   5         �Name$	 Box��5
      ���	#FF3C3C3C � RowDefinitions 5   
   �� 5      $��86.808 �6   �� 5      $	��100 �6   �� 5      $	��100 �6   �� 5      $	��100 �6    � ColumnDefinitions 5   
   �� 5      $	��100 �6   �� 5      $	��100 �6   .+�5   
   �� $��0��6   $��/wheel1.png��6    $
��Fill=�65   $	��100��6D   $	��100��6P   $��	0,0,0,100q�6]   $��2��6p   $��1��6�   �� 5   
   $��1��6   $��/wheel2.png��6    $
��Fill=�65   $	��100��6D   $	��100��6P   $��	0,0,0,100q�6]   $��2��6p   $��1��6�   �� 5   
   $��0��6   $��/wheel3.png��6    $
��Fill=�65   $	��100��6D   $	��100��6P   $��	0,0,0,100q�6]   $��2��6p   $��2��6�   �� 5   
   $��1��6   $��/wheel4.png��6    $
��Fill=�65   $	��100��6D   $	��100��6P   $��	0,0,0,100q�6]   $��2��6p   $��2��6�   A� 5   
   $
��Left=�6   $��62��6-   ���	#FF8C8B83$��Center=�6M   $��62��6h   
���  ��$��2��6~   $��69,0,0,0q�6�   $��2��6�   $��1��6�   �� 5    
   -   5         ��Name$ 	ColorText��5       $
��Left=�6&    �� TextWrapping$
 Wrap=�6A   $��TextBox��6U   $	��Top=�6d   $	��120��6|   $��2��6�   $��39,0,0,0q�6�   $��3��6�   �� 5!   
   -   5         ��Name$ ColorPep��5!      $��10��6#   $��10��6.   
���   �$��1q�6O    �� CornerRadius$ 5��6c   
�������$��
3,37,87,53q�6�   $��1��6�   $��1��6�   ._�5"      �� -   5         J� Opacity$ 0Q�5"      5$      5%      A� 5&   
   $��2��6   $��42,42,44,43q�6&   $��2��6;   $��1��6L   $	��115��6Y   5.      5/      