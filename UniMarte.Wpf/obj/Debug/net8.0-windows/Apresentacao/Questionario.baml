   M S B A M L   `   `   `  ����G  CUniMarte.Wpf, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullS.clr-namespace:UniMarte.Wpf.ControleCustomizado UniMarte.Wpf.ControleCustomizado  5   	   E'clr-namespace:UniMarte.Wpf.ApresentacaoUniMarte.Wpf.Apresentacao  5   	   *    $UniMarte.Wpf.Apresentacao.Satisfacao   5   	   W SPresentationCore, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35^ ZWindowsFormsIntegration, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35H 9http://schemas.microsoft.com/winfx/2006/xaml/presentation      5   	   R NSystem.Xaml, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   Acustom.clr-namespace:UniMarte.Wpf.ControleCustomizado     5   	   9local'clr-namespace:UniMarte.Wpf.Apresentacao     5   	     � Title$  
Satisfacao��5	   	    � WindowState$ 	Maximized=�6    � WindowStyle$
 None=�64   .��5
      ��  �� CornerRadius$ 20��6   ��5   
   �� 5       �� ImageSource$ /Imagens/Fundos/Fundo.jpg��6    j� Stretch$ UniformToFill=�6A   ._�5   
   �� $��5q�6    J� Opacity$
 0.75Q�6%   ��5      �� 5       �� 
StartPoint$	 0 0&�6&    �� EndPoint$	 1 1&�67   .��5      � 	 � Color$	 DarkBlue��6#   
 � Offset$
 0Q�65   � 5      $	 
DarkViolet��6#   $

 0.75Q�67   � 5      $	 Purple��6#   $
 1Q�63   5      ��5      �� 5      $	 0 0&�6&   $	 1 1&�67   .��5      � $	 DarkBlue��6#   $
 0Q�65   � 5      $	 Black��6#   $

 0.75Q�62   5      ._�5      � 
�������$	��900��6)   $	��720��65   $��50q�6B    � RowDefinitions 5      �� 5       $	��250 �6$   �� 5!      $��* �6$   �� 5"      $��* �6$   .+�5%      �� -   5         ��Name$ PerguntaTextBlock��5%      $��Center=�67   $��Center=�6R   
���   �$��0��6�   $��42(�6�   $��10q�6�   $��WrapWithOverflow=�6�   �� 5'      -   5         ��Name$ RespostaPanel��5'      $��1��64   $��Center=�6A   $��Center=�6\   $��10q�6y   .+�5(      2   ,UniMarte.Wpf.ControleCustomizado.EscolhaObra  -   5          Name$ EscolhaObra��5(   )   /   )UniMarte.Wpf.ControleCustomizado.Estrelas  5)      -   5          Name$ Estrelas��5)   &   -   'UniMarte.Wpf.ControleCustomizado.SimNao  5*      -   5          Name$ SimNao��5*   $   5+      �� 5-      -   5         ��Name$ btnProximaPergunta��5-      $��Próxima Pergunta��65   $��20(�5.      $��0q�6'   $��2��6;   
�������$��
Montserrat)�5/   ,   $��40��6E   $	��250��6Q   $��Center=�50      $��Center=�65    � Cursor$
 Hand��6R    
  Padrao#��[  51      $��0 50 0 0q�69   �� 53      -   5        $ btnFim��53      $	��FIM��6)   $��20(�6R   $��0q�6`   $��2��6t   
�������$��
Montserrat)�54   ,   $��Center=�6D   $��Center=�6`   $
 Hand��6}   #��[  55      $��0 50 0 0q�69   $y�	Collapsed=�6K   $	��150��6b   $��50��6n   �� 56      -   5        $ stkRelatorio��56      
�������$��0��6F   $��2��6S   $y�	Collapsed=�6d   .+�57      0   *UniMarte.Wpf.ControleCustomizado.Relatorio  -	   5          Name$ ctcRelatorio��57   '   $��Stretch=�6=   $��Stretch=�6[   58      59      5:      5;      5<      