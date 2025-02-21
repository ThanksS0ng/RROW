using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterInteractive : MonoBehaviour
{
    public GameObject chatBtnImg;




    public void Init() 
    {
        HideChatImg();
    }
    public void ShowChatImg() 
    {
        chatBtnImg.SetActive(true);
    }
    public void HideChatImg() 
    {
        chatBtnImg.SetActive(false);
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
