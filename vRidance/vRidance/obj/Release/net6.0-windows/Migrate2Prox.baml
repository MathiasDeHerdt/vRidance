   M S B A M L   `   `   `  ���� C  ?vRidance, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null#clr-namespace:vRidancevRidance      vRidance.Migrate2Prox   W SPresentationCore, Version=6.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=6.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=6.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=6.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35^ ZWindowsFormsIntegration, Version=6.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35H 9http://schemas.microsoft.com/winfx/2006/xaml/presentation      R NSystem.Xaml, Version=6.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     @d2http://schemas.microsoft.com/expression/blend/2008     Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     (localclr-namespace:vRidance     -     �Name$  wdwPMMigrate�� � Title$ vRidance��$	��450��$	��800�� � 
ResizeMode$ NoResize=� � WindowStyle$
 None=� � Icon$ /Assets/vRidance.ico��.��� -    �Name$ grdMain4������  �� ImageSource$ /Assets/bg_dark.png��.+��� -    ��Name$ rctTop��$��Center=�$��44��$	��Top=�$	��800�����	#7F000000�� -   $ 	rectClose��$
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
��������� -   $	 
lblPMStart��$��Migrating VMs��$��Center=�$��0,94,0,0q�$	��Top=�$��44��$	��516��
�������$��Bahnschrift SemiBold)�$��25(�$��Center=�
 J� RenderTransformOrigin$
 0.285,0.399&��� -	   $ rectNext��$��Center=�$��50��$��	0,342,0,0q�$	��Top=�$	��150��$
 Hand��$
 0.5,0.5&�z�V� .~��� �� ��  �� Angle$ 0Q�T� ���� $ /Assets/NextEnabled.png���� -
   $	 	lblCurrVM��$��Settings for��$��Center=�$��	0,146,0,0q�$	��Top=�$��44��$	��576��
�������$��Bahnschrift SemiBold)�$��20(�$��Center=�$
 0.285,0.399&��� -   $	 lblType��$��
Type of VM��$
��Left=�$��266,189,0,0q�$	��Top=�$��32��$	��120��$$��Bahnschrift SemiBold Condensed)�$��15(�
��������� -    ��Name$ cbType��$
��Left=�$��	266,0,0,0q�$��Center=�$	��120��$��Bahnschrift SemiBold)�$��17(���Z� ����  �� EndPoint$	 0,1&�.���  � Color$ 	#FFF0F0F0��� $ 	#FFE1E1E1�� � Offset$ 1Q��� -   $	 
lblVersion��$��Version of VM��$
��Left=�$��459,187,0,0q�$	��Top=�$��32��$��79��$$��Bahnschrift SemiBold Condensed)�$��15(�
��������� -   $ 	cbVersion��$
��Left=�$��	414,0,0,0q�$��Center=�$	��120��$��Bahnschrift SemiBold)�$��17(���Z� ���� $	 0,1&�.��� $ 	#FFF0F0F0��� $ 	#FFE1E1E1��$ 1Q��� -    ��Name$ txtCores��$
��Left=�$��266,273,0,0q� �� TextWrapping$
 Wrap=�$	��Top=�$	��120�� �� TextAlignment$ Center=�$��Bahnschrift SemiBold)�$��20(����	#66E1E1E1 �� AutoWordSelection$
 True��
���������Z� �� -   $	 lblCores��$��Number of cores��$
��Left=�$��266,249,0,0q�$	��Top=�$��34��$	��120��$$��Bahnschrift SemiBold Condensed)�$��15(�
��������� -   $	 	lblMemory��$��Amount of RAM (MB)��$
��Left=�$��426,249,0,0q�$	��Top=�$��34��$	��111��$$��Bahnschrift SemiBold Condensed)�$��15(�
��������� -   $ 	txtMemory��$
��Left=�$��414,273,0,0q�$
 Wrap=�$	��Top=�$	��120��$ Center=�$��Bahnschrift SemiBold)�$��20(����	#66E1E1E1$
 True��
���������Z� �� -   $ 
rectFinish��$��Center=�$��50��$��	0,342,0,0q�$	��Top=�$	��150��$
 Hand��$
 0.5,0.5&�$y�Hidden=�z�V� .~��� �� �� $ 0Q�T� ���� $ /Assets/NextEnabled.png��� -    �Name$ 
pbProgress��$��Center=�$��11��$��	0,440,0,0q�$	��Top=�$	��802�����	#FF34ACAB���	#7F000000��Z� �� -   $	 lblInfo��$�� ��$
��Left=�$��	0,409,0,0q�$	��Top=�$	��245��
����������	#7F000000$$��Bahnschrift SemiBold Condensed)�$��17(�