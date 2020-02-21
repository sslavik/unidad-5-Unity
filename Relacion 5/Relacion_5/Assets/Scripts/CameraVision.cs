using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraVision : MonoBehaviour
{
    RaycastHit hited;
    bool somethingHitted = false;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        somethingHitted = Physics.BoxCast(transform.position,new Vector3(Camera.main.pixelWidth, Camera.main.pixelHeight, 100), transform.forward, out hited);
    }

    private void OnDrawGizmos() {
        if(somethingHitted)
            Gizmos.DrawCube(transform.position, transform.localScale);
        Gizmos.DrawCube(transform.position, transform.localScale);
    }
}
