using System.Collections.Generic;
using UnityEngine;

public class DeckManager : MonoBehaviour
{
    public CardDatabase cardDatabase;  // Reference CardDatabase
    private List<CardDataWithSprite> deck = new List<CardDataWithSprite>(); //Draw Pile

    private void Start()
    {
        InitializeDeck();
        ShuffleDeck();
    }

    // Initiallide the Deck
    private void InitializeDeck()
    {
        deck.Clear(); // Make sure no old card
        foreach (CardData card in cardDatabase.cards) 
        {
            for (int i = 0; i < card.quantity; i++)
            {
                Sprite randomSprite = card.art[Random.Range(0, card.art.Length)];

                deck.Add(new CardDataWithSprite(card, randomSprite));
            }
        }
    }

    // Shuffle the draw pile
    public void ShuffleDeck()
    {
        for (int i = 0; i < deck.Count; i++)
        {
            CardDataWithSprite temp = deck[i];
            int randomIndex = Random.Range(0, deck.Count);
            deck[i] = deck[randomIndex];
            deck[randomIndex] = temp;
        }
    }

    // Draw from the pile
    public CardDataWithSprite DrawCard()
    {
        if (deck.Count == 0)
        {
            Debug.Log("Deck is empty!");
            return null;
        }

        CardDataWithSprite drawnCard = deck[0]; // Draw first card
        deck.RemoveAt(0);             // Remove the drew card
        return drawnCard;
    }

    // Check remaining card
    public int GetRemainingCards()
    {
        return deck.Count;
    }
}

    [System.Serializable]
    public class CardDataWithSprite
    {
        public CardData cardData;
        public Sprite sprite;

        public CardDataWithSprite(CardData cardData, Sprite sprite)
        {
            this.cardData = cardData;
            this.sprite = sprite;
        }
    }