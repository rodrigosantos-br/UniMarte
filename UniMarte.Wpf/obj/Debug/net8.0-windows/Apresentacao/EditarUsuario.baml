   M S B A M L   `   `   `  ����G  CUniMarte.Wpf, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullE'clr-namespace:UniMarte.Wpf.ApresentacaoUniMarte.Wpf.Apresentacao  5   	   -    'UniMarte.Wpf.Apresentacao.EditarUsuario   5   	   W SPresentationCore, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35^ ZWindowsFormsIntegration, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35H 9http://schemas.microsoft.com/winfx/2006/xaml/presentation      5   	   R NSystem.Xaml, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   X TFontAwesome.Sharp, Version=6.6.0.0, Culture=neutral, PublicKeyToken=d16d1e4e568ec10fFfa=http://schemas.awesome.incremented/wpf/xaml/fontawesome.sharp  5   	   3local'clr-namespace:UniMarte.Wpf.Apresentacao  5   	     � Title$  EditarUsuario��5	   	   $	��300��6   $	��500��6,    � WindowStyle$
 None=�5
   	    � WindowStartupLocation$ CenterScreen=�6   
������  � AllowsTransparency$
 True��5   "   .��5      ��  �� CornerRadius$ 20��6   ��5   
   �� 5       �� ImageSource$ /Imagens/Fundos/Fundo.jpg��6    j� Stretch$ UniformToFill=�6A   ._�5   
   �� $��5q�6    J� Opacity$
 0.75Q�6%   ��5      �� 5       �� 
StartPoint$	 0 0&�6&   	 �� EndPoint$		 1 1&�67   .��5      � 
 � Color$
 DarkBlue��6#    � Offset$ 0Q�65   � 5      $
 
DarkViolet��6#   $
 0.75Q�67   � 5      $
 Purple��6#   $ 1Q�63   5      ��5      �� 5      $	 0 0&�6&   $		 1 1&�67   .��5      � $
 DarkBlue��6#   $ 0Q�65   � 5      $
 Black��6#   $
 0.75Q�62   5      ._�5!      � $��0��6    � RowDefinitions 5"      �� 5#      $��30 �6$   �� 5$      $
��Auto �6$   �� 5%      $
��Auto �6$    � ColumnDefinitions 5'      �� 5(      �� 5)      $
��Auto �6'   �� 5*      $
��Auto �6'   �� 5+      $
��Auto �6'   .+�5.      �� 
�������$��10(�62   $��
Montserrat)�5/      $��0��60   $��Center=�6@   $��10 0 0 0q�50      �� 52      -   5         ��Name$ btnclose��52      $��0 2 5 0q�6,    � Cursor$
 Hand��53      $�� 2��6#      controlButton#��[  54   ,   .��55      !  FontAwesome.Sharp.IconImage  �  �FontAwesome.Sharp.IconImageBase`1[[FontAwesome.Sharp.IconChar, FontAwesome.Sharp, Version=6.6.0.0, Culture=neutral, PublicKeyToken=d16d1e4e568ec10f]]   Icon$ Xmark=�6#     ControlButtonIcon#��[ 60   56      � 57      $��1��6   .+�58      � $��10q�6   $��Center=�6'   $��Center=�6D   $��1��6_   .+�5:      �� $��Atualizar Usuário��6#   
�������.��5;      � 
������� 5<   "   �� 5=   &   $	��120 �67   �� 5>   &   $��* �67    5A   "   �� 5B   &   $
��Auto �64   �� 5C   &   $
��Auto �64   �� 5D   &   $
��Auto �64   �� 5E   &   $
��Auto �64   �� 5F   &   $
��Auto �64   �� 5G   &   $
��Auto �64   .+�5J   "   �� $��Nome de Usuário:��6(   $��0��6C   $��0��6P   �� 5K   "   -   5         ��Name$ txtNomeUsuario��5K   *   $��0��6B   $��1��6O   $��5q�6_   �� 5M   "   $��Senha:��6(   $��1��69   $��0��6F   G� 5N   "   -   5         G�Name$ txtSenha��5N   .   $��1��6@   $��1��6M   $��5q�6]   �� 5P   "   $��Nome Completo:��6(   $��2��6A   $��0��6N   �� 5Q   "   -   5        $ txtNomeCompleto��5Q   *   $��2��6C   $��1��6P   $��5q�6`   �� 5S   "   $��Idade:��6(   $��3��69   $��0��6F   �� 5T   "   -   5        $ txtIdade��5T   *   $��3��6<   $��1��6I   $��5q�6Y   �� 5V   "   $��E-mail:��6(   $��4��6:   $��0��6G   �� 5W   "   -   5        $ txtEmail��5W   *   $��4��6<   $��1��6I   $��5q�6Y   �� 5Y   "   -   5        $��	Atualizar��5Y   )   $��5��6=   $��1��6J   $	��100��6Z   $��30��6f   $��Center=�5Z   )   $��Center=�6F   $��16(�6a   ���#462AD8$��0q�5[   )   
�������$��
Montserrat)�6P   $  ��6h    
 Padrao#��[ 5\   )   $��20q�6I   6U   5]      5^      5_      5`      5a      5b      5c      5d      