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
    { label: ",", value: "." },
    { label: "=", value: "=" },
  ]

  const [equation, setEquation] = useState("")
  const [history, setHistory] = useState<string[]>([])
  const [showHistory, setShowHistory] = useState(false)

  const addToHistory = (entry: string) => {
    setHistory(prev => [...prev, entry])
  }

  const handleClick = (value: string) => {
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
        if (prev.startsWith("-")) return prev.slice(1)
        return "-" + prev
      })
      return
    }

    if (value === "=") {
      try {
        const result = evaluate(equation)
        addToHistory(`${equation} = ${result}`)
        setEquation(String(result))
      } catch {
        setEquation("Error")
      }
      return
    }

    if (value === "sqrt") {
      try {
        const result = evaluate(`sqrt(${equation})`)
        addToHistory(`√(${equation}) = ${result}`)
        setEquation(String(result))
      } catch {
        setEquation("Error")
      }
      return
    }

    if (value === "x^2") {
      try {
        const result = evaluate(`(${equation})^2`)
        addToHistory(`(${equation})² = ${result}`)
        setEquation(String(result))
      } catch {
        setEquation("Error")
      }
      return
    }

    if (value === "1/x") {
      try {
        const result = evaluate(`1/(${equation})`)
        addToHistory(`1/(${equation}) = ${result}`)
        setEquation(String(result))
      } catch {
        setEquation("Error")
      }
      return
    }

    setEquation(prev => prev + value)
  }

  return (
    <div className="h-screen w-screen bg-[url('/src/assets/background.jpg')] bg-cover bg-center flex items-center justify-center p-4">

      <div className="relative w-[350px] max-h-[700px] bg-white rounded-3xl shadow-2xl p-6 flex flex-col gap-6">

        {/* HISTORY BUTTON */}
        <button
          onClick={() => setShowHistory(!showHistory)}
          className="absolute top-3 right-3 bg-[#F5955F] text-white font-bold px-3 py-1 rounded-xl"
        >
          H
        </button>

        {/* INPUT */}
        <Input
          value={equation}
          readOnly
          className="text-right text-3xl font-bold text-[#525298] bg-[#F2F2F7] p-4 rounded-xl"
        />

        {/* HISTORY PANEL */}
        {showHistory && (
          <div className="bg-[#F2F2F7] text-[#525298] rounded-xl p-3 h-40 overflow-y-auto shadow-inner">
            {history.length === 0 && <p className="opacity-60">Brak historii</p>}
            {history.map((h, i) => (
              <p key={i} className="font-semibold">{h}</p>
            ))}
          </div>
        )}

        {/* BUTTONS */}
        <div className="grid grid-cols-4 gap-3">
          {buttons.map((btn, index) => {
            const isNumber = btn.value.match(/[0-9]/) || btn.value === "."
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
                  hover:opacity-80
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
