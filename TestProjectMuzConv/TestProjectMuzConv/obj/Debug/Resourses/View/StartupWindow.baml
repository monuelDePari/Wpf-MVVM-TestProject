   M S B A M L   `   `   `  ����M  ITestProjectMuzConv, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null7 clr-namespace:TestProjectMuzConvTestProjectMuzConv  5   	   5    /TestProjectMuzConv.Resourses.View.StartupWindow   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   V RMaterialDesignThemes.Wpf, Version=3.1.0.1244, Culture=neutral, PublicKeyToken=nullFmaterialDesign1http://materialdesigninxaml.net/winfx/xaml/themes  5   	   ,local clr-namespace:TestProjectMuzConv  5   	     � WindowStyle$
  None=�5	   	    � WindowStartupLocation$ CenterScreen=�5
   	    � Title$ StartupWindow��5   	   $	��700��6   $	��450��6,   ��68   Z� .��5      � 
�������$��10q�6   .+�5   
   �� $��50q�6   $��Center=�6"   .+�5      �� $'��!/Resourses/Assets/YoutubeLogo.png��6   $	��232��6?   $
��Left=�6L   $	��302��6g   �� 5      
�������$
��10 0q�6(    �� CornerRadius$ 50��66   �� 5      $��25q�6   .+�5      ��  � DataContext 6   �� *SelectedPerson+.+�5      �� -   5         ��Name$ 	loginText��5      $��15q�6z   )  #MaterialDesignThemes.Wpf.HintAssist   Hint$ Type your nickname here!��6�    *  &MaterialDesignOutlinedTextFieldTextBox#��[  6�   ��61   �� *Login+ �� Mode$ TwoWay=� �� UpdateSourceTrigger$ PropertyChanged=�6�   �� 5      -   5        $ passwordText��5      $��15q�6�   $ Type your password here!��6�   #��[  6�   ��64   �� *
Password+$ TwoWay=�$ PropertyChanged=�6�   �� 5      -   5        $ keyText��5      $��15q�6v   $ Type your key here!��6�   #��[  6�   ��6/   �� *Key+$ TwoWay=�$ PropertyChanged=�6�   5      �� 5      	 �� Orientation$	 
Horizontal=�6   $��Center=�66   $��Center=�6S   $	��104��6n   .+�5      �� -   5        
 ��Name$
 SignUp��5      $��	0 0 20 20q�6-   $��Center=�6a   $��Center=�6�   $��Sign Up��6�   
�������$��30��6�   
���   �$��95��6�   ��6@   �� *SignUpWindow+6�   �� 5      -   5        $
 SignIn��5      $��
20,27,0,47q�6-   $��Center=�6b   $��Center=�6�   $��SIGN IN��6�   
�������$��30��6�   
���   �$��95��6�   ��6A   �� *SignInWindow+6�   5      5      5      �� 5   
   -   5        $
 Cancel��5      $��X��6G   $
��Left=�6S   $��Center=�6n   $��366,10,0,626q�6�   
�������$��30��6�   
���   �$��54��6�   ��6"   �� *CloseLoginWindow+6�   5      5      