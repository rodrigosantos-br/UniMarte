   M S B A M L   `   `   `  ����G  CUniMarte.Wpf, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullE'clr-namespace:UniMarte.Wpf.ApresentacaoUniMarte.Wpf.Apresentacao  5   	   %    UniMarte.Wpf.Apresentacao.Obras   5   	   W SPresentationCore, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35^ ZWindowsFormsIntegration, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35H 9http://schemas.microsoft.com/winfx/2006/xaml/presentation      5   	   R NSystem.Xaml, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   9local'clr-namespace:UniMarte.Wpf.Apresentacao     5   	     � Title$  Obras��5   	    � WindowState$ 	Maximized=�6    � WindowStyle$
 None=�6/   .��5	      ��  �� CornerRadius$ 20��6   ��5
   
   �� 5       �� ImageSource$ /Imagens/Fundos/Fundo.jpg��6    j� Stretch$ UniformToFill=�6A   ._�5   
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
��Auto �6$   .+�5$      (� $��0��6   $��20q�6'    (� Stretch$ Uniform=�63   .��5%      � $
��1400��6   $	��700��6(   .+�5'      �� ���	#FF3F51B5$��4q�69   $ 10��6M   $	��400��5(   !   $	��550��6-    K� ZIndex$ 0��6:   $
��Left=�5)   !   $��	150,0,0,0q�6<   ._�5*      �� -   5         ��Name$ ImagemAnterior��5*   $   $	 0.7Q�5+   $   $��UniformToFill=�5,   $   5-      �� 50      ���	#FF3F51B5$��4q�69   $ 10��6M   $	��700��51   !   $	��650��6-   $ 2��6:   $��Center=�52   !   ._�53      � .+�54   "   �� -   5        $ ImagemAtual��54   (   $��UniformToFill=�55   (   � 58   "   $��Stretch=�6'    59   &   �� 5:   *   $
��Auto �68   �� 5;   *   $��* �68   �� 5<   *   $
��Auto �68   .+�5@   &   �� $��0��6-   ���	#80000000$��0,20,0,0q�6Q   ._�5A   *   �� -   5         ��Name$ 
TituloObra��5A   4   $��Center=�5B   2   $��28(�5C   2   $
��Bold"�5D   2   
�������$
��Wrap=�5F   2    �� TextAlignment$ Center=�5G   2    �� Padding$
 10,5q�5H   2   $	��680��5I   2   5J   '   �� 5M   &   $��2��6-   ���	#80000000$��0,0,0,20q�6Q   ._�5N   *   �� -   5        $ HistoricoObra��5N   4   $��Center=�5O   2   $��18(�5P   2   
�������$
��Wrap=�5R   2   $ Center=�5S   2   $
 10,5q�5T   2   $	��680��5U   2   $	��200��5V   2   5W   '   5X   #   5Y      5Z      �� 5]      ���	#FF3F51B5$��4q�69   $ 10��6M   $	��400��5^   !   $	��550��6-   $ 0��6:   $��Right=�5_   !   $��	0,0,150,0q�6=   ._�5`      �� -   5        $ ImagemPosterior��5`   $   $	 0.7Q�5a   $   $��UniformToFill=�5b   $   5c      5d      5e      �� 5h      $��1��6    �� Orientation$ 
Horizontal=�6*   $��Center=�6C   $��50q�6`   .+�5i      �� -   5         ��Name$ BotaoAnterior��5i      $��20(�64   $��Anterior��6B   ���#462AD8$��0q�6j   
�������$��
Montserrat)�5j   0   $��40��6I   $	��200��6U   $��Center=�5k      $��Center=�69    
  Padrao#��[  5l      $��10 30 100 10q�6=   6S   �� 5m      -   5        $ BotaoProximo��5m      $��20(�63   $��Próxima��6A   ���#462AD8$��0q�6h   
�������$��
Montserrat)�5n   0   $��40��6I   $	��200��6U   $��Center=�5o      $��Center=�69   #��[  5p      $��100 30 10 10q�6=   6S   5q      �� 5s      -   5        $ btnHome��5s      $��20(�6*   ���#462AD8$��0q�6M   
�������$��
Montserrat)�5t   ,   $	��100��6E   $	��100��6R   $	��Top=�5u      $
��Left=�62   #��[  5v      $��150 30 10 10q�69   ��5w      �� 5x      $��/Imagens/Icones/home.png��6    5z      5{      5|      5}      5~      