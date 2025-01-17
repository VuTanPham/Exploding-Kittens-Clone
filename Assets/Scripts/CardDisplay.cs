using System.Collections;
using System.Collections.Generic;
using Microsoft.Unity.VisualStudio.Editor;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;

public class CardDisplay : MonoBehaviour
{
    public Image cardImage;
    public Text cardNameText;
    public Text cardDescriptionText;

    public void SetCard(CardData card)
    {
        if(card == null) return;

        int randomIndex = Random.Range(0, card.art.Length);
        cardImage.sprite = card.art[randomIndex];

        cardNameText.text = card.cardName;
        cardDescriptionText.text = card.description;
    }   
}