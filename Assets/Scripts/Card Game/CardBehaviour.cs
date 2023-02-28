using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class CardBehaviour : MonoBehaviour, IPointerEnterHandler, IPointerExitHandler, IPointerDownHandler, IPointerUpHandler
{

    public bool hover;
    public Vector3 big = new Vector3 (1.1f, 1.1f, 1.1f);
    public Vector3 normal = new Vector3 (1,1,1);
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

    public void OnPointerDown(PointerEventData eventData)
    {
        SelectedCard.selectedObject = gameObject;
    }
    public void OnPointerUp(PointerEventData eventData)
    {
        SelectedCard.selectedObject = null;
    }



    
}
