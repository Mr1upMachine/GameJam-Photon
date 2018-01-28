using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColorChange : MonoBehaviour
{
    const int NORTH = 0, WEST = 90, SOUTH = 180, EAST = 270; //Use with laser direction
    public GameObject redLaser, blueLaser, greenLaser;
    public Transform spawnN, spawnS, spawnE, spawnW;

    void OnTriggerEnter2D(Collider2D other)
    {

        if (other.gameObject.transform.rotation == Quaternion.Euler(0, 0, NORTH) ||
			other.gameObject.transform.rotation == Quaternion.Euler(0, 0, 0) ||
			other.gameObject.transform.rotation == Quaternion.Euler(0, 0, -360)) //if laser is travelling north
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
        else if (other.gameObject.transform.rotation == Quaternion.Euler(0, 0, WEST) ||
			other.gameObject.transform.rotation == Quaternion.Euler(0, 0, -270)) //if laser is travelling west
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
        else if (other.gameObject.transform.rotation == Quaternion.Euler(0, 0, EAST) ||
			other.gameObject.transform.rotation == Quaternion.Euler(0, 0, -90)) //if laser is travelling east
        {
            if (gameObject.tag == "ConvertRed")
            {
                Destroy(other.gameObject);
                GameObject bullet = (GameObject)Instantiate(redLaser, spawnE.position, spawnE.rotation);
                Player.lasers.Add(bullet);
            }
            if (gameObject.tag == "ConvertBlue")
            {
                Destroy(other.gameObject);
                GameObject bullet = (GameObject)Instantiate(blueLaser, spawnE.position, spawnE.rotation);
                Player.lasers.Add(bullet);
            }
            if (gameObject.tag == "ConvertGreen")
            {
                Destroy(other.gameObject);
                GameObject bullet = (GameObject)Instantiate(greenLaser, spawnE.position, spawnE.rotation);
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
