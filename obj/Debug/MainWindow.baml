   M S B A M L   `   `   `  ����E  ALazy Tweet, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null'clr-namespace:Lazy_Tweet
Lazy_Tweet  5   	       Lazy_Tweet.MainWindow   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   *localclr-namespace:Lazy_Tweet     5   	     � Title$  Lazy Tweeter��5   	   $	��750��6   $
��1000��6+    � WindowStartupLocation$ CenterScreen=�5	   	   ���#AAB8C2���#1DA1F2$��Segoe UI SemiBold Italic)�5
   	   .��5      �  � RowDefinitions 5   
   �� 5      $
��2.5* �6   �� 5      $��* �6   �� 5      $
��4.5* �6    � ColumnDefinitions 5   
   �� 5      $��* �6   �� 5      $��2* �6   .+�5   
   �� $��20q�6   $��/Twitter-logo.png��6   $��Uniform=�67   �� 5   
   -   5        $��Title��5      $��1��6!   $��Center=�61   $��Center=�6L   $	��105(�6i   Lazy Tweeter6�   �� 5   
   $��1��6   $��Center=�6!   $
��Left=�6<   $��5q�6W   $��50(�6b   $��2��6p   Today I feel:6�   �� 5   
   $��3��6   $��70,10,10,10q�6"   $��Center=�67   $
��Left=�6R   .+�5      	� -   5        $��happy��5       	� 	GroupName$
 mood��6'    d� 	IsChecked$
 TrueY�68   ���#1DA1F2$��Segoe UI SemiBold Italic)�6^   $��45(�6�   $��Center=�6�   .��6�   Happy6�   	� 5      -   5        $	��sad��5      $
 mood��6%   ���#1DA1F2$��Segoe UI SemiBold Italic)�6K   $��45(�6q   $��Center=�6   .��6�   Sad6�   	� 5      -   5        $��angry��5      $
 mood��6'   ���#1DA1F2$��Segoe UI SemiBold Italic)�6M   $��45(�6s   $��Center=�6�   .��6�   Angry6�   	� 5      -   5        $��	disgusted��5      $
 mood��6+   ���#1DA1F2$��Segoe UI SemiBold Italic)�6Q   $��45(�6w   $��Center=�6�   .��6�   	Disgusted6�   	� 5      -   5        $��empty��5      $
 mood��6'   ���#1DA1F2$��Segoe UI SemiBold Italic)�6M   $��45(�6s   $��Center=�6�   .��6�   Empty6�   5       �� 5"   
   $��1��6   $��2��6"   $��2��62   $��Center=�6C   $��Right=�6^   $��10,10,70,10q�6z    �� Orientation$ Vertical=�6�   .+�5#      �� -   5        $��ownTweet��5#   O   $	��350��6   $��20q�6!   $	��120��6-   ���#1DA1F2$��	Own Tweet��6_   
�������$��Segoe UI SemiBold Italic)�6�   $��65(�6�    � 	Resources 5$       �� 
TargetType	 �� Property
 �� Value��%_   '��       �� 5%      " ��6   .�5&      �� 	 �@��CornerRadius$
 10��69   5'      5(      5)      �� 5*      -   5        $��account��5*   O   $	��350��6   $��20q�6!   $	��120��6-   ���#1DA1F2$��Account��6^   
�������$��Segoe UI SemiBold Italic)�6�   $��65(�6�    5+      ��%_   '��       �� 5,      " ��6   .�5-      �� 	 �@��CornerRadius$
 10��69   5.      5/      50      �� 51      -	   5        $��tweet��51   O   $	��350��6   $��20q�6!   $	��120��6-   ���#1DA1F2$��Tweet��6\   
�������$��Segoe UI SemiBold Italic)�6   $��65(�6�    52      ��%_   '��       �� 53      " ��6   .�54      �� 	 �@��CornerRadius$
 10��69   55      56      57      58      �� 5:   
   -
   5        $
��Name��5:      $��3��6    $��Bottom=�6-   $��25(�6H   $��15q�6V   ��6b   �� *USER+5;      5<      