   M S B A M L   `   `   `  ����C  ?vRidance, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null#clr-namespace:vRidancevRidance  5   	       vRidance.ProxMoxLogin   5   	   W SPresentationCore, Version=6.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=6.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=6.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=6.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35^ ZWindowsFormsIntegration, Version=6.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35H 9http://schemas.microsoft.com/winfx/2006/xaml/presentation      5   	   R NSystem.Xaml, Version=6.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   (localclr-namespace:vRidance     5   	   -   5          �Name$  
wdwPMLogin��5   	    � Title$ vRidance��5   	   $	��450��6   $	��800��6'    � 
ResizeMode$ NoResize=�63    � WindowStyle$
 None=�6I    � Icon$ /Assets/vRidance.ico��6\   .��5	      � -   5         �Name$ grdMain4��5	      ��5
   
   �� 5       �� ImageSource$ /Assets/bg_dark.png��6   .+�5   
   �� -   5         ��Name$ rctTop��5      $��Center=�6$   $��44��6A   $	��Top=�6M   $	��800��6e   ���	#7F0000006�   �� 5   
   -   5        $ 	rectClose��5      $
��Left=�6'   $��21��6B   $��
766,10,0,0q�6N   $	��Top=�6b   $��21��6z    � Cursor$
 Hand��6�   $
|�True��6�   ��5      �� 5      $ 
/close.png��6   5      �� 5   
   -   5        $ rectDark��5      $
��Left=�6&   $��21��6A   $��
738,10,0,0q�6M   $	��Top=�6a   $��22��6y   $
 Hand��6�   $
|�True��6�   ��5      �� 5      $ 	/moon.png��6   5      �� 5   
   -   5        $ rectMode��5      $
��Left=�6&   $��20��6A   $��
739,11,0,0q�6M   $	��Top=�6a   $��20��6y   $
 Hand��6�   $
|�True��6�   ��5      �� 5      $ /Assets/sun.png��6   5      �� 5   
   -   5        	 ��Name$	 lblvRidance��5      $��vRidance v1.0��6%   $
��Left=�6=   $��10,9,0,0q�6X   $	��Top=�6j   $��Cascadia Mono SemiBold)�6�   
�������6�   �� 5   
   -   5        $	 
lblPMLogin��5      $��Proxmox Login Information��6$   $��Center=�6H   $��0,94,0,0q�6e   $	��Top=�6w   $��44��6�   $	��350��6�   
�������$��Bahnschrift SemiBold)�6�   $��25(�6�   $��Center=�6�   �� 5   
   $��374,49,374,349q�6   $��/Assets/proxmox.png��6(   $
��Fill=�6E   �� 5    
   -	   5        $ rectNext��5       $��Center=�6&   $��50��6C   $��	0,342,0,0q�6O   $	��Top=�6b   $	��150��6z   $
 Hand��6�   
 J� RenderTransformOrigin$
 0.5,0.5&�6�   z�5!      V� 5"      .~�5#      �� �� 5$      �� 5%       �� Angle$ 0Q�6&   T� 5&      5'      ��5)      �� 5*      $ /Assets/NextEnabled.png��6   5,      �� 5-   
   -
   5         ��Name$ txtUsername��5-      $
��Left=�6'   $��266,225,0,0q�6B    �� TextWrapping$
 Wrap=�6W   $
��root��6k   $	��Top=�6w   $	��120��6�    �� TextAlignment$
 Left=�6�   $��Bahnschrift SemiBold)�6�   $��20(�6�   ���	#66E1E1E1 �� AutoWordSelection$
 True��6  
���������6�   Z� 6'  �� 5.   
   -   5        $	 lblUsername��5.      $��Username��6%   $
��Left=�68   $��266,202,0,0q�6S   $	��Top=�6h   $��33��6�   $	��120��6�   $$��Bahnschrift SemiBold Condensed)�6�   $��15(�6�   
�������6�   �� 5/   
   -   5        $	 lblPassword��5/      $��Password��6%   $
��Left=�68   $��414,202,0,0q�6S   $	��Top=�6h   $��33��6�   $	��120��6�   $$��Bahnschrift SemiBold Condensed)�6�   $��15(�6�   
�������$��Right=�6�   G� 50   
   -   5         G�Name$ pwbPassword��50      $
��Left=�6+   $��414,225,0,0q�6F   $	��Top=�6[   $	��120��6s   $��Bahnschrift SemiBold)�6   $��20(�6�   
����������	#66E1E1E1��6�   Z� �� 51   
   -   5        $	 lblvmId��51      $��Provide first VM ID��6!   $��Center=�6?   $��	0,268,0,0q�6\   $	��Top=�6o   $��28��6�   $	��350��6�   
�������$��Bahnschrift SemiBold)�6�   $��18(�6�   $��Center=�6�   �� 52   
   -   5        $ txtVMID��52      $��Center=�6#   $��	0,301,0,0q�6@   $
 Wrap=�6S   $	��Top=�6g   $	��120��6   $ Center=�6�   $��Bahnschrift SemiBold)�6�   $��20(�6�   ���	#66E1E1E1$
 True��6   
���������6�   Z� 6  �� 53   
   -   5        $ txtIP��53      $��Center=�6!   $��	0,175,0,0q�6>   $
 Wrap=�6Q   $	��Top=�6e   $	��120��6}   $
 Left=�6�   $��Bahnschrift SemiBold)�6�   $��20(�6�   ���	#66E1E1E1$
 True��6�   
���������6�   Z� 6  �� 54   
   -   5        $	 lblIP��54      $��Proxmox VE IP��6   $��Center=�67   $��	0,152,0,0q�6T   $	��Top=�6g   $��33��6   $	��120��6�   $$��Bahnschrift SemiBold Condensed)�6�   $��15(�6�   
�������$��Center=�6�   55      56      