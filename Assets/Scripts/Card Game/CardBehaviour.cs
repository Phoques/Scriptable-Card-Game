using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;
using UnityEngine.XR;

public class CardBehaviour : MonoBehaviour, IPointerEnterHandler, IPointerExitHandler, IPointerDownHandler, IPointerUpHandler
{

    public bool hover;
    public Vector3 big = new Vector3 (1.1f, 1.1f, 1.1f);
    public Vector3 normal = new Vector3 (1,1,1);

    public Vector3 cardInitialPos;
    public Vector3 cardFinalPos;
    

    PlayArea playAreaClass;
    Health healthClass;
    Hand handClass;
    CardBase cardBase;

    private void Start()
    {
        playAreaClass = GameObject.FindGameObjectWithTag("Play Area").GetComponent<PlayArea>();
        healthClass = GameObject.FindGameObjectWithTag("Health").GetComponent<Health>();
        handClass = GameObject.FindGameObjectWithTag("Hand").GetComponent<Hand>();
        cardBase = GetComponent<CardDisplay>().card;
        
    }


    public void OnPointerEnter(PointerEventData eventData)
    {
        
        hover = true;
        this.transform.localScale = big;
    }
    public void OnPointerExit(PointerEventData eventData)
    {
        hover = false;
        this.transform.localScale = normal;
    }

    //all raycast tick boxes on all of the card components (Image / text etc have been removed, except for the one attached the to background.
    //So we must remove the raycast, ONCE we have picked it up, so that the mouse can raycast past it to the play area.
    public void OnPointerDown(PointerEventData eventData)
    {
        //Here as soon as we click the card, it saves its current position for later, which means  if we let it go away from the play area it knows its original pos
        cardInitialPos = transform.position;
        SelectedCard.selectedObject = gameObject;
        gameObject.GetComponent<CardDisplay>().backgroundImage.raycastTarget = false;
        
        
        
    }
    public void OnPointerUp(PointerEventData eventData)
    {
        //if play area is not null (See play area script) if it is assigned as a game object, it is not null. However on pointer exit, it becomes null.
        //Essentially whenever you mouse over the the play area it become an active game object, and when you move away from it, it becomes null.
        if (SelectedCard.selectedPlayArea != null)
        {
            healthClass.TakeDamage(cardBase.attackBase.Value);

            
            if (handClass.cardCount > 0)
            {
                handClass.SpawnSingleCard();
                //Remove the count by 1
                handClass.cardCount--;
            }
            //Destroy the card
            Destroy(gameObject);
        }
        else
        {
            // card is now null, so it is no longer an active game object.
            SelectedCard.selectedObject = null;
            //it now moves back to its original position as we set it in the 'on pointer down interface method
            transform.position = cardInitialPos;
            //Make the raycast of the card true again, so the mouse can click on it and activate the on pointer down method to move the card.
            gameObject.GetComponent<CardDisplay>().backgroundImage.raycastTarget = true;

        }

    }



    
}
