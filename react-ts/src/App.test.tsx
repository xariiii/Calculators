import { render, screen, fireEvent } from "@testing-library/react"
import "@testing-library/jest-dom"
import App from "./App"

const click = (label: string) => {
  fireEvent.click(screen.getByText(label))
}

const getDisplay = () => screen.getByRole("textbox")

describe("Calculator App", () => {
  test("renders all buttons", () => {
    render(<App />)
    const labels = ["1","2","3","4","5","6","7","8","9","0","+","-","x","/","=","C","CE","DEL","+/-","√x","x²","1/x",",","%"]
    labels.forEach(label => {
      expect(screen.getByText(label)).toBeInTheDocument()
    })
  })

  test("basic addition: 1 + 2 = 3", () => {
    render(<App />)
    click("1")
    click("+")
    click("2")
    click("=")
    expect(getDisplay()).toHaveValue("3")
  })

  test("subtraction: 9 - 4 = 5", () => {
    render(<App />)
    click("9")
    click("-")
    click("4")
    click("=")
    expect(getDisplay()).toHaveValue("5")
  })

  test("multiplication: 7 x 8 = 56", () => {
    render(<App />)
    click("7")
    click("x")
    click("8")
    click("=")
    expect(getDisplay()).toHaveValue("56")
  })

  test("division: 8 / 2 = 4", () => {
    render(<App />)
    click("8")
    click("/")
    click("2")
    click("=")
    expect(getDisplay()).toHaveValue("4")
  })

  test("DEL removes last character", () => {
    render(<App />)
    click("9")
    click("8")
    click("DEL")
    expect(getDisplay()).toHaveValue("9")
  })

  test("C clears everything", () => {
    render(<App />)
    click("7")
    click("C")
    expect(getDisplay()).toHaveValue("")
  })

  test("CE clears last entry", () => {
    render(<App />)
    click("7")
    click("+")
    click("8")
    click("CE")
    expect(getDisplay()).toHaveValue("7+")
  })

  test("+/- toggles sign", () => {
    render(<App />)
    click("5")
    click("+/-")
    expect(getDisplay()).toHaveValue("-5")
    click("+/-")
    expect(getDisplay()).toHaveValue("5")
  })

  test("square root", () => {
    render(<App />)
    click("9")
    click("√x")
    expect(getDisplay()).toHaveValue("3")
  })

  test("square x²", () => {
    render(<App />)
    click("5")
    click("x²")
    expect(getDisplay()).toHaveValue("25")
  })

  test("1/x", () => {
    render(<App />)
    click("4")
    click("1/x")
    expect(getDisplay()).toHaveValue("0.25")
  })

  test("decimal input", () => {
    render(<App />)
    click("1")
    click(",")
    click("5")
    expect(getDisplay()).toHaveValue("1.5")
  })

  test("handles invalid expression", () => {
    render(<App />)
    click("+")
    click("=")
    expect(getDisplay()).toHaveValue("Error")
  })

  test("chained operations: 2 + 3 x 4 = 14", () => {
    render(<App />)
    click("2")
    click("+")
    click("3")
    click("x")
    click("4")
    click("=")
    expect(getDisplay()).toHaveValue("14")
  })
})
