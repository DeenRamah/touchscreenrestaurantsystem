   M S B A M L   `   `   `  ����   Samba.Modules.TaskModule@    :Samba.Modules.TaskModule.Widgets.TaskEditor.TaskEditorView   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     @d2http://schemas.microsoft.com/expression/blend/2008     -   $��16(�.���� -   $��Border��$��1q�
�������._�� -   $��MainGrid��
�������|�.    � RowDefinitions  �� $
��auto ��� $��* �.+�� $��3q� � ColumnDefinitions �� $��* �  �� $
��auto ��� $
��auto ��� $
��auto �.+��� -   $��CustomEditors��|�.  ���� *CustomFields+���� .R��� $��0,0,3,3q�.+��� ���� *Name+�� ���� *Value+ �� UpdateSourceTrigger$ PropertyChanged=����� .R�]� $��50���� -   $��TextBox��$��1�� �� MinLines$ 1��$��0,0,3,0q� �� TextWrapping$ WrapWithOverflow=� �� AutoWordSelection . $��0������ *	NewTask+$ PropertyChanged=��� $��1��$
��Auto=�.���� $��3q����� *Tasks+���� .R��� $��0,0,0,1q�
�������$	��0,2q� � 	Resources  �� 
TargetType   ItemsControlButtonStyle �� BasedOn	 �� Triggers
 P� Property P� Value �� Property �� Value �� Binding �� Path �� Value��%X  '��       7   '�� �     �� " ��8   	 P� 
 �@J�IsMouseOver . . ���  � ��
 �   �P� 
 �@J�IsMouseOver .  . ���  � ��
 �������  �� $ IsCompleted� True.a���  � ��
 ������� " ��	 ��  �� $ IsCompleted� True.a���  � ��$ StrikeThrough{���  � ��
 �����._�]� .+��� $��3q�$��Center=�$��	wingdings)����� *ToggleCompletedCommand+���� *IsCompletedCaption+� $��3,3,3,5q�$	��Top=�  �� $
��Auto ��� $
��Auto ��� $
��Auto �.+��� $��0��$��WrapWithOverflow=����� *CustomFieldValues+y��� *IsCustomFieldValuesVisible+  VisibilityConverter �� 	Converter# [ �� $��1��$��WrapWithOverflow=����� *Description+y��� *IsDescriptionVisible+# [ �� $��2������ *TaskCommands+���� .R��� $	��2,3q���  �� Command �� *DataContext.ExecuteCommand+ �� RelativeSource ��  �� Mode$ FindAncestor=� �� AncestorType" �� �� CommandParameter �� $ .�.�.��� ���� $ .����� .R�� 