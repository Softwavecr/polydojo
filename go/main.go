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

	spiderMan, found := FindHeroByName(heroes, "Spider-Man")
	if found {
		fmt.Println(spiderMan)
	} else {
		fmt.Println("Spider-Man not found")
	}

}

//go run *.go.
//expected result
//{Hulk 90000}
//{Spider-Man 25000}
