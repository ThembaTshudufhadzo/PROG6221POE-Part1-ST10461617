# PROG6221POE-Part1-ST10461617
 https://github.com/ThembaTshudufhadzo/PROG6221POE-Part1-ST10461617.git

# CyberSecurityChatbotApp README

## Overview

This C# application is a cybersecurity awareness chatbot. It provides information and answers questions related to various cybersecurity topics.

## Features

* **Displays a logo:** Upon startup, the application displays a logo using ASCII art.
* **Interactive Q&A:** Users can ask the chatbot questions about cybersecurity.
* **Cybersecurity topics:** The chatbot covers topics such as:
    * Password safety
    * Phishing
    * Safe browsing
    * Malware
    * Social engineering
    * Data privacy
    * Network security
    * Incident response
* **Provides information on how to avoid issues** The chatbot provides information on how to avoid common cybersecurity issues.

## Code Description

### 1.  `HandlingUserInputs` Class

    * The `HandlingUserInputs` class contains the logic for handling user input and providing appropriate responses.
    * `responses`: A static dictionary that stores cybersecurity-related questions and their corresponding answers.
    * `TypeWriteLine(string message, int delay = 30)`: A static method that simulates a typing effect by writing each character of a message to the console with a small delay.
    * `HandleUserInput(string userName)`:
        * This static method is the main entry point for interacting with the user.
        * It displays a welcome message and instructions on how to use the chatbot.
        * It enters a loop to continuously:
            * Read user input from the console.
            * Check if the user wants to exit.
            * If the input matches a key in the `responses` dictionary, it displays the corresponding answer using `TypeWriteLine`.
            * If the input contains keywords related to a specific topic (e.g., "password," "phishing"), it provides a list of related questions.
            * If the input is not recognized, it displays an error message.

### 2.  `DisplayMediaArt` Class

* The `DisplayMediaArt` class is responsible for displaying the application's logo as ASCII art.
* `DisplayLogoAndInfo()`:
    * This static method displays the logo and the application title.
    * It calls the `ConvertImageToASCII` method to convert the image to ASCII art.
* `ConvertImageToASCII(string imagePath, int maxWidth = 50)`:
    * This static method converts an image to ASCII art.
    * It takes the image path and an optional `maxWidth` as input.
    * It loads the image, resizes it, and then iterates through each pixel to determine the corresponding ASCII character based on the pixel's intensity.
    * It returns the ASCII art as a string.
    * It includes error handling for file not found and other exceptions during image processing.
    * It disposes of the `Bitmap` objects to release resources.

### 3. `Program` Class
* The `Main` method is the entry point of the program.
* It prompts the user for their name.
* It calls the `DisplayMediaArt.DisplayLogoAndInfo()` method to display the logo.
* It calls the `HandlingUserInputs.HandleUserInput()` method to start the chatbot interaction.

## How to Run the Application

1.  Ensure that you have the .NET runtime installed.
2.  Save the C# code to a file (e.g., `CyberSecurityChatbotApp.cs`).
3.  Place the image file (e.g., `cs2 (2).jpg`) in the specified path.  **Note:** The code uses an absolute path: `C:\Users\lab_services_student\Desktop\CyberSecurityChatbotApp\Resources\cs2 (2).jpg`.  You will need to change this path to the actual location of your image file.
4.  Open a command prompt or terminal.
5.  Navigate to the directory where you saved the C# file.
6.  Compile the code using the C# compiler:  `csc CyberSecurityChatbotApp.cs /r:System.Drawing.dll`
7.  Run the compiled executable:  `CyberSecurityChatbotApp.exe`
8.  The application will display the logo and prompt you to ask questions.
