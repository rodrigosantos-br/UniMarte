   M S B A M L   `   `   `  ����G  CUniMarte.Wpf, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullS.clr-namespace:UniMarte.Wpf.ControleCustomizado UniMarte.Wpf.ControleCustomizado  5   	   E'clr-namespace:UniMarte.Wpf.ApresentacaoUniMarte.Wpf.Apresentacao  5   	   #    UniMarte.Wpf.Apresentacao.Adm   5   	   W SPresentationCore, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35^ ZWindowsFormsIntegration, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35H 9http://schemas.microsoft.com/winfx/2006/xaml/presentation      5   	   R NSystem.Xaml, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   Acustom.clr-namespace:UniMarte.Wpf.ControleCustomizado     5   	   9local'clr-namespace:UniMarte.Wpf.Apresentacao     5   	     � Title$	  Adm��5	   	    � WindowState$ 	Maximized=�6    � WindowStyle$
 None=�6-   .��5
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

 0.75Q�62   5      ._�5      �  � ColumnDefinitions 5      �� 5       $
��Auto �6'   �� 5!      $��* �6'   .+�5#      �� $��Center=�6   $��0��68   $��50q�6H   .+�5$      �� -   5         ��Name$ btnRelatorio��5$      $��
Relatório��63   $��20(�6G   $��0q�6U   
�������$��
Montserrat)�5%   0   $��40��6I   $	��250��6U   $��Center=�5&      $��Center=�69    � Cursor$
 Hand��6V    
  Padrao#��[  5'      $��	0 100 0 0q�6=   6P   �� 5(      -   5        $ btnGerenciadorUsuarios��5(      $��Gerenciador de Usuários��6=   $��20(�6_   $��0q�6m   
�������$��
Montserrat)�5)   0   $��40��6I   $	��250��6U   $��Center=�5*      $��Center=�69   $
 Hand��6V   #��[  5+      $��	0 100 0 0q�6=   6P   �� 5,      -   5        $ btnFinalizarSoftware��5,      $��Fechar Aplicação��6;   $��20(�6V   $��0q�6d   
�������$��
Montserrat)�5-   0   $��40��6I   $	��250��6U   $��Center=�5.      $��Center=�69   $
 Hand��6V   #��[  5/      $��0 100 0 100q�6=   6R   50      � 51      -   5        $��grdGerenciador��51      $��1��6-   
������ .+�52      3   -UniMarte.Wpf.ControleCustomizado.RelatorioAdm  -   5          Name$ relatorioAdm��52   *   $y�Visible=�6@   2   ,UniMarte.Wpf.ControleCustomizado.Gerenciador  53      $y�	Collapsed=�6)   54      55      56      57      58      