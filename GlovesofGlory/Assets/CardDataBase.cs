using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardDataBase : MonoBehaviour
{

public static List<Card> cardList = new List<Card>();

void Awake(){
    cardList.Add (new Card(0, "Block", 35, 0, "Reduce damage taken from the next opponent's punch", Resources.Load <Sprite>("17")));
    cardList.Add (new Card(1, "Body Shot", 2, 30, "A targeted punch to the opponent's midsection, lowering their stamina", Resources.Load <Sprite>("1")));
    cardList.Add (new Card(2, "Counter Punch", 30, 35, "A defensive move that can be played in response to an opponent's attack", Resources.Load <Sprite>("2")));
    cardList.Add (new Card(3, "Cross", 10, 15, "A powerful straight punch", Resources.Load <Sprite>("3")));
    cardList.Add (new Card(4, "Hook", 15, 20, "A strong punch with the potential to stagger the opponent", Resources.Load <Sprite>("4")));
}
}
