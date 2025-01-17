using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeckManager : MonoBehaviour
{
    public CardDatabase cardDatabase; //Tham chiếu từ CardDatabase
    private List<CardData> deck = new List<CardData>();

    private void Start()
    {
        InitialDeck();
        ShuffleDeck();
    }
    
    //Creat Draw Pile
    public void InitialDeck()
    {
        deck.Clear();
        foreach (CardData card in cardDatabase.cards)
        {
            for(int i = 0; i < card.quantity; i++)
            {
                deck.Add(card);
            }
        }
    }
    
    //Shuffle
    public void ShuffleDeck()
    {
        for (int i = 0; i < deck.Count; i++)
        {
            CardData temp = deck[i];
            int randomIndex = Random.Range(0, deck.Count);
            deck[i] = deck[randomIndex];
            deck[randomIndex] = temp;
        }
    }

//     //Draw
//     public CardData DrawCard()
//     {
//         if(deck.Count == 0)
//         {
//             Debug.Log("Deck is empty!!!");
//             return null;
//         }
//     }

//     CardData drawnCard = deck[0];
//     deck.RemoveAt(0);
//     return drawnCard;
// }

// public int GetReaminingCards()
// {
//     return desk.Count();
}
