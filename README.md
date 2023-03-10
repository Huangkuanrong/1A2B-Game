## Description
This is a C# program that allows users to play the classic 1A2B guessing game.

## Structure
The program consists of a Program class and three helper methods: randNumber(), checkSame(), and Main().

The randNumber() function generates a random 4-digit number that contains unique digits between 1-9.

The checkSame() function compares two input strings and returns the number of "A" and "B" matches using nested loops.

The Main() function is the main entry point of the program. It uses the randNumber() and checkSame() functions to play the game, which involves generating a random number, prompting the user to guess the number, and providing feedback on the user's guess.

## Algorithm
1. Start the game loop.
2. Generate a random 4-digit number using the randNumber() function.
3. Display a welcome message to the user.
4. Start the guessing loop.
5. Prompt the user to enter a 4-digit number.
6. Use the checkSame() function to compare the user's guess to the generated number.
7. Display the number of "A" and "B" matches.
8. If the user guessed the number correctly, display a congratulations message and ask if they want to play again.
9. If the user does not want to play again, end the game loop and display a farewell message.
