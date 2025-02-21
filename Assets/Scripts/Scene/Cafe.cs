using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cafe : MonoBehaviour
{
    public CharacterInteractive characterInteractive;
    public Vector2 playerSpawnPosition;


    public void Init()
    {
        Hide();
        characterInteractive.Init();
    }

    public void Show()
    {
        GameMgr.I.player.SetPosition(playerSpawnPosition);
        GameMgr.I.cameraMove.Follow();
        gameObject.SetActive(true);
    }
    public void Hide()
    {
        gameObject.SetActive(false);
        GameMgr.I.cameraMove.UnFollow();
    }
}
