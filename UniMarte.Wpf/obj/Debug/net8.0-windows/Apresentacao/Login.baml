   M S B A M L   `   `   `  ����G  CUniMarte.Wpf, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullS.clr-namespace:UniMarte.Wpf.ControleCustomizado UniMarte.Wpf.ControleCustomizado  5   	   E'clr-namespace:UniMarte.Wpf.ApresentacaoUniMarte.Wpf.Apresentacao  5   	   %    UniMarte.Wpf.Apresentacao.Login   5   	   W SPresentationCore, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35^ ZWindowsFormsIntegration, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35H 9http://schemas.microsoft.com/winfx/2006/xaml/presentation      5   	   R NSystem.Xaml, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   X TFontAwesome.Sharp, Version=6.6.0.0, Culture=neutral, PublicKeyToken=d16d1e4e568ec10fFfa=http://schemas.awesome.incremented/wpf/xaml/fontawesome.sharp  5   	   ;custom.clr-namespace:UniMarte.Wpf.ControleCustomizado  5   	   3local'clr-namespace:UniMarte.Wpf.Apresentacao  5   	     � Title$  Login��5
   	    � WindowState$ 	Maximized=�6    � WindowStyle$
 None=�6/   
������  � AllowsTransparency$
 True��5   "   .��5      ��  �� CornerRadius$ 20��6   ��5   
   �� 5       �� ImageSource$$ /Imagens/Fundos/FundoLogin.jpg��6    j� Stretch$ UniformToFill=�6F   ._�5   
   �� $ 20��6   $��5q�6#    J� Opacity$
 0.75Q�67   ��5      �� 5       �� 
StartPoint$	 0 0&�6&   	 �� EndPoint$		 1 1&�67   .��5      � 
 � Color$
 DarkBlue��6#    � Offset$ 0Q�65   � 5      $
 
DarkViolet��6#   $
 0.75Q�67   � 5      $
 Purple��6#   $ 1Q�63   5      ��5      �� 5      $	 0 0&�6&   $		 1 1&�67   .��5      � $
 DarkBlue��6#   $ 0Q�65   � 5      $
 Black��6#   $
 0.75Q�62   5      ._�5!      �  � RowDefinitions 5"      �� 5#      $��30 �6$   �� 5$      $
��Auto �6$   �� 5%      $
��Auto �6$   .+�5(      �� $	��250��6   $��1��6)    �� Orientation$ Vertical=�66   $��Stretch=�6M   $��	0 10 0 10q�6i   .+�5*      �� $$��Administração Museu UniMarte��6    
�������$��25(�6W   $��Medium"�6e   $��
Montserrat)�6y   $��Center=�5+      $
��Wrap=�69    �� Padding$ 
0 10 0 10 q�6M    �� TextAlignment$ Center=�6b   �� 5-      $��	BEM VINDO��6    
�������$��15(�6H   $��Medium"�6V   $��
Montserrat)�6j   $��Center=�5.      $��0 5 0 0q�6:   �� 50      $��Usuário��6    
�������$��12(�6E   $
��Bold"�6S   $��
Montserrat)�6e   $
��Left=�51      $
��Wrap=�67   $��2 5 0 0q�6K   �� 53      -   5         ��Name$ txbNomeUsuario��53      $��13(�6R   $��Medium"�6`   $��
Montserrat)�6t   
������� �� 
CaretBrush
 ��������	#FF5C5454$��	0 0 0 2.5q�54   I   $��28��6e   $��Center=�6q   $��
2, 5, 0, 0q�55      $��	30 0 0 0 q�6.   .��6C   ��56      �� 57      $! /Imagens/Icones/usuario.jpg��6)   $ Uniform=�6S    j� 
AlignmentX$
 Left=�6e   .��58   .   59      �� 5;      $��Senha��6    
�������$��12(�6D   $
��Bold"�6R   $��
Montserrat)�6d   $
��Left=�5<      $
��Wrap=�67   $��2 15 0 0q�6K   G� 5>      -   5         G�Name$ psbSenha��5>   "   $��13(�6P   $��Medium"�6^   $��
Montserrat)�6r   
������� G� 
CaretBrush
 ��������	#FF5C5454$��	0 0 0 2.5q�5?   Q   $��28��6m   $��Center=�6y   $��
2, 5, 0, 0q�5@   "   $��	30 0 0 0 q�66   ��5B      �� 5C      $&  /Imagens/Icones/passwordBox.jpeg��6)   $ Uniform=�6X   $
 Left=�6j   5E      �� 5G      -   5         ��Name$ btnlogin��5G      ���#462AD8$��0q�6D   $��ENTRAR��6X   
�������$��12(�5H   0   $��
Montserrat)�6>   $��40��6W   $	��100��6c   $��Center=�5I      $��Center=�69    � Cursor$  ��6V   $��2��6`    
  Padrao#��[  5J   4   $��0 30 0 0q�6T   5L      5   /UniMarte.Wpf.ControleCustomizado.TecladoVirtual  5M      -   5          Name$ Teclado��5M   (   $��20q�69   $��2��6E   5N      5O      5P      5Q      