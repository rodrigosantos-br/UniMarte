   M S B A M L   `   `   `  ����G  CUniMarte.Wpf, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullS.clr-namespace:UniMarte.Wpf.ControleCustomizado UniMarte.Wpf.ControleCustomizado  5      3    -UniMarte.Wpf.ControleCustomizado.RelatorioAdm   5      W SPresentationCore, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35^ ZWindowsFormsIntegration, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35H 9http://schemas.microsoft.com/winfx/2006/xaml/presentation      5      R NSystem.Xaml, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      R NOxyPlot.Wpf, Version=2.2.0.0, Culture=neutral, PublicKeyToken=75e952ba404cdbb0Y UOxyPlot.Wpf.Shared, Version=2.2.0.0, Culture=neutral, PublicKeyToken=75e952ba404cdbb0"oxyhttp://oxyplot.org/wpf   5      <local.clr-namespace:UniMarte.Wpf.ControleCustomizado   5      .��5      � 
������ $	��100q�6$     � RowDefinitions  5   
   �� 5      $
��Auto �6   �� 5      $��* �6   .+�5   
   �� $ ��Museu UniMarte - DashBoard��6   $��24(�5      $
��Bold"�5      $��
MontSerrat)�5      
�������$��
10,10,0,20q�5      $��0��5      � 5   
   $��1��6   $��10q�6    � ColumnDefinitions 5      �� 5      $��* �6#   �� 5      $��* �6#   �� 5      $��* �6#   �� 5      $��* �6#     5!      �� 5"      $��* �6    �� 5#      $��3* �6    .+�5'      �� $��0��6   $��0��6"   $��20q�62    �� Padding$ 10q�6>   
������� �� CornerRadius$ 10��6^   ._�5(      � .+�5)      � .+�5*      �� $��Total de Visitantes��6$   $
��Bold"�6?   
�������6Q   5+      �� 5,      -   5         ��Name$ txbTotalVisitantes��5,       $��Center=�6<   $��Center=�6Y   $��50(�6t   $
��Bold"�6�   ���#4A4CFF6�   5-      5.      �� 51      $��0��6   $��1��6"   $��20q�62   $ 10q�6>   
�������$ 10��6^   ._�52      � .+�53      � .+�54      �� $ ��Questionários Respondidos��6$   $
��Bold"�6E   
�������6W   55      �� 56      -   5        $! txbQuestionariosRespondidos��56       $��50(�6E   $��Center=�6S   $��Center=�6p   $
��Bold"�6�   ���#4A4CFF6�   57      58      �� 5;      $��0��6   $��2��6"   $��20q�62   $ 10q�6>   
�������$ 10��6^   ._�5<      � .+�5=      � .+�5>      �� $��Média Geral��6$   $
��Bold"�67   
�������6I   5?      �� 5@      -   5        $ txbMediaGeral��5@       $��Center=�67   $��Center=�6T   $��50(�6o   $
��Bold"�6}   ���#4A4CFF6�   5A      5B      �� 5E      $��0��6   $��3��6"   $��20q�62   $ 10q�6>   
�������$ 10��6^   ._�5F      �   5G      �� 5H      $
��Auto �6(   �� 5I      $��* �6(   .+�5K      �� $!��Satisfeitos e Insatisfeitos��6    $
��Bold"�6C   
�������6U     OxyPlot.Wpf.PlotView  5L      -   5          Name$ plotViewPie��5L   #   $��1��68   5M      5N      �� 5Q      $��1��6   $��0��6"   $��2��62   $��20 20 20 100q�6F   $ 10q�6\   
�������$ 10��6|   ._�5R      �   5S      �� 5T      $
��Auto �6(   �� 5U      $��* �6(   .+�5W      �� $��Obras Preferidas��6    $��0��68   $
��Bold"�6E   
�������6W     5X      -   5        $ oxyGraficoBarras��5X   #   $��1��6=   5Y      5Z      �� 5]      $��1��6   $��2��6"   $��2��62   $��20 20 20 100q�6F   $ 10q�6\   
�������$ 10��6|   ._�5^      �   5_      �� 5`      $
��Auto �6(   �� 5a      $��* �6(    5c      �� 5d      $��* �6+   �� 5e      $��* �6+   .+�5g      �� $(��"Avaliação de Cada Setor do Museu��6    $��0��6H   $
��Bold"�6U   
�������6g   �� 5h      -   5         ��Name$ Legendas��5h   !   $��0��63   $��1��6@    �� Orientation$ Vertical=�6Q   $��10q�6h   .+�5j      �� $ 
Horizontal=�6%   $��5q�6>   .+�5k      A� $��10��6&   $��10��61   
���  ��$��Center=�6H   �� 5l      $��Arquitetura��6(   $��5,-2,0,0q�6;   $��Center=�6M   5m      �� 5n      $ 
Horizontal=�6%   $��5q�6>   .+�5o      A� $��10��6&   $��10��61   
��� � �$��Center=�6J   �� 5p      $#��Atendimento dos Funcionários��6(   $��5,0,0,0q�6L   $��Center=�6]   5q      �� 5r      $ 
Horizontal=�6%   $��5q�6>   .+�5s      A� $��10��6&   $��10��61   
��� ���$��Center=�6K   �� 5t      $��Ambiente e Limpeza��6(   $��5,0,0,0q�6B   $��Center=�6S   5u      �� 5v      $ 
Horizontal=�6%   $��5q�6>   .+�5w      A� $��10��6&   $��10��61   
��� ���$��Center=�6K   �� 5x      $��Qualidade das Obras��6(   $��5,0,0,0q�6C   $��Center=�6T   5y      5z        5|      -   5        $ plotViewAvaliacoes��5|   #   $��1��6?   $��0��6L   $��2��6\   5}      5~      5      5�      5�      