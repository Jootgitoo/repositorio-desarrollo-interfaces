   M S B A M L   `   `   `  ����G  CtpvMercadona, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null+clr-namespace:tpvMercadonatpvMercadona  5   	       tpvMercadona.MainWindow   5   	   W SPresentationCore, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   ,localclr-namespace:tpvMercadona     5   	     � Title$  
MainWindow��5   	   $	��450��6   $	��800��6)   .��5	      � .+�5   
   �� $��../images/mercadona.png��6   $��	1,0,1,340q�61   6G   �� 5   
   $��
0,94,400,0q�6   .@�5      �� $��Comida��6   .��5      � ���#C9F4CA � ColumnDefinitions 5      �� 5      $	��49* �6+   �� 5      $
��148* �6+   .+�5      �� -   5        $��btnCarne��5      $
��Left=�6-   $��	27,27,0,0q�6H   $	��Top=�6[   $	��100��6s   $	��100��6�   ���#F2F0F5$��2��6�   .��5      �� $��../images/carne.jpg��6    6?   5      �� 5      -   5        $��btnCereales��5      $
��Left=�60   $��
165,27,0,0q�6K   $	��Top=�6_   $	��100��6w   $	��100��6�   ���#F2F0F5$��1��6�   .��5      �� $��../images/cereales.jpg��6    6B   5      �� 5      -   5        $��
btnChuches��5      $
��Left=�6/   $��165,174,0,0q�6J   $	��Top=�6_   $	��100��6w   $	��100��6�   ���#F2F0F5$��1��6�   .��5      �� $��../images/chuches.jpg��6    $��82��6?   $��90��6K   5      �� 5       -   5        $��btnPan��5       $
��Left=�6+   $��
27,174,0,0q�6F   $	��Top=�6Z   $	��100��6r   $	��100��6   ���#F2F0F5$��2��6�   .��5!      �� $��../images/pan.jpg��6    6=   5"      5#      5'      �� 5(      $��	Cosmetica��6   .��5)      � ���#C9F4CA.+�5*      �� -   5        $��
btnColonia��5*      $
��Left=�6/   $��	29,28,0,0q�6J   $	��Top=�6]   $	��100��6u   $	��100��6�   .��5+      �� $��../images/colonia.jpg��6    $��75��6?   $��90��6K   6X   5,      �� 5.      -   5        $��btnDesodorante��5.      $
��Left=�63   $��
270,28,0,0q�6N   $	��Top=�6b   $	��100��6z   $	��100��6�   .��5/      �� $��../images/desodorante.jpg��6    $��68��6C   $��93��6O   6\   50      �� 52      -   5        $��btnJabon��52      $
��Left=�6-   $��
29,189,0,0q�6H   $	��Top=�6\   $	��100��6t   $	��100��6�   .��53      �� $��../images/jabon.jpg��6    $��68��6=   $��93��6I   6V   54      �� 56      -   5        $��btnPastaDientes��56      $
��Left=�64   $��270,189,0,0q�6O   $	��Top=�6d   $	��100��6|   $	��100��6�   .��57      �� $ ��../images/pastaDientes.jpg��6    $��68��6D   $��93��6P   6]   58      5:      5<      5=      &   System.Windows.Controls.DataGrid  5?   
   -	   5        $��dgListaProductos��5?      $��400,117,0,0q�6+      AutoGenerateColumns$ False��6@      Columns 5@      0  *System.Windows.Controls.DataGridTextColumn  5A      ,  &System.Windows.Controls.DataGridColumn   Header$ Nombre��6%   1  +System.Windows.Controls.DataGridBoundColumn   Binding 65   �� *Nombre+6R     5B      $ Precio��6%    65   �� *Precio+6R   5D      5F      5G      