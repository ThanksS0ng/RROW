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
    }
    public void Hide()
    {
        gameObject.SetActive(false);
    }
}
