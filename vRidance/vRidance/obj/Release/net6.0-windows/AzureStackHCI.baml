   M S B A M L   `   `   `  ���� C  ?vRidance, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null#clr-namespace:vRidancevRidance      vRidance.AzureStackHCI   W SPresentationCore, Version=6.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=6.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=6.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=6.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35^ ZWindowsFormsIntegration, Version=6.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35H 9http://schemas.microsoft.com/winfx/2006/xaml/presentation      R NSystem.Xaml, Version=6.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     @d2http://schemas.microsoft.com/expression/blend/2008     Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     (localclr-namespace:vRidance       � Title$  vRidance��$	��450��$	��800�� � 
ResizeMode$ NoResize=� � WindowStyle$
 None=�.��� -   ����  �� ImageSource$ /Assets/bg_dark.png��.+��� -    ��Name$ rctTop��$��Center=�$��44��$	��Top=�$	��800�����	#7F000000�� -   $ 	rectClose��$
��Left=�$��21��$��
766,10,0,0q�$	��Top=�$��21�� � Cursor$
 Hand��$
|�True������ $ 
/close.png���� -   $ rectDark��$
��Left=�$��21��$��
738,10,0,0q�$	��Top=�$��22��$
 Hand��$
|�True������ $ 	/moon.png���� -   $ rectMode��$
��Left=�$��20��$��
739,11,0,0q�$	��Top=�$��20��$
 Hand��$
|�True������ $ /Assets/sun.png���� -    ��Name$ lblvRidance��$��vRidance v1.0��$
��Left=�$��10,9,0,0q�$	��Top=�$��Cascadia Mono SemiBold)�
��������� -   $ 
lblPMStart��$#��Migrate VM to Azure Stack HCI��$��Center=�$��0,94,0,0q�$	��Top=�$��44��$	��516��
�������$��Bahnschrift SemiBold)�$��25(�$��Center=� J� RenderTransformOrigin$ 0.285,0.399&��� -   $ 	lblCurrVM��$#��Fill in the VM configurations��$��Center=�$��	0,143,0,0q�$	��Top=�$��44��$	��577��
�������$��Bahnschrift SemiBold)�$��20(�$��Center=�$ 0.285,0.399&��� -	   $ lblHostName��$��Hostname��$
��Left=�$��
30,184,0,0q�$	��Top=�$��33��$	��120��$$��Bahnschrift SemiBold Condensed)�$��15(�
��������� -
    ��Name$ txtHostName��$
��Left=�$��
30,207,0,0q�	 �� TextWrapping$
	 Wrap=�$	��Top=�$	��120��
 �� TextAlignment$
 Center=�$��Bahnschrift SemiBold)�$��20(����	#66E1E1E1 �� AutoWordSelection$
 True��
���������Z� �� -   $ 	lblVMName��$��VM Name��$
��Left=�$��
30,245,0,0q�$	��Top=�$��33��$	��120��$$��Bahnschrift SemiBold Condensed)�$��15(�
��������� -   $ 	txtVMName��$
��Left=�$��
30,268,0,0q�$
	 Wrap=�$	��Top=�$	��120��$
 Center=�$��Bahnschrift SemiBold)�$��20(����	#66E1E1E1$
 True��
���������Z� �� -   $ lblClusterName��$��Cluster Name��$
��Left=�$��183,184,0,0q�$	��Top=�$��33��$	��120��$$��Bahnschrift SemiBold Condensed)�$��15(�
��������� -   $ txtClusterName��$
��Left=�$��183,207,0,0q�$
	 Wrap=�$	��Top=�$	��120��$
 Center=�$��Bahnschrift SemiBold)�$��20(����	#66E1E1E1$
 True��
���������Z� �� -   $ lblStartMemory��$��Startup Memory��$
��Left=�$��183,245,0,0q�$	��Top=�$��33��$	��120��$$��Bahnschrift SemiBold Condensed)�$��15(�
��������� -   $ txtStartMemory��$
��Left=�$��183,268,0,0q�$
	 Wrap=�$	��Top=�$	��120��$
 Center=�$��Bahnschrift SemiBold)�$��20(����	#66E1E1E1$
 True��
���������Z� �� -   $ lblMinimumBytes��$��MinimumBytes��$��Center=�$��	0,184,0,0q�$	��Top=�$��33��$	��120��$$��Bahnschrift SemiBold Condensed)�$��15(�
��������� -   $ txtMinimumBytes��$��Center=�$��	0,207,0,0q�$
	 Wrap=�$	��Top=�$	��120��$
 Center=�$��Bahnschrift SemiBold)�$��20(����	#66E1E1E1$
 True��
���������Z� �� -   $ lblMaximumBytes��$��MaximumBytes��$��Center=�$��	0,245,0,0q�$	��Top=�$��33��$	��120��$$��Bahnschrift SemiBold Condensed)�$��15(�
��������� -   $ txtMaximumBytes��$��Center=�$��	0,268,0,0q�$
	 Wrap=�$	��Top=�$	��120��$
 Center=�$��Bahnschrift SemiBold)�$��20(����	#66E1E1E1$
 True��
���������Z� �� -   $ lblBootDeviceExtention��$��Device Extention��$
��Left=�$��502,182,0,0q�$	��Top=�$��33��$��98��$$��Bahnschrift SemiBold Condensed)�$��15(�
��������� -   $ txtBootDeviceExtention��$
��Left=�$��501,207,0,0q�$
	 Wrap=�$	��Top=�$	��120��$
 Center=�$��Bahnschrift SemiBold)�$��20(����	#66E1E1E1$
 True��
���������Z� �� -   $ lblBootDevicePath��$��Boot Device Path��$
��Left=�$��501,245,0,0q�$	��Top=�$��33��$	��111��$$��Bahnschrift SemiBold Condensed)�$��15(�
��������� -   $ txtBootDevicePath��$
��Left=�$��502,268,0,0q�$
	 Wrap=�$	��Top=�$	��120��$
 Center=�$��Bahnschrift SemiBold)�$��20(����	#66E1E1E1$
 True��
���������Z� �� -   $ lblNetworkAdapter��$��Network Adapter��$
��Left=�$��656,184,0,0q�$	��Top=�$��33��$	��111��$$��Bahnschrift SemiBold Condensed)�$��15(�
��������� -   $ txtNetworkAdapter��$
��Left=�$��656,207,0,0q�$
	 Wrap=�$	��Top=�$	��120��$
 Center=�$��Bahnschrift SemiBold)�$��20(����	#66E1E1E1$
 True��
���������Z� �� -   $ lblLocationPath��$��Location Path��$
��Left=�$��656,245,0,0q�$	��Top=�$��33��$	��110��$$��Bahnschrift SemiBold Condensed)�$��15(�
��������� -   $ txtLocationPath��$
��Left=�$��656,268,0,0q�$
	 Wrap=�$	��Top=�$	��120��$
 Center=�$��Bahnschrift SemiBold)�$��20(����	#66E1E1E1$
 True��
���������Z� �� -   $ lblCreateVM��$��	Create VM��$
��Left=�$��373,314,0,0q�$	��Top=�$��28��$��70��$$��Bahnschrift SemiBold Condensed)�$��15(�
��������� -   $ recCreateVM��$��Center=�$��50��$��	0,342,0,0q�$	��Top=�$	��150��$
 Hand��$ 0.5,0.5&�z�V� .~��� �� ��  �� Angle$ 0Q�T� ���� $ /Assets/NextEnabled.png��