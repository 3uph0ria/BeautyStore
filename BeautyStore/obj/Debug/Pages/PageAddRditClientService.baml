   M S B A M L   `   `   `  ����F  BBeautyStore, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null5clr-namespace:BeautyStore.PagesBeautyStore.Pages  5      0    *BeautyStore.Pages.PageAddRditClientService   5      \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35^ ZWindowsFormsIntegration, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      1localclr-namespace:BeautyStore.Pages     5      b ^MaterialDesignThemes.Wpf, Version=4.0.0.2422, Culture=neutral, PublicKeyToken=df2a72020bd7962aFmaterialDesign1http://materialdesigninxaml.net/winfx/xaml/themes  5   	     N� Title$  PageAddRditClientService��5
      .��5      � $��15q�6    � RowDefinitions 5   
   �� 5      $��* �6   �� 5      $��* �6   �� 5      $��* �6   �� 5      $��* �6   �� 5      $��* �6   .+�5   
   �� $��Center=�6   $��0��60   $D��>Добавление/редактирование записи��5   	    $   MaterialDesignHeadline5TextBlock#��[  5   	   �� 5   
   -   5        $
��Date��5      $��1��5      $	��600��5        MaterialDesignFilledTextBox#��[ 5      $��Center=�5       �� AcceptsReturn .  �� TextWrapping$
 Wrap=�5      )  #MaterialDesignThemes.Wpf.HintAssist   Hint$ Время записи��5       $��0 0 20 0q�5!      ��5      �� *Date+{�5"      ��  �� Path$ 	IsChecked� �� ElementName$0 *MaterialDesignFilledTextBoxEnabledComboBox���� 5$   
   -   5         ��Name$ CBoxService��5+      $ Услуги��5%      $	��600��5&      $��0 0 20 0q�5'      $��Center=�5(      $��2��5)       �� DisplayMemberPath$
 Name��5,      	 �� SelectedItem	 5*      �� *Services.Id+5,      �� 5/   
   -   5        $ 
CBoxClient��56      $ Клиент��50      $	��600��51      $��0 0 20 0q�52      $��Center=�53      $��3��54      $ Fullname��57      	 55      �� *
Clients.Id+57      �� 5:   
   $��Center=�6   $��4��60   $��Center=�6>   
 �� Orientation$
 
Horizontal=�6[   .+�5;      �� -   5        $��BtnAddClientservic��5;      $��Сохранить��6P   6g   5<      5=      5>      