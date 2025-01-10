using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UI_StartScene : MonoBehaviour
{
    public Button btn_NewGame;
    public Button btn_Options;
    public Button btn_Exit;
    public Button btn_Save;
    public Button btn_Load;


    public void Init()
    {
        Show();

        btn_NewGame.onClick.AddListener(() =>
        {
            Hide();

        });

        btn_Save.onClick.AddListener(() =>
        {
            //Hide();

        });

        btn_Load.onClick.AddListener(() =>
        {
            //Hide();

        });

        btn_Options.onClick.AddListener(() =>
        {
            //Hide();

        });

        btn_Exit.onClick.AddListener(() =>
        {
            Debug.Log("Exiting Game...");
            ExitGame();

        });
    }

    public void Show() 
    {
        gameObject.SetActive(true);
    }
    public void Hide() 
    {
        gameObject.SetActive(false);
    }

    public void ExitGame()
    {
        Debug.Log("Game is exiting...");
        Application.Quit();
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
