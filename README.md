# Personalized Greeting Generator

A simple C# console application that displays a personalized greeting with the current date, day of the week, and time.

## Features

- Displays the current day of the week (e.g., "Tuesday")
- Shows the current date in yyyy-MM-dd format (e.g., "2025-11-11")
- Displays the current time in HH:mm:ss format (e.g., "13:26:26")
- Combines all information in a friendly greeting message

## Output Example

```
Hello! Today is Tuesday, 2025-11-11 and the current time is 13:26:26.
```

## How to Run

1. Make sure you have .NET 8.0 or later installed
2. Navigate to the project directory
3. Run the application:
   ```bash
   dotnet run
   ```

## Technical Details

- Built with .NET 8.0
- Uses `DateTime.Now` to get current system date and time
- Formats date using `"yyyy-MM-dd"` format specifier
- Formats time using `"HH:mm:ss"` format specifier  
- Formats day of week using `"dddd"` format specifier (full day name)

## Project Structure

- `Program.cs` - Main application logic
- `PersonalizedGreetingGenerator.csproj` - Project configuration
- `FLOWCHART.md` - Visual representation of program flow
