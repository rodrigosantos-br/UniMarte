   M S B A M L   `   `   `  ���� G  CUniMarte.Wpf, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullE'clr-namespace:UniMarte.Wpf.ApresentacaoUniMarte.Wpf.Apresentacao  -    'UniMarte.Wpf.Apresentacao.EditarUsuario   W SPresentationCore, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35^ ZWindowsFormsIntegration, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35H 9http://schemas.microsoft.com/winfx/2006/xaml/presentation      R NSystem.Xaml, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     @d2http://schemas.microsoft.com/expression/blend/2008     Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     X TFontAwesome.Sharp, Version=6.6.0.0, Culture=neutral, PublicKeyToken=d16d1e4e568ec10fFfa=http://schemas.awesome.incremented/wpf/xaml/fontawesome.sharp  3local'clr-namespace:UniMarte.Wpf.Apresentacao    � Title$  EditarUsuario��$	��300��$	��500�� � WindowStyle$
 None=� � WindowStartupLocation$ CenterScreen=�
������  � AllowsTransparency$
 True��.����  �� CornerRadius$ 20������  �� ImageSource$ /Imagens/Fundos/Fundo.jpg�� j� Stretch$ UniformToFill=�._��� $��5q� J� Opacity$
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
 0.75Q�._�� $��0�� � RowDefinitions �� $��30 ��� $
��Auto ��� $
��Auto � � ColumnDefinitions �� �� $
��Auto ��� $
��Auto ��� $
��Auto �.+��� 
�������$��10(�$��
Montserrat)�$��0��$��Center=�$��10 0 0 0q��� -    ��Name$ btnclose��$��0 2 5 0q� � Cursor$
 Hand��$�� 2��   controlButton#��[  .��!  FontAwesome.Sharp.IconImage  �  �FontAwesome.Sharp.IconImageBase`1[[FontAwesome.Sharp.IconChar, FontAwesome.Sharp, Version=6.6.0.0, Culture=neutral, PublicKeyToken=d16d1e4e568ec10f]]   Icon$ Xmark=�  ControlButtonIcon#��[ � $��1��.+�� $��10q�$��Center=�$��Center=�$��1��.+��� $��Atualizar Usuário��
�������.��� 
������� �� $	��120 ��� $��* � �� $
��Auto ��� $
��Auto ��� $
��Auto ��� $
��Auto ��� $
��Auto ��� $
��Auto �.+��� $��Nome de Usuário:��$��0��$��0���� -    ��Name$ txtNomeUsuario��$��0��$��1��$��5q��� $��Senha:��$��1��$��0��G� -    G�Name$ txtSenha��$��1��$��1��$��5q��� $��Nome Completo:��$��2��$��0���� -   $ txtNomeCompleto��$��2��$��1��$��5q��� $��Idade:��$��3��$��0���� -   $ txtIdade��$��3��$��1��$��5q��� $��E-mail:��$��4��$��0���� -   $ txtEmail��$��4��$��1��$��5q��� -   $��	Atualizar��$��5��$��1��$	��100��$��30��$��Center=�$��Center=�$��16(����#462AD8$��0q�
�������$��
Montserrat)�$  �� 
 Padrao#��[ $��20q�