   M S B A M L   `   `   `  ����D  @Market_Pl, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null%clr-namespace:Market_Pl	Market_Pl  5   	       Market_Pl.MainWin   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   )localclr-namespace:Market_Pl     5   	   X TFontAwesome.Sharp, Version=6.3.0.0, Culture=neutral, PublicKeyToken=d16d1e4e568ec10fFfa=http://schemas.awesome.incremented/wpf/xaml/fontawesome.sharp  5   	     � Title$  Knitwear��5	   	   $	��730��5
   	   $
��1280��5   	    � WindowStartupLocation$ CenterScreen=�5   	    � WindowStyle$
 None=�5   	    � AllowsTransparency . 
������ .��5      �  � ColumnDefinitions 5   
   �� 5      $
��auto �6   $	��271��5      �� 5       � RowDefinitions 5   
   �� 5      $��57 �6   �� 5      .+�5   
   � $��2��6   $��2��5      .+�5      �� $��2��5       ��5!      �� 5"         primaryBackColor1 �� Color# [  6&   5$      5&      � 5*   
   -   5        $��2��5*      $��0��5+      $��0,0,0,1q�5.      .+�5/      �� $��0��6   $��0��50      $��Маркет��51      $��Center=�52      $��Center=�53      $��26(�54      ���#C0C0C055      �� 56       �� Orientation$ 
Horizontal=�6   $��RightToLeft=�57      
������ .+�5:      �� -   5         ��Name$ btnClose��5:        controlButton#��[ 5;      .��5=      !  FontAwesome.Sharp.IconImage  �  �FontAwesome.Sharp.IconImageBase`1[[FontAwesome.Sharp.IconChar, FontAwesome.Sharp, Version=6.3.0.0, Culture=neutral, PublicKeyToken=d16d1e4e568ec10f]]	   Icon$	 Xmark=�6#     controlButtonIcon#��[ 5>   #   5?      �� 5@      -   5        $ btnMaximize��5@      #��[ 5A      .��5C        $	 Square=�6#   #��[ 5D   #   5E      �� 5F      -   5        $ btnMinimize��5F      #��[ 5G      .��5I        $	 WindowMinimize=�6#   $��12��5J   #   #��[ 5K   #   5L      5M      5N      �� 5Q   
   $��1��6   $��1q�5R      $��0��5S      ��5T      �� 5U      
 �� 
StartPoint$	
 0,0&�6&    �� EndPoint$ 1,0.7&�5V   &   .��5W      �   secondaryBackColor1 � Color# [ 6#    � Offset$ 0Q�5X   #   5Y      ._�5]      �� .+�5_      	� -   5          
menuButton#��[ 5_       
 color1
 � Tag# [ 5`      ��5a      �� *ShowHomeViewCommand+.��5c      �� $ 
Horizontal=�6!   .+�5d        $	 PeopleGroup=�6'     menuButtonIcon#��[ 5e   '   �� 5f      $��Отделы��6$     menuButtonText#��[ 5g   $   5h      5i      	� 5l      -   5        #��[ 5l       
 color3# [ 5m      ��5n      �� *ShowCustomerViewCommand+.��5p      �� $ 
Horizontal=�6!   .+�5q        $		 Box=�6'   #��[ 5r   '   �� 5s      $��Товары��6$   #��[ 5t   $   5u      5v      	� 5w      -   5        #��[ 5w       
	 color4# [	 5x      ��5y      �� *ShowCustomerViewCommand+.��5{      �� $ 
Horizontal=�6!   .+�5|        $	 Dollar=�6'   #��[ 5}   '   �� 5~      $
��Wrap=�6$   #��[ 5   $   $��Продажи��5�   $   5�      5�      	� 5�      -   5        #��[ 5�      # [ 5�      ��5�      �� *ShowCustomerViewCommand+.��5�      �� $ 
Horizontal=�6!   .+�5�        $	 Brain=�6'   #��[ 5�   '   �� 5�      $��
Отчет��6$   #��[ 5�   $   5�      5�      5�      5�      � 5�   
   -	   5         �Name$ LV_User_Grid��5�      $��1��5�      $��1��5�      $��	0,0,20,20q�5�      � 5�   
   -
   5        $ LV_Plan_Grid��5�      $��1��5�      $��1��5�      $��	0,0,20,20q�5�      � 5�   
   -   5        $ LV_Plan_Week_Grid��5�      $��1��5�      $��1��5�      $��	0,0,20,20q�5�      � 5�   
   -   5        $ LV_Plan_Month_Grid��5�      $��1��5�      $��1��5�      $��	0,0,20,20q�5�      � 5�   
   -   5        $ LV_Order��5�      $��1��5�      $��1��5�      $��	0,0,20,20q�5�      � 5�   
   -   5        $ 
LV_Product��5�      $��1��5�      $��1��5�      $��	0,0,20,20q�5�      � 5�   
   -   5        $ 	LV_Recipe��5�      $��1��5�      $��1��5�      $��	0,0,20,20q�5�      5�      5�      