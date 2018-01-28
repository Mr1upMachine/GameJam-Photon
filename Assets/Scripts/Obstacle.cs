using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Obstacle : MonoBehaviour {

    // Use this for initialization

    public Transform targetPos; //assign these in inspector with "waypoint" gameobjects or something.
    public Transform startPos;

    bool towards = true;
    public float speed = 0.1f;

    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        transform.LookAt(targetPos.position);
        transform.position += transform.forward * speed * Time.deltaTime;
        if (towards)
        {
            if (Vector3.Distance(transform.position, targetPos.position) < 1.0f)
            {
                towards = false;
            }
        }
        else
        {
            if (Vector3.Distance(transform.position, startPos.position) < 1.0f)
            {
                towards = true;
            }
        }
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        Destroy(other.gameObject);
    }

    private void OnDestroy()
    {
        //plays particle effect animation
    }
}
