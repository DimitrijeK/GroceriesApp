   M S B A M L   `   `   `  ����B  >Nabavka, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null!clr-namespace:NabavkaNabavka  5   	       Nabavka.Window1   5   	   W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35^ ZWindowsFormsIntegration, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   'localclr-namespace:Nabavka     5   	   -   5          �Name$  	startPage��5   	    � Title$ Welcome��5	   	   $	��450��5
   	   $	��800��5   	    � WindowStartupLocation$ CenterScreen=�5   	   .��5      �  � ColumnDefinitions 5   
   �� 5      $
��574* �6   �� 5      $
��219* �6   .+�5   
   �� $��Groceries App��6   $��30(�5      $��Italic$�5      
���   �$��Right=�5      $
��Left=�5      $	��Top=�5      $��Center=�5       J� RenderTransformOrigin$ 0.526,0.577&�5      $	��595��5      $��70��5      $��	0,0,127,0q�5      $��2��5      �� 5    
   $
��Left=�6   $��65��5!      $	��Top=�5"      $��60��5#      $��/Images/groceries.png��5$      $��10,0,0,0q�5%      � 5(   
   ���	#FFCFB695$
��Left=�5)      $	��350��5*      $��0,70,0,0q�5+      $	��Top=�5,      $	��792��5-      $ 	0.455,0.5&�5.      $��2��5/      .+�51      �� $:��4With this app, you will never forget your groceries.��6   $
��Bold"�52      $��20(�53      
��� � �$	��Top=�55      $��155,23,147,0q�56      �� 57      $
��Left=�6   $	��185��58      $��
280,95,0,0q�59      $	��Top=�5:      $	��240��5;      .+�5<      �� $��Log In��6   
���   �$��15(�5>      $��Center=�5?      $
��Bold"�5@      �� 5A      
���   �6   �� 5B      $��30��6    �� TextWrapping$
 Wrap=�5C      $	��Top=�5D      $	��160��5E      $��40,20,40,10q�5F      G� 5G      $��30��6   $	��Top=�5H      $	��160��5I      $��40,0, 40, 20q�5J      �� 5K      -   5         ��Name$ logIn��5L      $��Log In��5K      
�������
��� � �$��15(�5O      $	��160��5P      $��37��5Q      $
��40,0q�5R      5S      �� 5T      $��GroupBox��6   $	��100��5U      5V      5W      9� 5X   
   $��1��6   $��Language��5Y      $
��Left=�5Z      $��70��5[      $��97,0,0,0q�5\      $	��Top=�5]      $	��112��5^      .��5`      �� .+�5a      �� -   5        $ 
englishBtn��5a   +   $��English��6   
������ 5b      �� 5c      -   5        $ 
serbianBtn��5c   +   $��Serbian��6   
������ 5d      5f      5g      5i      5j      