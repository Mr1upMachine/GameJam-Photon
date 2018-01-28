using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemUI : MonoBehaviour {

	public List<GameObject> objects = new List<GameObject>();
	public List<int> objectCounts = new List<int> ();
	private int cnt = 0;
	private List<Vector3>startLocations = new List<Vector3>();

	// Use this for initialization
	void Start () {
		int count = objects.Count;
		cnt = count;
	}
	
	// Update is called once per frame
	void Update () {
		for (int i = 1; i <= cnt; i++) {
			if (objectCounts [i - 1] > 0) {
                Debug.Log(transform.position.x);
                Vector3 tempVec = new Vector3 (transform.position.x, 5 - i, 0.0f);
				objects [i - 1] = (GameObject)Instantiate (objects [i - 1], tempVec, Quaternion.Euler (0, 0, 0));
				startLocations.Add (tempVec);
				objectCounts[i - 1]--;
			}
		}
	}

	void OnTriggerEnter2D(Collider2D other)
	{
		Destroy(other.gameObject);
	}
}
