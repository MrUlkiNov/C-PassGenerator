   M S B A M L   `   `   `  ����  PassGenerator'    !GreekPasswordGenerator.MainWindow   5   	   W SPresentationCore, Version=9.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=9.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=9.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=9.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35^ ZWindowsFormsIntegration, Version=9.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35H 9http://schemas.microsoft.com/winfx/2006/xaml/presentation      5   	   R NSystem.Xaml, Version=9.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	     � Title$  Greek Password Generator��5   	   $	��200��6*   $	��400��67   .��5      � $��10q�6    � RowDefinitions 5   
   �� 5      $
��Auto �6   �� 5      $
��Auto �6   �� 5	      $��* �6   .+�5   
   ��  �� Orientation$ 
Horizontal=�6   $��Center=�6.   .+�5      �� $��Password Length:��6   �� 5      -   5         ��Name$ PasswordLengthTextBox��5      $��50��65   $��8��6@   $��10,0,0,0q�6I   5      �� 5   
   -   5        $ PasswordTextBox��5      $��1��6+   $��16(�68    �� 
IsReadOnly$
 True��6F   $��Stretch=�6X   $��0,10,0,0q�6v   �� 5   
   $ 
Horizontal=�6   $��2��6.   $��Center=�6;   $��0,10,0,0q�6X   .+�5      �� -   5        $��Generate Password��5      $��5q�6V   �� 5      -   5        $��Copy to Clipboard��5      $��5q�6J   5      5      5      