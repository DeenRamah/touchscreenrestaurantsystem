   M S B A M L   `   `   `  ����   Samba.Presentation    Samba.Presentation.Shell   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    ` \Microsoft.Practices.Prism, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35.cal$http://www.codeplex.com/CompositeWPF  R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     -     � Title$  Samba Pos Shell�� � WindowStartupLocation$ CenterScreen=� � WindowStyle$ SingleBorderWindow=� � WindowState$ Normal=� J� SnapsToDevicePixels . $	��600��$	��800�� � Icon$- '/Samba.Presentation;component/apple.ico������  �� EndPoint$ 0.5,1&� �� 
StartPoint$ 0.5,0&�.���  � Color$ 	#FF70B8FF��	 � Offset$	 0Q�� $ 	#FF5CBBFF��$	 0.992Q�� $ 	#FF044392��$	 0.085Q�.��� -   $��MainGrid��
 � LayoutTransform
 ��  � RowDefinitions �� $
��auto ��� $��* ��� $
��auto � � ColumnDefinitions �� $��* ��� $��* �.+��� $��0�� �� Orientation$ 
Horizontal=�$��Stretch=�.+��� $9��3/Samba.Presentation;component/Images/apple-icon.png��$��UniformToFill=�$��0,0,0,2q��� -   $
��10,0q�$
��Bold"�$��24(�
�������$��Center=�
SambaPOS 3�� -   $��	TimeLabel��$��0��$��1��$��	10,5,10,0q�$��18(�
�������$��Center=�$��Right=�$��Lucida Console)�SAAT�� -   $��MainTabControl��   BorderlessTabControlStyle#��[  $��0q�$��0q�$��1��$��2��5  /Microsoft.Practices.Prism.Regions.RegionManager   
RegionName$ 
MainRegion�� �� SelectedIndex$ 0������  �� 
TargetType" ��.���  �� Property � y� �� Value$ 	Collapsed=�� $��2��$��2��
������� � 	Resources ��%-   '��       �� " ��.���  � ��$ 16(� �� $
��auto ��� $��* ��� $
��auto ��� $
��auto �.+��� -   $��
UserRegion��$��0��$ 
UserRegion��
������ ���� .R��� $ 
Horizontal=��� -   $��MessageRegion��$��1��$ MessageRegion��
������ ���� .R��� $ 
Horizontal=��� -   $��RightUserRegion��$��3��$ RightUserRegion��
������ ���� .R��� $ 
Horizontal=�