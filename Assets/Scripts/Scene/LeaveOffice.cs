using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LeaveOffice : MonoBehaviour
{

    public void OnCollisionExit2D(Collision2D collision)
    {
        print(collision.gameObject.name);

    }
    public void OnCollisionEnter2D(Collision2D collision)
    {
        print("Enter===");
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
