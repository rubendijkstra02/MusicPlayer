   M S B A M L   `   `   `  ����F  BMusicPlayer, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null)clr-namespace:MusicPlayerMusicPlayer  5   	       MusicPlayer.Hoofdmenu   5   	   W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35^ ZWindowsFormsIntegration, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   +localclr-namespace:MusicPlayer     5   	     � Title$  	Hoofdmenu��5   	   $��546.077��6   $��764.191��6,    � 
ResizeMode$ NoResize=�5	   	   .��5      � .+�5   
   o� -   5         o�Name$
 menu��5      $��27��6   $	��Top=�6)   ���	#FFC9C9C9.@�5      �� -   5         ��Name$ label1��5      $��	Hoofdmenu��6$   $��78��68   
���������6C   Z� 6Y   �� 5      -   5        $ label1_Copy��5      $��Afspeellijsten��6)   $��82��6B   
���������6M   Z� 6c   �� 5      -   5        $ label1_Copy1��5      $��Afspeellijsten��6*   $��81��6C   
���������6N   Z� 6d   �� 5      -   5        $ label1_Copy2��5      $��Albums��6*   $��53��6;   
���������6F   Z� 6\   �� 5      -   5        $ label5��5      $��Instellingen��6$   
���������6;   Z� 6d   5      &   System.Windows.Controls.DataGrid  5   
   -   5          Name$ dgAlbums��5      $
��Left=�6%   $��	10,59,0,0q�6@   $	��Top=�6S   $	��377��6k   $	��271��6x   ���	#FFD1D1D1���	#FFB9B9B9
�������6�   �� 5   
   -   5         ��Name$ imgFront��5      $��200px��6"   $��200px��61   $��Imgs/alb1.png��6?   $��289,34,269,283q�6V     5   
   -	   5        $ dgTracks��5      $
��Left=�6%   $��
510,85,0,0q�6@   $	��Top=�6T   $	��351��6l   $	��225��6y   ���	#FFD4D4D4���	#FFB9B9B9
�������6�   �� 5   
   -
   5        $ label3��5      $
��Left=�6    $��289,239,0,0q�6;   $	��Top=�6P   $	��200��6h   .��5      �� 
���   �$��1q�6)   $	��187��6=   $	��190��6J   5      �� 5   
   -   5        $ tbTrackTitle��5      $��Nummer: Silence��6&   $
��Left=�6@   $��300,249,0,0q�6[   $	��Top=�6p   $	��178��6�   �� 5   
   -   5        $ tbAlbumName��5      $��Album: SilcenceSongs��6%   $
��Left=�6D   $��300,275,0,0q�6_   $	��Top=�6t   $	��178��6�   �� 5   
   -   5        $ label4��5      $��Nummers van albums��6    $
��Left=�6=   $��
510,59,0,0q�6X   $	��Top=�6l   $	��225��6�   �� 5   
   -   5         ��Name$ tbBio��5   "    �� Padding$	 5pxq�6   $
��Left=�61   $��300,301,0,0q�6L   $
��Wrap=�6a   $	��Top=�6u   $	��126��6�   $	��178��6�   �� 6�   ���	#FF020202$��12.6666666666667(�6�   $��Consolas)�6�   $�Biografie: ��6�   �� 6	  �� 6  ���	#FF020202$��12.6666666666667(�60  $��Consolas)�6L  �� 6d  �� 6p  ���	#FF020202$��12.6666666666667(�6�  $��Consolas)�6�  $���Silence is een van de songs die uitgebracht werden door marshmallo dit nummer is in 2017 uitgbracht onder het mom van muziek is voor iedereen��6�  6U  �� 5   
   -   5         ��Name$ button��5      $
��Play��6!   $
��Left=�60   $��510,441,0,0q�6K   $	��Top=�6`   $	��112��6x   6�   �� 5   
   -   5        $ button_Copy��5      $��Pause��6&   $
��Left=�66   $��627,441,0,0q�6Q   $	��Top=�6f   $	��108��6~   6�   5      5       