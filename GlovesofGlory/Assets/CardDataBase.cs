using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardDataBase : MonoBehaviour
{
    public static List<Card> cardList = new List<Card> ();

    void Awake(){ 
        cardList.Add (new Card(0, "None", 0, 0, "None", Resources.Load <Sprite>("1"),"None"));
        cardList.Add (new Card(1, "Body Shot", 25, 30, "None", Resources.Load <Sprite>("2"),"Red"));
        cardList.Add (new Card(2, "Counter Punch", 30, 35,"None", Resources.Load <Sprite>("3"),"Blue"));
        cardList.Add (new Card(3, "Hook", 15, 20, "None", Resources.Load <Sprite>("4"),"Yellow"));
        cardList.Add (new Card(4, "Jab", 5, 10 ,"None", Resources.Load <Sprite>("5"),"Purple"));
    }
}
