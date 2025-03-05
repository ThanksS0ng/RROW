using System.Collections;
using System.Collections.Generic;
using Newtonsoft.Json.Converters;
using UnityEngine;
using UnityEngine.UI;

public class Cafe : MonoBehaviour
{
    public CharacterInteractive characterInteractive;
    public Vector2 playerSpawnPosition;

    public float leftBoundary_X;
    public float rightBoundary_X;

    [HideInInspector]
    public Vector3 leftCameraPos;
    [HideInInspector]
    public Vector3 rightCameraPos;

    public bool canChat = false;

    public void Init()
    {
        Hide();
        characterInteractive.Init();

        leftCameraPos = new Vector3(leftBoundary_X, 0, -10);
        rightCameraPos = new Vector3(rightBoundary_X, 0, -10);
    }

    public void Show()
    {
        GameMgr.I.player.SetPosition(playerSpawnPosition);
        GameMgr.I.cameraMove.Follow();
        gameObject.SetActive(true);
        GameMgr.I.isCafe = true;
    }
    public void Hide()
    {
        gameObject.SetActive(false);
        GameMgr.I.cameraMove.UnFollow();
        GameMgr.I.isCafe = false;
    }

    private void Update()
    {
        if (Input.GetKeyUp(KeyCode.E) && canChat)
        {
            canChat = false;
            UI_Chat.I.StartPresentlines("cafe_1and2");
        }
    }
}
