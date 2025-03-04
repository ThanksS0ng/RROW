using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UIMgr: MonoBehaviour
{
    public static UIMgr I;
    public UI_StartScene ui_startScene;
    public UI_Office ui_office;
    public UI_Reputation ui_peputation;
    public UI_TownMap ui_townMap;
    public UI_Chat ui_chat;
    public UI_CharacterImgLib ui_CharacterImgLib;
    public UI_Tips ui_tips;
    public UI_Cafe ui_cafe;


    private void Awake()
    {
        I = this; 
        ui_startScene.Init();
        ui_office.Init();
        ui_peputation.Init();
        ui_townMap.Init();
        ui_chat.Init();
        ui_CharacterImgLib.Init(); 
        ui_tips.Init();
        ui_cafe.Init();
        

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
