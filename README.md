# Mana2DragonShield

Mana2DragonShield is a web application built using Blazor WebAssembly (.NET 9), designed to provide a modern, interactive UI experience in the browser.

## Features

- Built on Blazor WebAssembly for rich client-side interactivity.
- Modular code structure with clear separation of data objects, layout, and pages.
- Service worker support for offline capabilities.
- Modern .NET 9 framework and best practices (nullable reference types, implicit usings).

## Project Structure

- `App.razor` - Sets up application routing and layouts.
- `Program.cs` - Initializes and configures the Blazor WebAssembly host.
- `DataObjects/` - Contains data model classes.
- `Layout/` - Contains layout components.
- `Pages/` - Contains the application's main pages.
- `wwwroot/` - Static files and service worker scripts.

## Getting Started

To run Mana2DragonShield locally:

1. **Clone the repository:**
   ```bash
   git clone https://github.com/Bourdain/ManaBox2DragonShield.git
   cd ManaBox2DragonShield
   ```

2. **Run the project:**
   ```bash
   dotnet run
   ```

3. Open your browser and navigate to the provided local address (typically `https://localhost:5001`).

## Requirements

- [.NET 9 SDK](https://dotnet.microsoft.com/download/dotnet/9.0) or later

## Technologies Used

- Blazor WebAssembly
- .NET 9
- C#

## Contributing

Pull requests are welcome! For major changes, please open an issue first to discuss what you would like to change.

## License

[MIT](LICENSE)

---

View the full project on GitHub: [ManaBox2DragonShield](https://github.com/Bourdain/ManaBox2DragonShield)
