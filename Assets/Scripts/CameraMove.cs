using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraMove : MonoBehaviour
{
    public void Init() 
    {

    }

    public void Follow() 
    {
        this.transform.SetParent(GameMgr.I.player.transform);
    }
    public void UnFollow() 
    {
        this.transform.SetParent(null);
    }
}
