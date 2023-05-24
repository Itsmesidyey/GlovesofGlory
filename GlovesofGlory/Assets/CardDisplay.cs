using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class CardDisplay : MonoBehaviour
{
    public Card card;

    public TMP_Text nameText;
    public TMP_Text descriptionText;

    public Image artworkImage;

    public TMP_Text energycostText;
    public TMP_Text damageText;

    void Start()
    {
        if (card == null)
        {
            Debug.LogError("Card is null");
            return;
        }

        nameText.text = card.name;
        descriptionText.text = card.description;
        artworkImage.sprite = card.artwork;
        energycostText.text = card.energycost.ToString();
        damageText.text = card.damage.ToString();
    }
}
