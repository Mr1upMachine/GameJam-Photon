using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColorChange : MonoBehaviour
{
    const int NORTH = 0, WEST = 90, SOUTH = 180, EAST = 270; //Use with laser direction
    public GameObject redLaser, blueLaser, greenLaser;
    public Transform spawnN, spawnS, spawnE, spawnW;
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
                Destroy(other.gameObject);
                GameObject bullet = (GameObject)Instantiate(redLaser, spawnN.position, spawnN.rotation);
                Player.lasers.Add(bullet);
            }
            if (gameObject.tag == "ConvertBlue")
            {
                Destroy(other.gameObject);
                GameObject bullet = (GameObject)Instantiate(blueLaser, spawnN.position, spawnN.rotation);
                Player.lasers.Add(bullet);
            }
            if (gameObject.tag == "ConvertGreen")
            {
                Destroy(other.gameObject);
                GameObject bullet = (GameObject)Instantiate(greenLaser, spawnN.position, spawnN.rotation);
                Player.lasers.Add(bullet);
            }
        }
        else if (other.gameObject.transform.rotation == Quaternion.Euler(0, 0, WEST)) //if laser is travelling west
        {
            if (gameObject.tag == "ConvertRed")
            {
                Destroy(other.gameObject);
                GameObject bullet = (GameObject)Instantiate(redLaser, spawnW.position, spawnW.rotation);
                Player.lasers.Add(bullet);
            }
            if (gameObject.tag == "ConvertBlue")
            {
                Destroy(other.gameObject);
                GameObject bullet = (GameObject)Instantiate(blueLaser, spawnW.position, spawnW.rotation);
                Player.lasers.Add(bullet);
            }
            if (gameObject.tag == "ConvertGreen")
            {
                Destroy(other.gameObject);
                GameObject bullet = (GameObject)Instantiate(greenLaser, spawnW.position, spawnW.rotation);
                Player.lasers.Add(bullet);
            }
        }
        else if (other.gameObject.transform.rotation == Quaternion.Euler(0, 0, EAST)) //if laser is travelling east
        {
            if (gameObject.tag == "ConvertRed")
            {
                Destroy(other.gameObject);
                GameObject bullet = (GameObject)Instantiate(redLaser, spawnN.position, spawnE.rotation);
                Player.lasers.Add(bullet);
            }
            if (gameObject.tag == "ConvertBlue")
            {
                Destroy(other.gameObject);
                GameObject bullet = (GameObject)Instantiate(blueLaser, spawnN.position, spawnE.rotation);
                Player.lasers.Add(bullet);
            }
            if (gameObject.tag == "ConvertGreen")
            {
                Destroy(other.gameObject);
                GameObject bullet = (GameObject)Instantiate(greenLaser, spawnN.position, spawnE.rotation);
                Player.lasers.Add(bullet);
            }
        }
        else if (other.gameObject.transform.rotation == Quaternion.Euler(0, 0, SOUTH) || other.gameObject.transform.rotation == Quaternion.Euler(0, 0, -180)) //if laser is travelling south
        {
            if (gameObject.tag == "ConvertRed")
            {
                Destroy(other.gameObject);
                GameObject bullet = (GameObject)Instantiate(redLaser, spawnS.position, spawnS.rotation);
                Player.lasers.Add(bullet);
            }
            if (gameObject.tag == "ConvertBlue")
            {
                Destroy(other.gameObject);
                GameObject bullet = (GameObject)Instantiate(blueLaser, spawnS.position, spawnS.rotation);
                Player.lasers.Add(bullet);
            }
            if (gameObject.tag == "ConvertGreen")
            {
                Destroy(other.gameObject);
                GameObject bullet = (GameObject)Instantiate(greenLaser, spawnS.position, spawnS.rotation);
                Player.lasers.Add(bullet);
            }
        }
    }
}
