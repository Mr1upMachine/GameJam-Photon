using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Tilemaps;

public class GameManager : MonoBehaviour {

    public Tilemap tilemap;
    public GameObject camera;


	// Use this for initialization
	void Start () {
		
	}

    void FixedUpdate()
    {
        Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);

        RaycastHit hitInfo;
        if(Physics.Raycast(ray, out hitInfo)) //raycast out from where the mouse is
        {
            GameObject ourHitObject = hitInfo.collider.transform.gameObject; //get the gameobject it's hitting
            if (Input.GetMouseButtonDown(0)) //if they are clicking
            {
                Debug.Log("I clicked " + ourHitObject.name + ".");
                Debug.Log("I clicked " + ourHitObject.tag + " tag.");

                if(ourHitObject.tag == "Mirror")
                {
                    //logic for rotating mirrors etc when they are clicked
                    //ourHitObject.SendMessage("Rotate", parameter);  USE THIS FORMAT FOR ROTATING OBJECTS
                }
            }
        }
    }
}
