import { Button } from "@/components/ui/button"
import { Input } from "@/components/ui/input"
import { evaluate } from "mathjs"
import { useState } from "react"

function App() {
  const buttons = [
    {label: "%", value:"%"},
    {label: "CE", value:"CE"},
    {label: "C", value:"C"},
    {label: "DEL", value:"DEL"},

    {label: "1/x", value:"1/x"},
    {label: "x²", value:"x^2"},
    {label: "√x", value:"sqrt"},
    {label: "/", value:"/"},

    {label: "7", value:"7"},
    {label: "8", value:"8"},
    {label: "9", value:"9"},
    {label: "x", value:"*"},

    {label: "4", value:"4"},
    {label: "5", value:"5"},
    {label: "6", value:"6"},
    {label: "-", value:"-"},

    {label: "1", value:"1"},
    {label: "2", value:"2"},
    {label: "3", value:"3"},
    {label: "+", value:"+"},

    {label: "+/-", value:"+/-"},
    {label: "0", value:"0"},
    {label: ",", value:"."},
    {label: "=", value:"="},
  ]

  const [equation, setEquation] = useState("")

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
        setEquation(String(result))
      } catch {
        setEquation("Error")
      }
      return
    }

    if (value === "sqrt") {
      try {
        const result = evaluate(`sqrt(${equation})`)
        setEquation(String(result))
      } catch {
        setEquation("Error")
      }
      return
    }

    if (value === "x^2") {
      try {
        const result = evaluate(`(${equation})^2`)
        setEquation(String(result))
      } catch {
        setEquation("Error")
      }
      return
    }

    if (value === "1/x") {
      try {
        const result = evaluate(`1/(${equation})`)
        setEquation(String(result))
      } catch {
        setEquation("Error")
      }
      return
    }

    setEquation(prev => prev + value)
  }

  return (
    <div className="h-screen w-screen bg-[url('/src/assets/background.jpg')] bg-cover bg-center">
      <div className="flex items-center justify-center h-screen">
        <div className="h-screen w-1/3 bg-gray-800 rounded-3xl">
          <div className="flex flex-col justify-center items-center gap-6 m-6">
            <Input
              value={equation}
              readOnly
              className="text-right text-xl"
            />
            <div className="grid grid-cols-4 gap-2">
              {buttons.map((btn, index) => (
                <Button
                  key={index}
                  onClick={() => handleClick(btn.value)}
                  className="bg-gray-700 text-white text-xl p-14 m-2 rounded-3xl hover:bg-gray-400"
                >
                  {btn.label}
                </Button>
              ))}
            </div>
          </div>
        </div>
      </div>
    </div>
  )
}

export default App
