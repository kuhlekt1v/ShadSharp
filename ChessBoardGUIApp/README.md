# Challenge

Congratulations. Your program should be working (mostly). However, there is some unfinished business.

## 1. Error Checking

Double check to make sure all cases work as designed. Check for out-of-bounds errors.

## 2. Multiple Pieces

Utilize `ComboBox1` control values to select all five different chest pieces. Currently the word 'Knight' is hard-coded into the program in several places. You will have to create a new event handler for the `ComboBox1` control, store the selected chess piece name in a variable and pass this to the function `MarkNextLegalMoves`.

## 3. Center Button Text

Currently the clicked button changes color but the button text does not show what kind of piece is placed on the board. Return to the `Board.cs` class and look at the `MarkNextLegalMoves` method. You will see that the method updates the `LegalNextMove` for each cell, but nowhere does it set the property value for `CurrentlyOccupied`.
