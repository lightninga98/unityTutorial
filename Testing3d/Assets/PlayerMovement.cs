using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 combinable = new();
        if(Input.GetKeyDown(KeyCode.Space))
        {
            combinable += new Vector3(0, 5, 0);
        }
        if (Input.GetKey(KeyCode.UpArrow))
        {
            combinable += new Vector3(0, 0, 1);
        }
        if (Input.GetKey(KeyCode.RightArrow))
        {
            combinable += new Vector3(1, 0, 0);
        }
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            combinable += new Vector3(-1, 0, 0);
        }
        if (Input.GetKey(KeyCode.DownArrow))
        {
            combinable += new Vector3(0, 0, -1);
        }
        GetComponent<Rigidbody>().velocity = combinable;
    }
}
