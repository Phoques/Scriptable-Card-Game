using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class PlayArea : MonoBehaviour, IPointerEnterHandler, IPointerExitHandler
{

    public Health healthClass;
    public Hand hand;
    public int cardCount = 5;

    public Transform playAreaBoard;


    private void Start()
    {
        //Find Object of type is when you are finding a script tht is NOT connected the game object that THIS script is on.
        healthClass = FindObjectOfType<Health>();
        hand = FindObjectOfType<Hand>();
        //Get component refers to any component that is attached to this game object.
        playAreaBoard = GetComponent<Transform>();
    }

    //When the mouse pointer moves over (enters) the play area, the play area becomes a game object.
    public void OnPointerEnter(PointerEventData eventData)
    {

        SelectedCard.selectedPlayArea = gameObject;

    }
    //When the mouse moves away from the play area it becomes null / just an area, nothing that reacts to anything.
    public void OnPointerExit(PointerEventData eventData)
    {
        SelectedCard.selectedPlayArea = null;

    }
  


}
