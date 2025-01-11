using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UIMgr: MonoBehaviour
{
    public static UIMgr I;
    public UI_StartScene ui_startScene;
    public UI_Office ui_office;
    public UI_Peputation ui_peputation;


    private void Awake()
    {
        I = this; 
        ui_startScene.Init();
        ui_office.Init();
        ui_peputation.Init();


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
