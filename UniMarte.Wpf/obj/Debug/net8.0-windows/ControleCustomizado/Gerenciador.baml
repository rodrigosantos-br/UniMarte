   M S B A M L   `   `   `  ����G  CUniMarte.Wpf, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullS.clr-namespace:UniMarte.Wpf.ControleCustomizado UniMarte.Wpf.ControleCustomizado  5      2    ,UniMarte.Wpf.ControleCustomizado.Gerenciador   5      W SPresentationCore, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35^ ZWindowsFormsIntegration, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35H 9http://schemas.microsoft.com/winfx/2006/xaml/presentation      5      R NSystem.Xaml, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      X TFontAwesome.Sharp, Version=6.6.0.0, Culture=neutral, PublicKeyToken=d16d1e4e568ec10fFfa=http://schemas.awesome.incremented/wpf/xaml/fontawesome.sharp  5      :d2http://schemas.microsoft.com/expression/blend/2008  5      :local.clr-namespace:UniMarte.Wpf.ControleCustomizado  5        � Cursor$   ��5      .��5      � $��Center=�6   $��Stretch=�6(   $��20 50 20 50q�6D   .+�5   
   �� $��50q�6   $   ��6!   .+�5      &   System.Windows.Controls.DataGrid  -   5          Name$ 
dgUsuarios��5         AutoGenerateColumns$ False��6+   $	��500��6G   $��10,10,10,10q�6T      SelectionMode$ Single=�5         CanUserAddRows$ False��6.   $��Stretch=�6E   $��Stretch=�6a   $��16(�5      $��
Montserrat)�6%      
IsReadOnly$
 True��6=      Columns 5      0  *System.Windows.Controls.DataGridTextColumn  5      ,  &System.Windows.Controls.DataGridColumn   Header$ ID��6)      Width5  /System.Windows.Controls.DataGridLengthConverter$ 50 6L   1  +System.Windows.Controls.DataGridBoundColumn	   Binding	 65   �� *Id+
   ElementStyle
 5      �� 5       �� 
TargetType" ��6$   .�5   "   ��  �� Property � �� �� Value$ Center=�6F   �� 5   "    �@��Padding$ 5q�6<   5      5        5      $ Nome de Usuário��6)   $	 150 6b   	 6B   �� *NomeUsuario+
 5      �� 5      " ��6$   .�5   "   ��  � ��$ Center=�6F   �� 5   "    �@��Padding$ 5q�6<   5      5!        5"      $ Senha��6)   $	 100 6R   	 68   �� *Senha+
 5#      �� 5$      " ��6$   .�5%   "   ��  � ��$ Center=�6F   �� 5&   "    �@��Padding$ 5q�6<   5'      5)        5*      $ Nome Completo��6)   $	 300 6a   	 6@   �� *NomeCompleto+
 5+      �� 5,      " ��6$   .�5-   "   ��  � ��$ Center=�6F   �� 5.   "    �@��Padding$ 5q�6<   5/      51        52      $ Idade��6)   $ 50 6R   	 68   �� *Idade+
 53      �� 54      " ��6$   .�55   "   ��  � ��$ Center=�6F   �� 56   "    �@��Padding$ 5q�6<   57      59        5:      $ E-mail��6)   $	 300 6S   	 69   �� *Email+
 5;      �� 5<      " ��6$   .�5=   "   ��  � ��$ Center=�6F   �� 5>   "    �@��Padding$ 5q�6<   5?      5A      5C      �� 5D       �� Orientation$ 
Horizontal=�6   $��Center=�62   $��Center=�6M   .+�5E      �� -   5         ��Name$ btnInserirUsuario��5E      $��	Adicionar��64   $��Right=�6H   $��20(�6d   $��0q�6r   
�������$��
Montserrat)�5F   ,   $��40��6E   $	��250��6Q   $��Center=�5G      $
  Hand��64    
  Padrao#��[  5H      $��10 50 60 10q�69   6N   �� 5I      -   5        $��Editar��5I      $��Right=�6*   $��20(�6F   $��0q�6T   
�������$��
Montserrat)�5J   ,   $��40��6E   $	��250��6Q   $��Center=�5K      $
  Hand��64   #��[  5L      $��10 50 60 10q�69   6N   �� 5M      -   5        $��Excluir��5M      $��Right=�6+   $��20(�6G   $��0q�6U   
�������$��
Montserrat)�5N   ,   $��40��6E   $	��250��6Q   $��Center=�5O      $
  Hand��64   #��[  5P      $��10 50 10 10q�69   6N   5Q      5R      5S      5T      