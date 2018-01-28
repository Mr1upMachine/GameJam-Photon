using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour {

	public static List<GameObject> lasers = new List<GameObject>();
	private float shotSpeed;
	public GameObject laserPrefab;
    public Transform spawn;
    public bool canRotate = true;

    // Use this for initialization
    void Start () {
        shotSpeed = 10;
	}
    
	private void FixedUpdate()
	{

		if (Input.GetKeyDown("space"))
		{
			GameObject bullet = (GameObject)Instantiate(laserPrefab, spawn.position, spawn.rotation);
			lasers.Add(bullet);
		}
		for(int count = 0; count < lasers.Count; count++ )
		{
			if (lasers[count] != null)
			{
				lasers[count].transform.Translate(new Vector3(0, 1) * Time.deltaTime * shotSpeed);
			}
		}
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
