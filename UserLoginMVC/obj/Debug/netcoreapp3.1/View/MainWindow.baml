   M S B A M L   `   `   `  ����G  CUserLoginMVC, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null5clr-namespace:UserLoginMVC.ViewUserLoginMVC.View  5   	   "    UserLoginMVC.View.MainWindow   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   1localclr-namespace:UserLoginMVC.View     5   	     � Title$  
MainWindow��5   	   $	��437��6   $	��906��6)   .��5	      � $��0,0,10,0q�6   .+�5   
   �� -   5         ��Name$ userName��5      $
��Left=�5      $��38��5       �� TextWrapping$
 Wrap=�5       �� TextAlignment$ Center=�5      $��	user name��5      $	��Top=�5      $	��165��6%   $��	62,42,0,0q�5      $��20(�5      �� 5   
   -   5        $ 
numberRole��5      $
��Left=�5      $��38��5      $
 Wrap=�5      $ Center=�5      $�� ��5      $	��Top=�5      $��84��6%   $��486,173,0,0q�5       $��20(�5!      �� 5"   
   -   5        $
 date��5#      $
��Left=�5$      $��38��5%      $
 Wrap=�5&      $ Center=�5'      $�� ��5(      $	��Top=�5)      $	��102��6%   $��654,166,0,0q�5*      $��20(�5+      6   �� 5,   
   -   5         ��Name$ changeUserRole��5-      $��change��5.      $
��Left=�5/      $��457,106,0,0q�50      $	��Top=�51      $	��129��52      $��34��53      54      �� 55   
   -   5        $ okRole��56      $��change��57      $
��Left=�58      $��458,106,0,0q�59      $	��Top=�5:      $	��128��5;      $��34��5<      5=      �� 5>   
   -   5        $ atChange��5?      $��change��5@      $
��Left=�5A      $��641,106,0,0q�5B      $	��Top=�5C      $	��128��5D      $��34��5E      5F      �� 5G   
   -   5        $ okDate��5H      $��change��5I      $
��Left=�5J      $��641,106,0,0q�5K      $	��Top=�5L      $	��128��5M      $��34��5N      5O      �� 5P   
   -   5        $ userFak��5Q      $
��Left=�5R      $��38��5S      $
 Wrap=�5T      $ Center=�5U      $��user number��5V      $	��Top=�5W      $	��165��6%   $��
254,39,0,0q�5X      $��20(�5Y      �� 5Z   
   -	   5        $ userRole��5[      $
��Left=�5\      $��38��5]      $
 Wrap=�5^      $ Center=�5_      $��	user role��5`      $	��Top=�5a      $	��165��6%   $��
439,39,0,0q�5b      $��20(�5c      �� 5d   
   -
   5        $ howTo1��5e      $
��Left=�5f      $��38��5g      $
 Wrap=�5h      $ Center=�5i      $2��,Type the number in the box then click chamge��5j      $	��Top=�5k      $	��398��6%   $��354,271,0,0q�5l      $��13(�5m      �� 5n   
   -   5        $ 	howToDate��5o      $
��Left=�5p      $��32��5q      $
 Wrap=�5r      $ Center=�5s      $0��*Type the date in yyyyMMdd and click change��5t      $	��Top=�5u      $	��311��6%   $��562,225,0,0q�5v      $��13(�5w      �� 5x   
   -   5        $ howTo��5y      $
��Left=�5z      $��41��5{      $
 Wrap=�5|      $ Center=�5}      $\��V0-ANONYMOUS          1-ADMIN         2-INSPECTOR         3-PROFESSOR         4-STUDENT��5~      $	��Top=�5�      $	��324��6%   $��391,225,0,0q�5�      $��13(�5�      �� 5�   
   -   5        $ 
activeTime��5�      $
��Left=�5�      $��38��5�      $
 Wrap=�5�      $ Center=�5�      $��active time��5�      $	��Top=�5�      $	��165��6%   $��
623,39,0,0q�5�      $��20(�5�      �� 5�   
   -   5        $ showListNamesButton��5�      $��	all names��5�      $
��Left=�5�      $��
80,329,0,0q�5�      $	��Top=�5�      $	��128��5�      $��34��5�      5�      �� 5�   
   -   5        $ 
displayLog��5�      $��all log��5�      $
��Left=�5�      $��413,329,0,0q�5�      $	��Top=�5�      $	��128��5�      $��34��5�      5�      �� 5�   
   -   5        $ 
loginCount��5�      $��times login��5�      $
��Left=�5�      $��254,329,0,0q�5�      $	��Top=�5�      $	��128��5�      $��34��5�      5�      �� 5�   
   -   5        $ 
currentAct��5�      $��current activities��5�      $
��Left=�5�      $��587,329,0,0q�5�      $	��Top=�5�      $	��128��5�      $��34��5�      5�      �� 5�   
   $
��Fill=�5�      $��/View/tuto.jpg��5�      $��91,106,578,116q�5�      5�      5�      