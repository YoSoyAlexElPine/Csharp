   M S B A M L   `   `   `  ����B  >WpfApp2, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null!clr-namespace:WpfApp2WpfApp2  5   	       WpfApp2.MainWindow   5   	   W SPresentationCore, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   'localclr-namespace:WpfApp2     5   	     � Title$  
MainWindow��5   	   $	��450��6   $	��800��6)   .��5	      � .+�5   
   � -   5         �Name$ Agregar��5      .+�5      �� $��Añadir tarea��6   $
��Left=�6+   $��	26,22,0,0q�6F   $	��Top=�6Y   $��30��6q   $	��137��6}   $
��Bold"�6�   �� 5      -   5        $��TB_Tarea��5      $
��Left=�6&   $��	26,57,0,0q�6A    �� TextWrapping$
 Wrap=�6T   $	��Top=�6h   $	��137��6�   $��26��6�   �� 5      -   5        $��Agregar��5      $
��Left=�6'   $��
26,101,0,0q�6B   $	��Top=�6V   $��21��6n   $��56��6z   6�   5      � 5   
   -   5        $ ListaTareas��5      .+�5      �� 
���   �$��1q�6)   $
��Left=�6=   $	��144��6X   $��	10,10,0,0q�6e   $	��Top=�6x   $	��190��6�   &   System.Windows.Controls.DataGrid  5      -   5          Name$ DataGrid��5      $��376,10,10,42q�6*      SelectionUnit$
 Cell=�6A      Columns 5      4  .System.Windows.Controls.DataGridTemplateColumn  5      ,  &System.Windows.Controls.DataGridColumn   Header$ 	Realizada��6-      CellTemplate 5      �� 5      .R�5   "   �� $
{�True��6G   $��Center=�6X   $��Center=�6u    d� 	IsChecked 6+   �� *hecha+6u   5      5      0  *System.Windows.Controls.DataGridTextColumn  5      $ Tarea��6)   	   Width5  /System.Windows.Controls.DataGridLengthConverter$	 * 6S   1  +System.Windows.Controls.DataGridBoundColumn
   Binding
 68   �� *nombre+6S   5      5       5"      5#      