   M S B A M L   `   `   `  ���� C  ?vRidance, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null#clr-namespace:vRidancevRidance      vRidance.ChooseFolder   W SPresentationCore, Version=6.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=6.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=6.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=6.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35^ ZWindowsFormsIntegration, Version=6.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35H 9http://schemas.microsoft.com/winfx/2006/xaml/presentation      R NSystem.Xaml, Version=6.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     @d2http://schemas.microsoft.com/expression/blend/2008     Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     (localclr-namespace:vRidance     -     �Name$  wdwChooseFolder�� � Title$ vRidance��$	��450��$	��800�� � 
ResizeMode$ NoResize=� � WindowStyle$
 None=� � Icon$ /Assets/vRidance.ico��.��� -    �Name$ grdMain3������  �� ImageSource$ /Assets/bg_dark.png��.+��� -    ��Name$ rctTop��$��Center=�$��44��$	��Top=�$	��800�����	#7F000000�� -   $ 	rectClose��$
��Left=�$��21��$��
766,10,0,0q�$	��Top=�$��21�� � Cursor$
 Hand��$
|�True������ $ 
/close.png���� -   $ rectDark��$
��Left=�$��21��$��
738,10,0,0q�$	��Top=�$��22��$
 Hand��$
|�True������ $ 	/moon.png���� -   $ rectMode��$
��Left=�$��20��$��
739,11,0,0q�$	��Top=�$��20��$
 Hand��$
|�True������ $ /Assets/sun.png���� -   	 ��Name$	 lblvRidance��$��vRidance v1.0��$
��Left=�$��10,9,0,0q�$	��Top=�$��Cascadia Mono SemiBold)�
��������� -   
 ��Name$
 txtPath��$��Center=�$��	0,263,0,0q� �� TextWrapping$
 Wrap=�$	��Top=�$	��476��$��27�����	#7F000000
������� �� SelectionBrush �	#FF00C88D$��Bahnschrift SemiBold)�$��Normal&���Z� �� -	   $	 lblInfo��$/��)Select directory with VMDK subdirectories��$
��Left=�$��158,225,0,0q�$	��Top=�$��33��$	��305��$$��Bahnschrift SemiBold Condensed)�$��15(��� -
   $ rectNext��$��Center=�$��50��$��	0,342,0,0q�$	��Top=�$	��150��$
 Hand�� J� RenderTransformOrigin$ 0.5,0.5&�z�V� .~��� �� ��  �� Angle$ 0Q�T� ���� $ /Assets/NextEnabled.png���� -   $	 lblSelectFolder��$��Select Parent VM Folder��$��Center=�$��0,94,0,0q�$	��Top=�$��44��$	��350��
�������$��Bahnschrift SemiBold)�$��25(�$��Center=��� -    ��Name$ 	btnSearch��$��°°°��$
��Left=�$��643,263,0,0q�$	��Top=�$��27��$��31�����	#FF61D4B8��Z� 