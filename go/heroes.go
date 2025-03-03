package main

import (
        "encoding/json"
        "os"
)

// Hero struct to represent a hero
type Hero struct {
        Name     string `json:"name"`
        Strength int    `json:"strength"`
}

// LoadHeroes reads heroes data from a JSON file.
func LoadHeroes(filename string) ([]Hero, error) {
        data, err := os.ReadFile(filename)
        if err != nil {
                return nil, err
        }

        var heroes []Hero
        err = json.Unmarshal(data, &heroes)
        if err != nil {
                return nil, err
        }

        return heroes, nil
}