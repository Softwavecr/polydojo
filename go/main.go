package main

import (
	"fmt"
	"log"
)

func main() {
	fmt.Println("1- Hello, Heroes")
	heroes, err := LoadHeroes("data.json")
	if err != nil {
		log.Fatalf("Error loading heroes: %v", err)
	}

	hulk, found := FindHeroByName(heroes, "Hulk")
	if found {
		fmt.Println("2- Find:", hulk)
	} else {
		fmt.Println("Hulk not found")
	}

	filterHeroes := Filter(heroes, Strong)
	fmt.Println("4- Filter:", filterHeroes)
}

func Strong(hero Hero) bool {
	return hero.Strength >= 2000
}

//go run *.go.
//expected result
//{Hulk 90000}
//{Spider-Man 25000}
