using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerDeck
{

    public List<Card> deck = new List<Card>();

    public int x;
    // Start is called before the first frame update
    void Start()
    {
        x = 0;

        for(int i=0;i<40; i++){
            x = Random.Range(1,4);
            deck[i] = CardDataBase.cardList[x];

        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
