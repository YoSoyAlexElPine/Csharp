   M S B A M L   `   `   `  ����A  =Examen, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null)clr-namespace:Examen.ViewExamen.View  5   	       Examen.View.inicio   5   	   W SPresentationCore, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   +localclr-namespace:Examen.View     5   	     � Title$  inicio��5   	   $	��450��6   $	��800��6%   .��5	      � .+�5
   
   �� -   5         ��Name$ 
tabControl��5
       �� TabStripPlacement$
 Left=�6)   .@�5      �� $��Inicio��6   .��5      �� .+�5      � $	��668��6   $	��434��6'   $
��Left=�64   .+�5      �� -   5         ��Name$	 l_a��5       $��A��6-   $
��Left=�69   $��
181,30,0,0q�6T   $	��Top=�6h   $��18(�6�   $
��Bold"�6�   �� 5      -   5        $	 l_b��5       $��B;��6-   $
��Left=�6:   $��
181,81,0,0q�6U   $	��Top=�6i   $��18(�6�   $
��Bold"�6�   �� 5      -   5        $	 l_c��5       $��C��6-   $
��Left=�69   $��181,136,0,0q�6T   $	��Top=�6i   $��18(�6�   $
��Bold"�6�   �� 5      -   5         ��Name$
 tb_a��5   "   $
��Left=�60   $��
371,29,0,0q�6K    �� TextWrapping$
 Wrap=�6_   $	��Top=�6s   $	��189��6�   $��35��6�   $��Right=�6�   $��Center=�6�   6�   �� 5      -   5        $
 tb_b��5   "   $
��Left=�60   $��
371,81,0,0q�6K   $
 Wrap=�6_   $	��Top=�6s   $	��189��6�   $��35��6�   $��Right=�6�   $��Center=�6�   6�   �� 5      -   5        $
 tb_c��5   "   $
��Left=�60   $��371,136,0,0q�6K   $
 Wrap=�6`   $	��Top=�6t   $	��189��6�   $��35��6�   $��Right=�6�   $��Center=�6�   6�   �� 5      -   5         ��Name$ b_save��5   !   $
��Save��61   $
��Left=�6@   $��503,339,0,0q�6[   $	��Top=�6p   $��29��6�   $��57��6�   6�   5      5      5      �� 5      -	   5         ��Name$ tabItem2��5      $
��Nudo��6)   .��5      �� .+�5      � $
��Left=�6   $��0,0,0,-6q�66   $	��671��6H   $	��434��6T    � RowDefinitions 5      �� 5      �� 5       .+�5&      &   System.Windows.Controls.DataGrid  -
   5        	  Name$	 dg_partidos��5&   #   $��19,18,260,73q�68   
   AutoGenerateColumns$
 False��6N      
IsReadOnly$
 True��6j   $��2��6�      Columns 5)      0  *System.Windows.Controls.DataGridTextColumn  5*   "   ,  &System.Windows.Controls.DataGridColumn   Header$ Acronym��6R   1  +System.Windows.Controls.DataGridBoundColumn   Binding 65   �� *
Acronimo+6R     5+   "   $ Party��6P      Width5  /System.Windows.Controls.DataGridLengthConverter$ * 6_    65   �� *Nombre+6_     5,   "   $ 	President��6T   $ * 6g    65   �� *
Presidente+6g   51      �� 54      -   5        $ b_save2��54   !   $
��Save��62   $
��Left=�6A   $��556,169,0,0q�6\   $	��Top=�6q   $��29��6�   $��56��6�   $��1��6�   57      59      5:      5;      5<      5=      