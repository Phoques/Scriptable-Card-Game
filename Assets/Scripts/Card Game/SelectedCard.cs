using System.Collections;
using System.Collections.Generic;
using System.Runtime.InteropServices.WindowsRuntime;
using UnityEngine;

public class SelectedCard : MonoBehaviour
{
    public static GameObject selectedObject;
    public static GameObject selectedPlayArea;
    


    // Update is called once per frame
    void Update()
    {
        if (selectedObject != null)
        {
            Vector2 pos = new Vector2(Input.mousePosition.x, Input.mousePosition.y);
            selectedObject.transform.position = pos;
        }
        

    }

   
}
