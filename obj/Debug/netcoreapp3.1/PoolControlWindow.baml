   M S B A M L   `   `   `  ����f  bManuel_Fernandez_de_Heredia_Delgado_DI_XAML, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nulli9clr-namespace:Manuel_Fernandez_de_Heredia_Delgado_DI_XAML+Manuel_Fernandez_de_Heredia_Delgado_DI_XAML  5   	   C    =Manuel_Fernandez_de_Heredia_Delgado_DI_XAML.PoolControlWindow   5   	   W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   Klocal9clr-namespace:Manuel_Fernandez_de_Heredia_Delgado_DI_XAML     5   	     � Title$  PoolControlWindow��5   	   $	��450��6#   $	��800��60    � WindowStartupLocation$ Manual=�6<    � Left$	 150��6[   
 � Top$ 50��6f    � 
ResizeMode$ NoResize=�6o   .��5	      � .+�5
   
   �� $��/FondoBase.jpg��6   $��UniformToFill=�6(   6B   �� 5   
   -   5        
�������
�����_�$��Volver��5   ;   $
��Left=�6[   $��706,374,0,0q�6v   $	��Top=�6�   $��35��6�   $��66��6�   &   System.Windows.Controls.DataGrid  5   
   -   5          Name$ poolGrid��5      
�������   AutoGenerateColumns$ False��6d      
IsReadOnly$
 True��6�   $��172,130,172,10q�6�   ��6>   ��  �� Path$ PoolList�	   Columns	 5      0  *System.Windows.Controls.DataGridTextColumn  5      ,  &System.Windows.Controls.DataGridColumn
   Header$

 Sala��6%   1  +System.Windows.Controls.DataGridBoundColumn   Binding 63   �� $
 Name�6S     5      $
 Temperatura��6%    6:   �� $ Temperature�6a     5      $
 Especies��6%    67   �� $ Species�6Z     5      $
 Última Revisión��6%    6>   �� $ 
LastReview�6d     5      $
 Tratamiento��6%    6:   �� $ 	Treatment�6_   5      �� 5   
   -   5        $��Agregar��5      
�����_�
�������$
��Left=�6]   $��
273,83,0,0q�6x   $	��Top=�6�   $��27��6�   $��64��6�   �� 5   
   -   5        $��	Modificar��5      
�����_�
�������$
��Left=�6b   $��
367,83,0,0q�6}   $	��Top=�6�   $��27��6�   $��59��6�   �� 5   
   -   5        $��Eliminar��5      
�����_�
�������$
��Left=�6a   $��
458,83,0,0q�6|   $	��Top=�6�   $��27��6�   $��66��6�   5      5      