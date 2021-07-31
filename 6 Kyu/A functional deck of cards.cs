using System.Linq;

private static readonly string[] CardNumbers = {"ace", "two", "three", "four", "five", "six", "seven", "eight", "nine", "ten", "jack", "queen", "king"};
private static readonly string[] CardSuits = { "hearts", "diamonds", "clubs", "spades" };

public static string[] BuildDeck() =>
	CardSuits.SelectMany(suit => CardNumbers, (suit, number) => $"{number} of {suit}").ToArray();