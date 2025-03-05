package main

import (
	"fmt"
	"log"
)

func main() {
	heroes, err := LoadHeroes("data.json")
	if err != nil {
		log.Fatalf("Error loading heroes: %v", err)
	}

	hulk, found := FindHeroByName(heroes, "Hulk")
	if found {
		fmt.Println(hulk)
	} else {
		fmt.Println("Hulk not found")
	}

	filterHeroes := Filter(heroes, Strong)
	fmt.Println("Filtered Heroes:", filterHeroes)
}

func Strong(hero Hero) bool {
	return hero.Strength >= 2000
}

//go run *.go.
//expected result
//{Hulk 90000}
//{Spider-Man 25000}
