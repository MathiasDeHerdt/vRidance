   M S B A M L   `   `   `  ����C  ?vRidance, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null#clr-namespace:vRidancevRidance  5   	       vRidance.MainWindow   5   	   W SPresentationCore, Version=6.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=6.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=6.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=6.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35^ ZWindowsFormsIntegration, Version=6.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35H 9http://schemas.microsoft.com/winfx/2006/xaml/presentation      5   	   R NSystem.Xaml, Version=6.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   (localclr-namespace:vRidance     5   	   -   5          �Name$  wdwVRidance��5   	    � Title$ vRidance��5   	   $	��450��6   $	��800��6'   ���	#FF252526
�������$y�Visible=�6^   ���	#FF252526 J� Opacity$
 0.99Q�6�    � WindowStyle$
 None=�6�    � 
ResizeMode$ NoResize=�6�    J� Effect 5	      3  -System.Windows.Media.Effects.DropShadowEffect  5
   
   .��5      � -   5         �Name$ grdMain��5      $	��800��6   $	��450��6(   ��5   
   �� 5       �� ImageSource$ /bg_dark.png��6   .+�5   
   �� -   5         ��Name$ rctTop��5      $��Center=�6$   $��44��6A   $	��Top=�6M   $	��800��6e   ���	#7F0000006�   �� 5   
   -   5        $ 	rectClose��5      $
��Left=�6'   $��21��6B   $��
766,10,0,0q�6N   $	��Top=�6b   $��21��6z   	 � Cursor$
	 Hand��6�   $
|�True��6�   ��5      �� 5      $ 
/close.png��6   5      �� 5   
   -   5        $ rectDark��5      $
��Left=�6&   $��21��6A   $��
738,10,0,0q�6M   $	��Top=�6a   $��22��6y   $
	 Hand��6�   $
|�True��6�   ��5      �� 5      $ 	/moon.png��6   5      �� 5   
   -   5        $ rectMode��5      $
��Left=�6&   $��20��6A   $��
739,10,0,0q�6M   $	��Top=�6a   $��20��6y   $
	 Hand��6�   $
|�True��6�   ��5      �� 5      $ /Assets/sun.png��6   5      �� 5    
   -   5        $ rectNext��5       $��Center=�6&   $��50��6C   $��	0,331,0,0q�6O   $	��Top=�6b   $	��150��6z   $
	 Hand��6�   ��5!      �� 5"      $ /NextEnabled.png��6   5$      �� 5%   
   -   5        
 ��Name$
 lblvRidance��5%      $��vRidance v1.0��6%   $
��Left=�6=   $��10,9,0,0q�6X   $	��Top=�6j   $��Cascadia Mono SemiBold)�6�   
�������6�   �� 5&   
   -	   5        $
 lblTitle��5&      $��Welcome to vRidance!��6"   $��Center=�6A   $��0,63,0,0q�6^   $	��Top=�6p   $��70��6�   $	��402��6�   
�������$$��Bahnschrift SemiBold Condensed)�6�   $��50(�6�   �� 5'   
   -
   5        $
 lblExplanation��5'      $����vRidance is a tool ,created by HOWEST students, that ensures an easy and 
straightforward process of Virtual Machine migrations to multiple platforms.
Supported platforms for vRidance are:
  1. Proxmox
  2. Citrix
  3. Azure Stack HCI��6(   $��Center=�6J  $��Center=�6g  $	��140��6�  $	��606��6�  
�������$��Bahnschrift SemiBold)�6�  $��17(�6�  $
��Left=�6�  $��Center=�6   �� 5(   
   $
��Left=�6   $	��100��6/   $��636,340,0,0q�6<   $	��Top=�6Q   $	��164��6i   ��5)      �� 5*      $ /mctlogo.png��6   5,      5.      5/      