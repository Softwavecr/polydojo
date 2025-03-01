package main

import (
	"encoding/json"
	"fmt"
	"log"
)

// Hero represents the structure of a hero object.
type Hero struct {
	Name     string `json:"name"`
	Strength int    `json:"strength"`
}

func main() {
	// Define the heroes data as a JSON string.
	heroesJSON := `[
                {"name": "Hulk", "strength": 90000},
                {"name": "Spider-Man", "strength": 25000},
                {"name": "Hawk Eye", "strength": 136},
                {"name": "Thor", "strength": 100000},
                {"name": "Black Widow", "strength": 136},
                {"name": "Vision", "strength": 5000},
                {"name": "Scarlet Witch", "strength": 60},
                {"name": "Mystique", "strength": 120},
                {"name": "Namora", "strength": 75000},
                {"name": "Captain America", "strength": 362},
                {"name": "Deadpool", "strength": 1814},
                {"name": "Black Panther", "strength": 1814}
        ]`

	// Unmarshal the JSON string into a slice of Hero structs.
	var heroes []Hero
	err := json.Unmarshal([]byte(heroesJSON), &heroes)
	if err != nil {
		log.Fatalf("Error unmarshaling JSON: %v", err)
	}

	// Find the Hulk using a loop.
	var hulk *Hero // Use a pointer to handle the case where Hulk is not found
	for i := range heroes {
		if heroes[i].Name == "Hulk" {
			hulk = &heroes[i]
			break // Exit the loop when Hulk is found
		}
	}

	// Print the result.
	if hulk != nil {
		fmt.Println(hulk)
	} else {
		fmt.Println("Hulk not found")
	}
}

// execute in bash
//go run find.go
//expected result
//&{Hulk 90000}
