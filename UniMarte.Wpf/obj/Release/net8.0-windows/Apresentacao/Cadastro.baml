   M S B A M L   `   `   `  ���� G  CUniMarte.Wpf, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullS.clr-namespace:UniMarte.Wpf.ControleCustomizado UniMarte.Wpf.ControleCustomizado  (    "UniMarte.Wpf.Apresentacao.Cadastro   W SPresentationCore, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35^ ZWindowsFormsIntegration, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35H 9http://schemas.microsoft.com/winfx/2006/xaml/presentation      R NSystem.Xaml, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     Acustom.clr-namespace:UniMarte.Wpf.ControleCustomizado       � Title$  Cadastro�� � WindowStyle$
 None=� � WindowState$ 	Maximized=�.����  �� CornerRadius$ 20��$��Stretch=�$��Stretch=�����  �� ImageSource$ /Imagens/Fundos/Fundo.jpg�� j� Stretch$ UniformToFill=�._�� 
������ .+��� -    ��Name$ btnAdm��$y�	Collapsed=����#462AD8$��0q�
�������$��
Montserrat)�$	��100��$	��100��$	��Top=�$��Right=� K� ZIndex$ 1�� 
  Padrao#��[  $��10 100 150 10q����� $ ��/Imagens/Icones/gestao.png���� -   $ btnHome��$��20(����#462AD8$��0q�
�������$��
Montserrat)�$	��100��$	��100��$	��Top=�$
��Left=� � Cursor$  ��$ 1��#��[  $��150 100 10 10q����� $��/Imagens/Icones/home.png���� $��5q�	 J� Opacity$
	 0.75Q�$��Stretch=�$��Stretch=����� 
 �� 
StartPoint$	
 0 0&� �� EndPoint$	 1 1&�.���  � Color$ DarkBlue�� � Offset$ 0Q�� $ 
DarkViolet��$
 0.75Q�� $ Purple��$ 1Q����� $	
 0 0&�$	 1 1&�.��� $ DarkBlue��$ 0Q�� $ Black��$
 0.75Q�._�� 
������  � RowDefinitions �� $
��Auto ��� $
��Auto �.+��� $ 20��
������ $��1q�
������� �� Padding$ 10q�$��10,20,10,20q�$��Center=�._��� $	��300��$��0�� �� Orientation$ Vertical=�$��Stretch=�$��	0 10 0 10q�.+��� $��48(�
���   �$��
Bem-vindo!��$
��Bold"�$��Center=��� $��16(�
���   �$ ��Cadastre-se para continuar��$��0,10,0,0q�$��Center=��� $
��Nome��
�������$��12(�$
��Bold"�$��
Montserrat)�$
��Left=�$
��Wrap=�$��2 5 0 0q��� -    ��Name$ txbNome��$��22(�$��Medium"�$��
Montserrat)�
���   � �� 
CaretBrush
 �   ����	#FF5C5454$��	0 0 0 2.5q�$��28��$��Center=�$��
2, 5, 0, 0q�$��	30 0 0 0 q�$��0��.������ $ /Imagens/Icones/Nome.png��$ Uniform=� j� 
AlignmentX$
 Left=�.���� $��Data de Nascimento��
�������$��12(�$
��Bold"�$��
Montserrat)�$
��Left=�$
��Wrap=�$��2 15 0 0q�� $	��300��$��28��$��
2, 5, 0, 0q� � ColumnDefinitions �� $��40 ��� $��* �.+��� $(��"/Imagens/Icones/DataNascimento.png��$��Uniform=�$��30��$��30��$
��Left=�$��Center=�(  "System.Windows.Controls.DatePicker  -   $��dtpDataNascimento��$��1�� � Language$ pt-BR�$��22(�$��Medium"�$��
Montserrat)�
���   ����	#FF5C5454$��	0 0 0 2.5q�$��Center=�$��10,0,0,0q�
������    DisplayDate$ 
2022-11-20��   SelectedDateFormat$ Short=�   Text$ 
dd/mm/aaaa���� -   $��	CADASTRAR��$��20(����#462AD8$��0q�
�������$��
Montserrat)�$��40��$	��200��$��Center=�$��Center=�$  ��#��[  $��0 30 0 0q�� $��1��$��Center=�$��Center=�$��10,20,10,20q�.+�5   /UniMarte.Wpf.ControleCustomizado.TecladoVirtual  -     Name$ Teclado��