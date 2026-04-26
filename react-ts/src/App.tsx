import { Button } from "@/components/ui/button"
import { Input } from "@/components/ui/input"
import { evaluate } from "mathjs"
import { useState } from "react"

function App() {

  const buttons = [
    { label: "%", value: "%" },
    { label: "CE", value: "CE" },
    { label: "C", value: "C" },
    { label: "DEL", value: "DEL" },

    { label: "1/x", value: "1/x" },
    { label: "x²", value: "x^2" },
    { label: "√x", value: "sqrt" },
    { label: "/", value: "/" },

    { label: "7", value: "7" },
    { label: "8", value: "8" },
    { label: "9", value: "9" },
    { label: "x", value: "*" },

    { label: "4", value: "4" },
    { label: "5", value: "5" },
    { label: "6", value: "6" },
    { label: "-", value: "-" },

    { label: "1", value: "1" },
    { label: "2", value: "2" },
    { label: "3", value: "3" },
    { label: "+", value: "+" },

    { label: "+/-", value: "+/-" },
    { label: "0", value: "0" },
    { label: ".", value: "." },
    { label: "=", value: "=" },
  ]

  const [equation, setEquation] = useState("")
  const [history, setHistory] = useState<string[]>([])
  const [showHistory, setShowHistory] = useState(false)

  const [tts, setTts] = useState(false)
  const [party, setParty] = useState(false)

  const addToHistory = (entry: string) => {
    setHistory(prev => [...prev, entry])
  }

  const clean = (num: number) => parseFloat(num.toFixed(6))
  const format = (num: number) => num.toLocaleString("pl-PL")

  // 🔊 CZYTANIE CYFR PO KOLEI (jak w Javie)
  const speak = (text: string) => {
    if (!tts) return

    const map: Record<string, string> = {
      "+": "plus",
      "-": "minus",
      "*": "razy",
      "/": "podzielone przez",
      ".": "przecinek",
      ",": "przecinek",
      "%": "procent",
      "C": "czyść",
      "CE": "czyść ostatnie",
      "DEL": "usuń"
    }

    // liczby → czytaj cyframi
    if (/^[0-9.,]+$/.test(text)) {
      const spoken = text
        .replace(",", ".")
        .split("")
        .map(ch => map[ch] ?? ch)
        .join(" ")

      speechSynthesis.cancel()
      speechSynthesis.speak(new SpeechSynthesisUtterance(spoken))
      return
    }

    const spoken = map[text] ?? text
    speechSynthesis.cancel()
    speechSynthesis.speak(new SpeechSynthesisUtterance(spoken))
  }

  const speakResult = (prefix: string, result: string) => {
    if (!tts) return

    const digits = result
      .replace(",", ".")
      .split("")
      .map(ch => (ch === "." ? "przecinek" : ch))
      .join(" ")

    const text = `${prefix} wynik ${digits}`

    speechSynthesis.cancel()
    speechSynthesis.speak(new SpeechSynthesisUtterance(text))
  }

  const speakToggle = (feature: string, state: boolean) => {
    if (!tts) return
    const text = `${feature} ${state ? "włączony" : "wyłączony"}`
    speechSynthesis.cancel()
    speechSynthesis.speak(new SpeechSynthesisUtterance(text))
  }

  const handleClick = (value: string) => {

    // C / CE / DEL mówią teraz poprawnie
    if (value === "C") {
      speak("C")
      setEquation("")
      return
    }

    if (value === "CE") {
      speak("CE")
      setEquation(prev => prev.replace(/([0-9.]+|\D+)$/, ""))
      return
    }

    if (value === "DEL") {
      speak("DEL")
      setEquation(prev => prev.slice(0, -1))
      return
    }

    if (value === "+/-") {
      if (!equation) return

      const wasNegative = equation.startsWith("-")
      const newValue = wasNegative ? equation.slice(1) : "-" + equation

      const spoken = wasNegative
        ? `zmiana znaku, ${newValue}`
        : `zmiana znaku, minus ${equation}`

      speak(spoken)
      setEquation(newValue)
      return
    }


    // % — działa jak w Windows Calculator
    if (value === "%") {
      if (!equation) return
      try {
        const num = evaluate(equation)
        const result = clean(num / 100)
        speakResult("procent z", String(result))
        setEquation(format(result))
        addToHistory(`${equation}% = ${result}`)
      } catch {
        speak("wystąpił błąd")
        setEquation("Error")
      }
      return
    }

    // sqrt / x^2 / 1/x
    if (value === "sqrt" || value === "x^2" || value === "1/x") {
      if (!equation) return

      try {
        const num = evaluate(equation)
        let result = 0

        if (value === "sqrt") {
          result = Math.sqrt(num)
          speakResult(`pierwiastek z ${num} to`, String(clean(result)))
        }

        if (value === "x^2") {
          result = num * num
          speakResult(`${num} do kwadratu to`, String(clean(result)))
        }

        if (value === "1/x") {
          result = 1 / num
          speakResult(`odwrotność ${num} to`, String(clean(result)))
        }

        result = clean(result)
        setEquation(format(result))
        addToHistory(`${equation} → ${result}`)

      } catch {
        speak("wystąpił błąd")
        setEquation("Error")
      }

      return
    }

    // normalne kliknięcia
    if (value !== "=") {
      speak(value)
      setEquation(prev => prev + value)
      return
    }

    // wynik
    try {
      let result = evaluate(equation)
      result = clean(result)

      addToHistory(`${equation} = ${result}`)
      setEquation(format(result))

      speakResult("", String(result))

    } catch {
      speak("wystąpił błąd")
      setEquation("Error")
    }
  }

  return (
    <div className={`h-screen w-screen bg-[url('/src/assets/background.jpg')] bg-cover flex items-center justify-center p-4
      ${party ? "animate-[party_3s_linear_infinite]" : ""}`}>

      <style>
        {`
        @keyframes party {
          0% { filter: hue-rotate(0deg) brightness(1); }
          50% { filter: hue-rotate(180deg) brightness(1.2); }
          100% { filter: hue-rotate(360deg) brightness(1); }
        }
        `}
      </style>

      <div className="relative w-[350px] bg-white rounded-3xl shadow-2xl p-6 flex flex-col gap-4">

        {/* TOP BAR */}
        <div className="flex justify-between">

          <div className="flex gap-2">
            <button
              onClick={() => {
                setTts(p => {
                  speakToggle("tryb mówienia", !p)
                  return !p
                })
              }}
              className={`px-3 py-1 rounded-xl text-sm text-white ${tts ? "bg-[#525298]" : "bg-gray-400"}`}
            >
              🔊
            </button>

            <button
              onClick={() => {
                setParty(p => {
                  speakToggle("tryb imprezowy", !p)
                  return !p
                })
              }}
              className={`px-3 py-1 rounded-xl text-sm text-white ${party ? "bg-[#F5955F]" : "bg-gray-400"}`}
            >
              🎉
            </button>
          </div>

          <button
            onClick={() => {
              setShowHistory(p => {
                speakToggle("historia", !p)
                return !p
              })
            }}
            className="bg-[#F5955F] text-white px-3 py-1 rounded-xl text-sm"
          >
            H
          </button>
        </div>

        {/* INPUT */}
        <div className="overflow-x-auto whitespace-nowrap">
          <Input
            value={equation}
            readOnly
            className="text-right text-3xl font-bold text-[#525298] bg-[#F2F2F7] p-4 rounded-xl"
          />
        </div>

        {/* HISTORY */}
        {showHistory && (
          <div className="bg-[#F2F2F7] text-[#525298] rounded-xl p-3 h-40 overflow-y-auto">
            {history.map((h, i) => <p key={i}>{h}</p>)}
          </div>
        )}

        {/* BUTTONS */}
        <div className="grid grid-cols-4 gap-3">
          {buttons.map((btn, index) => {
            const isNumber = /[0-9.]/.test(btn.value)
            const isOrange = ["CE", "C", "DEL", "="].includes(btn.value)
            const isPurple = ["1/x", "x^2", "sqrt", "/", "*", "-", "+", "%", "+/-"].includes(btn.value)

            return (
              <Button
                key={index}
                onClick={() => handleClick(btn.value)}
                className={`
                  text-xl font-bold rounded-2xl h-16
                  ${isNumber && !isOrange ? "bg-[#F2F2F7] text-[#525298]" : ""}
                  ${isOrange ? "bg-[#F5955F] text-white" : ""}
                  ${isPurple ? "bg-[#525298] text-white" : ""}
                  active:scale-95 transition
                `}
              >
                {btn.label}
              </Button>
            )
          })}
        </div>

      </div>
    </div>
  )
}

export default App
