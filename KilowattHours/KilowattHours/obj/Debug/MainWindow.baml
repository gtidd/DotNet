   M S B A M L   `   `   `  ����H  DKilowattHours, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null-clr-namespace:KilowattHoursKilowattHours  5   	       KilowattHours.MainWindow   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   -localclr-namespace:KilowattHours     5   	     � Title$  
MainWindow��5   	   $��592.886��6   $��665.511��6-   .��5	      � .+�5
   
   �� -   5         ��Name$ lblKilowattHours��5
      $��Kilowatt Hour Calculator��6*   $��
197,10,0,0q�6M   $	��Top=�6a   $	��233��6y   $
��Left=�6�   �� 5   
   -   5         ��Name$ cmbAppliances��5      $
��Left=�6*   $��
197,50,0,0q�6E   $	��Top=�6Y   $	��149��6q   .@�5      ��  � Cursor$ Cross��6   $��Space Heater��6*   �� 5      $ Cross��6   $��Dish washer��6*   �� 5      $ Cross��6   $
��Oven��6*   �� 5      $ Cross��6   $��	Microwave��6*   �� 5      $ Cross��6   $��Gamma Blaster��6*   �� 5      $ Cross��6   $��TV��6*   �� 5      $ Cross��6   $��Dryer��6*   5      �� 5   
   -   5        $ lblSelection��5      $��Select Appliance��6&   $
��Left=�6A   $��	77,46,0,0q�6\   $	��Top=�6o   $	��101��6�   �� 5   
   -   5        $ lblPowerNeeded��5      $)��#Power Needed in Kilowatts (1 - 100)��6(   $
��Left=�6V   $��
20,174,0,0q�6q   $	��Top=�6�   $	��215��6�   �� 5   
   -   5        $ lblAvgUseHourly��5      $.��(Average Use daily (Enter Hours up to 24)��6)   $
��Left=�6\   $��
20,249,0,0q�6w   $	��Top=�6�   $	��247��6�   �� 5   
   -   5         ��Name$ txtPowerNeeded��5      $
��Left=�6*   $��23��6E   $��272,174,0,0q�6Q    �� TextWrapping$
 Wrap=�6f   $	��Top=�6z   $��82��6�   �� 5   
   -   5        $ 	txtAvgUse��5      $
��Left=�6%   $��23��6@   $��272,249,0,0q�6L   $
 Wrap=�6a   $	��Top=�6u   $��82��6�   �� 5   
   -   5        $ lblCost��5      $(��"Cost per Kilowatt hour (.05 - .50)��6!   $
��Left=�6N   $��
20,106,0,0q�6i   $	��Top=�6}   $	��183��6�   �� 5   
   -	   5        $ txtCost��5      $
��Left=�6#   $��23��6>   $��272,106,0,0q�6J   $
 Wrap=�6_   $	��Top=�6s   $��82��6�    J� RenderTransformOrigin$ 1.176,0.484&�6�   �� 5   
   -
   5         ��Name$ btnCalculate��5      $��	Calculate��6'   $
��Left=�6;   $��103,307,0,0q�6V   $	��Top=�6k   $��75��6�   �� 5   
   -   5        $ btnClear��5      $��Clear Fields��6#   $
��Left=�6:   $��271,307,0,0q�6U   $	��Top=�6j   $��75��6�   �� 5   
   -   5        $ btnExit��5      $
��Exit��6"   $
��Left=�61   $��442,307,0,0q�6L   $	��Top=�6a   $��75��6y   �� 5   
   -   5        $ lblHourlyTotal��5      $��Total Hourly Cost��6(   $
��Left=�6D   $��457,103,0,0q�6_   $	��Top=�6t   $	��105��6�   �� 5   
   -   5        $ lblYearlyCost��5      $��Total Yearly Cost��6'   $
��Left=�6C   $��457,174,0,0q�6^   $	��Top=�6s   $	��105��6�   �� 5    
   -   5        $ txtYearlyCost��5       $
��Left=�6)   $��23��6D   $��457,215,0,0q�6P   $
 Wrap=�6e   $	��Top=�6y   $	��120��6�    �� IsReadOnlyCaretVisible . 	 �� 
IsReadOnly	 . 6�   �� 5!   
   -   5        $ txtHourlyCost��5!      $
��Left=�6)   $��23��6D   $��457,134,0,0q�6P   $
 Wrap=�6e   $	��Top=�6y   $	��120��6�    . 	 . 6�   �� 5"   
   -   5        $ lblNumOfGal��5"      $	��N/A��6%   $
��Left=�63   $��
20,218,0,0q�6N   $	��Top=�6b   $	��192��6z   �� 5#   
   -   5        $ txtNumOfGal��5#      $
��Left=�6'   $��23��6B   $��272,215,0,0q�6N   $
 Wrap=�6c   $	��Top=�6w   $��83��6�   �� 5$   
   -   5        $ lblWaterCostPerHour��5$      $	��N/A��6-   $
��Left=�6;   $��
20,139,0,0q�6V   $	��Top=�6j   $	��183��6�   �� 5%   
   -   5        $ txtWaterCost��5%      $
��Left=�6(   $��23��6C   $��271,142,0,0q�6O   $
 Wrap=�6d   $	��Top=�6x   $��83��6�   &   System.Windows.Controls.DataGrid  5&   
   -   5        
  Name$
 dataGrid��5&      $
��Left=�6%   $��
20,362,0,0q�6@   $	��Top=�6T   $	��170��6l   $	��606��6y   5(      5)      