   M S B A M L   `   `   `  ���� C  ?vRidance, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null#clr-namespace:vRidancevRidance      vRidance.ProxMoxLogin   W SPresentationCore, Version=6.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=6.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=6.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=6.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35^ ZWindowsFormsIntegration, Version=6.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35H 9http://schemas.microsoft.com/winfx/2006/xaml/presentation      R NSystem.Xaml, Version=6.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     @d2http://schemas.microsoft.com/expression/blend/2008     Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     (localclr-namespace:vRidance     -     �Name$  
wdwPMLogin�� � Title$ vRidance��$	��450��$	��800�� � 
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
lblPMLogin��$��Proxmox Login Information��$��Center=�$��0,94,0,0q�$	��Top=�$��44��$	��350��
�������$��Bahnschrift SemiBold)�$��25(�$��Center=��� $��374,49,374,349q�$��/Assets/proxmox.png��$
��Fill=��� -	   $ rectNext��$��Center=�$��50��$��	0,342,0,0q�$	��Top=�$	��150��$
 Hand��
 J� RenderTransformOrigin$
 0.5,0.5&�z�V� .~��� �� ��  �� Angle$ 0Q�T� ���� $ /Assets/NextEnabled.png���� -
    ��Name$ txtUsername��$
��Left=�$��266,225,0,0q� �� TextWrapping$
 Wrap=�$
��root��$	��Top=�$	��120�� �� TextAlignment$
 Left=�$��Bahnschrift SemiBold)�$��20(����	#66E1E1E1 �� AutoWordSelection$
 True��
���������Z� �� -   $	 lblUsername��$��Username��$
��Left=�$��266,202,0,0q�$	��Top=�$��33��$	��120��$$��Bahnschrift SemiBold Condensed)�$��15(�
��������� -   $	 lblPassword��$��Password��$
��Left=�$��414,202,0,0q�$	��Top=�$��33��$	��120��$$��Bahnschrift SemiBold Condensed)�$��15(�
�������$��Right=�G� -    G�Name$ pwbPassword��$
��Left=�$��414,225,0,0q�$	��Top=�$	��120��$��Bahnschrift SemiBold)�$��20(�
����������	#66E1E1E1��Z� �� -   $	 lblvmId��$��Provide first VM ID��$��Center=�$��	0,268,0,0q�$	��Top=�$��28��$	��350��
�������$��Bahnschrift SemiBold)�$��18(�$��Center=��� -   $ txtVMID��$��Center=�$��	0,301,0,0q�$
 Wrap=�$	��Top=�$	��120��$ Center=�$��Bahnschrift SemiBold)�$��20(����	#66E1E1E1$
 True��
���������Z� �� -   $ txtIP��$��Center=�$��	0,175,0,0q�$
 Wrap=�$	��Top=�$	��120��$
 Left=�$��Bahnschrift SemiBold)�$��20(����	#66E1E1E1$
 True��
���������Z� �� -   $	 lblIP��$��Proxmox VE IP��$��Center=�$��	0,152,0,0q�$	��Top=�$��33��$	��120��$$��Bahnschrift SemiBold Condensed)�$��15(�
�������$��Center=�