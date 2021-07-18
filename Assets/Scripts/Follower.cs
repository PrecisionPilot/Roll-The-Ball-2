using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Follower : MonoBehaviour
{
    public GameObject followObject;
    private Vector3 offset;
    void Start()
    {
        
    }

    private void Update()
    {
        offset = transform.position - followObject.transform.position;
    }
    void LateUpdate()
    {
        transform.position = followObject.transform.position + offset;
        transform.RotateAround(followObject.transform.position, new Vector3(0, 1, 0), Input.GetAxis("Mouse X"));
    }
}
