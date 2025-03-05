package main

import (
	"fmt"
	"log"
)

func main() {
	fmt.Println("1- Print:  Hello, Heroes")
	heroes, err := LoadHeroes("data.json")
	if err != nil {
		log.Fatalf("Error loading heroes: %v", err)
	}

	hulk, found := FindFunc(heroes, "Hulk")
	if found {
		fmt.Println("2- Find:", hulk)
	} else {
		fmt.Println("Hulk not found")
	}

	names := MapFunc(heroes, AppendSymbol)
	fmt.Println("3- Map:", names)

	filterHeroes := FilterFunc(heroes, Strong)
	fmt.Println("4- Filter:", filterHeroes)
}

var AppendSymbol = func(hero Hero) string {
	return hero.Name + "!"
}

func Strong(hero Hero) bool {
	return hero.Strength >= 2000
}

//go run *.go.
//expected result
//{Hulk 90000}
//{Spider-Man 25000}
