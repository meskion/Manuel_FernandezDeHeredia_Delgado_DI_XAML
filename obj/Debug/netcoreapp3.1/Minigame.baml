   M S B A M L   `   `   `  ����f  bManuel_Fernandez_de_Heredia_Delgado_DI_XAML, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nulli9clr-namespace:Manuel_Fernandez_de_Heredia_Delgado_DI_XAML+Manuel_Fernandez_de_Heredia_Delgado_DI_XAML  5   	   :    4Manuel_Fernandez_de_Heredia_Delgado_DI_XAML.Minigame   5   	   W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   Klocal9clr-namespace:Manuel_Fernandez_de_Heredia_Delgado_DI_XAML     5   	     � Title$  Minigame��5   	   $	��450��6   $	��800��6'    � WindowStartupLocation$ Manual=�63    � Left$	 150��6R   
 � Top$ 50��6]    � 
ResizeMode$ NoResize=�6f   .��5	      � .+�5
   
   �� $��/FondoBase.jpg��6   $��UniformToFill=�6(   6B   �� 5   
   -   5        
�������
�����_�$��Volver��5   ;   $
��Left=�6[   $��706,374,0,0q�6v   $	��Top=�6�   $��35��6�   $��66��6�   �� 5   
   $��/pufferfish.png��6�   $
��Fill=�6�    �� StretchDirection$
 Both=�6�   $��Center=�6�   $��Center=�6�   ��6   ��  �� ElementName$ 
sizeSlider�� �� Path$ Value� �� Mode$ OneWay=���6S   �� $ 
sizeSlider��$ Value�$ OneWay=�6�   �� 5   
   -   5        	 ��Name$	 
sizeSlider��5      $��Center=�6%   $��	0,324,0,0q�6B   $	��Top=�6U   $	��602��6m   $��36��6y   
 � Maximum$	
 800Q�6�    � Minimum$ 40Q�6�    J� Effect 5      3  -System.Windows.Media.Effects.DropShadowEffect  5      5      �� 5   
   
�������$��Center=�6-   $��	0,342,0,0q�6J   $
��Wrap=�6]   $	��Top=�6q   $��43��6�   $	��424��6�   �� 6�   $U�OLos peces Globo pueden inflarse hasta superar varias veces su tamaño original!��6�   �� 6�    � Language$ es-es�6  $+�% Mueve el Slider para ver como cambia��6  �� 6B  �� 6N  $ es-es�6R  6f  5      5      