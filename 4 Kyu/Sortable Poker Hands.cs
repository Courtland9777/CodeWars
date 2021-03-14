using System;
using System.Collections.Generic;
using System.Linq;

public class Card
{
    public int Value { get; }
    public int Suit { get; }

    public Card(int value, int suit)
    {
        Value = value;
        Suit = suit;
    }
}

public class PokerHand : IComparable
{
    public readonly string pokerHand;
    private Card[] HandOfCards { get; }
    public int HandValue { get; }
    public static int StraightFlush = 8000000; 
    public static int FourOfAKind = 7000000; 
    public static int FullHouse = 6000000; 
    public static int Flush = 5000000;
    public static int Straight = 4000000;
    public static int Set = 3000000;
    public static int TwoPair = 2000000;
    public static int OnePair = 1000000;

    public PokerHand(string hand)
    {
        pokerHand = hand;
        HandOfCards = GetCardInHand(pokerHand);
        HandValue = ValueHand(HandOfCards);
    }

    int IComparable.CompareTo(object obj)
    {
        PokerHand c = (PokerHand)obj;
        if (obj == null) return 0;
       
        return c.HandValue.CompareTo(this.HandValue);
    }

    public static int ValueHand(Card[] hand)
    {
        if (IsFlush(hand) && IsStraight(hand))
            return ValueStraightFlush(hand);
        else if (Is4s(hand))
            return ValueFourOfAKind(hand);
        else if (IsFullHouse(hand))
            return ValueFullHouse(hand);
        else if (IsFlush(hand))
            return ValueFlush(hand);
        else if (IsStraight(hand))
            return ValueStraight(hand);
        else if (Is3s(hand))
            return ValueSet(hand);
        else if (Is22s(hand))
            return ValueTwoPairs(hand);
        else if (Is2s(hand))
            return ValueOnePair(hand);
        else
            return ValueHighCard(hand);
    }

    public static int ValueStraightFlush(Card[] hand)
    {
        return StraightFlush + ValueHighCard(hand);
    }

    public static int ValueFlush(Card[] hand)
    {
        return Flush + ValueHighCard(hand);
    }

    public static int ValueStraight(Card[] hand)
    {
        return Straight + ValueHighCard(hand);
    }

    public static int ValueFourOfAKind(Card[] hand)
    {
        hand = hand.OrderBy(c => c.Value).ToArray();
        return FourOfAKind + ValueHighCard(hand);
    }

    public static int ValueFullHouse(Card[] hand)
    {
        hand = hand.OrderBy(c => c.Value).ToArray();
        return FullHouse + ValueHighCard(hand);
    }

    public static int ValueSet(Card[] hand)
    {
        hand = hand.OrderBy(c => c.Value).ToArray();
        return Set + ValueHighCard(hand);
    }

    public static int ValueTwoPairs(Card[] hand)
    {
        int val = 0;
        hand = hand.OrderBy(c => c.Value).ToArray();

        if (hand[0].Value == hand[1].Value && hand[2].Value == hand[3].Value)
        {
            val = (14 * 14 * hand[2].Value) + (14 * hand[0].Value) + hand[4].Value;
        }
        else if (hand[0].Value == hand[1].Value && hand[3].Value == hand[4].Value)
        {
            val = (14 * 14 * hand[3].Value) + (14 * hand[0].Value) + hand[2].Value;
        }
        else
        {
            val = (14 * 14 * hand[3].Value) + (14 * hand[1].Value) + hand[0].Value;
        }

        return TwoPair + val + ValueHighCard(hand);
    }

    public static int ValueOnePair(Card[] hand)
    {
        int val = 0;

        hand = hand.OrderBy(c => c.Value).ToArray();

        if (hand[0].Value == hand[1].Value)
        {
            val = (14 * 14 * 14 * hand[0].Value) + hand[2].Value + (14 * hand[3].Value) + (14 * 14 * hand[4].Value);
        }
        else if (hand[1].Value == hand[2].Value)
        {
            val = (14 * 14 * 14 * hand[1].Value) + hand[0].Value + (14 * hand[3].Value) + (14 * 14 * hand[4].Value);
        }
        else if (hand[2].Value == hand[3].Value)
        {
            val = (14 * 14 * 14 * hand[2].Value) + hand[0].Value + (14 * hand[1].Value) + (14 * 14 * hand[4].Value);
        }
        else
        {
            val = (14 * 14 * 14 * hand[3].Value) + hand[0].Value + (14 * hand[1].Value) + (14 * 14 * hand[2].Value);
        }

        return OnePair + val;
    }

    public static int ValueHighCard(Card[] hand)
    {
        hand = hand.OrderBy(c => c.Value).ToArray();
        if (hand[4].Value == 14 && hand[0].Value == 2 && IsStraight(hand)) return 1 + (14 * 2) + (14 * 14 * 3) + (14 * 14 * 14 * 4) + (14 * 14 * 14 * 14 * 5);
        return hand[0].Value + (14 * hand[1].Value) + (14 * 14 * hand[2].Value) + (14 * 14 * 14 * hand[3].Value) + (14 * 14 * 14 * 14 * hand[4].Value);
    }

    private static bool IsFlush(Card[] hand)
    {
        if (hand.Length != 5) return false;
        hand = hand.OrderBy(c => c.Suit).ToArray();
        return hand[0].Suit == hand[4].Suit;
    }

    private static bool IsStraight(Card[] hand)
    {
        int testValue;
        if (hand.Length != 5) return false;
        hand = hand.OrderBy(c => c.Value).ToArray();
        if(hand[4].Value == 14)
        {
            bool a = hand[0].Value == 2 && hand[1].Value == 3 &&
                hand[2].Value == 4 && hand[3].Value == 5;

            bool b = hand[0].Value == 10 && hand[1].Value == 11 &&
                hand[2].Value == 12 && hand[3].Value == 13;

            return a || b;
        }
        else
        {
            testValue = hand[0].Value + 1;

            for (int i = 1; i < 5; i++)
            {
                if (hand[i].Value != testValue) return false;
                testValue++;
            }
        }
        return true;
    }

    private static bool Is4s(Card[] hand)
    {
        bool a1, a2;
        if (hand.Length != 5) return false;
        hand = hand.OrderBy(c => c.Value).ToArray();

        a1 = hand[0].Value == hand[1].Value &&
             hand[1].Value == hand[2].Value &&
             hand[2].Value == hand[3].Value;

        a2 = hand[1].Value == hand[2].Value &&
             hand[2].Value == hand[3].Value &&
             hand[3].Value == hand[4].Value;

        return a1 || a2;
    }

    private static bool IsFullHouse(Card[] hand)
    {
        bool a1, a2;
        if (hand.Length != 5) return false;
        hand = hand.OrderBy(c => c.Value).ToArray();

        a1 = hand[0].Value == hand[1].Value &&
             hand[1].Value == hand[2].Value &&
             hand[3].Value == hand[4].Value;

        a2 = hand[0].Value == hand[1].Value &&
             hand[2].Value == hand[3].Value &&
             hand[3].Value == hand[4].Value;

        return a1 || a2;
    }

    private static bool Is3s(Card[] hand)
    {
        bool a1, a2, a3;
        if (hand.Length != 5) return false;
        hand = hand.OrderBy(c => c.Value).ToArray();

        if (Is4s(hand) || IsFullHouse(hand)) return false;

        a1 = hand[0].Value == hand[1].Value &&
             hand[1].Value == hand[2].Value;

        a2 = hand[1].Value == hand[2].Value &&
             hand[2].Value == hand[3].Value;

        a3 = hand[2].Value == hand[3].Value &&
             hand[3].Value == hand[4].Value;

        return a1 || a2 || a3;
    }

    private static bool Is22s(Card[] hand)
    {
        bool a1, a2, a3;
        if (hand.Length != 5) return false;
        if (Is4s(hand) || IsFullHouse(hand) || Is3s(hand)) return false;
        hand = hand.OrderBy(c => c.Value).ToArray();

        a1 = hand[0].Value == hand[1].Value &&
             hand[2].Value == hand[3].Value;

        a2 = hand[0].Value == hand[1].Value &&
             hand[3].Value == hand[4].Value;

        a3 = hand[1].Value == hand[2].Value &&
             hand[3].Value == hand[4].Value;

        return a1 || a2 || a3;
    }

    private static bool Is2s(Card[] hand)
    {
        bool a1, a2, a3, a4;
        if (hand.Length != 5) return false;
        if (Is4s(hand) || IsFullHouse(hand) || Is3s(hand) || Is22s(hand)) return false;
        hand = hand.OrderBy(c => c.Value).ToArray();

        a1 = hand[0].Value == hand[1].Value;
        a2 = hand[1].Value == hand[2].Value;
        a3 = hand[2].Value == hand[3].Value;
        a4 = hand[3].Value == hand[4].Value;

        return a1 || a2 || a3 || a4;
    }

    private Card[] GetCardInHand(string pokerHand)
    {
        Card[] cards = new Card[5];
        var cardValDict = CardValueDict();
        string[] arr = pokerHand.Split(' ');
        for (int i = 0; i < arr.Length; i++)
        {
            cards[i] = new Card(cardValDict[arr[i].Substring(0, 1)], GetSuitInt(arr[i].Substring(1, 1)));
        }

        return cards;
    }

    private static int GetSuitInt(string suit)
    {
        switch (suit)
        {
            case "H": return 1;
            case "D": return 2;
            case "C": return 3;
            case "S": return 4;
            default: return -1;
        }
    }

    public static Dictionary<string, int> CardValueDict()
    {
        var dict = new Dictionary<string, int>
        {
            { "2", 2 },
            { "3", 3 },
            { "4", 4 },
            { "5", 5 },
            { "6", 6 },
            { "7", 7 },
            { "8", 8 },
            { "9", 9 },
            { "T", 10 },
            { "J", 11 },
            { "Q", 12 },
            { "K", 13 },
            { "A", 14 }
        };
        return dict;
    }
}