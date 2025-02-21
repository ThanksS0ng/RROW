using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameMgr : MonoBehaviour
{
    public static GameMgr I;

    public PlayerMove player;
    public CameraMove cameraMove;

    public Office office;
    public Cafe cafe;

    //add new scene objects...

    private void Awake() 
    {
        I = this;

        player.Init();
        cameraMove.Init();

        office.Init();
        cafe.Init();



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
