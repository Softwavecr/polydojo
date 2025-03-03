package main

// FindHeroByName finds a hero by their name.
func FindHeroByName(heroes []Hero, name string) (Hero, bool) {
	for _, hero := range heroes {
		if hero.Name == name {
			return hero, true
		}
	}
	return Hero{}, false // Return an empty Hero and false if not found
}
