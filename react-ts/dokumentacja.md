# 🧮 Kalkulator React + TypeScript + Vite + Tailwind

Nowoczesny kalkulator webowy z dodatkowymi funkcjami (TTS, historia działań, tryb imprezowy), napisany w **React + TypeScript + Vite**.

---

## 🚀 Demo funkcji

✔ podstawowe działania matematyczne  
✔ funkcje zaawansowane (√, x², 1/x, %)  
✔ historia działań  
✔ tryb głosowy (Text-to-Speech)  
✔ tryb „party mode” 🎉  
✔ obsługa błędów  
✔ testy jednostkowe (Jest + Testing Library)

---

## 📦 Wymagania

- Node.js 16+
- npm
- React + Vite
- TypeScript
- mathjs
- Tailwind CSS
- @testing-library/react + jest-dom

---

## ▶️ Instalacja i uruchomienie

### 1. Przejdź do folderu projektu
```bash
cd react-ts
```

### 2. Instalacja zależności
```bash
npm install
```

### 3. Uruchom aplikację
```bash
npm run dev
```

---

## 🧪 Testy

### Uruchom testy jednostkowe:
```bash
npm test
```

Testy obejmują m.in.:
- działania matematyczne (+, -, ×, ÷)
- funkcje specjalne (√, x², 1/x, %)
- czyszczenie (C, CE, DEL)
- obsługę błędów
- formatowanie wejścia

---

## ✨ Funkcje aplikacji

### 🔢 Operacje matematyczne
- dodawanie
- odejmowanie
- mnożenie
- dzielenie
- procenty
- pierwiastkowanie
- potęgowanie
- odwrotność liczby (1/x)
- zmiana znaku (+/-)

---

### 🧠 Logika działania
- silnik obliczeń: **mathjs**
- obsługa całych wyrażeń (np. `2+3*4`)
- automatyczne formatowanie wyników
- zabezpieczenie przed błędami (try/catch)

---

### 🗂 Historia działań
- zapisywanie każdego działania
- możliwość podglądu historii
- przechowywanie w stanie React (`useState`)

---

### 🔊 Tryb głosowy (TTS)
- odczytywanie kliknięć
- czytanie wyników
- obsługa liczb cyfrowo
- komunikaty systemowe (C, CE, DEL)

---

### 🎉 Tryb imprezowy
- dynamiczny efekt kolorów (hue-rotate animation)
- zmiana wyglądu UI

---

## 🧩 Struktura aplikacji

### 1. Przyciski
Wszystkie przyciski generowane są dynamicznie z tablicy `buttons`.

### 2. Wyświetlacz
Pole input (readonly) pokazuje aktualne działanie lub wynik.

### 3. Obsługa kliknięć
Funkcja `handleClick()`:
- buduje wyrażenie
- obsługuje funkcje specjalne
- wykonuje obliczenia (`evaluate`)
- obsługuje błędy

---

## 🧪 Przykłady działań

| Wyrażenie | Wynik |
|----------|------|
| 7 + 8 | 15 |
| 9 √x | 3 |
| 5 x² | 25 |
| 8 / 2 | 4 |
| 1 / 4 | 0.25 |
| 2 + 3 × 4 | 14 |

---

## 🛠 Technologie

- React
- TypeScript
- Vite
- Tailwind CSS
- mathjs
- Web Speech API
- Jest + Testing Library

---

## 📌 Możliwe rozszerzenia

- tryb naukowy (sin, cos, tan)
- pamięć kalkulatora (M+, M-, MR)
- LocalStorage dla historii
- dark mode
- obsługa klawiatury