# 🧮 Kalkulator Java Swing + MVC (Logic + UI)

Graficzny kalkulator desktopowy napisany w **Java Swing**, z rozdzieloną logiką (`CalculatorLogic`) oraz interfejsem użytkownika (`Calculator`).

Aplikacja obsługuje podstawowe i zaawansowane operacje matematyczne, historię działań, tryb głosowy (TTS) oraz tryb imprezowy 🎉.

---

## 🚀 Funkcje aplikacji

✔ podstawowe działania matematyczne  
✔ funkcje specjalne (√, x², 1/x, %)  
✔ zmiana znaku (+/-)  
✔ historia obliczeń  
✔ obsługa błędów  
✔ tryb głosowy (Text-to-Speech via PowerShell)  
✔ tryb imprezowy (kolorowe tło)  
✔ własna implementacja logiki kalkulatora  

---

## 📦 Wymagania

- Java 17+
- JDK (javac + java)
- IntelliJ IDEA (zalecane)
- Swing (wbudowany w Java SE)

Sprawdzenie wersji:

```bash
java -version
```

---

## ▶️ Uruchomienie projektu

### 1. Otwórz projekt

- IntelliJ IDEA → **File → Open → folder projektu**

### 2. Ustaw SDK

- File → Project Structure → Project SDK → Java 17+

### 3. Uruchom aplikację

- Otwórz `Calculator.java`
- Kliknij ▶ przy `main`
- Run

---

## 🧪 Uruchomienie testów

### 1. Otwórz projekt w IntelliJ

### 2. Uruchom testy logiki

- Znajdź: `CalculatorLogicTest.java`
- Kliknij ▶
- Run Tests

Testy obejmują:

- dodawanie
- odejmowanie
- mnożenie
- dzielenie
- sqrt
- x²
- 1/x
- procenty
- obsługę błędów

---

## 🧠 Architektura projektu

Projekt jest podzielony na 2 główne części:

### 🖥 Calculator (GUI)

Odpowiada za:

- interfejs Swing
- obsługę przycisków
- historię
- TTS
- tryb imprezowy

### ⚙ CalculatorLogic (logika)

Odpowiada za:
- operacje matematyczne
- walidację danych
- bezpieczeństwo obliczeń

---

## ✨ Funkcje matematyczne

- ➕ dodawanie
- ➖ odejmowanie
- ✖ mnożenie
- ➗ dzielenie
- √ pierwiastek
- x² potęgowanie
- 1/x odwrotność
- % procent

---

## 🗂 Historia działań

Aplikacja zapisuje wszystkie operacje w formacie:

```
5 + 3 = 8
9 / 3 = 3
```

Historia jest wyświetlana w panelu `JTextArea`.

---

## 🔊 Tryb głosowy (TTS)

- działa przez PowerShell + `System.Speech`
- czyta:
  - kliknięte przyciski
  - wyniki działań
  - zmiany trybów

Przykład:

```
5 + 3 → "pięć plus trzy"
wynik → "osiem"
```

---

## 🎉 Tryb imprezowy

- dynamiczna zmiana kolorów tła
- animacja Hue Rotate
- sterowanie `javax.swing.Timer`

---

## 🧩 Struktura projektu

```
Calculator.java        → GUI + obsługa UI + TTS + historia
CalculatorLogic.java   → logika matematyczna
CalculatorLogicTest    → testy jednostkowe
```

---

## 🧪 Przykładowe działania

| Wejście | Wynik |
|--------|------|
| 7 + 4 | 11 |
| 9 - 3 | 6 |
| 8 * 4 | 32 |
| √16 | 4 |
| 1 / 4 | 0.25 |
| 5 % | 0.05 |
| 5² | 25 |

---

## ⚠️ Obsługa błędów

Aplikacja zabezpiecza się przed:

- dzieleniem przez zero
- pierwiastkiem z liczby ujemnej
- niepoprawnym inputem

W przypadku błędu:

```
Error
```

---

## 🛠 Technologie

- Java 17
- Swing (GUI)
- AWT (grafika i eventy)
- PowerShell Speech API (TTS)
- JUnit (testy)
- OOP + separacja logiki

---

## 💡 Możliwe rozszerzenia

- zapis historii do pliku
- dark mode
- obsługa klawiatury
- tryb naukowy (sin, cos, tan)
- pamięć kalkulatora (M+, MR, MC)
- refactor do JavaFX

