using UnityEngine;
using System.Collections;
using UnityEngine.Tilemaps;

[RequireComponent(typeof(BoxCollider2D))]

public class Draggable : MonoBehaviour
{
    private Vector3 screenPoint;
    private Vector3 offset;
    private Tilemap tilemap;
    private Grid grid;
    private bool collided;

    private void Start()
    {
        tilemap = GameObject.Find("Tilemap").GetComponent<Tilemap>();
        grid = GameObject.Find("Grid").GetComponent<Grid>();
        Debug.Log("Starting World Pos: " + transform.position);
    }

    void OnMouseDown()
    {

        offset = gameObject.transform.position - Camera.main.ScreenToWorldPoint(new Vector3(Input.mousePosition.x, Input.mousePosition.y, screenPoint.z));
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
        //float radius = 5f;
        //if (Physics.CheckSphere(spawnPos, radius))
        //{
        //    Debug.Log("Object found at World Position: " + spawnPos + "\n Objects Grid Pos: " + grid.WorldToCell(spawnPos));
        //} else
        //{

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



        Vector3Int cellPosition = grid.WorldToCell(transform.position);

        transform.position = grid.GetCellCenterWorld(cellPosition);
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        collided = true;
    }

    private void OnCollisionExit2D(Collision2D collision)
    {
        collided = false;
    }
}