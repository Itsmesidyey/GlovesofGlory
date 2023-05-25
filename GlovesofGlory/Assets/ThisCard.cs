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

    public TMP_Text Name;
    public TMP_Text Energy;
    public TMP_Text Damage;
    public TMP_Text Description;

    public Sprite thisSprite;
    public Image thatImage;

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

            thisSprite =thisCard[0].thisImage;
        }

        Name.text = "" + cardName;
        Energy.text = "" + cost;
        Damage.text = "" + power;
        Description.text = "" + cardDescription;

        thatImage.sprite = thisSprite;
    }
}
