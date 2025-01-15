using System.Collections;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using UnityEngine;
using static UnityEngine.RuleTile.TilingRuleOutput;

public class PlayerMove : MonoBehaviour
{
    public float speed;
    public Animator animator;

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
}
