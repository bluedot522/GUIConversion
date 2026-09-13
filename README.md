# GUI Conversion Project

### Application: 
Movie Theater Discount Calculator

### Purpose: 
Determines whether a discount is applicable given the data of patron age and the movie's rating. 

### Inputs: 
(int) age, (string) rating

### Calculations: 
Decision by certain conditions. if((age < 12 || age >= 65) % rating == 'G'). Subtracts half from the total if discount applies, otherwise standard $20.00 amount applies.

### Output: 
"This discount (is)/ (is not) applied for a total of $(amount)."

Users input an age and movie rating into appropriate textbox fields and click the Calculate button. The results should appear beside the results label. Othewise, an error message will occur. The Clear All button clears all entries from the text inputs and results output. The Quit button quits the program.

### Features:

This program features 11 pt Segoe Font for readability.
The minumum form size is at 660, 300, while the maximum size is at 800, 300.

The tab order starts at the Age entry, descends to the Rating entry, follows to Calculate, Clear All, then Quit.

The welcome message is anchored to the top left.
The Results label and text box is anchored to the right.
The inputs and Calculate button items anchored to the left. 
The Clear and Quit buttons anchored to the bottom right.

The input validation includes messages for the following:
"Age must not be blank," when the age textbox is blank.
"Rating must not be blank," when the rating textbox is blank.
"Please enter a valid age," when the age is not numeric.
"Please enter a valid movie rating," when the movie rating does not match G, PG, MA-17, R, X, or any lowercase variants.

A few limitations of the program are that the window can only be resized a slight amount and it can only display one error message at a time. The price and discount are always fixed amounts, being $20.00 and half-off, respectively.
