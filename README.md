# Physics Simulation

A simple C# console program that simulates projectile motion under gravity.

## Description

This project calculates the trajectory of a projectile using basic kinematic equations.
It prompts the user for:

- initial speed (m/s)
- launch angle (degrees)
- time step (s)

The program then outputs the projectile's position, velocity, range, and flight time.

## Files

- `Physics code.cs` - main simulation source code.

## Requirements

- .NET SDK or a C# compiler

## Run

1. Open a terminal in the project folder.
2. Compile the program with:
   ```powershell
   csc "Physics code.cs"
   ```
3. Run the executable:
   ```powershell
   .\"Physics code.exe"
   ```

## Notes

- Gravity is set to `9.81 m/s^2`.
- The simulation updates position and velocity using a simple fixed time step.

## Author

Written and developed by Gorb/Gorlubian.
