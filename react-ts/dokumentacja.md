# 🧮 Kalkulator w React + Vite + TypeScript + Tailwind
Prosty kalkulator napisany w Typescript, umożliwiający wykonywanie podstawowych działań arytmetycznych

## 📦 Wymagania

* Node.js 16+
* npm
* React + Vite
* Biblioteka mathjs
* Komponenty UI (Button, Input)
* Plik tła background.jpg

Sprawdzenie wersji:

```
node -v
```

## ▶️ Uruchomienie

### Aby uruchomić kalkulator należy wpisać następujące komendy w terminalu
- Przejdz do folderu react-ts:

``` 
cd react-ts
```
- Zainstaluj zależności:
```
npm install
```
- Uruchom projekt:
``` 
npm run dev
```

### Aby uruchomić test należy wpisać następujące komendy w terminalu

- Przejdz do folderu react-ts:

``` 
cd react-ts
```
- Zainstaluj zależności:
```
npm install
```
- Uruchom test:
``` 
npm test
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

## 📄 Opis dzialania programu

1. Generowanie przycisków: 

Wszystkie przyciski są zdefiniowane w tablicy buttons, co ułatwia ich renderowanie i zarządzanie.

2. Wyświetlacz:

Komponent Input pokazuje aktualne działanie lub wynik. Pole jest tylko do odczytu.

3. Obsługa kliknięć (handleClick):

Funkcja interpretuje kliknięcia i wykonuje odpowiednie akcje:

+ modyfikacja równania:


+ wywołanie evaluate() z mathjs

+ obsługa funkcji specjalnych (sqrt, x², 1/x, +/-)

+ obsługa błędów

4. Logika obliczeń:

Wszystkie działania matematyczne są wykonywane przez bibliotekę mathjs, co zapewnia poprawność i bezpieczeństwo obliczeń.

5. Interfejs użytkownika:

Kalkulator jest zbudowany z siatki 4×N przycisków, stylizowanych za pomocą Tailwind CSS.
Tło aplikacji jest ustawione poprzez background.jpg.

## 🧪 Przykładowe działania

| Wejście | Wynik |
|---------|---------|
|   7+8   |    15   |
|    √9   |    3    |
|   1/4   |   0.25  |