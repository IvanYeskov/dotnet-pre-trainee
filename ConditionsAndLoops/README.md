# Number Analyzer & Arithmetic Calculator

A console-based C# utility that validates numbers, analyzes their mathematical properties (sign, primality), and executes basic arithmetic operations.

---

## Features

- **Input Validation:** Safely parses input strings into 32-bit signed integers using `int.TryParse`.
- **Sign Detection:** Identifies whether a value is positive, negative, or zero using ternary expressions.
- **Primality Test:** Checks whether the input is prime or composite in $O(\sqrt{n})$ time complexity.
- **Arithmetic Engine:** Supports basic arithmetic operations (`+`, `-`, `*`, `/`, `%`) with built-in zero-division checks.
- **Interactive Execution Loop:** Runs continuously until explicitly terminated by the user (`y/n`).

---

## Supported Operations

| Operator | Operation | Note |
| :---: | :--- | :--- |
| `+` | Addition | $a + b$ |
| `-` | Subtraction | $a - b$ |
| `*` | Multiplication | $a \times b$ |
| `/` | Integer Division | Truncates towards zero; guarded against zero division |
| `%` | Modulo (Remainder) | Returns remainder; guarded against zero division |

---

## Getting Started

### Prerequisites

- [.NET 6.0 SDK](https://dotnet.microsoft.com/download) or higher installed on your system.

### Installation & Run

1. Clone or download this repository:
   ```bash
   git clone [https://github.com/your-username/number-analyzer.git](https://github.com/your-username/number-analyzer.git)
   cd number-analyzer