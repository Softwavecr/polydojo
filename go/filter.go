package main

func Filter[T any](list []T, predicate func(T) bool) []T {
	var result []T
	for _, item := range list {
		if predicate(item) {
			result = append(result, item)
		}
	}
	return result
}
