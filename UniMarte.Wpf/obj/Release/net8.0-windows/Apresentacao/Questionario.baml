   M S B A M L   `   `   `  ���� G  CUniMarte.Wpf, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullS.clr-namespace:UniMarte.Wpf.ControleCustomizado UniMarte.Wpf.ControleCustomizado  E'clr-namespace:UniMarte.Wpf.ApresentacaoUniMarte.Wpf.Apresentacao  *    $UniMarte.Wpf.Apresentacao.Satisfacao   W SPresentationCore, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35^ ZWindowsFormsIntegration, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35H 9http://schemas.microsoft.com/winfx/2006/xaml/presentation      R NSystem.Xaml, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     @d2http://schemas.microsoft.com/expression/blend/2008     Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     Acustom.clr-namespace:UniMarte.Wpf.ControleCustomizado     9local'clr-namespace:UniMarte.Wpf.Apresentacao       � Title$  
Satisfacao�� � WindowState$ 	Maximized=� � WindowStyle$
 None=�.����  �� CornerRadius$ 20������  �� ImageSource$ /Imagens/Fundos/Fundo.jpg�� j� Stretch$ UniformToFill=�._��� $��5q� J� Opacity$
 0.75Q�����  �� 
StartPoint$	 0 0&� �� EndPoint$	 1 1&�.��� 	 � Color$	 DarkBlue��
 � Offset$
 0Q�� $	 
DarkViolet��$

 0.75Q�� $	 Purple��$
 1Q����� $	 0 0&�$	 1 1&�.��� $	 DarkBlue��$
 0Q�� $	 Black��$

 0.75Q�._�� 
�������$	��900��$	��720��$��50q� � RowDefinitions �� $	��250 ��� $��* ��� $��* �.+��� -    ��Name$ PerguntaTextBlock��$��Center=�$��Center=�
���   �$��0��$��42(�$��10q�$��WrapWithOverflow=��� -    ��Name$ RespostaPanel��$��1��$��Center=�$��Center=�$��10q�.+�2   ,UniMarte.Wpf.ControleCustomizado.EscolhaObra  -     Name$ EscolhaObra��/   )UniMarte.Wpf.ControleCustomizado.Estrelas  -     Name$ Estrelas��-   'UniMarte.Wpf.ControleCustomizado.SimNao  -     Name$ SimNao���� -    ��Name$ btnProximaPergunta��$��Próxima Pergunta��$��20(�$��0q�$��2��
�������$��
Montserrat)�$��40��$	��250��$��Center=�$��Center=� � Cursor$
 Hand�� 
  Padrao#��[  $��0 50 0 0q��� -   $ btnFim��$	��FIM��$��20(�$��0q�$��2��
�������$��
Montserrat)�$��Center=�$��Center=�$
 Hand��#��[  $��0 50 0 0q�$y�	Collapsed=�$	��150��$��50���� -   $ stkRelatorio��
�������$��0��$��2��$y�	Collapsed=�.+�0   *UniMarte.Wpf.ControleCustomizado.Relatorio  -	     Name$ ctcRelatorio��$��Stretch=�$��Stretch=�