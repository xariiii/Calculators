# 🧮 Kalkulator w Java + Swing
Graficzny kalkulator napisany w Java Swing, obsługujący podstawowe działania matematyczne, funkcje specjalne oraz historię obliczeń. Interfejs został zbudowany ręcznie przy użyciu komponentów Swing, z własną kolorystyką i układem.

## 📦 Wymagania

* Java 17+
* Kompilator javac
* Środowisko uruchomieniowe JRE/JDK
* Pliki źródłowe Calculator.java oraz CalculatorLogic.java

Sprawdzenie wersji:

```
java -version
```

## ▶️ Uruchomienie

Aby uruchomić kalkulator należy wpisać następujące komendy w terminalu
- Kompilacja:

``` 
javac Calculator.java
```
- Uruchomienie:
```
java Calculator
```

## ✨ Obsługiwane funkcje

* Dodawanie
* Odejmowanie 
* Mnożenie
* Dzielenie
* Pierwiastek kwadratowy
* Potęgowanie
* Odwrócenie liczby
* Obliczanie procent
* Zmiana znaku liczby
* Czyszczenie całego działania
* Usuwanie ostatniego znaku
* Czyszczenie ostatniego wpisu
* Obsługa błędów
* Historia

## 📄 Opis działania programu
1. Interfejs użytkownika (Swing):

Aplikacja tworzy okno JFrame z trzema głównymi sekcjami:

- Pole wyświetlacza (JTextField)

- Panel przycisków (JPanel + GridLayout)

- Panel historii (JTextArea + JScrollPane)

- Kolorystyka i styl przycisków są ustawione ręcznie.

2. Lista przycisków:

Przyciski są zdefiniowane w liście List<CalcButton>, co ułatwia ich generowanie i przypisywanie akcji.

3. Obsługa kliknięć:

Metoda handleButton(String val) odpowiada za:

- dopisywanie cyfr

- obsługę operatorów

- funkcje specjalne (sqrt, x², 1/x, %, +/-)

- usuwanie znaków

- wykonywanie obliczeń po naciśnięciu "="

- zapisywanie działań do historii

4. Logika obliczeń:

Program przechowuje:

- num1 — pierwszą liczbę

- operator — wybrany operator

- startNew — flagę informującą, czy rozpocząć nowe działanie

- Po naciśnięciu "=" wykonywane jest działanie i zapisywane do historii.

5. Historia obliczeń:

Panel po prawej stronie (JTextArea) wyświetla wszystkie wykonane działania w formacie:

```
5 + 3 = 8
9 / 3 = 3
```

## 🧪 Przykładowe działania

| Wejście | Wynik |
|---------|---------|
|   7+4   |    11   |
|   √16   |    4    |
|   8*4   |    32   |
