   M S B A M L   `   `   `  ����H  DSiCuAstaPasta, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null9!clr-namespace:SiCuAstaPasta.ViewsSiCuAstaPasta.Views  5   7  C&clr-namespace:SiCuAstaPasta.ViewModelsSiCuAstaPasta.ViewModels  6g  '    !SiCuAstaPasta.Views.ConectareView   6   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    6:   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     6|   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     6�   @d2http://schemas.microsoft.com/expression/blend/2008     6�   3local!clr-namespace:SiCuAstaPasta.Views     67  =
viewModels&clr-namespace:SiCuAstaPasta.ViewModels     6g    � DataContext  5      =  7SiCuAstaPasta.ViewModels.InregistrareConectareViewModel  5   
   -   5        	ViewModel��5   4    � 	Resources 5         ButtonTemplate �� 
TargetType �� Triggers P� Property P� Value �� Property �� Value  LabelTamplate��%  &	        &	 �    �� 5   
   " ��61   .R�5	      �� #��z��6   
������ $��0q�6Y   ._�5
      �� $��Center=�6#   $��Center=�6@   5       5      P� 5       � {� . . �5      ��  � ��
 ���� 63   �� 5       � ��$ Microsoft YaHei UI)�63   �� 5       � ��$ 27(�61   �� 5       � �� �	#FF44444463   �� 5       � ��$ 50��6/   5      P� 5       �@J�IsMouseOver . . �5      ��  � �� �	#FF44444463   �� 5       � ��
 �����63   �� 5       �@�Cursor$
 Hand��6/   �� 5       � ��$ 18(�61   �� 5       � ��$ 50��6/   5      5      �� 5   
   " ��60   .R�5      �� #��z��6   
������ $��0q�6Y   ._�5       �� $��Center=�6#   $��Center=�6@   5!       5"      P� 5#       � {� . . �5$      ��  � ��
 ���� 63   �� 5%       � ��$ Microsoft YaHei UI)�63   �� 5&       � ��$ 14(�61   �� 5'       � �� �	#FF44444463   5(      5*      5+      .��5-      � $��0q�6    � ColumnDefinitions 5.   
   �� 5/      50      �� 51      52      .+�54   
   �� $��30,30,30,350q�6   $��1��6+   $��0��6;   .+�55      �� $��Palatino Linotype)�6   $
��0,10q�67   $��70(�6E   $��Center=�6S   ���	#FF444444$	��322��6�   
Restaurant�� 56      PASTA�� 57      	Near ME�� 58      59      5:      �� 5;   
   $��1��6   $��30,350,30,30q�6%   .+�5<      �� #��[ 6   .��6>   Email6E   �� 5=      -   5        	 ��Name$	 Email��5=      6'   �� 5>      #��[ 6   .��6>   Parola6F   G� 5?      -   5        
 G�Name$
 Parola��5?      6,   �� 5@      $��0, 25q�6   .+�5A      �� -   5        #��[  5A   0   .��6[   	Conectare6f   �� 5B      -   5        #��[  5B   4   .��6_   Inregistrare6m   �� 5C      -   5        #��[  5C   1   $��Continua fara cont��6\   5D      5E      �� 5F   
   $��0��6   $��0��6"   .+�5G      �� $1��+/SiCuAstaPasta;component/External/logo2.png��6   $y�Visible=�6I   $	��699��6^   $��UniformToFill=�6k   5H      5I      5J      