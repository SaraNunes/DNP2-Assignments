   M S B A M L   `   `   `  ����   Assignment6_Player#    Assignment6_Player.MainWindow   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     @d2http://schemas.microsoft.com/expression/blend/2008     Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006       � Title$  Media Player��$��522.973��$	��800�� � WindowStartupLocation$ CenterScreen=� � 
ResizeMode$ NoResize=�.��� .+�r� -   $��MediaViewer��$
��Left=�$	��331��$��0,47,-0.4,0q�$	��Top=�$	��794�� r� LoadedBehavior$ Manual=��� -   $��
OpenButton��$
��Left=�$��196,427,0,0q�$	��Top=�$��81��$��41��$��2q�
���   � � Triggers :�  :� RoutedEvent$ Button.Click��.[��� .���� .���� 	 �� To$ GreenX� �� TargetProperty$1 +(Button.Background).(SolidColorBrush.Color)� g� FillBehavior$
 Stop=�	 g� Duration$	 0:0:1D�
 g� AutoReverse
 . .����  �� Orientation$ 
Horizontal=�.+��� $��44�� �� TextAlignment$ Center=�$��Center=��� $
�Open���� -   $��
PlayButton��$
��Left=�$��310,427,0,0q�$	��Top=�$��81��$��41��$��2q�
���   �.���� $ 
Horizontal=�.+��� $��44��$ Center=�$��Center=��� $
�Play��z��� -   PlayTransform�� �� Angle$ 0Q� :� $ Button.Click��.[��� .���� .��W�  �� 
TargetName$ PlayTransform��$ (RotateTransform.Angle)� W� From$	 0.0X�	 W� To$	 360X�$	 0:0:1D��� -   $��PauseButton��$
��Left=�$��429,427,0,0q�$	��Top=�$��81��$��41��$��2q�
���   �.���� $ 
Horizontal=�.+��� $��44��$ Center=�$��Center=��� $�Pause��z��� -   PauseTransform��$	 360Q� :� $ Button.Click��.[��� .���� .��W� $ PauseTransform��$ (RotateTransform.Angle)�$	 360X�$ 0X�$	 0:0:1D��� -   $��
StopButton��$
��Left=�$��547,427,0,0q�$	��Top=�$��81��$��41��$��2q�
���   � J� RenderTransformOrigin$ 0.767,0.522&�.���� $ 
Horizontal=�.+��� -    ��Name$ StopText��$��44��$ Center=�$��Center=��� $
�Stop�� :� $ Button.Click��.[��� .���� .��W� $ 
StopButton��$ (Button.Opacity)�$ 1X�$ 0X�$	 0:0:1D�
 . �� -	   $��FilePlayingLabel��$�� ��$
��Left=�$��	41,10,0,0q�$	��Top=�$	��709���� -
   $��ProgressBar��$
��Left=�$��
93,390,0,0q�$	��Top=�$	��691��$��15���� -   $��ProgressLabel��$
��Left=�$��
10,383,0,0q�$	��Top=�$��33��$��56��$ 0.512,1.152&�