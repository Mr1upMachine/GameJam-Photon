using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColorChange : MonoBehaviour
{
    const int NORTH = 0, WEST = 90, SOUTH = 180, EAST = 270; //Use with laser direction

    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    void OnTriggerEnter2D(Collider2D other)
    {

        if (other.gameObject.transform.rotation == Quaternion.Euler(0, 0, NORTH)) //if laser is travelling north
        {
            if (gameObject.tag == "ConvertRed")
            {

            }
            if (gameObject.tag == "ConvertBlue")
            {

            }
            if (gameObject.tag == "ConvertRed")
            {

            }
        }
        else if (other.gameObject.transform.rotation == Quaternion.Euler(0, 0, WEST)) //if laser is travelling west
        {
            if (gameObject.tag == "ConvertRed")
            {

            }
            if (gameObject.tag == "ConvertBlue")
            {

            }
            if (gameObject.tag == "ConvertRed")
            {

            }
        }
        else if (other.gameObject.transform.rotation == Quaternion.Euler(0, 0, EAST)) //if laser is travelling east
        {
            if (gameObject.tag == "ConvertRed")
            {

            }
            if (gameObject.tag == "ConvertBlue")
            {

            }
            if (gameObject.tag == "ConvertRed")
            {

            }
        }
        else if (other.gameObject.transform.rotation == Quaternion.Euler(0, 0, WEST)) //if laser is travelling south
        {
            if (gameObject.tag == "ConvertRed")
            {

            }
            if (gameObject.tag == "ConvertBlue")
            {

            }
            if (gameObject.tag == "ConvertRed")
            {

            }
        }
    }
}
