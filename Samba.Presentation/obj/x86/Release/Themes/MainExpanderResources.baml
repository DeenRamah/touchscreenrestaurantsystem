   M S B A M L   `   `   `  ���� R  NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089 %  !MainExpanderHeaderBackgroundBrush  �� Color ! MainExpanderHeaderBorderBrush " MainExpanderContentBorderBrush , (MainExpanderControlNormalForegroundBrush . *MainExpanderControlDisabledForegroundBrush . *MainExpanderControlDisabledBackgroundBrush * &MainExpanderControlDisabledBorderBrush ' #ExpanderToggleButtonBackgroundBrush * &ExpanderToggleButtonMouseOverFillBrush (	 $ExpanderToggleButtonPressedFillBrush 
 ExpanderToggleButton �� 
TargetType �� RelativeSource �� Path �� Triggers P� Property P� Value �� 
TargetName �� Property	 �� Value  MainViewExpander
 �� 
TargetType � RowDefinitions �Name �� CornerRadius � ColumnDefinitions � OverridesDefaultStyle d� 	IsChecked �� Mode �� ElementName�� D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     :x,http://schemas.microsoft.com/winfx/2006/xaml      %  &	        &	      &	 &     &	 7     &	 H     &	 \     &	 q     &	 �     &	 �     &		 �     &	
 �     7   7  7 	 &	 h    7  7  7   7 
 7  7  7  7  7  7  7  �� $  	#FF3771C1���� $  Black���� $  Black���� $  White���� $  DarkGray���� $  	LightGray���� $  	LightGray���� $  White���� $  Green���� $  Yellow���� " d�.R�� .+��� $��Stretch=�8��  $��Stretch=�
������ F� $��Chevron��$��Center=�$��Center=�"����        �@KL @KL р��     	����  �� *TemplatedParent+$ 
Foreground� P�  �@d�	IsChecked$
 trueY�. ��� $ Chevron�� � ��"	 ��    @KL �@KL     р�� @KL 	P�  �@J�IsMouseOver . . ��� $ Chevron��8	   � ��P�  � �� . . ��� $ Chevron��8	   � ���� "
 9�.���  � ��8	   ��  � ��	 �� " 9�.R��  �� $
��Auto ��� $ 
ContentRow��$��0 �.+��� $��HeaderBorder��$��0��$��1q�$ 0,0,0,0��8�� 8�� ._��  �� $��* ��� $��20 �.+��� $��0��$��4q�$��Header����. d� $��1�� . 8�� 8��  �� $ 
IsExpanded�$ TwoWay=� �� *TemplatedParent+�� $��ContentBorder��$��1��8�� $��1,0,1,1q�$ 0,0,0,0��._��� $��4q� P�  �@9�
IsExpanded . . ��� $ 
ContentRow��	 �� $ Content��$ DesiredHeight� � ��P�  � {� .  . ��� 8	   � ���� $ HeaderBorder��8	   � ���� $ HeaderBorder��8	   � ���� $ ContentBorder��8	 	  � ����  � ��	 �� .R��� 8��
 $
��Bold"����� 