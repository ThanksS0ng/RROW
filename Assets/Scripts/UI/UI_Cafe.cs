using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UI_Cafe : MonoBehaviour
{
    public Button btn_LeaveCafe;
    public void Init() 
    {
        HideBtnLeave();
        btn_LeaveCafe.onClick.AddListener(() =>
        {
            UIMgr.I.ui_townMap.ShowTownMap();
        });
    }

    public void ShowBtnLeave()
    {
        btn_LeaveCafe.gameObject.SetActive(true);
    }
    public void HideBtnLeave()
    {
        btn_LeaveCafe.gameObject.SetActive(false);
    }
    public void Hide()
    {
        gameObject.SetActive(false);
        btn_LeaveCafe.gameObject.SetActive(false);
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
