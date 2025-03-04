using System.Collections;
using System.Collections.Generic;
using Newtonsoft.Json.Bson;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class UI_TownMap : MonoBehaviour
{
    public GameObject pnl_DetailInfo_CAFE;
    public GameObject pnl_DetailInfo_Newsroom;
    public Button btn_Back;

    public Button btn_Cafe;
    public Button btn_Newsroom;


    public void Init() 
    {
        HideTownMap();
        HideAllPnls();

        btn_Back.onClick.AddListener(() => 
        {
            HideTownMap();
            HideAllPnls();
        });

        btn_Cafe.onClick.AddListener(() =>
        {
            HideTownMap();
            GameMgr.I.office.Hide();
            UIMgr.I.ui_office.Hide();
            GameMgr.I.cafe.Show();
        });

        btn_Newsroom.onClick.AddListener(() =>
        {
            HideTownMap();
            GameMgr.I.cafe.Hide();
            UIMgr.I.ui_cafe.Hide();
            GameMgr.I.office.Show_BackOffice();
        });
    }


    public void ShowTownMap() 
    {
        this.gameObject.SetActive(true);
    }
    public void HideTownMap()
    {
        this.gameObject.SetActive(false);
        HideAllPnls();
    }
    public void ShowPnlCafe()
    {
        pnl_DetailInfo_CAFE.SetActive(true);
    }
    public void ShowPnlNewsroom() 
    {
        pnl_DetailInfo_Newsroom.SetActive(true);
    }

    public void HideAllPnls() 
    {
        pnl_DetailInfo_CAFE.SetActive(false);
        pnl_DetailInfo_Newsroom.SetActive(false);
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyUp(KeyCode.Escape)) 
        {
            HideTownMap();
            HideAllPnls();
        }
    }
}
