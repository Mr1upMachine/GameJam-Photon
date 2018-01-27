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

    private void Start()
    {
        tilemap = GameObject.Find("Tilemap").GetComponent<Tilemap>();
        grid = GameObject.Find("Grid").GetComponent<Grid>();
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
        Debug.Log(curScreenPoint);
        Debug.Log("Grid location: " + grid.WorldToCell(curPosition));
        Vector3Int v3 = new Vector3Int(-2, -5, 0);
        //Debug.Log("There is a tile at this location: " + tilemap.HasTile(v3));
        //Vector3Int gridPos = grid.WorldToCell(curPosition);
        //Debug.Log("Grid Pos is: " + gridPos);
        //Debug.Log("There is a tile at this location: " + tilemap.HasTile(gridPos));
        //Debug.Log("The world location of that cell is: " + grid.CellToWorld(gridPos));
        transform.position = curPosition;
    }

    void OnMouseUp()
    {
        Vector3Int cellPosition = grid.WorldToCell(transform.position);
        transform.position = grid.GetCellCenterWorld(cellPosition);
    }
}