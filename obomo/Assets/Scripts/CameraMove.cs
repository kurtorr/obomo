using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraMove : MonoBehaviour
{
    //
    public GameObject sus;
    public float camHeight = 10;
    public float camDistance = -20;
    public float camRotate = 0;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = new Vector3(sus.transform.position.x, sus.transform.position.y, sus.transform.position.z);
        transform.rotation = new Quaternion(sus.transform.rotation.x, sus.transform.rotation.y, sus.transform.rotation.z, sus.transform.rotation.w);
        transform.Translate(new Vector3(0, camHeight, camDistance));
    }
}
