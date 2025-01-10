using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Office : MonoBehaviour
{
    public void Init()
    {
        Hide();
    }

    public void Show() 
    {
        gameObject.SetActive(true);    
    }
    public void Hide() 
    {
        gameObject.SetActive(false);
    }
   
    
}
