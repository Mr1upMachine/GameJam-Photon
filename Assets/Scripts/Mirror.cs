using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mirror : MonoBehaviour {

    public enum Color { White, Red, Green, Blue };
    public Color mColor = Color.White;

    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    private void FixedUpdate()
    {
        
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if (gameObject.transform.rotation == Quaternion.Euler(0, 0, 0))
        {
            other.gameObject.transform.rotation = Quaternion.Euler(0, 0, -90);
        }
        else if (gameObject.transform.rotation == Quaternion.Euler(0, 0, 270))
        {
            other.gameObject.transform.rotation = Quaternion.Euler(0, 0, 90);
        }
        else
        {
            Destroy(other.gameObject);
        }

    }
}
