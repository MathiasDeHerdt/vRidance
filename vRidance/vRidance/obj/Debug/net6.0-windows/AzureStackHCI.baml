   M S B A M L   `   `   `  ����C  ?vRidance, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null#clr-namespace:vRidancevRidance  5   	       vRidance.AzureStackHCI   5   	   W SPresentationCore, Version=6.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=6.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=6.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=6.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35^ ZWindowsFormsIntegration, Version=6.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35H 9http://schemas.microsoft.com/winfx/2006/xaml/presentation      5   	   R NSystem.Xaml, Version=6.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   (localclr-namespace:vRidance     5   	     � Title$  vRidance��5   	   $	��450��6   $	��800��6'    � 
ResizeMode$ NoResize=�63    � WindowStyle$
 None=�6I   .��5
      � -   5        ��5   
   �� 5       �� ImageSource$ /Assets/bg_dark.png��6   .+�5   
   �� -   5         ��Name$ rctTop��5      $��Center=�6$   $��44��6A   $	��Top=�6M   $	��800��6e   ���	#7F0000006q   �� 5   
   -   5        $ 	rectClose��5      $
��Left=�6'   $��21��6B   $��
766,10,0,0q�6N   $	��Top=�6b   $��21��6z    � Cursor$
 Hand��6�   $
|�True��6�   ��5      �� 5      $ 
/close.png��6   5      �� 5   
   -   5        $ rectDark��5      $
��Left=�6&   $��21��6A   $��
738,10,0,0q�6M   $	��Top=�6a   $��22��6y   $
 Hand��6�   $
|�True��6�   ��5      �� 5      $ 	/moon.png��6   5      �� 5    
   -   5        $ rectMode��5       $
��Left=�6&   $��20��6A   $��
739,11,0,0q�6M   $	��Top=�6a   $��20��6y   $
 Hand��6�   $
|�True��6�   ��5!      �� 5"      $ /Assets/sun.png��6   5$      �� 5)   
   -   5         ��Name$ lblvRidance��5)      $��vRidance v1.0��6%   $
��Left=�6=   $��10,9,0,0q�6X   $	��Top=�6j   $��Cascadia Mono SemiBold)�6�   
�������6�   �� 5*   
   -   5        $ 
lblPMStart��5*      $#��Migrate VM to Azure Stack HCI��6$   $��Center=�6L   $��0,94,0,0q�6i   $	��Top=�6{   $��44��6�   $	��516��6�   
�������$��Bahnschrift SemiBold)�6�   $��25(�6�   $��Center=�6�    J� RenderTransformOrigin$ 0.285,0.399&�6  �� 5+   
   -   5        $ 	lblCurrVM��5+      $#��Fill in the VM configurations��6#   $��Center=�6K   $��	0,143,0,0q�6h   $	��Top=�6{   $��44��6�   $	��577��6�   
�������$��Bahnschrift SemiBold)�6�   $��20(�6�   $��Center=�6�   $ 0.285,0.399&�6  �� 50   
   -	   5        $ lblHostName��50      $��Hostname��6%   $
��Left=�68   $��
30,184,0,0q�6S   $	��Top=�6g   $��33��6   $	��120��6�   $$��Bahnschrift SemiBold Condensed)�6�   $��15(�6�   
�������6�   �� 51   
   -
   5         ��Name$ txtHostName��51      $
��Left=�6'   $��
30,207,0,0q�6B   	 �� TextWrapping$
	 Wrap=�6V   $	��Top=�6j   $	��120��6�   
 �� TextAlignment$
 Center=�6�   $��Bahnschrift SemiBold)�6�   $��20(�6�   ���	#66E1E1E1 �� AutoWordSelection$
 True��6  
���������6�   Z� 6  �� 53   
   -   5        $ 	lblVMName��53      $��VM Name��6#   $
��Left=�65   $��
30,245,0,0q�6P   $	��Top=�6d   $��33��6|   $	��120��6�   $$��Bahnschrift SemiBold Condensed)�6�   $��15(�6�   
�������6�   �� 54   
   -   5        $ 	txtVMName��54      $
��Left=�6%   $��
30,268,0,0q�6@   $
	 Wrap=�6T   $	��Top=�6h   $	��120��6�   $
 Center=�6�   $��Bahnschrift SemiBold)�6�   $��20(�6�   ���	#66E1E1E1$
 True��6  
���������6�   Z� 6  �� 56   
   -   5        $ lblClusterName��56      $��Cluster Name��6(   $
��Left=�6?   $��183,184,0,0q�6Z   $	��Top=�6o   $��33��6�   $	��120��6�   $$��Bahnschrift SemiBold Condensed)�6�   $��15(�6�   
�������6�   �� 57   
   -   5        $ txtClusterName��57      $
��Left=�6*   $��183,207,0,0q�6E   $
	 Wrap=�6Z   $	��Top=�6n   $	��120��6�   $
 Center=�6�   $��Bahnschrift SemiBold)�6�   $��20(�6�   ���	#66E1E1E1$
 True��6  
���������6�   Z� 6   �� 59   
   -   5        $ lblStartMemory��59      $��Startup Memory��6(   $
��Left=�6A   $��183,245,0,0q�6\   $	��Top=�6q   $��33��6�   $	��120��6�   $$��Bahnschrift SemiBold Condensed)�6�   $��15(�6�   
�������6�   �� 5:   
   -   5        $ txtStartMemory��5:      $
��Left=�6*   $��183,268,0,0q�6E   $
	 Wrap=�6Z   $	��Top=�6n   $	��120��6�   $
 Center=�6�   $��Bahnschrift SemiBold)�6�   $��20(�6�   ���	#66E1E1E1$
 True��6  
���������6�   Z� 6   �� 5<   
   -   5        $ lblMinimumBytes��5<      $��MinimumBytes��6)   $��Center=�6@   $��	0,184,0,0q�6]   $	��Top=�6p   $��33��6�   $	��120��6�   $$��Bahnschrift SemiBold Condensed)�6�   $��15(�6�   
�������6�   �� 5=   
   -   5        $ txtMinimumBytes��5=      $��Center=�6+   $��	0,207,0,0q�6H   $
	 Wrap=�6[   $	��Top=�6o   $	��120��6�   $
 Center=�6�   $��Bahnschrift SemiBold)�6�   $��20(�6�   ���	#66E1E1E1$
 True��6  
���������6�   Z� 6!  �� 5?   
   -   5        $ lblMaximumBytes��5?      $��MaximumBytes��6)   $��Center=�6@   $��	0,245,0,0q�6]   $	��Top=�6p   $��33��6�   $	��120��6�   $$��Bahnschrift SemiBold Condensed)�6�   $��15(�6�   
�������6�   �� 5@   
   -   5        $ txtMaximumBytes��5@      $��Center=�6+   $��	0,268,0,0q�6H   $
	 Wrap=�6[   $	��Top=�6o   $	��120��6�   $
 Center=�6�   $��Bahnschrift SemiBold)�6�   $��20(�6�   ���	#66E1E1E1$
 True��6  
���������6�   Z� 6!  �� 5B   
   -   5        $ lblBootDeviceExtention��5B      $��Device Extention��60   $
��Left=�6K   $��502,182,0,0q�6f   $	��Top=�6{   $��33��6�   $��98��6�   $$��Bahnschrift SemiBold Condensed)�6�   $��15(�6�   
�������6�   �� 5C   
   -   5        $ txtBootDeviceExtention��5C      $
��Left=�62   $��501,207,0,0q�6M   $
	 Wrap=�6b   $	��Top=�6v   $	��120��6�   $
 Center=�6�   $��Bahnschrift SemiBold)�6�   $��20(�6�   ���	#66E1E1E1$
 True��6  
���������6�   Z� 6(  �� 5E   
   -   5        $ lblBootDevicePath��5E      $��Boot Device Path��6+   $
��Left=�6F   $��501,245,0,0q�6a   $	��Top=�6v   $��33��6�   $	��111��6�   $$��Bahnschrift SemiBold Condensed)�6�   $��15(�6�   
�������6�   �� 5F   
   -   5        $ txtBootDevicePath��5F      $
��Left=�6-   $��502,268,0,0q�6H   $
	 Wrap=�6]   $	��Top=�6q   $	��120��6�   $
 Center=�6�   $��Bahnschrift SemiBold)�6�   $��20(�6�   ���	#66E1E1E1$
 True��6
  
���������6�   Z� 6#  �� 5H   
   -   5        $ lblNetworkAdapter��5H      $��Network Adapter��6+   $
��Left=�6E   $��656,184,0,0q�6`   $	��Top=�6u   $��33��6�   $	��111��6�   $$��Bahnschrift SemiBold Condensed)�6�   $��15(�6�   
�������6�   �� 5I   
   -   5        $ txtNetworkAdapter��5I      $
��Left=�6-   $��656,207,0,0q�6H   $
	 Wrap=�6]   $	��Top=�6q   $	��120��6�   $
 Center=�6�   $��Bahnschrift SemiBold)�6�   $��20(�6�   ���	#66E1E1E1$
 True��6
  
���������6�   Z� 6#  �� 5K   
   -   5        $ lblLocationPath��5K      $��Location Path��6)   $
��Left=�6A   $��656,245,0,0q�6\   $	��Top=�6q   $��33��6�   $	��110��6�   $$��Bahnschrift SemiBold Condensed)�6�   $��15(�6�   
�������6�   �� 5L   
   -   5        $ txtLocationPath��5L      $
��Left=�6+   $��656,268,0,0q�6F   $
	 Wrap=�6[   $	��Top=�6o   $	��120��6�   $
 Center=�6�   $��Bahnschrift SemiBold)�6�   $��20(�6�   ���	#66E1E1E1$
 True��6  
���������6�   Z� 6!  �� 5Q   
   -   5        $ lblCreateVM��5Q      $��	Create VM��6%   $
��Left=�69   $��373,314,0,0q�6T   $	��Top=�6i   $��28��6�   $��70��6�   $$��Bahnschrift SemiBold Condensed)�6�   $��15(�6�   
�������6�   �� 5R   
   -   5        $ recCreateVM��5R      $��Center=�6)   $��50��6F   $��	0,342,0,0q�6R   $	��Top=�6e   $	��150��6}   $
 Hand��6�   $ 0.5,0.5&�6�   z�5S      V� 5T      .~�5U      �� �� 5V      �� 5W       �� Angle$ 0Q�6&   T� 5X      5Y      ��5[      �� 5\      $ /Assets/NextEnabled.png��6   5^      5`      5a      