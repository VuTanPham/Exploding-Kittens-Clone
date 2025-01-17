using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//Define ra các loại bài và số lượng của mỗi loại bài
[CreateAssetMenu(fileName = "CardData", menuName = "Cards/CardData")]
public class CardData : ScriptableObject
{
    public string cardName;
    public string cardDescription;
    public Sprite[] art;
    public int quantity;

}
