   M S B A M L   `   `   `  ���� G  CUniMarte.Wpf, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullE'clr-namespace:UniMarte.Wpf.ApresentacaoUniMarte.Wpf.Apresentacao  %    UniMarte.Wpf.Apresentacao.Obras   W SPresentationCore, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35^ ZWindowsFormsIntegration, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35H 9http://schemas.microsoft.com/winfx/2006/xaml/presentation      R NSystem.Xaml, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     @d2http://schemas.microsoft.com/expression/blend/2008     Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     9local'clr-namespace:UniMarte.Wpf.Apresentacao       � Title$  Obras�� � WindowState$ 	Maximized=� � WindowStyle$
 None=�.����  �� CornerRadius$ 20������  �� ImageSource$ /Imagens/Fundos/Fundo.jpg�� j� Stretch$ UniformToFill=�._��� $��5q� J� Opacity$
 0.75Q�����  �� 
StartPoint$	 0 0&� �� EndPoint$	 1 1&�.��� 	 � Color$	 DarkBlue��
 � Offset$
 0Q�� $	 
DarkViolet��$

 0.75Q�� $	 Purple��$
 1Q����� $	 0 0&�$	 1 1&�.��� $	 DarkBlue��$
 0Q�� $	 Black��$

 0.75Q�._��  � RowDefinitions �� $��* ��� $
��Auto �.+�(� $��0��$��20q� (� Stretch$ Uniform=�.��� $
��1400��$	��700��.+��� ���	#FF3F51B5$��4q�$ 10��$	��400��$	��550�� K� ZIndex$ 0��$
��Left=�$��	150,0,0,0q�._��� -    ��Name$ ImagemAnterior��$	 0.7Q�$��UniformToFill=��� ���	#FF3F51B5$��4q�$ 10��$	��700��$	��650��$ 2��$��Center=�._�� .+��� -   $ ImagemAtual��$��UniformToFill=�� $��Stretch=� �� $
��Auto ��� $��* ��� $
��Auto �.+��� $��0�����	#80000000$��0,20,0,0q�._��� -    ��Name$ 
TituloObra��$��Center=�$��28(�$
��Bold"�
�������$
��Wrap=� �� TextAlignment$ Center=� �� Padding$
 10,5q�$	��680���� $��2�����	#80000000$��0,0,0,20q�._��� -   $ HistoricoObra��$��Center=�$��18(�
�������$
��Wrap=�$ Center=�$
 10,5q�$	��680��$	��200���� ���	#FF3F51B5$��4q�$ 10��$	��400��$	��550��$ 0��$��Right=�$��	0,0,150,0q�._��� -   $ ImagemPosterior��$	 0.7Q�$��UniformToFill=��� $��1�� �� Orientation$ 
Horizontal=�$��Center=�$��50q�.+��� -    ��Name$ BotaoAnterior��$��20(�$��Anterior�����#462AD8$��0q�
�������$��
Montserrat)�$��40��$	��200��$��Center=�$��Center=� 
  Padrao#��[  $��10 30 100 10q��� -   $ BotaoProximo��$��20(�$��Próxima�����#462AD8$��0q�
�������$��
Montserrat)�$��40��$	��200��$��Center=�$��Center=�#��[  $��100 30 10 10q��� -   $ btnHome��$��20(����#462AD8$��0q�
�������$��
Montserrat)�$	��100��$	��100��$	��Top=�$
��Left=�#��[  $��150 30 10 10q����� $��/Imagens/Icones/home.png��