   M S B A M L   `   `   `  ����G  CUniMarte.Wpf, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullS.clr-namespace:UniMarte.Wpf.ControleCustomizado UniMarte.Wpf.ControleCustomizado  5   	   (    "UniMarte.Wpf.Apresentacao.Cadastro   5   	   W SPresentationCore, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35^ ZWindowsFormsIntegration, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35H 9http://schemas.microsoft.com/winfx/2006/xaml/presentation      5   	   R NSystem.Xaml, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   Acustom.clr-namespace:UniMarte.Wpf.ControleCustomizado     5   	     � Title$  Cadastro��5   	    � WindowStyle$
 None=�5   	    � WindowState$ 	Maximized=�6   .��5      ��  �� CornerRadius$ 20��6   $��Stretch=�6   $��Stretch=�6;   ��5	   
   �� 5
       �� ImageSource$ /Imagens/Fundos/Fundo.jpg��6    j� Stretch$ UniformToFill=�6A   ._�5   
   � 
������ .+�5      �� -   5         ��Name$ btnAdm��5      $y�	Collapsed=�6:   ���#462AD8$��0q�5   "   
�������$��
Montserrat)�5       $	��100��69   $	��100��6F   $	��Top=�5      $��Right=�6&    K� ZIndex$ 1��6B    
  Padrao#��[  5      $��10 100 150 10q�6-   ��5      �� 5      $ ��/Imagens/Icones/gestao.png��6   5      �� 5      -   5        $ btnHome��5      $��20(�6&   ���#462AD8$��0q�6I   
�������$��
Montserrat)�5       $	��100��69   $	��100��6F   $	��Top=�5      $
��Left=�6&    � Cursor$  ��6A   $ 1��6K   #��[  5      $��150 100 10 10q�6-   ��5      �� 5      $��/Imagens/Icones/home.png��6   5      �� 5       $��5q�6   	 J� Opacity$
	 0.75Q�6)   $��Stretch=�68   $��Stretch=�6V   ��5!      �� 5"      
 �� 
StartPoint$	
 0 0&�6&    �� EndPoint$	 1 1&�67   .��5#      �  � Color$ DarkBlue��6#    � Offset$ 0Q�65   � 5$      $ 
DarkViolet��6#   $
 0.75Q�67   � 5%      $ Purple��6#   $ 1Q�63   5&      ��5)      �� 5*      $	
 0 0&�6&   $	 1 1&�67   .��5+      � $ DarkBlue��6#   $ 0Q�65   � 5,      $ Black��6#   $
 0.75Q�62   5-      ._�5/      � 
������  � RowDefinitions 50      �� 51      $
��Auto �6$   �� 52      $
��Auto �6$   .+�55      �� $ 20��6   
������ $��1q�6E   
������� �� Padding$ 10q�6o   $��10,20,10,20q�6|   $��Center=�6�   ._�57      �� $	��300��6!   $��0��6-    �� Orientation$ Vertical=�6:   $��Stretch=�6Q   $��	0 10 0 10q�6m   .+�5:      �� $��48(�6$   
���   �$��
Bem-vindo!��6E   $
��Bold"�6W   $��Center=�6i   �� 5;      $��16(�6$   
���   �$ ��Cadastre-se para continuar��6E   $��0,10,0,0q�6g   $��Center=�6y   �� 5=      $
��Nome��6$   
�������$��12(�6F   $
��Bold"�6T   $��
Montserrat)�6f   $
��Left=�5>   $   $
��Wrap=�6?   $��2 5 0 0q�6S   �� 5@      -   5         ��Name$ txbNome��5@   "   $��22(�5B   "   $��Medium"�60   $��
Montserrat)�6D   
���   � �� 
CaretBrush
 �   ����	#FF5C5454$��	0 0 0 2.5q�5C   M   $��28��6i   $��Center=�5D   "   $��
2, 5, 0, 0q�5E   "   $��	30 0 0 0 q�66   $��0��6J   .��6X   ��5F      �� 5G   "   $ /Imagens/Icones/Nome.png��6-   $ Uniform=�6T    j� 
AlignmentX$
 Left=�6f   .��5H   2   5I      �� 5L      $��Data de Nascimento��6$   
�������$��12(�6U   $
��Bold"�6c   $��
Montserrat)�6u   $
��Left=�5M   $   $
��Wrap=�6?   $��2 15 0 0q�6S   � 5P      $	��300��6   $��28��6+   $��
2, 5, 0, 0q�67    � ColumnDefinitions 5Q      �� 5S   "   $��40 �63   �� 5U   "   $��* �63   .+�5Y      �� $(��"/Imagens/Icones/DataNascimento.png��6$   $��Uniform=�6P   $��30��5Z   $   $��30��6/   $
��Left=�6;   $��Center=�6V   (  "System.Windows.Controls.DatePicker  5]      -   5        $��dtpDataNascimento��5]   )   $��1��5^   )    � Language$ pt-BR�69   $��22(�6J   $��Medium"�6X   $��
Montserrat)�6l   
���   ����	#FF5C5454$��	0 0 0 2.5q�5_   T   $��Center=�5`   )   $��10,0,0,0q�6K   
������    DisplayDate$ 
2022-11-20��6w      SelectedDateFormat$ Short=�6�      Text$ 
dd/mm/aaaa��6�   5a      �� 5d      -   5        $��	CADASTRAR��5d   %   $��20(�5e   %   ���#462AD8$��0q�6H   
�������$��
Montserrat)�5f   8   $��40��6Q   $	��200��6]   $��Center=�5g   %   $��Center=�6A   $  ��6^   #��[  5h   %   $��0 30 0 0q�6E   5i      5j      � 5k      $��1��6   $��Center=�6$   $��Center=�6A   $��10,20,10,20q�6\   .+�5l      5   /UniMarte.Wpf.ControleCustomizado.TecladoVirtual  -   5          Name$ Teclado��5l   ,   5m      5n      5o      5p      5q      5r      