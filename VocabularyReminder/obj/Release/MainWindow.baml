   M S B A M L   `   `   `  ���� M  IVocabularyReminder, Version=1.0.1.0, Culture=neutral, PublicKeyToken=null7 clr-namespace:VocabularyReminderVocabularyReminder  #    VocabularyReminder.MainWindow   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     @d2http://schemas.microsoft.com/expression/blend/2008     Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     2local clr-namespace:VocabularyReminder     U QMaterialDesignThemes.Wpf, Version=3.0.1.920, Culture=neutral, PublicKeyToken=nullFmaterialDesign1http://materialdesigninxaml.net/winfx/xaml/themes  -     �Name$  Frm_MainWindow��   MaterialDesignBody#���   $��Regular"�$��13(�&   System.Windows.Media.TextOptions   TextFormattingMode$ Ideal=�   TextRenderingMode$
 Auto=�  MaterialDesignPaper#���    MaterialDesignFont#���   � Title$ Vocabulary Reminder��$��746.25��$	��995��.���  � RowDefinitions �� $��1* ��� $��2* ��� $��1* ��� $��2* ��� $��1* ��� $��2* ��� $��1* ��� $��2* ��� $��1* ��� $
��0.6* � � ColumnDefinitions �� $
��0.5* ��� $��2* ��� $��1* ��� $��2* ��� $��1* ��� $��2* ��� $��1* ��� $��2* ��� $
��0.5* �.+��� -    ��Name$ Inp_ListWord�� �� TextWrapping$
 Wrap=�$��3��$��1��$��5�� �� AcceptsReturn . $��3���� -   	 ��Name$	 
Btn_Import��$��Import��$��1��$��1��$
��Auto���� -   $	 Btn_ProcessDeleteData��$��Delete All Data��$��7��$��5��$
��Auto���� -   $	 Btn_StartLearning��$��Start Learning��$��3��$��7��$��3��$
��Auto���� $��9��$��10��.@�� -   
 �Name$
 Status_ProgessBar��$	��100�� � Value$ 0Q� � Maximum$ 0Q�$��15���� -    ��Name$ Status_Message��$
��Wrap=�$��
Message...���� -   $ Inp_TimeRepeat��$��1��$
��Left=�$��22��$��	128,4,0,0q�$��7��$
 Wrap=�$	��120��$	��Top=�$��37�� �� TextAlignment$ Right=��� $��Time/word (s):��$
��Left=�$��7��$	��Top=�$��0,4,0,0q�$��1���� -	   $	 Btn_PreloadMp3��$��Download Mp3��$��1��$��5��$
��Auto���� -
    ��Name$ Inp_RandomOption��$��Random Words��$��1��$
��Left=�$��	0,55,0,26q�$��7�� d� 	IsChecked$
 TrueY�$��15��$	��148��$��2���� -   $	 Btn_Import_Auto��$��Import 3000 words��$��7��$��3��$
��Auto���� $��Remembered Words:��$��7��$
��Left=�$��1��$	��Top=��� $��Imported Words:��$��7��$
��Left=�$��1��$	��Top=�$��0,31,0,0q�$	��113���� -    ��Name$! Label_Stats_RememberedWords��$��0��$��7��$
��Left=�$��1��$	��Top=�$��49��$��	150,0,0,0q�$��2���� -   $ Label_Stats_ImportedWords��$��0��$��7��$
��Left=�$��1��$	��Top=�$��
150,31,0,0q�$��49��$��2���� -   $	 Btn_ShowLearnedList��$��Show Learned Words��$��7��$��7��$
��Auto��