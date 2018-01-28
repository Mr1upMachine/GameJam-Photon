using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Tilemaps;

public class GameManager : MonoBehaviour {

    private Tilemap tilemap;
    public GameObject camera;
    private Grid grid;
    private List<Tile> tiles = new List<Tile>();
    int yMax, yMin, xMax, xMin;



	// Use this for initialization
	void Start () {
        //swap tiles for their gameObjects
        tilemap = GameObject.Find("Tilemap").GetComponent<Tilemap>();
        grid = GameObject.Find("Grid").GetComponent<Grid>();
        SwapTiles();
        xMin = -15;
        xMax = 16;
        yMax = 11;
        yMin = -11;

    }

    void SwapTiles()
    {
        int iterator = 0;
        for (int i = xMin; i < xMax; i++)
        {
            for (int j = yMin; j < yMax; j++)
            {
                Vector3Int temp = new Vector3Int(i, j, 0);
                Debug.Log("Trying Pos: " + temp);
                if (tilemap.GetTile(temp) != null)
                {
                    tiles.Add((Tile) tilemap.GetTile(temp));
                }
            }
        }
        Vector3Int v3 = new Vector3Int(-4, -4, 0);
        tiles.Add((Tile)tilemap.GetTile(v3));
        Debug.Log("Number of Tiles found on Tilemap: " + tiles.Count);
    }

    //void FixedUpdate()
    //{
    //    Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);

    //    RaycastHit hitInfo;
    //    if(Physics.Raycast(ray, out hitInfo)) //raycast out from where the mouse is
    //    {
    //        GameObject ourHitObject = hitInfo.collider.transform.gameObject; //get the gameobject it's hitting
    //        if (Input.GetMouseButtonDown(0)) //if they are clicking
    //        {
    //            Debug.Log("I clicked " + ourHitObject.name + ".");
    //            Debug.Log("I clicked " + ourHitObject.tag + " tag.");

    //            if(ourHitObject.tag == "Mirror")
    //            {
    //                //logic for rotating mirrors etc when they are clicked
    //                //ourHitObject.SendMessage("Rotate", parameter);  USE THIS FORMAT FOR ROTATING OBJECTS
    //            }
    //        }
    //    }
    //}
}
