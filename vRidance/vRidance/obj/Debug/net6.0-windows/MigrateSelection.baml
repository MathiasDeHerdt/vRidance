   M S B A M L   `   `   `  ����C  ?vRidance, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null#clr-namespace:vRidancevRidance  5   	       vRidance.MigrateSelection   5   	   W SPresentationCore, Version=6.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=6.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=6.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=6.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35^ ZWindowsFormsIntegration, Version=6.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35H 9http://schemas.microsoft.com/winfx/2006/xaml/presentation      5   	   R NSystem.Xaml, Version=6.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   (localclr-namespace:vRidance     5   	   -   5          �Name$  wdwMain2��5   	    � Title$ vRidance��5   	   $	��450��6   $	��800��6'    � WindowStyle$
 None=�63    � Icon$ /Assets/vRidance.ico��6F   .��5	      � -   5         �Name$ grdMain2��5	      ���	#FF2B2B2B.+�5
   
   �� $
��Left=�6   $	��230��6/   $��
146,68,0,0q�6<   $	��Top=�6P   $	��500��6h    J� IsManipulationEnabled$
 True��6t   ���	#7F0000006�   �� 5   
   -   5         ��Name$ chckProxmox��5      $�� ��6(   $
��Left=�63   $��224,121,0,0q�6N   $	��Top=�6c   $��16��6{   $��18��6�    J� RenderTransformOrigin$ 0.5,0.5&�6�   ���	#FF8E8E8E
���������6�   Z� z�5      V� 5      .~�5      ��  �� ScaleX$ 2Q�6%   	 �� ScaleY$	 2Q�60   �� 5      �� 5      T� 5      5      5      �� 5   
   -   5        $ 
chckCitrix��5      $�� ��6'   $
��Left=�62   $��224,177,0,0q�6M   $	��Top=�6b   $��16��6z   $��18��6�   $ 0.5,0.5&�6�   ���	#FF8E8E8E
���������6�   Z� z�5      V� 5      .~�5      �� $ 2Q�6%   $	 2Q�60   �� 5      �� 5      T� 5      5      5      �� 5   
   -   5        $ chckAzureStack��5      $�� ��6+   $
��Left=�66   $��224,233,0,0q�6Q   $	��Top=�6f   $��16��6~   $��18��6�   $ 0.5,0.5&�6�   ���	#FF8E8E8E
���������6�   Z� z�5       V� 5!      .~�5"      �� $ 2Q�6%   $	 2Q�60   �� 5#      �� 5$      T� 5%      5&      5(      �� 5)   
   -   5        
 ��Name$
 
lblProxmox��5)      $'��!Convert from vSphere to Proxmox

��6$   $
��Left=�6X   $��269,113,0,0q�6s   $	��Top=�6�   $��58��6�   $	��355��6�   
���������6�   Z� �� 5*   
   -   5        $
 	lblCitrix��5*      $$��Convert from vSphere to Citrix��6#   $
��Left=�6L   $��269,170,0,0q�6g   $	��Top=�6|   $��59��6�   $	��355��6�   
�������6�   �� 5+   
   -   5        $
 lblAzureStack��5+      $-��'Convert from vSphere to Azure Stack HCI��6'   $
��Left=�6Y   $��269,225,0,0q�6t   $	��Top=�6�   $��59��6�   $	��355��6�   
�������6�   �� 5,   
   -	   5         ��Name$ rctTop��5,      $��Center=�6$   $��44��6A   $	��Top=�6M   $	��800��6e   ���	#7F0000006�   �� 5-   
   -
   5        $
 lblvRidance��5-      $��vRidance v1.0��6%   $
��Left=�6=   $��10,9,0,0q�6X   $	��Top=�6j   $��Cascadia Mono SemiBold)�6�   
�������6�   �� 5.   
   -   5        $ 
rectClose2��5.      $
��Left=�6(   $��21��6C   $��
769,10,0,0q�6O   $	��Top=�6c   $��21��6{   ��5/      �� 50       �� ImageSource$ 
/close.png��6   52      �� 53   
   -   5        $ rectDark��53      $
��Left=�6&   $��21��6A   $��
738,10,0,0q�6M   $	��Top=�6a   $��22��6y    � Cursor$
 Hand��6�   $
|�True��6�   ��54      �� 55      $ 	/moon.png��6   57      �� 58   
   -   5        $ rectMode��58      $
��Left=�6&   $��20��6A   $��
739,11,0,0q�6M   $	��Top=�6a   $��20��6y   $
 Hand��6�   $
|�True��6�   ��59      �� 5:      $ /Assets/sun.png��6   5<      �� 5=   
   -   5        $ rectNextDis2��5=      $
��Left=�6*   $��50��6E   $��323,349,0,0q�6Q   $	��Top=�6f   $	��150��6~   ��5>      �� 5?      $ /NextDisabled.png��6   5A      �� 5B   
   -   5        $ 	rectNext2��5B      $
��Left=�6'   $��50��6B   $��323,349,0,0q�6N   $	��Top=�6c   $	��150��6{   $
 Hand��6�   ��5C      �� 5D      $ /NextEnabled.png��6   5F      5H      5I      