# Personalized Greeting Generator

A C# console application that generates personalized greetings based on the user's name and the current time of day.

## Features

- **User Input**: Prompts the user to enter their name with input validation
- **Smart Defaults**: Uses "Friend" as default when no name is provided or input is empty/whitespace
- **Time-based Greetings**: Displays different greetings based on the current hour:
  - **Good morning** (5:00 AM - 11:59 AM)
  - **Good afternoon** (12:00 PM - 4:59 PM)
  - **Good evening** (5:00 PM - 8:59 PM)
  - **Good night** (9:00 PM - 4:59 AM)
- **Date & Time Display**: Shows current day of the week, date, and time
- **Null Safety**: Handles null input gracefully with null-coalescing operator

## Output Examples

**With user input:**
```
Please enter your name:John
Good afternoon, John! Today is Tuesday, 2025-11-11 and the current time is 14:30:15.
Press any key to exit...
```

**With empty input:**
```
Please enter your name:
Good morning, Friend! Today is Tuesday, 2025-11-11 and the current time is 09:15:22.
Press any key to exit...
```

## How to Run

1. Make sure you have .NET 8.0 or later installed
2. Navigate to the project directory
3. Run the application:
   ```bash
   dotnet run
   ```

## Technical Details

- **Framework**: Built with .NET 8.0
- **Date/Time**: Uses `DateTime.Now` to get current system date and time
- **Input Handling**: Uses `Console.ReadLine()` with null-coalescing operator (`??`)
- **Input Validation**: `string.IsNullOrWhiteSpace()` for comprehensive empty input checking
- **Time Logic**: Switch expression with pattern matching for time-based greetings
- **Formatting**:
  - Date: `"yyyy-MM-dd"` format specifier
  - Time: `"HH:mm:ss"` format specifier  
  - Day of week: `"dddd"` format specifier (full day name)
- **Error Handling**: Graceful handling of null and empty user input

## Project Structure

- `Program.cs` - Main application logic
- `PersonalizedGreetingGenerator.csproj` - Project configuration
- `FLOWCHART.md` - Visual representation of program flow
