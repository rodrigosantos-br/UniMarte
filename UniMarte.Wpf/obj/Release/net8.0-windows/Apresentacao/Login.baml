   M S B A M L   `   `   `  ���� G  CUniMarte.Wpf, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullS.clr-namespace:UniMarte.Wpf.ControleCustomizado UniMarte.Wpf.ControleCustomizado  E'clr-namespace:UniMarte.Wpf.ApresentacaoUniMarte.Wpf.Apresentacao  %    UniMarte.Wpf.Apresentacao.Login   W SPresentationCore, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35^ ZWindowsFormsIntegration, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35H 9http://schemas.microsoft.com/winfx/2006/xaml/presentation      R NSystem.Xaml, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     @d2http://schemas.microsoft.com/expression/blend/2008     Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     X TFontAwesome.Sharp, Version=6.6.0.0, Culture=neutral, PublicKeyToken=d16d1e4e568ec10fFfa=http://schemas.awesome.incremented/wpf/xaml/fontawesome.sharp  ;custom.clr-namespace:UniMarte.Wpf.ControleCustomizado  3local'clr-namespace:UniMarte.Wpf.Apresentacao    � Title$  Login�� � WindowState$ 	Maximized=� � WindowStyle$
 None=�
������  � AllowsTransparency$
 True��.����  �� CornerRadius$ 20������  �� ImageSource$$ /Imagens/Fundos/FundoLogin.jpg�� j� Stretch$ UniformToFill=�._��� $ 20��$��5q� J� Opacity$
 0.75Q�����  �� 
StartPoint$	 0 0&�	 �� EndPoint$		 1 1&�.��� 
 � Color$
 DarkBlue�� � Offset$ 0Q�� $
 
DarkViolet��$
 0.75Q�� $
 Purple��$ 1Q����� $	 0 0&�$		 1 1&�.��� $
 DarkBlue��$ 0Q�� $
 Black��$
 0.75Q�._��  � RowDefinitions �� $��30 ��� $
��Auto ��� $
��Auto �.+��� $	��250��$��1�� �� Orientation$ Vertical=�$��Stretch=�$��	0 10 0 10q�.+��� $$��Administração Museu UniMarte��
�������$��25(�$��Medium"�$��
Montserrat)�$��Center=�$
��Wrap=� �� Padding$ 
0 10 0 10 q� �� TextAlignment$ Center=��� $��	BEM VINDO��
�������$��15(�$��Medium"�$��
Montserrat)�$��Center=�$��0 5 0 0q��� $��Usuário��
�������$��12(�$
��Bold"�$��
Montserrat)�$
��Left=�$
��Wrap=�$��2 5 0 0q��� -    ��Name$ txbNomeUsuario��$��13(�$��Medium"�$��
Montserrat)�
������� �� 
CaretBrush
 ��������	#FF5C5454$��	0 0 0 2.5q�$��28��$��Center=�$��
2, 5, 0, 0q�$��	30 0 0 0 q�.������ $! /Imagens/Icones/usuario.jpg��$ Uniform=� j� 
AlignmentX$
 Left=�.���� $��Senha��
�������$��12(�$
��Bold"�$��
Montserrat)�$
��Left=�$
��Wrap=�$��2 15 0 0q�G� -    G�Name$ psbSenha��$��13(�$��Medium"�$��
Montserrat)�
������� G� 
CaretBrush
 ��������	#FF5C5454$��	0 0 0 2.5q�$��28��$��Center=�$��
2, 5, 0, 0q�$��	30 0 0 0 q����� $&  /Imagens/Icones/passwordBox.jpeg��$ Uniform=�$
 Left=��� -    ��Name$ btnlogin�����#462AD8$��0q�$��ENTRAR��
�������$��12(�$��
Montserrat)�$��40��$	��100��$��Center=�$��Center=� � Cursor$  ��$��2�� 
  Padrao#��[  $��0 30 0 0q�5   /UniMarte.Wpf.ControleCustomizado.TecladoVirtual  -     Name$ Teclado��$��20q�$��2��