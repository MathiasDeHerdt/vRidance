   M S B A M L   `   `   `  ����C  ?vRidance, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null#clr-namespace:vRidancevRidance  5   	       vRidance.EndScreen   5   	   W SPresentationCore, Version=6.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=6.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=6.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=6.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35^ ZWindowsFormsIntegration, Version=6.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35H 9http://schemas.microsoft.com/winfx/2006/xaml/presentation      5   	   R NSystem.Xaml, Version=6.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   (localclr-namespace:vRidance     5   	   -   5          �Name$  wdwEndScreen��5   	    � Title$ 	EndScreen��5   	   $	��450��6   $	��800��6(    � WindowStyle$
 None=�64    � Icon$ /Assets/vRidance.ico��6G   .��5	      � -   5         �Name$ grdMain��5	      $	��800��6   $	��450��6(   ��5
      �� 5       �� ImageSource$ /bg_dark.png��6   .+�5      �� -   5         ��Name$ rctTop��5      $��Center=�6(   $��44��6E   $	��Top=�6Q   $	��800��6i   ���	#7F0000006�   �� 5      -   5        $ 	rectClose��5      $
��Left=�6+   $��21��6F   $��
766,10,0,0q�6R   $	��Top=�6f   $��21��6~    � Cursor$
 Hand��6�   $
|�True��6�   ��5      �� 5      $ 
/close.png��6!   5      �� 5      -   5        $ rectDark��5      $
��Left=�6*   $��21��6E   $��
738,10,0,0q�6Q   $	��Top=�6e   $��22��6}   $
 Hand��6�   $
|�True��6�   ��5      �� 5      $ 	/moon.png��6!   5      �� 5      -   5        $ rectMode��5      $
��Left=�6*   $��20��6E   $��
739,10,0,0q�6Q   $	��Top=�6e   $��20��6}   $
 Hand��6�   $
|�True��6�   ��5      �� 5      $ /Assets/sun.png��6!   5      �� 5      -   5         ��Name$ lblvRidance��5      $��vRidance v1.0��6)   $
��Left=�6A   $��10,9,0,0q�6\   $	��Top=�6n   $��Cascadia Mono SemiBold)�6�   
�������6�   �� 5      -   5        $ lblTitle��5      $��Migration Complete!��6&   $��Center=�6D   $��0,63,0,0q�6a   $	��Top=�6s   $��70��6�   $	��402��6�   
�������$$��Bahnschrift SemiBold Condensed)�6�   $��50(�6�   $��Center=�6�   $��Center=�6  �� 5      -	   5        $ lblExplanation��5      $���zYour VM's have been migrated successfully!
You can now close this window.

Happy virtualizing!

~ vRidance Developers��6,   $��Center=�6�   $��Center=�6�   $	��140��6  $	��606��6  
�������$��Bahnschrift SemiBold)�6=  $��17(�6_  $
��Left=�6m  $��Center=�6�  �� 5       $
��Left=�6   $	��100��63   $��636,340,0,0q�6@   $	��Top=�6U   $	��164��6m   ��5!      �� 5"      $ /mctlogo.png��6!   5$      5&      5'      