using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;
public class CardDisplay : MonoBehaviour
{



    //Card
    public CardBase card;
    //UI Connections
    public Text nameText, descriptionText, costText, attackText, healthText;
    // Text name, description, cost, attack, health
    public Image iconImage;
    public Image backgroundImage;
    //Image - icon, background

    //This is triggered when the card is set to active in the scene...it allows the card time to get the data from the hand before setting itself up.
    void OnEnable()
    {
        //Unure why this needs Value, Might have something to do with the Generic Variable Base Script?
        nameText.text = card.name.Value;
        descriptionText.text = card.description.Value;
        costText.text = card.cost.Value.ToString(); // I have added 'Value' as without it, it cannot take in the Scriptable Object value (In this framework)
        attackText.text = card.attackBase.Value.ToString();
        healthText.text = card.healthBase.Value.ToString();
        iconImage.sprite = card.icon.Value;
        backgroundImage.sprite = card.background.Value;
    }
}
