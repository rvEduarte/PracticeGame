using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class DisableFire : MonoBehaviour, IPointerDownHandler, IPointerUpHandler
{
    bool buttonPressed;
    public GameObject shooting;

    // Update is called once per frame
    void Update()
    {
        if(buttonPressed == true)
        {
            Debug.Log("Disable shooting");
            shooting.SetActive(false);
        }else
        {
            Debug.Log("Enable shooting");
            shooting.SetActive(true);
        }
    }

    void IPointerDownHandler.OnPointerDown(PointerEventData eventData)
    {
        buttonPressed = true;
    }

    void IPointerUpHandler.OnPointerUp(PointerEventData eventData)
    {
        buttonPressed = false;
    }
}
