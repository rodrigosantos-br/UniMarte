   M S B A M L   `   `   `  ���� G  CUniMarte.Wpf, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullS.clr-namespace:UniMarte.Wpf.ControleCustomizado UniMarte.Wpf.ControleCustomizado  3    -UniMarte.Wpf.ControleCustomizado.RelatorioAdm   W SPresentationCore, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35^ ZWindowsFormsIntegration, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35H 9http://schemas.microsoft.com/winfx/2006/xaml/presentation      R NSystem.Xaml, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     @d2http://schemas.microsoft.com/expression/blend/2008     R NOxyPlot.Wpf, Version=2.2.0.0, Culture=neutral, PublicKeyToken=75e952ba404cdbb0Y UOxyPlot.Wpf.Shared, Version=2.2.0.0, Culture=neutral, PublicKeyToken=75e952ba404cdbb0"oxyhttp://oxyplot.org/wpf   <local.clr-namespace:UniMarte.Wpf.ControleCustomizado   .��� 
������ $	��100q�  � RowDefinitions  �� $
��Auto ��� $��* �.+��� $ ��Museu UniMarte - DashBoard��$��24(�$
��Bold"�$��
MontSerrat)�
�������$��
10,10,0,20q�$��0��� $��1��$��10q� � ColumnDefinitions �� $��* ��� $��* ��� $��* ��� $��* �  �� $��* ��� $��3* �.+��� $��0��$��0��$��20q� �� Padding$ 10q�
������� �� CornerRadius$ 10��._�� .+�� .+��� $��Total de Visitantes��$
��Bold"�
��������� -    ��Name$ txbTotalVisitantes��$��Center=�$��Center=�$��50(�$
��Bold"����#4A4CFF�� $��0��$��1��$��20q�$ 10q�
�������$ 10��._�� .+�� .+��� $ ��Questionários Respondidos��$
��Bold"�
��������� -   $! txbQuestionariosRespondidos��$��50(�$��Center=�$��Center=�$
��Bold"����#4A4CFF�� $��0��$��2��$��20q�$ 10q�
�������$ 10��._�� .+�� .+��� $��Média Geral��$
��Bold"�
��������� -   $ txbMediaGeral��$��Center=�$��Center=�$��50(�$
��Bold"����#4A4CFF�� $��0��$��3��$��20q�$ 10q�
�������$ 10��._��   �� $
��Auto ��� $��* �.+��� $!��Satisfeitos e Insatisfeitos��$
��Bold"�
�������  OxyPlot.Wpf.PlotView  -     Name$ plotViewPie��$��1���� $��1��$��0��$��2��$��20 20 20 100q�$ 10q�
�������$ 10��._��   �� $
��Auto ��� $��* �.+��� $��Obras Preferidas��$��0��$
��Bold"�
�������  -   $ oxyGraficoBarras��$��1���� $��1��$��2��$��2��$��20 20 20 100q�$ 10q�
�������$ 10��._��   �� $
��Auto ��� $��* � �� $��* ��� $��* �.+��� $(��"Avaliação de Cada Setor do Museu��$��0��$
��Bold"�
��������� -    ��Name$ Legendas��$��0��$��1�� �� Orientation$ Vertical=�$��10q�.+��� $ 
Horizontal=�$��5q�.+�A� $��10��$��10��
���  ��$��Center=��� $��Arquitetura��$��5,-2,0,0q�$��Center=��� $ 
Horizontal=�$��5q�.+�A� $��10��$��10��
��� � �$��Center=��� $#��Atendimento dos Funcionários��$��5,0,0,0q�$��Center=��� $ 
Horizontal=�$��5q�.+�A� $��10��$��10��
��� ���$��Center=��� $��Ambiente e Limpeza��$��5,0,0,0q�$��Center=��� $ 
Horizontal=�$��5q�.+�A� $��10��$��10��
��� ���$��Center=��� $��Qualidade das Obras��$��5,0,0,0q�$��Center=�  -   $ plotViewAvaliacoes��$��1��$��0��$��2��