using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotate : MonoBehaviour {

    public bool spin;
    public float timer = 1;
    private float count;
	// Use this for initialization
	void Start () {
        count = timer;
	}
	
	// Update is called once per frame
	void Update () {
        count -= Time.deltaTime;
        if (count <= 0 && spin)
        {
            if (transform.rotation == Quaternion.Euler(0, 0, 0))
            {
                transform.rotation = Quaternion.Euler(0, 0, 270);
            }
            else if (transform.rotation == Quaternion.Euler(0, 0, 270))
            {
                transform.rotation = Quaternion.Euler(0, 0, 180);
            }
            else if (transform.rotation == Quaternion.Euler(0, 0, 180))
            {
                transform.rotation = Quaternion.Euler(0, 0, 90);
            }
            else if (transform.rotation == Quaternion.Euler(0, 0, 90))
            {
                transform.rotation = Quaternion.Euler(0, 0, 0);
            }
            count = timer;
        }
	}
}
