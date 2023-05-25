using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;
public class ThisCard : MonoBehaviour
{
    public List<Card> thisCard = new List<Card>();
    public int thisId;

    public int id;
    public string cardName;
    public int cost;
    public int power;
    public string cardDescription;

    public Text nameText;
    public Text costText;
    public Text powerText;
    public Text descriptionText;

    void Start()
    {
        if (CardDataBase.cardList.Count > 0)
        {
            thisCard.Add(CardDataBase.cardList[thisId]);
        }
    }

    void Update()
    {
        if (thisCard.Count > 0)
        {
            id = thisCard[0].id;
            cardName = thisCard[0].cardName;
            cost = thisCard[0].cost;
            power = thisCard[0].power;
            cardDescription = thisCard[0].cardDescription;
        }

        nameText.text = "" + cardName;
        costText.text = "" + cost;
        powerText.text = "" + power;
        descriptionText.text = "" + cardDescription;
    }
}
