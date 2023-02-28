using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Hand : MonoBehaviour
{

    public Transform hand;
    public CardBase[] cards;
    public GameObject cardPrefab;

    private void Start()
    {
        for (int i = 0; i < 5; i++)
        {
            //for each card we spawn in the prefab is off so that the spawned in card is off
            GameObject cardClone = Instantiate(cardPrefab, hand);
            //we then send the prefab clone the card data
            cardClone.GetComponent<CardDisplay>().card = cards[Random.Range(0, cards.Length)];
            //when the card has the data we turn it on...triggering OnEnable
            cardClone.SetActive(true);
        }
    }




}
