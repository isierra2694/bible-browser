   M S B A M L   `   `   `  ����G  CBibleBrowser, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null+clr-namespace:BibleBrowserBibleBrowser  5   	   #    BibleBrowser.BibleBrowserMain   5   	   W SPresentationCore, Version=6.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=6.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=6.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=6.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=6.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   ,localclr-namespace:BibleBrowser     5   	     � Title$  Bible Browser��5   	   $	��720��6   $
��1280��6,   ���#0c0c0c � 	Resources 5
         VerseTemplate �� TextWrapping � Cursor �� 
IsReadOnly �� TextAlignment �� Mode  ChapterTitleTemplate  BookTitleTemplate K� Capitals0   *BibleBrowser.BibleDocumentTemplateSelector ! BibleDocumentTemplateSelector   VerseTemplate	   ChapterTitleTemplate
   BookTitleTemplate��%  &	        &	     &	 L    &	 �    7   7  7  �� 5   
   .R�5      �� $
 Wrap=�5      $ Arrow��5      $
 True��5      $��0q�5      ���#d6d6d6���#131316$��Georgia)�5      $��18(�5      $
 Left=�5      $��0,2,0,2q�5      ��5      �� *Text+$ OneWay=�5      5      �� 5   
   .R�5      �� $
 Wrap=�5      $ Arrow��5      $
 True��5      $��0q�5      ���#d6d6d6���#131316$��Georgia)�5       $��24(�5!      $��Italic$�5"      $ Center=�5#      $��	0,20,0,20q�5$      ��5      �� *Text+$ OneWay=�5$      5%      �� 5&   
   .R�5'      �� .+�5(      �� $
 Wrap=�5)      $ Arrow��5*      $
 True��5+      $��0q�5,      ���#d6d6d6���#131316$��Georgia)�5/      $��18(�50      $ Center=�51      $ 	SmallCaps=�52      $��0,75,0,0q�53      ��5(      �� *
Descriptor+$ OneWay=�53      �� 54      $
 Wrap=�55      $ Arrow��56      $
 True��57      $��0q�58      ���#d6d6d6���#131316$��Georgia)�5;      $��32(�5<      $ Center=�5=      $ 	SmallCaps=�5>      $��0,15,0,0q�5?      ��54      �� *Text+$ OneWay=�5?      5@      5A        5B   
   8   8	  8
  5E   .   5F      .��5G      �  � RowDefinitions 5H   
   �� 5I      $��40 �6   �� 5J      .+�5M   
   �� $��0��6   ���#0c0c0c$��3q�64    �� CornerRadius$ 5��6H   ._�5N      �  � ColumnDefinitions 5O      �� 5P      $��35 �6'   �� 5Q      $��* �6'   .+�5S      d� -   5        $��ToggleVerseButton��5S      $��0��68   ���#0c0c0c���#0c0c0c 5T       �� 
TargetType �� Property �� Value��%^   '��       �� 5U      " ��6    .�5V      ��  �@��CornerRadius$ 5��6=   5W      5X      .��5Y      ��  �� Orientation$ 
Horizontal=�6!   .+�5Z      �� $��/img/bible.png��6    $��20��68    �� BitmapScalingMode$ HighQuality=�6C   � 5[      -   5        $��VerseSelector��5[        � 	StaysOpen$
 True��5]       $	��500��5^       ��5\       �� *	IsChecked+ �� ElementName$ ToggleVerseButton��.��5_      �� $��1q�6%   ._�5`   "   R� -   5        $��BibleVersesViewer��5`   +    %� IsVirtualizing$
 True��5b   +    %� VirtualizationMode$ 	Recycling=�5c   +   $��Disabled=�5d   +   ���#131316��5a   +   �� *Books+��5f   &   �� 5g   *   " Q�60   .�5h   .   -   5        5i   +   ��5k   &   �� 5l   *    �� ItemsSource 6C   �� *
Chapters+.R�5m   .   �� .+�5n   2   �� ���#d6d6d6��6<   �� *Text+6R   5o   /   5p   +   5r   #   5s      5t      5u      5v      � 5w      $��1��6    5x      �� 5y      $��35 �6+   �� 5z      .+�5|      �� $��/img/search.png��6   $��20��65   $ HighQuality=�6@   �� 5}      -   5        $��SearchTextBox��5}      $��	10,8,10,0q�6M   ���#d6d6d6$��2��6v   ���#0c0c0c.��6�    5~      ��%^   '��       �� 5      " ��6$   .�5�   "   ��  �@��CornerRadius$ 5��6A   5�      5�      .��6-   #   BibleBrowser.WatermarkService   	Watermark 5�      �� 5�       �� Padding$ 3,0,0,0q�6(   ���#d6d6d6	Search...6Z   .��5�   <   5�      5�      5�      5�      �� 5�   
   $��1��6   ���#0c0c0c$��3q�64   ._�5�      �� -   5        $��BibleDocumentViewer��5�      $
 True��5�      $��Disabled=�5�      #��[ 5�      ���#131316���#0c0c0c$��	20,0,20,0q�5�       5�      ��%�   '��       �� 5�      " ��6   .�5�      ��  �@��CornerRadius$ 5��69   �� 5�       � ��$ 3q�6<   �� 5�       � �� �#0c0c0c68   5�      5�      ��5�      �� 5�      " ��6   .�5�      ��  � ��
 ���� 67   �� 5�       � �� 5�      �� 5�   "    �� 
TargetType" ��62   .R�5�   &   �� 5�   #   5�      5�      5�      5�      �� 5�   
   -   5        $��BibleSearchResultsPanel��5�   H   $��1��6   ���#0c0c0c$��3q�64   $y�	Collapsed=�6g   ._�5�      �  5�      �� 5�      $��30 �6$   �� 5�      .+�5�      �  5�      �� 5�      �� 5�      $��50 �6+   .+�5�      �� -   5        $��SearchResultsTitle��5�       ���#0c0c0c���#d6d6d6$ 	10,5,10,5q�5�       66   �� 5�      -	   5        $��1��5�      ���#0c0c0c���#d6d6d6.��5�   2   Cancel6:   5�      �� 5�      -
   5        $��BibleSearchResultsViewer��5�   (   $��1��6   $
 True��5�      $��Disabled=�5�      ���#131316$��	20,0,20,0q�5�      ��5�      �� 5�      .R�5�      �� $
��Wrap=�6(   ���#d6d6d6$��Georgia)�5�   (   $��18(�5�   (    �� TextAlignment$
 Left=�5�   (   $ 0,2,0,2q�5�   (   �� 5�   &   �6*   �� *FormattedVerse+ �� 5�   &   $� ��6*    �� 5�   &   �6*   �� *	VerseText+5�      5�       5�      ��%�   '��       �� 5�      " ��6    .�5�      ��  �@��CornerRadius$ 5��6=   �� 5�       � ��$ 3q�6@   �� 5�       � �� �#0c0c0c6<   5�      5�      ��5�      �� 5�      " ��6    .�5�      ��  � ��
 ���� 6;   �� 5�       � �� 5�   "   �� 5�   &   " ��66   .R�5�   *   �� 5�   '   5�      5�      5�      5�      5�      5�      5�      