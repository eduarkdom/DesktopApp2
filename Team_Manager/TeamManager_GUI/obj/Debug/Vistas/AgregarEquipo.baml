   M S B A M L   `   `   `  ����J  FTeamManager_GUI, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null?$clr-namespace:TeamManager_GUI.VistasTeamManager_GUI.Vistas  5   	   *    $TeamManager_GUI.Vistas.AgregarEquipo   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   6local$clr-namespace:TeamManager_GUI.Vistas     5   	     � Title$  Agregar Equipo��5   	   $	��500��6    $	��800��6-    � 	Resources 5	         CommonControlStyle �� 
TargetType �� Property �� Value �� BasedOn �� 
TargetType �� CornerRadius ��Name��%M  &	        '��     7   '�� �    7   �� 5
   
   " ��6+   .�5      ��  � ��$ 5q�6(   �� 5       � ��$ 0,0,0,5q�6'   �� 5       � ��$ 1q�60   �� 5       � �� �#9999996,   �� 5       � ��
 �����6+   �� 5       � ��$ 30��6*   5      �� 5   
   " ��6   8   .�5      ��  � �� 5      �� 5      " ��6&   .R�5      �� ���#999999$��1q�67   $ 5��6K   ._�5      �� $ PART_ContentHost��66   $��0q�6+   66   5      5      5      5      �� 5    
   " ��6   8   .�5!      ��  � ��
 �����6+   �� 5"       � �� 5#      �� 5$      " ��6&   .R�5%      �� #��z��6!   #��z��5&   !   #��z��5'   !   $ 5��5(   !   ._�5)      �� $��Center=�6/   $��Center=�6L   5*      5+      5-      5.      5/      .��51      � -   5        	 �Name$	 gAgregarEquipo��51      .+�52   
   �� -   5        
 ��Name$
 	lblTitulo��52      $��Agrega un Equipo��6#   $��Center=�6>   $	��Top=�6[   $��24(�6s   $��0,-5,0,0q�6�   �� 53   
   -   5         ��Name$ spAgregarEquipo��53   ;   $��209,42,209,16q�6   $	��500��6,   .+�54      �� -   5        $
 lblNombreEquipo��54   -   $��Nombre Equipo:��6   6-   �� 55      -   5         ��Name$ txtNombreEquipo��55      $��0,0,0,5q�6/   �� 57      -   5        $
 lblCantidadJugadores��57   5   $��Cantidad de Jugadores:��6   65   �� 58      -   5        $ txtCantidadJugadores��58      $��0,0,0,5q�64   6E   �� 5:      -   5        $
 lblNombreDT��5:   -   $��Nombre del DT:��6   6-   �� 5;      -	   5        $ txtNombreDT��5;      $��0,0,0,5q�6,   �� 5=      -
   5        $
 lblTipoEquipo��5=   .   $��Tipo de Equipo:��6   6.   �� 5>      -   5         ��Name$ cmbTipoEquipo��5>      $��0,0,0,5q�6.   $��31��6?   $��Center=�6K    �� 
IsEditable .   �� SelectedIndex$ 0��6�   .@�5?      �� -   5         ��Name$
 cbi1��5?   G   $��Seleccionar��6   {�.  6G   �� 5@      -   5        $
 cbi2��5@   3   $��	Masculino��6   63   �� 5A      -   5        $
 cbi3��5A   2   $��Femenino��6   62   5B      �� 5D      -   5        $
 lblCapitanEquipo��5D   2   $��Capitán del Equipo:��6   62   �� 5E      -   5        $ txtCapitanEquipo��5E      $��0,0,0,5q�60   �� 5G      -   5        $ spAgregarEquipoCheckBox��5G   2    �� Orientation$ 
Horizontal=�6   .+�5H      �� -   5        $
 lblTieneSub21��5H      $��¿Tiene Sub-21?��6/   $��92��6H   $��0,0,0,5q�6S   �� 5I      -   5         ��Name$ chkTieneSub21��5I      $�� ��62    J� RenderTransformOrigin$ 
3.88,0.606&�6=   $��	4,-1,-2,0q�6`   $��Center=�6t   $��25��6�   $��73��6�   $��Center=�6�   $
��Left=�6�   $��Center=�6�   $��10,0,0,0q�6   d� 	IsChecked$ FalseY�6  5J      �� 5L      -   5         ��Name$ bntAgregarEquipo��5L      $��Agregar Equipo��6/   $ 0.5,0.5&�6d   $��18(�6�   
�������$��0,5,0,0q�6�   ���	#FF3F92AE$��2,2,2,2q�6�    � IsSharedSizeScope . $��39��6�   $��Center=�6	  5M      5N      5O      