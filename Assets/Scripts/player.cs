using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class player : MonoBehaviour {

	private List<GameObject> lasers = new List<GameObject>();
	private float shotSpeed;
	public GameObject laserPrefab;
	// Use this for initialization
	void Start () {

	}

	// Update is called once per frame
	void Update () {

		shotSpeed = 5;
	}

	// Update is called once per frame
	void Update()
	{
		if (Input.GetKeyDown("mouse 0"))
		{
			GameObject bullet = (GameObject)Instantiate(laserPrefab, transform.position, Quaternion.identity);
			lasers.Add(bullet);
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
