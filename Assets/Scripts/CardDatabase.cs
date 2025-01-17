using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//Create array that contain all Cards (CardData)
[CreateAssetMenu(fileName = "CardDatabase", menuName = "Cards/Card Database")]
public class CardDatabase : ScriptableObject
{
    public CardData[] cards;
}
