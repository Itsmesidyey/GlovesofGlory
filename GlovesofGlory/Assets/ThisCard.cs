using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;
using TMPro;

public class ThisCard : MonoBehaviour
{
    public List<Card> thisCard = new List<Card>();
    public int thisId;

    public int id;
    public string cardName;
    public int cost;
    public int power;
    public string cardDescription;

    public TMP_Text nameText;
    public TMP_Text costText;
    public TMP_Text powerText;
    public TMP_Text descriptionText;

    public Sprite thisSprite;
    public Image thatImage;

    void Start()
    {
        
        thisCard [0] = CardDataBase.cardList[thisId];
        
    }

    void Update()
    {
        
            id = thisCard[0].id;
            cardName = thisCard[0].cardName;
            cost = thisCard[0].cost;
            power = thisCard[0].power;
            cardDescription = thisCard[0].cardDescription;

            thisSprite =thisCard[0].thisImage;
        

        nameText.text = "" + cardName;
        costText.text = "" + cost;
        powerText.text = "" + power;
        descriptionText.text = "" + cardDescription;

        thatImage.sprite = thisSprite;
    }
}
