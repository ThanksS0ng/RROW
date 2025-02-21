using System.Collections;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Newtonsoft.Json.Converters;
using UnityEngine;
using static UnityEngine.RuleTile.TilingRuleOutput;

public class PlayerMove : MonoBehaviour
{
    public float speed;
    public Animator animator;

    public void Init()
    {
        
    }

    public void SetPosition(Vector2 position)
    {
        this.transform.localPosition = position;
    }
    // Start is called before the first frame update
    void Start()
    {


    }

    // Update is called once per frame
    void Update()
    {
        //Input two axises.
        animator.SetFloat("horizontal", Input.GetAxis("Horizontal"));


        Vector3 horizontal = new Vector3(Input.GetAxis("Horizontal"), 0f, 0f);
        transform.position = transform.position + horizontal * Time.deltaTime * speed;

    }

    public void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.name == "NPC_1and2")
        {
            var ci = collision.GetComponent<CharacterInteractive>();
            ci.ShowChatImg();
        }
    }
    public void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.gameObject.name == "NPC_1and2")
        {
            var ci = collision.GetComponent<CharacterInteractive>();
            ci.HideChatImg();
        }
    }
    public void OnCollisionEnter2D(Collision2D collision)
    {
        //show the UI.
        if (collision.gameObject.name == "OfficeWall_R")
        {
            UIMgr.I.ui_office.ShowBtnLeave();
        }

    }
    public void OnCollisionExit2D(Collision2D collision)
    {
        //hide the UI.
        if (collision.gameObject.name == "OfficeWall_R")
        {
            UIMgr.I.ui_office.HideBtnLeave();
        }

    }



}
