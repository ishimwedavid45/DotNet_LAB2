# C# (.NET) Lab 2 - Desktop Application (Windows Forms)

This repository contains the Windows Forms implementation of **Lab 2** for C# (.NET), porting the Bicycle Rental and Mushroom Identifier console programs into a multi-form desktop application.

## Application Architecture & Flow
```
Login Form ──(Valid Login)──> Choose Form
                                 ├──> Bicycle Form (Rental Calculator)
                                 │       ├── Back: Return to Choose Form
                                 │       └── Logout: Return to Login Form
                                 │
                                 └──> Mushroom Form (Mushroom Identifier)
                                         ├── Back: Return to Choose Form
                                         └── Logout: Return to Login Form
```

## Features
- **Login Form**: Validates that Username and Password fields are not empty before proceeding.
- **Choose Form**: Navigation hub providing access to the Bicycle Rental and Mushroom Identifier screens.
- **Bicycle Form**:
  - Validates user input (0–23 for starting hour, 1–24 for ending hour, starting < ending).
  - Calculates rental costs:
    - 00:00–07:00 & 21:00–24:00: 500 RWF / hour
    - 07:00–14:00 & 19:00–21:00: 1000 RWF / hour
    - 14:00–19:00: 1500 RWF / hour
  - Displays total cost in a read-only TextBox and via MessageBox.
- **Mushroom Form**:
  - Asks at most 3 questions using interactive Yes/No dialogs.
  - Accurately determines all 6 mushroom species:
    - Agaric Jaunissant
    - Amanite tue-mouche
    - Cepe de bordeaux
    - Coprin chevelu
    - Girolle
    - Pied bleu
- **Navigation**:
  - **Back**: Returns to the Choose form.
  - **Logout**: Returns to the Login form.

## Built With
- C# (.NET Framework 4.7.2)
- Windows Forms (System.Windows.Forms)
- Visual Studio
