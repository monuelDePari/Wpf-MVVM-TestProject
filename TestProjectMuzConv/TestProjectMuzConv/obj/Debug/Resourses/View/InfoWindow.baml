   M S B A M L   `   `   `  ����M  ITestProjectMuzConv, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullU/clr-namespace:TestProjectMuzConv.Resourses.View!TestProjectMuzConv.Resourses.View  5   	   2    ,TestProjectMuzConv.Resourses.View.InfoWindow   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   Alocal/clr-namespace:TestProjectMuzConv.Resourses.View     5   	   V RMaterialDesignThemes.Wpf, Version=3.1.0.1244, Culture=neutral, PublicKeyToken=nullFmaterialDesign1http://materialdesigninxaml.net/winfx/xaml/themes  5   	     � WindowStyle$
  None=�5	   	    � WindowStartupLocation$ CenterScreen=�5
   	    � Title$ 
InfoWindow��5   	   $	��600��6   $	��800��6)   ��65   Z� .��5      � 
�������$��10q�6    � ColumnDefinitions 5   
   �� 5      $��* �6   �� 5      $��* �6    � RowDefinitions 5   
   �� 5      �� 5      �� 5      .+�5   
   �� $��2��6   $��Center=�6)   $��0 0 0 20q�6F   .+�5      �� $'��!/Resourses/Assets/YoutubeLogo.png��6   $	��232��6?   $
��Left=�6L   $	��302��6g   5      �� 5   
   $��0��6   $��1��6"   ��6/   �� *YoutubePersonInfos+ �� SelectedItem 5      �� *
PersonInfo+��5      �� 5      .R�5      �� $��5q�6!   .+�5      �� $��18(�6$   ��62   ��  �� Path$ YoutubePlaylistsId�5      5       5"      �� 5$   
   $��1��6   $��1��6%   $��2��62    � DataContext 6C   �� *
PersonInfo+.+�5%      �� $��Selected Playlist��6   $��16(�61   $��DemiBold"�6?   �� 5&      $��ID��6   $��16(�6"   �� 5'      ��6   �� *YoutubePlaylistsId+ �� UpdateSourceTrigger$ PropertyChanged=��� 5(      $��Title��6   $��16(�6%   �� 5)      ��6   �� *Title+$ PropertyChanged=��� 5*      $��ChannelTitle��6   $��16(�6,   �� 5+      ��6   �� *ChannelTitle+$ PropertyChanged=��� 5,      $��PublishedAt��6   $��16(�6+   �� 5-      ��6   �� *PublishedAt+$ PropertyChanged=��� 5.      $��Description��6   $��16(�6+   �� 5/      ��6   �� *Description+$ PropertyChanged=�50      �� 51   
   -   5        	 ��Name$	 Cancel��51   .   $��1��6   $��0��6!   $��X��6c   $
��Left=�6o   $��Center=�6�   
�������
���   �$��54��6�   $��30��6�   $��322,10,0,130q�6�   ��6>   �� *CloseLoginWindow+6�   52      53      