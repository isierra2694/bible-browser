   M S B A M L   `   `   `  ���� G  CBibleBrowser, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null+clr-namespace:BibleBrowserBibleBrowser  #    BibleBrowser.BibleBrowserMain   W SPresentationCore, Version=6.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=6.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=6.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=6.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     R NSystem.Xaml, Version=6.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     @d2http://schemas.microsoft.com/expression/blend/2008     Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     ,localclr-namespace:BibleBrowser       � Title$  Bible Browser��$	��720��$
��1280�����#0c0c0c � 	Resources    VerseTemplate �� TextWrapping � Cursor �� 
IsReadOnly �� TextAlignment �� Mode  ChapterTitleTemplate  BookTitleTemplate K� Capitals0   *BibleBrowser.BibleDocumentTemplateSelector ! BibleDocumentTemplateSelector   VerseTemplate	   ChapterTitleTemplate
   BookTitleTemplate��%  &	        &	 �     &	 Y    &	 �    7   7  7  �� .R��� $
 Wrap=�$ Arrow��$
 True��$��0q����#d6d6d6���#131316$��Georgia)�$��18(�$
 Left=�$��0,2,0,2q����� *Text+$ OneWay=��� .R��� $
 Wrap=�$ Arrow��$
 True��$��0q����#d6d6d6���#131316$��Georgia)�$��24(�$��Italic$�$ Center=�$��	0,20,0,20q����� *Text+$ OneWay=��� .R��� .+��� $
 Wrap=�$ Arrow��$
 True��$��0q����#d6d6d6���#131316$��Georgia)�$��18(�$ Center=�$ 	SmallCaps=�$��0,75,0,0q����� *
Descriptor+$ OneWay=��� $
 Wrap=�$ Arrow��$
 True��$��0q����#d6d6d6���#131316$��Georgia)�$��32(�$ Center=�$ 	SmallCaps=�$��0,15,0,0q����� *Text+$ OneWay=�  8   8	  8
  .���  � RowDefinitions �� $��40 ��� .+��� $��0�����#0c0c0c$��3q� �� CornerRadius$ 5��._��  � ColumnDefinitions �� $��35 ��� $��* �.+�d� -   $��ToggleVerseButton��$��0�����#0c0c0c���#0c0c0c  �� 
TargetType �� Property �� Value��%9   '��       �� " ��.���  �@��CornerRadius$ 5��.����  �� Orientation$ 
Horizontal=�.+��� $��/img/bible.png��$��20�� �� BitmapScalingMode$ HighQuality=�� -   $��VerseSelector�� � 	StaysOpen$
 True��$	��500������ *	IsChecked+ �� ElementName$ ToggleVerseButton��.���� $��1q�._�R� -   $��BibleVersesViewer�� %� IsVirtualizing$
 True�� %� VirtualizationMode$ 	Recycling=�$��Disabled=����#131316���� *Books+���� " Q�.�-   ����  �� ItemsSource �� *
Chapters+.R��� .+��� ���#d6d6d6���� *Text+� $��1�� �� $��35 ��� .+��� $��/img/search.png��$��20��$ HighQuality=��� -   $��SearchTextBox��$��	10,8,10,0q����#d6d6d6$��2�����#0c0c0c.�� ��%9   '��       �� " ��.���  �@��CornerRadius$ 5��.��#   BibleBrowser.WatermarkService   	Watermark ��  �� Padding$ 3,0,0,0q����#d6d6d6	Search....���� $��1�����#0c0c0c$��3q�._��� -   $��BibleDocumentViewer��$
 True��$��Disabled=�#��[ ���#131316���#0c0c0c$��	20,0,20,0q� ��%j   '��       �� " ��.���  �@��CornerRadius$ 5����  � ��$ 3q���  � �� �#0c0c0c���� " ��.���  � ��
 ���� ��  � �� ��  �� 
TargetType" ��.R��� �� -   $��BibleSearchResultsPanel��$��1�����#0c0c0c$��3q�$y�	Collapsed=�._��  �� $��30 ��� .+��  �� �� $��50 �.+��� -   $��SearchResultsTitle�����#0c0c0c���#d6d6d6$ 	10,5,10,5q��� -	   $��1�����#0c0c0c���#d6d6d6.��Cancel�� -
   $��BibleSearchResultsViewer��$��1��$
 True��$��Disabled=����#131316$��	20,0,20,0q����� .R��� $
��Wrap=����#d6d6d6$��Georgia)�$��18(� �� TextAlignment$
 Left=�$ 0,2,0,2q��� ��� *FormattedVerse+ �� $� �� �� ��� *	VerseText+ ��%j   '��       �� " ��.���  �@��CornerRadius$ 5����  � ��$ 3q���  � �� �#0c0c0c���� " ��.���  � ��
 ���� ��  � �� �� " ��.R��� 