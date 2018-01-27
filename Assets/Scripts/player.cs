using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class player : MonoBehaviour {

	private List<GameObject> lasers = new List<GameObject>();
	private int counter = 0;
	private float shotSpeed;
	public GameObject laserPrefab;

	// Use this for initialization
	void Start () {
        shotSpeed = 5;
	}
    

	// Update is called once per frame
	void Update()
	{
		if (Input.GetKeyDown("mouse 0"))

		if (Input.GetKeyDown("mouse 0") && counter == 0)
		{
			GameObject bullet = (GameObject)Instantiate(laserPrefab, transform.position, Quaternion.identity);
			lasers.Add(bullet);
			counter = 25;
		}
		if (counter > 0 )
		{

			if (counter % 2.0 == 0.0) {
				GameObject bullet = (GameObject)Instantiate(laserPrefab, transform.position, Quaternion.identity);
				lasers.Add(bullet);
			}
			counter -= 1;
		}
		for(int count = 0; count < lasers.Count;count++ )
		{
			if (lasers[count] != null)
			{
				lasers[count].transform.Translate(new Vector3(0, 1) * Time.deltaTime * shotSpeed);
			}
		}
	}
}
