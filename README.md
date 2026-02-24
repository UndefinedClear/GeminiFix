# ⚡ GeminiFix

[![License: MIT](https://img.shields.io/badge/License-MIT-yellow.svg)](https://opensource.org/licenses/MIT)
[![.NET 8.0](https://img.shields.io/badge/.NET-8.0-blue.svg)](https://dotnet.microsoft.com/download/dotnet/8.0)
[![Platform: Windows](https://img.shields.io/badge/Platform-Windows-0078D6.svg)](https://www.microsoft.com/windows)
[![Help: +1 to Issue](https://img.shields.io/badge/Help-%2B1%20to%20Issue-green?logo=google)](https://issuetracker.google.com/issues/487139128)

**GeminiFix** is a lightweight, high-performance terminal optimization tool designed specifically for **Antigravity** users on Windows. It patches session configurations to ensure seamless terminal tool execution and eliminates common environment compatibility errors.

```text
   _____ ______ __  __ _____ _   _ _____     ______ _______   __
  / ____|  ____|  \/  |_   _| \ | |_   _|   |  ____|_   _\ \ / /
 | |  __| |__  | \  / | | | |  \| | | |     | |__    | |  \ V / 
 | | |_ |  __| | |\/| | | | | . ` | | |     |  __|   | |   > <  
 | |__| | |____| |  | |_| |_| |\  |_| |_    | |     _| |_ / . \ 
  \_____|______|_|  |_|_____|_| \_|_____|   |_|    |_____/_/ \_X
```

## 🚀 Key Features

- **Automated Patching**: Instantly injects mandatory Windows terminal rules into your `.gemini` profile.
- **Safety First**: Includes a built-in scanner and previewer to let you audit changes before they are applied.
- **Optimized for Windows**: Specifically handles encoding (`chcp 65001`) and command execution patterns unique to the Windows shell.
- **Lightweight & Fast**: Built with C# and .NET 8 for maximum performance and zero bloat.

## 🛠️ Installation

1. **Clone the Repository**

   ```bash
   git clone https://github.com/your-username/GeminiFix.git
   cd GeminiFix
   ```

2. **Build and Run**
   Ensure you have the [.NET 8 SDK](https://dotnet.microsoft.com/download/dotnet/8.0) installed.

   ```bash
   cmd /c build.bat
   ```

## 📖 Usage

Run the executable to start the interactive scanner:

1. The tool will locate your `.gemini` directory and `Gemini.md` file.
2. It will display a preview of your current configuration.
3. Select **[ 1 ] Apply Fix** to patch your file with professional terminal standards.

## 🆘 Support on the Issue Tracker

This tool was created to provide a reliable terminal experience for **Antigravity** users on Windows. If this project helps you, please consider supporting its official implementation:

**👉 [Add a +1 to this Google Issue Tracker ticket](https://issuetracker.google.com/issues/487139128)**

> [!TIP]
> Adding a "+1" (upvoting) the issue helps Google prioritize native fixes for these terminal constraints.

## 🧪 Technical Details

GeminiFix enforces the following execution standards:

- All commands are wrapped with `cmd /c` for reliable execution.
- Ensures UTF-8 encoding support via `chcp 65001`.
- Enables command chaining with `&&` and `&`.

## 🤝 Contributing

Contributions are welcome! Please feel free to submit a Pull Request.

1. Fork the Project
2. Create your Feature Branch (`git checkout -b feature/AmazingFeature`)
3. Commit your Changes (`git commit -m 'Add some AmazingFeature'`)
4. Push to the Branch (`git push origin feature/AmazingFeature`)
5. Open a Pull Request

## 📄 License

Distributed under the MIT License. See `LICENSE` for more information.

---
*Built with ❤️ for the Gemini community.*
