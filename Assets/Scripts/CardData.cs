using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//Define type of card and how many of them
[CreateAssetMenu(fileName = "CardData", menuName = "Cards/CardData")]
public class CardData : ScriptableObject
{
    public string cardName;
    public string cardDescription;
    public Sprite[] art;
    public int quantity;
}
