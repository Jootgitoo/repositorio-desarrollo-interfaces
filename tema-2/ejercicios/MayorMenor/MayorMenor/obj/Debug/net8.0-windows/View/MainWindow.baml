   M S B A M L   `   `   `  ����E  AMayorMenor, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null'clr-namespace:MayorMenor
MayorMenor  5   	       MayorMenor.MainWindow   5   	   W SPresentationCore, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   *localclr-namespace:MayorMenor     5   	     � Title$  
MainWindow��5   	   $	��450��6   $	��800��6)   .��5	      �  � RowDefinitions 5   
   �� 5      $��* �6   6)   �� 5      $��* �6   6)   �� 5      $��* �6   6)    � ColumnDefinitions 5   
   �� 5      $��* �6   6+   �� 5      $��* �6   6+   �� 5      $��* �6   6+   .+�5   
   �� $��Center=�6   $��0,10,0,0q�61   $
��Wrap=�6C   $&�� Indica el numero menor del rango��6W   $	��Top=�6   $��19��6�   $	��184��6�   
������6�   �� 5   
   -   5        $��tbNumeroMenor��5      $��Center=�6'   $��0,46,0,0q�6D    �� TextWrapping$
 Wrap=�6V   $�� ��6j   $	��Top=�6r   $��65��6�   $��59��6�   
���   �
�������6�   �� 5   
   $��2��6   $��Center=�6$   $��0,16,0,0q�6A   $
��Wrap=�6S   $-��'Escriba aquí el numero mayor del rango��6g   $	��Top=�6�   $	��223��6�   
����  �
�������6�   �� 5   
   -   5        $��tbNumeroMayor��5   "   $��2��6   $��Center=�67   $��0,46,0,0q�6T   $
 Wrap=�6f   $�� ��6z   $	��Top=�6�   $��65��6�   $��59��6�   
���   �
�������6�   �� 5    
   -   5         ��Name$ btnJugar��5       $��1��6#   $��Jugar��63   $��Center=�6C   $��2��6`   $��Center=�6m   $��65��6�   $	��118��6�   
������6�   �� 5"   
   $��1��6   $
��Left=�6$   $��	44,25,0,0q�6?   $��1��6R   $
��Wrap=�6_   $(��"Ingrese aquí su numero a adivinar��6s   $	��Top=�6�   $	��194��6�   
�������6�   �� 5#   
   -   5        $��tbNumeroDichoUsuario��5#      $��1��6.   $��Center=�6>   $��1��6[   $
 Wrap=�6h   $�� ��6|   $	��Top=�6�   $��78��6�   $��0,56,0,0q�6�   $��62��6�   �� 5%   
   $��2��6   $!��../View/images/numeros1.jpg��6   6D   �� 5'   
   $��2��6   $��2��6   $ ��../View/images/numero2.jpg��6-   6S   �� 5(   
   -   5        $ btnComprobarNumero��5(      $��2��6-   $��1��6=   $��Comprobar numero��6J   $��Center=�6e   $��0,66,0,0q�6�   $	��Top=�6�   $��31��6�   $	��131��6�   6�   5*      5+      