   M S B A M L   `   `   `  ����M  ItpvCamisetasFutbol, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null7 clr-namespace:tpvCamisetasFutboltpvCamisetasFutbol  5   	   #    tpvCamisetasFutbol.MainWindow   5   	   W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   2local clr-namespace:tpvCamisetasFutbol     5   	     � Title$  
MainWindow��5   	   $	��450��6   $	��800��6)   .��5
      � .+�5   
   &   System.Windows.Controls.DataGrid  -   5        $��dgCamisetas��5      $��10,10,314,229q�6&      AutoGenerateColumns .     Columns 5      0  *System.Windows.Controls.DataGridTextColumn  5      ,  &System.Windows.Controls.DataGridColumn   Header$ ID��6%   1  +System.Windows.Controls.DataGridBoundColumn   Binding 61   �� *
IdProducto+  5      $ Precio��6%    65   �� *Precio+  5      $ Descripcion��6%    6:   �� *Descripcion+  5      $ Tipo Producto��6%    6<   �� *IdTipoProducto+5      �� 5   
   -   5        $
��Left=�5      $��
514,22,0,0q�6-   $	��Top=�6A   $��70��6Y   $��80��6e   .��5      �� -   5         ��Name$ primeraEquipacionFCB2425��5      $(��"../images/equipacion-FCB-24-25.jpg��66   $��57��6b   6p   5      �� 5   
   -   5        $
��Left=�5      $��
674,22,0,0q�6,   $	��Top=�6@   $��70��6X   $��80��6d   .��5      �� -   5        $ primeraEquipacionMadrid24��5      $%��../images/equipacionRM24-25.jpg��67   $��53��6`   $��60��6k   6y   5      �� 5!   
   -   5        $
��Left=�5!      $��514,115,0,0q�6-   $	��Top=�6B   $��70��6Z   $��80��6f   .��5"      �� -   5        $ edicionLimitadaRM��5"      $'��!../images/edicion-limitada-rm.jpg��6/   6\   5#      �� 5%   
   -   5        $
��Left=�5%      $��674,115,0,0q�6-   $	��Top=�6B   $��70��6Z   $��80��6f   .��5&      �� -	   5        $ edicionLimitadaFCB��5&      $(��"../images/edicion-limitada-fcb.jpg��60   6^   5'      �� 5)   
   -
   5        $
��Left=�5)      $��514,217,0,0q�6-   $	��Top=�6B   $��70��6Z   $��80��6f   .��5*      �� -   5        $ primeraEquipacionATM��5*      $I��C../images/camiseta-atletico-madrid-primera-equipacion-2024-2025.jpg��62   6�   5+      �� 5-   
   -   5        $
��Left=�5-      $��674,217,0,0q�6-   $	��Top=�6B   $��70��6Z   $��80��6f   .��5.      �� -   5        $ primeraEquipacionAlba��5.      $5��/../images/Primera-equipacion-Albacete-24-25.jpg��63   6n   5/      �� 51   
   -   5        $
��Left=�51      $��514,319,0,0q�6-   $	��Top=�6B   $��70��6Z   $��80��6f   .��52      �� -   5        $ segundaEquipacionAlaves��52      $4��.../images/Segunda-equipacion-Alavés-24-25.jpg��65   6n   53      �� 55   
   -   5        $
��Left=�55      $��674,319,0,0q�6-   $	��Top=�6B   $��69��6Z   $��78��6f   .��56      �� -   5        $ primeraEquipacionBetis��56      $1��+../images/Primera-equpacion-Betis 24-25.jpg��64   6k   57      �� 5:   
   $
��Left=�6   $��	0,222,0,0q�6/   $	��Top=�6B   $��3��6Z   $	��496��6e   �� 5;   
   $
��Left=�6   $��	279,0,0,0q�6/   $��Center=�6B   $��9��6]   $	��434��6h    J� RenderTransformOrigin$ 0.5,0.5&�6t   z�5<      V� 5=      .~�5>      �� �� 5?      �� 5@       �� Angle$ -89.934Q�6&   T� 5A      5B      5D      � 5H   
   $��10,230,314,100q�6   ���#CADEE65J      �� 5L   
   -   5        $��
tbSubtotal��5L      $
��Left=�6$   $��
28,279,0,0q�6?    �� TextWrapping$
 Wrap=�6S   $�� ��6g   $	��Top=�6o   $	��100��6�   $��19��6�   �� 5M   
   $
��Left=�6   $��
28,244,0,0q�6/   $
��Wrap=�6C   $��Subtotal��6W   $	��Top=�6g   ���#CADEE6$��19��6�   $��60��6�   	 �� TextAlignment$	 Center=�6�   �� 5N   
   $
��Left=�6   $��171,244,0,0q�6/   $
��Wrap=�6D   $��	Descuento��6X   $	��Top=�6i   ���#CADEE6$��19��6�   $��60��6�   $	 Center=�6�   �� 5O   
   -   5        $��tbDescuento��5O   %   {�.  $
��Left=�68   $��171,279,0,0q�6S   $
 Wrap=�6h   $�� ��6|   $	��Top=�6�   $	��100��6�   $��19��6�   �� 5P   
   $
��Left=�6   $��327,244,0,0q�6/   $
��Wrap=�6D   $��Precio total ��6X   $	��Top=�6m   ���#CADEE6$��19��6�   $��73��6�   $	 Center=�6�   �� 5Q   
   -   5        $��tbPrecioTotal��5Q      $
��Left=�6'   $��327,279,0,0q�6B   $
 Wrap=�6W   $�� ��6k   $	��Top=�6s   $	��129��6�   $��19��6�   �� 5T   
   -   5        $��Pagar��5T      $
��Left=�6!   $��
10,358,0,0q�6<   $	��Top=�6P   $��50��6h   $	��120��6t   ���#9ADB9A6�   �� 5U   
   -   5        $��Abrir cajón��5U      $
��Left=�6'   $��188,359,0,0q�6B   $	��Top=�6W   $��50��6o   $	��120��6{   ���#DBC3926�   �� 5V   
   -   5        $��Eliminar articulo��5V      $
��Left=�6-   $��366,359,0,0q�6H   $	��Top=�6]   $��50��6u   $	��120��6�   ���#DB76726�   �� 5W   
   $
��Left=�6   $��	0,339,0,0q�6/   $	��Top=�6B   $��3��6Z   $	��496��6e   5Y      5Z      