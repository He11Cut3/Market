   M S B A M L   `   `   `  ����D  @Market_Pl, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null?$clr-namespace:Market_Pl.Add_Edit_DelMarket_Pl.Add_Edit_Del  5   	   *    $Market_Pl.Add_Edit_Del.Sell_Edit_Del   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   6local$clr-namespace:Market_Pl.Add_Edit_Del     5   	   X TFontAwesome.Sharp, Version=6.3.0.0, Culture=neutral, PublicKeyToken=d16d1e4e568ec10fFfa=http://schemas.awesome.incremented/wpf/xaml/fontawesome.sharp  5   	     � Title$  Knitwear��5	   	   $	��530��5
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
600,0,0,10q�5A      .��5B      !  FontAwesome.Sharp.IconImage  �  �FontAwesome.Sharp.IconImageBase`1[[FontAwesome.Sharp.IconChar, FontAwesome.Sharp, Version=6.3.0.0, Culture=neutral, PublicKeyToken=d16d1e4e568ec10f]]   Icon$ Xmark=�6#     controlButtonIcon#��[ 5C   #   5D      5E      5G      �� 5K   
   $��1��6   $��1��5L      $��2��5M      .+�5N      �� -   5         ��Name$ Article��5N      $	��200��5O      $��35��5P      $��45 15 15 15q�5Q      $
��Left=�5R      $��
Montserrat)�5S      $��Medium"�5T      $��16(�5U      
������� �� SelectionBrush
 �  �� �� 
CaretBrush
 �����
�������5Y      �� 5Z      -   5        $
 Date��5Z      $	��200��5[      $��35��5\      $��45 15 15 15q�5]      $
��Left=�5^      $��
Montserrat)�5_      $��Medium"�5`      $��16(�5a      
�������
 �  ��
 �����
�������5e      �� 5f      -   5        $
 Unit��5f      $	��200��5g      $��35��5h      $��45 15 15 15q�5i      $
��Left=�5j      $��
Montserrat)�5k      $��Medium"�5l      $��16(�5m      
�������
 �  ��
 �����
�������5q      5r      �� 5s   
   $��1��6   $��0��5t      $��2��5u      .+�5v      �� $��Артикул��6     text_ButtonText#��[ 5w      �� 5x      $��Дата продажи��6   #��[ 5y      �� 5z      $3��-Кол-во проданного товара��6   $
��Wrap=�5{      #��[ 5|      $��42��5}      $��
0,15,15,15q�5~      5      � 5�   
    � Orientation$ 
Horizontal=�6   $��2��5�      $��2��5�      .+�5�      �� -   5        $ Product_Edit��5�      $��0��5�      $��2��5�      $
��Left=�5�      $��40��5�      $��Medium"�5�      $	��165��5�      $��
Montserrat)�5�      $��Изменить��5�      $	��Top=�5�      $��
340,20,0,0q�5�      �� 5�      -   5        $ Product_Del��5�      $��Удалить��5�      $��Right=�5�      $��40��5�      $��Medium"�5�      $	��165��5�      $��
Montserrat)�5�      $��	10,20,0,0q�5�      5�      5�      5�      