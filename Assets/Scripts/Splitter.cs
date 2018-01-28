using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Splitter : MonoBehaviour {
    public GameObject whiteLaser, redLaser, blueLaser, greenLaser;
    public Transform spawnL, spawnR;
    public bool canRotate = true;
    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
    void OnTriggerEnter2D(Collider2D other)
    {
		GameObject laserL = whiteLaser;
		GameObject laserR = whiteLaser;

		if (tag == "splitWWW") {
			laserL = whiteLaser;
			laserR = whiteLaser;
		} else if (tag == "splitWBB") {
			laserL = blueLaser;
			laserR = blueLaser;
		} else if (tag == "splitWBG") {
			laserL = blueLaser;
			laserR = greenLaser;
		}else if (tag == "splitWBR") {
			laserL = blueLaser;
			laserR = redLaser;
		} else if (tag == "splitWGG") {
			laserL = greenLaser;
			laserR = greenLaser;
		} else if (tag == "splitWGR") {
			laserL = greenLaser;
			laserR = redLaser;
		} else if (tag == "splitwRR") {
			laserL = redLaser;
			laserR = redLaser;
		} else if (tag == "splitWRB") {
			laserL = redLaser;
			laserR = blueLaser;
		} else if (tag == "splitWRG") {
			laserL = redLaser;
			laserR = greenLaser;
		}

        Destroy(other.gameObject);
		GameObject bullet1 = (GameObject)Instantiate(laserL, spawnL.position, spawnL.rotation);
		GameObject bullet2 = (GameObject)Instantiate(laserR, spawnR.position, spawnR.rotation);
        Player.lasers.Add(bullet1);
        Player.lasers.Add(bullet2);
    }

    private void OnMouseOver()
    {
        if (canRotate)
        {
            if (Input.GetMouseButtonDown(1))
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
            }
        }
    }
}
