   M S B A M L   `   `   `  ���� F  BHelloBeauty, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null5clr-namespace:HelloBeauty.PagesHelloBeauty.Pages      HelloBeauty.Pages.Users   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35^ ZWindowsFormsIntegration, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     @d2http://schemas.microsoft.com/expression/blend/2008     1localclr-namespace:HelloBeauty.Pages     b ^MaterialDesignThemes.Wpf, Version=4.0.0.2422, Culture=neutral, PublicKeyToken=df2a72020bd7962aFmaterialDesign1http://materialdesigninxaml.net/winfx/xaml/themes     MaterialDesignBody#���   $��Regular"�$��13(�&   System.Windows.Media.TextOptions    TextFormattingMode$  Ideal=�   TextRenderingMode$
 Auto=�  MaterialDesignPaper N� 
Background# �    MaterialDesignFont N� 
FontFamily# �  $
��1050��$	��600�� N� Title$ Users��.���  � RowDefinitions �� $��60 ��� $��* �.+�(  "MaterialDesignThemes.Wpf.ColorZone     Mode$ Inverted=�$��16q�.��]� .+���  �� Orientation$ 
Horizontal=�.+��� -   $��BtnBack��$��Center=�  MaterialDesignToolButton#���  .��'  !MaterialDesignThemes.Wpf.PackIcon     Kind$ 	ArrowLeft=�$��14���� $��Center=�$��16 0 0 0q�$��HelloBeauty��  $ Standard=�$��8 4 8 4q�	   CornerRadius$	 2��
 K� ZIndex$
 1��$��16 0 0 0q�+  %MaterialDesignThemes.Wpf.ShadowAssist   ShadowDepth$ Depth1=�.���  � ColumnDefinitions �� $
��Auto ��� $��* ��� $
��Auto �.+��� $��Center=�#���  .��  $ Search=� J� Opacity$	 .56Q� J� RenderTransformOrigin$ 0.812,-1.125&�$��14���� -   $��Search��$��1��$��8 0 0 0q�)  #MaterialDesignThemes.Wpf.HintAssist   Hint$ 
Поиск��.  (MaterialDesignThemes.Wpf.TextFieldAssist   DecorationVisibility$ Hidden=�$��0q�$	��200��$��Center=��� -    ��Name$ ListServices��$��1��$��Disabled=�$
��Left=�$��2������ .R��  � Orientation$ 
Horizontal=�$��Center=����� .R�#  MaterialDesignThemes.Wpf.Card  $	��270��.���  �� $	��250 ��� $��* ��� $
��Auto �.+��� $	��250��$	��266��$��UniformToFill=����� *Img+�� $��1��$��8 10 8 0q�.+���  $  MaterialDesignHeadline6TextBlock#��[ $
��Bold"����� *Name+��  $  MaterialDesignSubtitle1TextBlock#��[ $
��Wrap=�$��Center=����� *Cost+ �� StringFormat$   Стоимость {0}₽���� #��[ $
��Wrap=�$��0 0 0 10q�$��Center=����� *
Duration+$. ( Длительность {0} минут��