   M S B A M L   `   `   `  ����H  DSiCuAstaPasta, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null9!clr-namespace:SiCuAstaPasta.ViewsSiCuAstaPasta.Views  5   :  C&clr-namespace:SiCuAstaPasta.ViewModelsSiCuAstaPasta.ViewModels  6j  *    $SiCuAstaPasta.Views.InregistrareView   6   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    6=   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     6   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     6�   @d2http://schemas.microsoft.com/expression/blend/2008     6�   3local!clr-namespace:SiCuAstaPasta.Views     6:  =
viewModels&clr-namespace:SiCuAstaPasta.ViewModels     6j    � DataContext  5      =  7SiCuAstaPasta.ViewModels.InregistrareConectareViewModel  5   
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
 ���� 63   �� 5%       � ��$ Microsoft YaHei UI)�63   �� 5&       � ��$ 14(�61   �� 5'       � �� �	#FF44444463   5(      5*      5+      .��5-      �� $��190 80q�6   .+�5.   
   �� $
��0 30q�6   .+�5/      �� $0��*/SiCuAstaPasta;component/External/user.png��6   $y�Visible=�6H   $��68��6]   50      �� 51   
   #��[ 6   .��6:   Nume6@   �� 52   
   ��6   �� *InregistrareUtilizator.nume+6A   �� 53   
   #��[ 6   .��6:   	Prenume6C   �� 54   
   ��6   �� * InregistrareUtilizator.prenume+6D   �� 55   
   #��[ 6   .��6:   	Telefon6C   �� 56   
   -   5        ��56      �� * InregistrareUtilizator.telefon+6o   �� 57   
   #��[ 6   .��6:   Email6A   �� 58   
   ��6   �� *InregistrareUtilizator.email+6B   �� 59   
   #��[ 6   .��6:   Adresa de livrare6M   �� 5:   
   ��6   �� *InregistrareUtilizator.adresa+6C   �� 5;   
   #��[ 6   .��6:   Parola6B   �� 5<   
   ��6   �� *InregistrareUtilizator.parola+6C   �� 5>   
   $
��0 40q�6   .+�5?      �� #��[  6   ��6@   �� *InregistrareUtilizatorCommand+.��6r   Creeaza utilizator6�   �� 5@      -   5        #��[  5@      .��6T   Inapoi6\   5A      5B      5C      