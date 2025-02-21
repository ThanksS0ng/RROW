using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UI_Office : MonoBehaviour
{
    public Button btn_LeaveOffice;


    public void Init()
    {
        Hide();

        btn_LeaveOffice.onClick.AddListener(() =>
        {
            UIMgr.I.ui_townMap.ShowTownMap();
        });

    }

    public void Show()
    {
        gameObject.SetActive(true);
       
    }
    public void ShowBtnLeave()
    {
        btn_LeaveOffice.gameObject.SetActive(true);
    }
    public void HideBtnLeave()
    {
        btn_LeaveOffice.gameObject.SetActive(false);
    }
    public void Hide()
    {
        gameObject.SetActive(false);
        btn_LeaveOffice.gameObject.SetActive(false);
    }


}
