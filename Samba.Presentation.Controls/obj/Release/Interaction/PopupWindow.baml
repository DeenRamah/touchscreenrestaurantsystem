   M S B A M L   `   `   `  ����   Samba.Presentation.Controls9    3Samba.Presentation.Controls.Interaction.PopupWindow   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35^ ZWindowsFormsIntegration, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     @d2http://schemas.microsoft.com/expression/blend/2008     -     � Title$  Popup�� � WindowStyle$
 None=� � Topmost .  � AllowsTransparency . 
������  � ShowInTaskbar .  |�.   � ShowActivated .  .���  � RowDefinitions �� $��* ��� $
��auto �.+��� $��1������ *	PopupList+���� .R��� $	��btn��   ItemsControlButtonStyle#��[  |�.  ���� * DataContext.ClickButtonCommand+ �� RelativeSource ��  �� Mode$ FindAncestor=�	 �� AncestorType"	 ������ .���� $	��Brd��|�.  $	��150��$y�Hidden=�$��2q�
 �� CornerRadius$
 3��$��1q����� *HeaderColor+����  �� EndPoint$ 	0.504,1.5&� �� 
StartPoint$ 
0.504,0.03&�.���  � Offset$ 0Q� � Color �� *ContentColor+� $ 	#FFFFFFFF��$	 0.9Q� � Triggers :�  :� RoutedEvent$ Loaded��[��� .����  g� 	BeginTime$ 00:00:00X�.��W�  �� 
TargetName$	 Brd�� �� TargetProperty$ Height� W� From$	 0.0X� g� Duration$ 0:0:0.5D� W� EasingFunction 0  *System.Windows.Media.Animation.ElasticEase  7  1System.Windows.Media.Animation.EasingFunctionBase   
EasingMode$ EaseOut=�   Oscillations$ 3��   Springiness$ 8Q�T� $ 
Visibility�..�i�  R� KeyTime$ 	0:0:0.001��  System.Windows.Visibility   Visible R� Value# Z ._��� |�.  .+��� $��TitleBox��|�.   �� Padding$ 2,0,0,2q�
�������$��18(�$
��Bold"����� *HeaderColor+���� *Title+�� |�.  $��12(�$
��Bold"�$��2q�$
��Wrap=����� *	Content+