   M S B A M L   `   `   `  ����G  CUniMarte.Wpf, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullE'clr-namespace:UniMarte.Wpf.ApresentacaoUniMarte.Wpf.Apresentacao  5   	   /    )UniMarte.Wpf.Apresentacao.PopupSatisfacao   5   	   W SPresentationCore, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35^ ZWindowsFormsIntegration, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35H 9http://schemas.microsoft.com/winfx/2006/xaml/presentation      5   	   R NSystem.Xaml, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   9local'clr-namespace:UniMarte.Wpf.Apresentacao     5   	     � AllowsTransparency$
  True��5      
������  � Title$ PopupSatisfacao��5   	   $	��200��6!   $	��400��6.    � WindowStyle$
 None=�6:   .��5	      ��  �� CornerRadius$ 20��6   ��5
   
   �� 5       �� ImageSource$$ /Imagens/Fundos/FundoLogin.jpg��6    j� Stretch$ UniformToFill=�6F   ._�5   
   �� $��5q�6    J� Opacity$
 0.75Q�6%   ��5      �� 5       �� 
StartPoint$	 0 0&�6&    �� EndPoint$	 1 1&�67   .��5      � 	 � Color$	 DarkBlue��6#   
 � Offset$
 0Q�65   � 5      $	 
DarkViolet��6#   $

 0.75Q�67   � 5      $	 Purple��6#   $
 1Q�63   5      ��5      �� 5      $	 0 0&�6&   $	 1 1&�67   .��5      � $	 DarkBlue��6#   $
 0Q�65   � 5      $	 Black��6#   $

 0.75Q�62   5      ._�5      �  � RowDefinitions 5      �� 5      $��* �6$   �� 5       $
��Auto �6$   .+�5"      �� -   5         ��Name$ txbPopupSatisfacao��5"      $���}Gostaríamos de saber sua opinião! Deseja responder a um breve questionário de satisfação sobre sua experiência conosco?��5#      
�������$��22(�5$   /   $��WrapWithOverflow=�6=   $��
MontSerrat)�6]    �� TextAlignment$ Center=�6u   $��0��6�   �� 5%       �� Orientation$ 
Horizontal=�6   $��1��66   $��Center=�6C   $��Center=�6`   .+�5&      �� -   5         ��Name$ btnNao��5&      ���#462AD8$��0q�6B   $	��NAO��6V   
�������$��12(�5'   0   $��
Montserrat)�6>   $��40��6W   $	��100��6c   $��Center=�5(      $��Center=�69    � Cursor$  ��6V    
  Padrao#��[  5)   2   $��10q�6R   �� 5*      -   5        $ btnSim��5*      ���#462AD8$��0q�6B   $	��SIM��6V   
�������$��12(�5+   0   $��
Montserrat)�6>   $��40��6W   $	��100��6c   $��Center=�5,      $��Center=�69   $  ��6V   #��[  5-   2   $��10q�6R   5.      5/      50      51      52      