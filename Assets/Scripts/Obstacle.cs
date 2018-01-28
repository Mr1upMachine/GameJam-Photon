using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Obstacle : MonoBehaviour {

    // Use this for initialization
<<<<<<< HEAD
    public bool doesMove = false;
=======
    public float distance;
    public float min = 2f;
    public float max = 3f;
    // Use this for initialization
    void Start()
    {
>>>>>>> 80fdd264558cf195966486ca8f2dcb80a053fdba

        min = transform.position.x;
        max = transform.position.x + distance;

<<<<<<< HEAD
    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        if (doesMove)
        {
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
=======
>>>>>>> 80fdd264558cf195966486ca8f2dcb80a053fdba
    }

    // Update is called once per frame
    void Update()
    {


        transform.position = new Vector3(Mathf.PingPong(Time.time * 2, max - min) + min, transform.position.y, transform.position.z);

    }

    void OnTriggerEnter2D(Collider2D other)
    {
        Destroy(other.gameObject);
    }
}
