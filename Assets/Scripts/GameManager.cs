using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    public DeckManager deckManager;
    public Transform handArea;
    public GameObject cardPrefab;
    public Text remainingCardsText;
    // Start is called before the first frame update
    void Start()
    {
        UpdateRemainingCardsUI();
    }

    // Update is called once per frame
    public void DrawCard()
    {
        CardDataWithSprite drawnCard = deckManager.DrawCard(); //Draw Pile
        if(drawnCard != null)
        {
            GameObject newCard = Instantiate(cardPrefab, handArea);
            Image cardImage = newCard.GetComponent<Image>();
            cardImage.sprite = drawnCard.sprite;
        }

        UpdateRemainingCardsUI();
    }

    private void UpdateRemainingCardsUI()
    {
        remainingCardsText.text = "Card Left: " + deckManager.GetRemainingCards();
    }
}
