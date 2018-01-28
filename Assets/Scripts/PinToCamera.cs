using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PinToCamera : MonoBehaviour {

    private float distance = 3.0f;

    private void Start()
    {
        transform.parent = Camera.main.transform;
    }

    // Update is called once per frame
    void Update () {
        float offsetX, offsetY, offsetZ;
        offsetX = 8.2f;
        offsetY = .5f;
        offsetZ = .2f;
        Vector3 v3 = Camera.main.transform.position;
        //int width = Camera.main.scaledPixelWidth;
        //Debug.Log("Camera pos is: " + v3);
        //Debug.Log("Width is: " + width);
        //v3.x += (float)width - (transform.localScale.x / 2);
        v3.x += offsetX;
        //Debug.Log("v3.x is: " + v3.x);
        //v3.y += offsetY;
        //Debug.Log("v3.y is: " + v3.y);
        ////v3.z += offsetZ;
        //Debug.Log("New v3 is: " + v3);
        //gameObject.transform.position = Camera.main.ScreenToViewportPoint(v3) + Camera.main.transform.forward * distance;
        gameObject.transform.position = v3 + Camera.main.transform.forward * distance;
        gameObject.transform.rotation = new Quaternion(0.0f, Camera.main.transform.rotation.y, 0.0f, Camera.main.transform.rotation.w);
    }
}
