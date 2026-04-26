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

  // 🔊 FIXED REAL-TIME TTS
  const speak = (input: string, mode: "input" | "result" = "input") => {
    if (!tts) return

    const map: Record<string, string> = {
      "+": "plus",
      "-": "minus",
      "*": "razy",
      "/": "podzielone przez",
      ".": "przecinek",
      "=": "równa się"
    }

    let text = map[input] ?? input

    // ❗ result mode = tylko wynik, bez powtórek
    if (mode === "result") {
      text = "wynik " + input
    }

    speechSynthesis.cancel()
    speechSynthesis.speak(new SpeechSynthesisUtterance(text))
  }

  const handleClick = (value: string) => {

    // C / DEL / CE NIE MÓWIĄ NIC (ważne UX fix)
    if (value === "C") {
      setEquation("")
      return
    }

    if (value === "CE") {
      setEquation(prev => prev.replace(/([0-9.]+|\D+)$/, ""))
      return
    }

    if (value === "DEL") {
      setEquation(prev => prev.slice(0, -1))
      return
    }

    if (value === "+/-") {
      setEquation(prev => {
        if (!prev) return prev
        return prev.startsWith("-") ? prev.slice(1) : "-" + prev
      })
      return
    }

    // 🔢 REAL-TIME INPUT
    if (value !== "=") {
      setEquation(prev => {
        const next = prev + value
        speak(value, "input")   // <- LIVE FIX
        return next
      })
      return
    }

    // 🟰 RESULT (ONLY ONCE)
    try {
      let result = evaluate(equation)
      result = clean(result)

      addToHistory(`${equation} = ${result}`)
      setEquation(format(result))

      speak(String(result), "result") // <- FIXED (no duplication)

    } catch {
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
              onClick={() => setTts(p => !p)}
              className={`px-3 py-1 rounded-xl text-sm text-white ${tts ? "bg-[#525298]" : "bg-gray-400"}`}
            >
              🔊
            </button>

            <button
              onClick={() => setParty(p => !p)}
              className={`px-3 py-1 rounded-xl text-sm text-white ${party ? "bg-[#F5955F]" : "bg-gray-400"}`}
            >
              🎉
            </button>
          </div>

          <button
            onClick={() => setShowHistory(p => !p)}
            className="bg-[#F5955F] text-white px-3 py-1 rounded-xl text-sm"
          >
            H
          </button>
        </div>

        {/* INPUT */}
        <Input
          value={equation}
          readOnly
          className="text-right text-3xl font-bold text-[#525298] bg-[#F2F2F7] p-4 rounded-xl"
        />

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
            const isPurple = ["1/x", "x^2", "sqrt", "/", "*", "-", "+"].includes(btn.value)

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