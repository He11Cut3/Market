   M S B A M L   `   `   `  ����D  @Market_Pl, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null?$clr-namespace:Market_Pl.Add_Edit_DelMarket_Pl.Add_Edit_Del  5   	   %    Market_Pl.Add_Edit_Del.Sell_Add   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   6local$clr-namespace:Market_Pl.Add_Edit_Del     5   	   X TFontAwesome.Sharp, Version=6.3.0.0, Culture=neutral, PublicKeyToken=d16d1e4e568ec10fFfa=http://schemas.awesome.incremented/wpf/xaml/fontawesome.sharp  5   	     � Title$  Knitwear��5	   	   $	��530��5
   	   $	��780��5   	    � WindowStartupLocation$ CenterScreen=�5   	    � WindowStyle$
 None=�5   	    � AllowsTransparency . 
������ .��5      �  � ColumnDefinitions 5   
   �� 5      $	��370 �6   �� 5      $	��410 �6   �� 5      $��0* �6    � RowDefinitions 5   
   �� 5      $
��auto �6   �� 5      $	��31* �6   �� 5      $��8* �6   .+�5   
   � $��3��6   $��2��5      .+�5       ��  �� CornerRadius$ 10 10 10 10��6   $��2��5!      ��5"      �� 5#       �� 
StartPoint$	 0,0&�6*    �� EndPoint$	 1,1&�5$   *   .��5%      �    primaryBackColor1	 � Color#	 [  6'   
 � Offset$
 1Q�5&   '   5'      5*      5,      �� 50   
   $��0��6   $��1q�51      $��15,15,15,15q�52      $ 15��53      $��2��54      ._�58      ��  �� Orientation$ 
Horizontal=�6   .+�59      �� $��Маркет��6   $��Center=�5:      $��Center=�5;      $��26(�5<      ���#C0C0C05=      �� 5>      -   5         ��Name$ btnClose��5>        controlButton#��[ 5?      $��
600,0,0,10q�5A      .��5B      !  FontAwesome.Sharp.IconImage  �  �FontAwesome.Sharp.IconImageBase`1[[FontAwesome.Sharp.IconChar, FontAwesome.Sharp, Version=6.3.0.0, Culture=neutral, PublicKeyToken=d16d1e4e568ec10f]]   Icon$ Xmark=�6#     controlButtonIcon#��[ 5C   #   5D      5E      5G      �� 5I   
   $��1��6   $��1��5J      $��2��5K      .+�5L      �� -   5         ��Name$ Article��5L      $	��200��5M      $��35��5N      $��45 15 15 15q�5O      $
��Left=�5P      $��
Montserrat)�5Q      $��Medium"�5R      $��16(�5S      
������� �� SelectionBrush
 �  �� �� 
CaretBrush
 �����
�������5W      �� 5X      -   5        $
 Date��5X      $	��200��5Y      $��35��5Z      $��45 15 15 15q�5[      $
��Left=�5\      $��
Montserrat)�5]      $��Medium"�5^      $��16(�5_      
�������
 �  ��
 �����
�������5c      �� 5d      -   5        $
 Unit��5d      $	��200��5e      $��35��5f      $��45 15 15 15q�5g      $
��Left=�5h      $��
Montserrat)�5i      $��Medium"�5j      $��16(�5k      
�������
 �  ��
 �����
�������5o      5p      �� 5q   
   $��1��6   $��0��5r      $��2��5s      .+�5t      �� $��Артикул��6     text_ButtonText#��[ 5u      �� 5v      $��Дата продажи��6   #��[ 5w      �� 5x      $3��-Кол-во проданного товара��6   $
��Wrap=�5y      #��[ 5z      $��42��5{      $��
0,15,15,15q�5|      5}      �� 5~   
   -   5        $	 Dep��5~      $��1��5      $��2��5�      $��Right=�5�      $��35��5�      $��Medium"�5�      $	��110��5�      $��
Montserrat)�5�      $��Добавить��5�      $	��Top=�5�      $��	0,25,35,0q�5�      5�      5�      