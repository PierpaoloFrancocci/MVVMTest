   M S B A M L   `   `   `  ����D  @MVVM_Test, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null9!clr-namespace:MVVM_Test.ViewModelMVVM_Test.ViewModel  5      %    MVVM_Test.View.ConverterControl   5      \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      7	ViewModel!clr-namespace:MVVM_Test.ViewModel     5        J� InputBindings  5      �� 5   
   
 �� Key$ Enter��6    �� Command 6!   �� *ConvertTextCommand+.��5      �� $	��336��6   .+�5   
   �� 
����  �$��5,5,5,0q�6"   .��63   Input6:   �� 5   
   $��5q�6N   ��6   �� *Input+ �� UpdateSourceTrigger$ PropertyChanged=�6N   �� 5   
   
����  �$��5,5,5,0q�6"   .��63   
ListView6=   �� 5   
   $	��100��60   $��5q�6=   ��6   �� *Items+6=   �� 5   
   
����  �$��5,5,5,0q�6"   .��63   	Results6<   �� 5   
   $��5q�6P   ��6   �� *Output+$ PropertyChanged=�6P   �� 5   
    �� Orientation$ 
Horizontal=�6   .+�5      �� $��5q�6S   ��6   �� *Fuzzy+$ PropertyChanged=�6S   �� 5      $��5q�6S   ��6   �� *Buzzy+$ PropertyChanged=�6S   �� 5      $��5q�6W   ��6   �� *	FuzzBuzzy+$ PropertyChanged=�6W   �� 5      $��5q�6V   ��6   �� *
Duration+$ PropertyChanged=�6V   5      �� 5   
   $��5q�61   ��6   �� *TestCommand+.��6<   Test6B   5      5      