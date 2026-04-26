# 🧮 Kalkulator w C#

Prosty kalkulator napisany w C# z użyciem Windows Forms, umożliwiający wykonywanie podstawowych działań i funkcji dodatkowych.

## 📦 Wymagania

* Windows
* .NET Framework / .NET Windows Forms
* Visual Studio (lub inny edytor obsługujący WinForms)

## ▶️ Uruchomienie

1) Otwórz projekt w Visual Studio.
2) Uruchom aplikację przyciskiem Start.
3) Kalkulator otworzy się w oknie Windows Forms.

## ✨ Obsługiwane funkcje

### Funkcje podstawowe
* Dodawanie
* Odejmowanie 
* Mnożenie
* Dzielenie

### Funkcje dodatkowe
* Procenty
* Częściowe czyszczenie
* Pełne czyszczenie
* Usuwanie ostatniego znaku
* Odwrotność liczby
* Podnoszenie do kwadratu
* Pierwiastek kwadratowy
* Zmiana znaku
* Wpisywanie cyfr
* Obliczanie wyniku
* Historia działań

## 📄 Opis dzialania programu
```
Program przyjmuje cyfry i operacje z przycisków interfejsu.
Po wybraniu działania zapisuje pierwszą liczbę i czeka na drugą.
Po naciśnięciu przycisku równa się wykonuje obliczenie i wyświetla wynik.
Funkcje specjalne (pierwiastek, kwadrat, procenty itd.) działają natychmiast na aktualnej liczbie.
Wszystkie wykonane działania są zapisywane w historii.
CE czyści bieżący wpis, C czyści cały kalkulator, Backspace usuwa ostatni znak.
```

## 🧪 Przykładowe działania

| Wejście | Wynik |
|---------|---------|
|3*3|9|
|√9|3|
|20/4|5|
