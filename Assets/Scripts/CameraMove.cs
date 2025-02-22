using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraMove : MonoBehaviour
{
    public void Init()
    {

    }

    private void Update()
    {
        if (GameMgr.I.isCafe)
        {
            Camera.main.transform.position = new Vector3(GameMgr.I.player.transform.position.x, 0, -10);
            if (transform.position.x < GameMgr.I.cafe.leftCameraPos.x)
            {
                transform.position = GameMgr.I.cafe.leftCameraPos;
            }
            if (transform.position.x > GameMgr.I.cafe.rightCameraPos.x)
            {
                transform.position = GameMgr.I.cafe.rightCameraPos;
            }
        }
       
    }

    public void SetPosition()
    {

    }
    public void Follow()
    {

    }
    public void UnFollow()
    {
        this.transform.SetParent(null);
    }
}
