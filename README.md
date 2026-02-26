# Bulls and Cows – C# Console Game

A console-based implementation of the classic *Bulls & Cows* number guessing game.

This project focuses on clean structure, validation logic, and separation of responsibilities in a small-scale C# application.

---

## Overview

The game generates a random 4-digit number with unique digits.  
The player attempts to guess the number, receiving feedback in terms of:

- **Bulls** – correct digit in the correct position
- **Cows** – correct digit in the wrong position

The game continues until the correct number is guessed.

---

## Project Structure

The project is intentionally structured into logical components:

- `SecretGenerator` – Generates the hidden number
- `GuessValidator` – Handles input validation rules
- `GuessResult` – Encapsulates evaluation result (bulls & cows)
- `RoundController` – Coordinates game flow
- `Program` – Entry point

This structure keeps domain logic separate from control flow.

---

## Key Concepts Practiced

- Separation of responsibilities
- State vs control flow distinction
- Input validation pipeline
- Deterministic evaluation logic
- Basic modular design in C#

---

## How to Run

### Option 1 – Using .NET CLI

```bash
dotnet run
