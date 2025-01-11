using System.Collections;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using UnityEngine;
using static UnityEngine.RuleTile.TilingRuleOutput;

public class PlayerMove : MonoBehaviour
{
    public float speed;
    public Animator anim;

    // Start is called before the first frame update
    void Start()
    {


    }

    // Update is called once per frame
    void Update()
    {
        //Input two axises.
        Vector3 horizontal = new Vector3(Input.GetAxis("Horizontal"), 0f, 0f);
        //-1,   0,    +1
        if (horizontal.x < 0)
        {
            transform.rotation = new Quaternion(0, -180, 0, 0);
        }
        if (horizontal.x > 0)
        {
            transform.rotation = new Quaternion(0, 0, 0, 0);

        }
        transform.position = transform.position + horizontal * Time.deltaTime * speed;
        if (horizontal.x > -0.01f && horizontal.x < 0.01f)
        {
            anim.enabled = false;
        }
    }
}
