   M S B A M L   `   `   `  ????C  ?zadanie1, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null#clr-namespace:zadanie1zadanie1  5   	       zadanie1.Window2   5   	   W SPresentationCore, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   (localclr-namespace:zadanie1     5   	     ? Title$  Window2??5   	   $	??450??6   $	??800??6&   .??5	      ?? .+?5
   
   ?? -   5         ??Name$ rozmiarTekstu??5
       ? Minimum$ 10Q?5       ? Maximum$ 45Q?5       ? Value$ 20Q?5      5      ?? 5   
   -   5         ??Name$ kolor??5      .@?5      ?? .??6   Red6    ?? 5      .??6   blue6!   ?? 5      .??6   green6"   5      ?? 5   
   ??6   ??  ?? ElementName$ kolor?? ?? Path$
 Text???6H   ?? $ rozmiarTekstu??$ Value?Testowanie wiązania danych5   ,   ?? 5   
   -   5         ??Name$ tekst??5      6#   ?? 5   
   ??6   ?? $ tekst??$
 Text?6E   ?? 5    
   -   5        $
 box1??5    ?   ??6   ?? $
 box2??$
 Text?6O   ?? 5!   
   -   5        $
 box2??5!   ?   ??6   ?? $
 box1??$
 Text?6O   ?? 5"   
   -   5        $ slider2??5"      $ 0Q?5#      $	 255Q?5$      $ 0Q?5%      	 ?? TickFrequency$	 1Q?5&      
 ?? IsSnapToTickEnabled$

 True??5'      5(      ?? 5)   
   -   5        $ liczba3??5)   h   ??6   ?? $ slider2??$ Value? ?? UpdateSourceTrigger$ PropertyChanged=?6{   ?? 5+   
   -   5        $ slider3??5+      $ 1Q?5,      $ 45Q?5-      $ 20Q?5.      $	 1Q?5/      $

 True??50      51      ?? 52   
   -	   5        $ liczba4??52   b   ??6   ?? $ slider3??$ Value?$ 	LostFocus=?6u   ?? 53   
   ??6   ?? $ slider3??$ Value?$ 	LostFocus=?Text do zmiany trzcionki6?   54      55      