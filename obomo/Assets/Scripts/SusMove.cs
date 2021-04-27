using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SusMove : MonoBehaviour
{
    //
    public float speed = 15.0f;
    public float rSpeed = 180.0f;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //Move forward/back/left/right with WASD
        if (Input.GetKey(KeyCode.W))
        {
            transform.Translate(new Vector3(0, 0, speed * Time.deltaTime));
            Debug.Log("Input: W");
        }
        else if (Input.GetKey(KeyCode.S))
        {
            transform.Translate(new Vector3(0, 0, -speed * Time.deltaTime));
            Debug.Log("Input: S");
        }
        if (Input.GetKey(KeyCode.D))
        {
            transform.Translate(new Vector3(speed * Time.deltaTime, 0, 0));
            Debug.Log("Input: D");
        }
        else if (Input.GetKey(KeyCode.A))
        {
            transform.Translate(new Vector3(-speed * Time.deltaTime, 0, 0));
            Debug.Log("Input: A");
        }
        //Rotate imposter
        if (Input.GetKey(KeyCode.RightArrow))
        {
            transform.Rotate(new Vector3(0, rSpeed * Time.deltaTime, 0));
        }
        else if (Input.GetKey(KeyCode.LeftArrow))
        {
            transform.Rotate(new Vector3(0, -rSpeed * Time.deltaTime, 0));
        }

    }
}
