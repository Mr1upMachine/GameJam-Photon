using UnityEngine;
using System.Collections;
using UnityEngine.Tilemaps;


public class Draggable : MonoBehaviour
{
    private Vector3 screenPoint;
    private Vector3 offset;
    private Tilemap tilemap;
    private Grid grid;
    private GameObject[] allObj;
    //private bool collided;
    //private Rigidbody2D temp;

    private void Start()
    {
        tilemap = GameObject.Find("Tilemap").GetComponent<Tilemap>();
        grid = GameObject.Find("Grid").GetComponent<Grid>();
        Debug.Log("Starting World Pos: " + transform.position);
        if (gameObject.GetComponent(typeof(BoxCollider2D)) == null && gameObject.GetComponent(typeof(PolygonCollider2D)) == null)
        {
            //Debug.Log("Does not have a box collider, please set one");
            gameObject.AddComponent<BoxCollider2D>();
        }
        //collided = false;
    }

    //private void Update()
    //{
    //    if (Input.GetMouseButtonUp(0))
    //    {
    //        RaycastHit[] hits;
    //        Ray camRay = Camera.main.ScreenPointToRay(Input.mousePosition);
    //        hits = Physics.RaycastAll (camRay);

    //        Debug.Log("Hits: " + hits.Length);
    //        if (hits.Length > 2)
    //        {
    //            collided = true;
    //        }
    //    }
    //}

    void OnMouseDown()
    {

        offset = gameObject.transform.position - Camera.main.ScreenToWorldPoint(new Vector3(Input.mousePosition.x, Input.mousePosition.y, screenPoint.z));
        //temp = gameObject.AddComponent<Rigidbody2D>();
        
    }

    void OnMouseDrag()
    {
        //Debug.Log(tile.GetTileData(this.transform.position, tilemap, ));
        //Debug.Log(tilemap.localBounds);
        Vector3 curScreenPoint = new Vector3(Input.mousePosition.x, Input.mousePosition.y, screenPoint.z);
        Vector3 curPosition = Camera.main.ScreenToWorldPoint(curScreenPoint) + offset;
        //Debug.Log(curScreenPoint);
        //Debug.Log("Grid location: " + grid.WorldToCell(curPosition));
        //Vector3Int v3 = new Vector3Int(-2, -5, 0);
        //Debug.Log("There is a tile at this location: " + tilemap.HasTile(v3));
        //Vector3Int gridPos = grid.WorldToCell(curPosition);
        //Debug.Log("Grid Pos is: " + gridPos);
        //Debug.Log("There is a tile at this location: " + tilemap.HasTile(gridPos));
        //Debug.Log("The world location of that cell is: " + grid.CellToWorld(gridPos));
        transform.position = curPosition;
    }

    void OnMouseUp()
    {
        //spawn a sphere to check for objects at the specified position
        //Vector3 spawnPos = transform.position;
        //float radius = 100;
        //if (Physics.CheckSphere(spawnPos, radius))
        //{
        //    Debug.Log("Object found at World Position: " + spawnPos + "\n Objects Grid Pos: " + grid.WorldToCell(spawnPos));
        //}
        //else
        //{
        //    Debug.Log("Fuck Unity");
        //}
        //Debug.Log("New Pos: " + transform.position);

        //Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);

        //RaycastHit hitInfo;
        //if (Physics.Raycast(ray, out hitInfo)) //raycast out from where the mouse is
        //{
        //    GameObject ourHitObject = hitInfo.collider.transform.gameObject; //get the gameobject it's hitting
        //    if(ourHitObject != null)
        //    {
        //        Debug.Log("The object that you tried to place the item on is: " + ourHitObject.name);
        //    }
        //}


        //Debug.Log("Collided: " + collided);
        Vector3Int cellPosition = grid.WorldToCell(transform.position);
        Debug.Log(tilemap.GetInstantiatedObject(cellPosition));
        transform.position = grid.GetCellCenterWorld(cellPosition);

        //Destroy(temp);
    }

    private GameObject[] findAllGameObj(GameObject[] arr)
    {
        

        return arr;
    }

    //private void OnCollisionEnter2D(Collision2D collision)
    //{
    //    collided = true;
    //    //Debug.Log("Collision Trigger");
    //}

    //private void OnCollisionExit2D(Collision2D collision)
    //{
    //    collided = false;
    //}
}