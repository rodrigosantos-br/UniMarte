   M S B A M L   `   `   `  ���� G  CUniMarte.Wpf, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullS.clr-namespace:UniMarte.Wpf.ControleCustomizado UniMarte.Wpf.ControleCustomizado  5    /UniMarte.Wpf.ControleCustomizado.TecladoVirtual   W SPresentationCore, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35^ ZWindowsFormsIntegration, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35H 9http://schemas.microsoft.com/winfx/2006/xaml/presentation      R NSystem.Xaml, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     @d2http://schemas.microsoft.com/expression/blend/2008     @local.clr-namespace:UniMarte.Wpf.ControleCustomizado       � 	Resources     FocusVisual �� Property �� Value �� StrokeDashArray!  System.Windows.SystemColors   ControlTextBrushKey J� SnapsToDevicePixels  OptionMarkFocusVisual   OptionMark.Static.Background �� Color  OptionMark.Static.Border  OptionMark.Static.Glyph # OptionMark.MouseOver.Background  OptionMark.MouseOver.Border  OptionMark.MouseOver.Glyph ! OptionMark.Pressed.Background 	 OptionMark.Pressed.Border 
 OptionMark.Pressed.Glyph " OptionMark.Disabled.Background  OptionMark.Disabled.Border  OptionMark.Disabled.Glyph 	 Shift �� 
TargetType �� 
TargetType	 �Name
 � ColumnDefinitions ��Name F�Name J� Opacity �� Stretch ��Name ��Name �� Triggers P� Property P� Value �� 
TargetName �� CornerRadius �� Padding��%�
  &	        &	 R     &	 �     &	 �     &	 �     &	 �     &	 �     &	     &	 )    &		 >    &	
 S    &	 h    &	 }    &	 �    &	 �    7   7  7  7  7  7  7  7  7  7  7  7  7  7  7  7 	 7 
 7 
 '�� �    �� .���  � �� �� .R��� $��2q�$	 1 2R�#���  $
 true��$��1���� .���  � �� �� .R��� $��14,0,0,0q�$	 1 2R�#���  $
 true��$��1���� $ 	#FFFFFFFF���� $ 	#FF707070���� $ 	#FF212121���� $ 	#FFF3F9FF���� $ 	#FF5593FF���� $ 	#FF212121���� $ 	#FFD9ECFF���� $ 	#FF3C77DD���� $ 	#FF212121���� $ 	#FFE6E6E6���� $ 	#FFBCBCBC���� $ 	#FF707070���� " ��.���  �@�FocusVisualStyle8   ��  � ��8  ��  � ��8  ��  � ��# �  ��  � ��$ 1q���  � �� �� " ��.R�� $	 templateRoot��
������ $
 True��
 �� $
��Auto ��� $��* �.+��� $ checkBoxBorder��#��z��#��z��#��z��#��z��$��1q�#��z��._�� $	 markGrid��.+�F� $ 
optionMark��Y�����4� �� Ѽ�G dԊ Ѩ�D dԊ �    ^>O ��z r�5 ��@ ��\ 
ܺ��� @�j�  �>��4� �� 8�� $��1q�$ 0Q�$
 None=��� $ indeterminateMark��8�� $��2q�$ 0Q��� $ contentPresenter��$��1��$|�False��#��z��#��z��$
��True��# z #��z�� P�  � ��$
 true��. ��� 8   �@�FocusVisualStyle��  � ��$ 4,-1,0,0q�P�  �@J�IsMouseOver$
 true��. ��� $ checkBoxBorder��8   � ���� $ checkBoxBorder��8   � ���� $ 
optionMark��8   � ���� $ indeterminateMark��8 	  � ��P�  � {�$ false��. ��� $ checkBoxBorder��8 
  � ���� $ checkBoxBorder��8   � ���� $ 
optionMark��8   � ���� $ indeterminateMark��8   � ��P�  � ��$
 true��. ��� $ checkBoxBorder��8   � ���� $ checkBoxBorder��8   � ���� $ 
optionMark��8   � ���� $ indeterminateMark��8   � ��P�  �@d�	IsChecked$
 trueY�. ��� $ 
optionMark�� �@J�Opacity$ 1Q��� $ indeterminateMark�� �@J�Opacity$ 0Q�P�  Z�  �@d�	IsChecked. ��� $ 
optionMark�� �@J�Opacity$ 0Q��� $ indeterminateMark�� �@J�Opacity$ 1Q��� " ��.���  � ��
 ���� ��  � ��
 ���� ��  � ��$ 0q���  � ��$ 10q���  � ��$ 5q���  � ��$ Segoe UI Semibold)���  � ��$ 20(���  � ��$ Center=���  � ��$ Center=���  � �� �� " ��.R��� $ border��
�������
�������$��1q�$ 15��# z��._��� $��Center=�$��Center=� P�  �@J�IsMouseOver$
 True��. ��� $ border�� � ��
 ��  ��� $ border�� � ��
 �   �P�  � ��$
 True��. ��� $ border�� � ��
 ����.��� $	��440��$
��1200��$��Stretch=�$��Stretch=� � RowDefinitions �� $��* ��� $��* ��� $��* ��� $��* ��� $��* �
 �� $��* ��� $��* ��� $��* ��� $��* ��� $��* ��� $��* ��� $��* ��� $��* ��� $��* ��� $��* ��� $��* ��� $��* �.+��� -    ��Name$ chkShift��$��SHIFT��$��3��$��0��$��2��$��Segoe UI Semibold)�$��20(�$��10q�$��5q����� " ��.R��� $ border��
�������
�������$��1q�$ 10��$ 10q�._��� $��Center=�$��Center=� P�  �@d�	IsChecked$
 TrueY�. ��� $ border�� � ��
 ����P�  � ��$
 True��. ��� $ border�� � ��
 ��  ��� $ border�� � ��
 �   ��� -   $
��btn1��$��1��
 � Tag$ 1��$��0��$��1���� -   $
��btn2��$��2��$ 2��$��0��$��2���� -   $
��btn3��$��3��$ 3��$��0��$��3���� -   $
��btn4��$��4��$ 4��$��0��$��4���� -   $
��btn5��$��5��$ 5��$��0��$��5���� -   $
��btn6��$��6��$ 6��$��0��$��6���� -   $
��btn7��$��7��$ 7��$��0��$��7���� -	   $
��btn8��$��8��$ 8��$��0��$��8���� -
   $
��btn9��$��9��$ 9��$��0��$��9���� -   $
��btn0��$��0��$ 0��$��0��$��10���� -   $
��btnQ��$��Q��$ Q��$��1��$��0���� -   $
��btnW��$��W��$ W��$��1��$��1���� -   $
��btnE��$��E��$ E��$��1��$��2���� -   $
��btnR��$��R��$ R��$��1��$��3���� -   $
��btnT��$��T��$ T��$��1��$��4���� -   $
��btnY��$��Y��$ Y��$��1��$��5���� -   $
��btnU��$��U��$ U��$��1��$��6���� -   $
��btnI��$��I��$ I��$��1��$��7���� -   $
��btnO��$��O��$ O��$��1��$��8���� -   $
��btnP��$��P��$ P��$��1��$��9���� -   $
��btnA��$��A��$ A��$��2��$��0���� -   $
��btnS��$��S��$ S��$��2��$��1���� -   $
��btnD��$��D��$ D��$��2��$��2���� -   $
��btnF��$��F��$ F��$��2��$��3���� -   $
��btnG��$��G��$ G��$��2��$��4���� -   $
��btnH��$��H��$ H��$��2��$��5���� -   $
��btnJ��$��J��$ J��$��2��$��6���� -   $
��btnK��$��K��$ K��$��2��$��7���� -   $
��btnL��$��L��$ L��$��2��$��8���� -   $��btnÇ��$��Ç��$ Ç��$��2��$��9���� -    $
��btnZ��$��Z��$ Z��$��3��$��2���� -!   $
��btnX��$��X��$ X��$��3��$��3���� -"   $
��btnC��$��C��$ C��$��3��$��4���� -#   $
��btnV��$��V��$ V��$��3��$��5���� -$   $
��btnB��$��B��$ B��$��3��$��6���� -%   $
��btnN��$��N��$ N��$��3��$��7���� -&   $
��btnM��$��M��$ M��$��3��$��8���� -'   $��btnATil��$��Ã��$ Ã��$��4��$��0���� -(   $��	btnAAgudo��$��Á��$ Á��$��4��$��1���� -)   $��	btnEAgudo��$��É��$ É��$��3��$��11���� -*   $��btnOTil��$��Õ��$ Õ��$��2��$��10���� -+   $��	btnOAgudo��$��Ó��$ Ó��$��2��$��11���� -,   $��btnPonto��$��.��$ .��$��3��$��10���� --   $��btnBarra��$��/��$ /��$��3��$��9���� -.   $��
btnVirgula��$��,��$ ,��$��4��$��10���� -/   $��	btnArroba��$��@��$ @��$��4��$��11���� -0   $��	btnEspaco��$��ESPAÇO��$  ��$��4��$��3��$��6���� -1   $��	btnApagar��$��1��$��10��$��2��.����  �� Orientation$ 
Horizontal=�.+��� $��APAGAR��$��Center=��� $'��!/Imagens/Icones/seta-esquerda.png��$
��Fill=�$��60��$��82��$��10,0,0,0q�