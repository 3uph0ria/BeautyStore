   M S B A M L   `   `   `  ����F  BBeautyStore, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null5clr-namespace:BeautyStore.PagesBeautyStore.Pages  5      *    $BeautyStore.Pages.PageAddEditService   5      \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35^ ZWindowsFormsIntegration, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      1localclr-namespace:BeautyStore.Pages     5      b ^MaterialDesignThemes.Wpf, Version=4.0.0.2422, Culture=neutral, PublicKeyToken=df2a72020bd7962aFmaterialDesign1http://materialdesigninxaml.net/winfx/xaml/themes  5   	     N� Title$  PageAddEditService��5
      .��5      � $��15q�6    � RowDefinitions 5      �� 5   
   $��* �6   �� 5   
   $��* �6   �� 5   
   $��* �6   �� 5   
   $��* �6   �� 5   
   $��* �6   �� 5   
   $��* �6   �� 5   
   $��* �6   �� 5   
   $��* �6   �� 5   
   $��* �6   .+�5      �� $��Center=�6   $��0��6,   $'��!Добавление услуги��5   	    $   MaterialDesignHeadline5TextBlock#��[  5   	   �� 5   
   -   5        $
��Name��5      $��1��5      $	��600��5        MaterialDesignFilledTextBox#��[ 5       $��Center=�5!       �� AcceptsReturn .  �� TextWrapping$
 Wrap=�5#      )  #MaterialDesignThemes.Wpf.HintAssist   Hint$ Наименование��5$      $��0 0 20 0q�5%      ��5      �� *Name+{�5&      ��  �� Path$ 	IsChecked� �� ElementName$0 *MaterialDesignFilledTextBoxEnabledComboBox���� 5)   
   -   5        $
��Cost��5+      $��2��5*      $	��600��5-      #��[ 5.      $��Center=�5/       . $
 Wrap=�51      $ Стоимость��52      $��0 0 20 0q�53      ��5,      �� *Cost+{�54      �� $ 	IsChecked�$0 *MaterialDesignFilledTextBoxEnabledComboBox���� 56   
   -   5         ��Name$ CBoxCategory��5=      $ Категория��57      $	��600��58      $��0 0 20 0q�59      $��Center=�5:      $��3��5;       �� DisplayMemberPath$
 Name��5>      	 �� SelectedItem	 5<      �� *Categoris.Id+5>      �� 5A   
   -   5        $	��Img��5C      $��4��5B      $	��600��5E      #��[ 5F      $��Center=�5G       . $
 Wrap=�5I      $ Картинка��5J      $��0 0 20 0q�5K      ��5D      �� *Img+{�5L      �� $ 	IsChecked�$0 *MaterialDesignFilledTextBoxEnabledComboBox���� 5N   
   -   5        $ CBoxCustomer��5U      $ Поставщик��5O      $	��600��5P      $��0 0 20 0q�5Q      $��Center=�5R      $��5��5S      $
 Name��5V      	 5T      �� *Customers.Id+5V      �� 5Y   
   -   5        $��Amount��5[      $��6��5Z      $	��600��5]      #��[ 5^      $��Center=�5_       . $
 Wrap=�5a      $# Кол-во на складе��5b      $��0 0 20 0q�5c      ��5\      �� *Amount+{�5d      �� $ 	IsChecked�$0 *MaterialDesignFilledTextBoxEnabledComboBox���� 5f   
   -   5        $��Description��5h      $��6��5g      $	��600��5j      #��[ 5k      $��Center=�5l       . $
 Wrap=�5n      $ Описание��5o      $��0 0 20 0q�5p      ��5i      �� *Description+{�5q      �� $ 	IsChecked�$0 *MaterialDesignFilledTextBoxEnabledComboBox���� 5s   
   $��Center=�6   $��8��60   $��Center=�6>   
 �� Orientation$
 
Horizontal=�6[   .+�5t   
   �� -   5        $��BtnAddservice��5t      $��Добавить��6B   6X   5u      5v      5w      