# Quiz App

## Description
This is a simple Quiz Application written in C# that asks the user three general knowledge questions. The user earns or loses points based on their answers.

## Features
- Asks three questions related to general knowledge.
- Awards +1 point for a correct answer and deducts -1 point for an incorrect answer.
- Provides feedback based on the final score.

## Requirements
- .NET SDK installed on your system.
- A C# compatible environment (Visual Studio, VS Code, or any other IDE supporting C#).

## How to Run
1. Open a terminal or command prompt in the directory containing the source code.
2. Compile the code using the following command:
   ```sh
   csc QuizApp.cs
   ```
3. Run the compiled executable:
   ```sh
   QuizApp.exe
   ```

## Expected Output
1. The application welcomes the user.
2. The user is prompted with three questions.
3. After answering, the user is given feedback on whether their response was correct or incorrect.
4. The final score is displayed with a message based on the performance.

## Example Questions
1. What is the capital of India?
2. What is known as the Silicon Valley of India?
3. Who founded Apple?

## Possible Issues
- Case sensitivity: Answers must match exactly (e.g., "Delhi" instead of "delhi").
- No validation for empty inputs.
- The final message is humorous and might need to be adjusted based on the intended audience.

## Future Enhancements
- Improve input handling to be case-insensitive.
- Add more questions.
- Implement a graphical user interface (GUI) for better user experience.

## Author
Arryan Malhotra

