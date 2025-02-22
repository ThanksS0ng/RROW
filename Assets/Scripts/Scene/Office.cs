using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Office : MonoBehaviour
{
    public Vector2 playerSpawnPosition;
    public void Init()
    {
        Hide();
    }

    public void Show()
    {
        GameMgr.I.player.SetPosition(playerSpawnPosition);
        gameObject.SetActive(true);
        GameMgr.I.isOffice = true;
        Camera.main.transform.position = new Vector3(0, 0, -10);
    }
    public void Hide()
    {
        gameObject.SetActive(false);
    }
}
