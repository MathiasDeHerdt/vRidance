   M S B A M L   `   `   `  ���� C  ?vRidance, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null#clr-namespace:vRidancevRidance      vRidance.MigrateSelection   W SPresentationCore, Version=6.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=6.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=6.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=6.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35^ ZWindowsFormsIntegration, Version=6.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35H 9http://schemas.microsoft.com/winfx/2006/xaml/presentation      R NSystem.Xaml, Version=6.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     @d2http://schemas.microsoft.com/expression/blend/2008     Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     (localclr-namespace:vRidance     -     �Name$  wdwMain2�� � Title$ vRidance��$	��450��$	��800�� � WindowStyle$
 None=� � Icon$ /Assets/vRidance.ico��.��� -    �Name$ grdMain2�����	#FF2B2B2B.+��� $
��Left=�$	��230��$��
146,68,0,0q�$	��Top=�$	��500�� J� IsManipulationEnabled$
 True�����	#7F000000�� -    ��Name$ chckProxmox��$�� ��$
��Left=�$��224,121,0,0q�$	��Top=�$��16��$��18�� J� RenderTransformOrigin$ 0.5,0.5&����	#FF8E8E8E
���������Z� z�V� .~���  �� ScaleX$ 2Q�	 �� ScaleY$	 2Q��� �� T� �� -   $ 
chckCitrix��$�� ��$
��Left=�$��224,177,0,0q�$	��Top=�$��16��$��18��$ 0.5,0.5&����	#FF8E8E8E
���������Z� z�V� .~��� $ 2Q�$	 2Q��� �� T� �� -   $ chckAzureStack��$�� ��$
��Left=�$��224,233,0,0q�$	��Top=�$��16��$��18��$ 0.5,0.5&����	#FF8E8E8E
���������Z� z�V� .~��� $ 2Q�$	 2Q��� �� T� �� -   
 ��Name$
 
lblProxmox��$'��!Convert from vSphere to Proxmox

��$
��Left=�$��269,113,0,0q�$	��Top=�$��58��$	��355��
���������Z� �� -   $
 	lblCitrix��$$��Convert from vSphere to Citrix��$
��Left=�$��269,170,0,0q�$	��Top=�$��59��$	��355��
��������� -   $
 lblAzureStack��$-��'Convert from vSphere to Azure Stack HCI��$
��Left=�$��269,225,0,0q�$	��Top=�$��59��$	��355��
��������� -	    ��Name$ rctTop��$��Center=�$��44��$	��Top=�$	��800�����	#7F000000�� -
   $
 lblvRidance��$��vRidance v1.0��$
��Left=�$��10,9,0,0q�$	��Top=�$��Cascadia Mono SemiBold)�
��������� -   $ 
rectClose2��$
��Left=�$��21��$��
769,10,0,0q�$	��Top=�$��21������  �� ImageSource$ 
/close.png���� -   $ rectDark��$
��Left=�$��21��$��
738,10,0,0q�$	��Top=�$��22�� � Cursor$
 Hand��$
|�True������ $ 	/moon.png���� -   $ rectMode��$
��Left=�$��20��$��
739,11,0,0q�$	��Top=�$��20��$
 Hand��$
|�True������ $ /Assets/sun.png���� -   $ rectNextDis2��$
��Left=�$��50��$��323,349,0,0q�$	��Top=�$	��150������ $ /NextDisabled.png���� -   $ 	rectNext2��$
��Left=�$��50��$��323,349,0,0q�$	��Top=�$	��150��$
 Hand������ $ /NextEnabled.png��