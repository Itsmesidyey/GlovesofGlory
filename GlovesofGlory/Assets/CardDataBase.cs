using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardDataBase : MonoBehaviour
{

public static List<Card> cardList = new List<Card> ();

void Awake(){
    cardList.Add (new Card(0, "None", 0, 0, "None"));
    cardList.Add (new Card(1, "jab1", 2, 1000, "asd"));
    cardList.Add (new Card(2, "jab2", 3, 1000, "dsa"));
    cardList.Add (new Card(3, "jab3", 5, 1000, "ss"));
    cardList.Add (new Card(4, "jab4", 1, 1000, "aa"));
}
}
