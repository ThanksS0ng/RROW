using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Office : MonoBehaviour
{
    public Vector2 playerSpawnPosition;
    public Vector2 plyaerBackPostion;
    public void Init()
    {
        GameMgr.I.player.SetPosition(playerSpawnPosition);
        Hide();
    }

    public void Show_Init()
    {
        GameMgr.I.player.SetPosition(playerSpawnPosition);
        gameObject.SetActive(true);
        GameMgr.I.isOffice = true;
        UIMgr.I.ui_office.Show();
        Camera.main.transform.position = new Vector3(0, 0, -10);
    }
    public void Show_BackOffice() 
    {
        GameMgr.I.player.SetPosition(plyaerBackPostion);
        gameObject.SetActive(true);
        UIMgr.I.ui_office.Show();
        GameMgr.I.isOffice = true;
        Camera.main.transform.position = new Vector3(0, 0, -10);
    }

    public void Hide()
    {
        gameObject.SetActive(false);
    }
}
