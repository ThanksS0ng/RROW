using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class MouseHovering : MonoBehaviour, IPointerEnterHandler, IPointerExitHandler
{
    public GameObject obj;

    //Do this when the cursor enters the rect area of this selectable UI object.
    public void OnPointerEnter(PointerEventData eventData)
    {
        obj.SetActive(true);
    }

    public void OnPointerExit(PointerEventData eventData)
    {
        obj.SetActive(false);
    }
}
