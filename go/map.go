package main

func MapFunc[T, TResult any](list []T, funcVal func(T) TResult) []TResult {
	result := make([]TResult, len(list))
	for i, item := range list {
		result[i] = funcVal(item)
	}
	return result
}
