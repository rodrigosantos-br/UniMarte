   M S B A M L   `   `   `  ���� G  CUniMarte.Wpf, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullS.clr-namespace:UniMarte.Wpf.ControleCustomizado UniMarte.Wpf.ControleCustomizado  2    ,UniMarte.Wpf.ControleCustomizado.Gerenciador   W SPresentationCore, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35^ ZWindowsFormsIntegration, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35H 9http://schemas.microsoft.com/winfx/2006/xaml/presentation      R NSystem.Xaml, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     X TFontAwesome.Sharp, Version=6.6.0.0, Culture=neutral, PublicKeyToken=d16d1e4e568ec10fFfa=http://schemas.awesome.incremented/wpf/xaml/fontawesome.sharp  :d2http://schemas.microsoft.com/expression/blend/2008  :local.clr-namespace:UniMarte.Wpf.ControleCustomizado    � Cursor$   ��.��� $��Center=�$��Stretch=�$��20 50 20 50q�.+��� $��50q�$   ��.+�&   System.Windows.Controls.DataGrid  -     Name$ 
dgUsuarios��   AutoGenerateColumns$ False��$	��500��$��10,10,10,10q�   SelectionMode$ Single=�   CanUserAddRows$ False��$��Stretch=�$��Stretch=�$��16(�$��
Montserrat)�   
IsReadOnly$
 True��   Columns 0  *System.Windows.Controls.DataGridTextColumn  ,  &System.Windows.Controls.DataGridColumn   Header$ ID��   Width5  /System.Windows.Controls.DataGridLengthConverter$ 50 1  +System.Windows.Controls.DataGridBoundColumn	   Binding	 �� *Id+
   ElementStyle
 ��  �� 
TargetType" ��.���  �� Property � �� �� Value$ Center=���  �@��Padding$ 5q�  $ Nome de Usuário��$	 150 	 �� *NomeUsuario+
 �� " ��.���  � ��$ Center=���  �@��Padding$ 5q�  $ Senha��$	 100 	 �� *Senha+
 �� " ��.���  � ��$ Center=���  �@��Padding$ 5q�  $ Nome Completo��$	 300 	 �� *NomeCompleto+
 �� " ��.���  � ��$ Center=���  �@��Padding$ 5q�  $ Idade��$ 50 	 �� *Idade+
 �� " ��.���  � ��$ Center=���  �@��Padding$ 5q�  $ E-mail��$	 300 	 �� *Email+
 �� " ��.���  � ��$ Center=���  �@��Padding$ 5q���  �� Orientation$ 
Horizontal=�$��Center=�$��Center=�.+��� -    ��Name$ btnInserirUsuario��$��	Adicionar��$��Right=�$��20(�$��0q�
�������$��
Montserrat)�$��40��$	��250��$��Center=�$
  Hand�� 
  Padrao#��[  $��10 50 60 10q��� -   $��Editar��$��Right=�$��20(�$��0q�
�������$��
Montserrat)�$��40��$	��250��$��Center=�$
  Hand��#��[  $��10 50 60 10q��� -   $��Excluir��$��Right=�$��20(�$��0q�
�������$��
Montserrat)�$��40��$	��250��$��Center=�$
  Hand��#��[  $��10 50 10 10q�