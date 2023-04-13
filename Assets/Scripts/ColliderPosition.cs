using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColliderPosition : MonoBehaviour
{
    private Grid grid;
    // Start is called before the first frame update
    void Start()
    {
        grid = transform.parent.GetComponentInParent<Grid>();
        if (transform.name=="CrossWalk_1")
        {
            transform.position = grid.CellToWorld(new Vector3Int(-1, 0, 0));
        }
        else if (transform.name == "CrossWalk_1")
        {
            transform.position = grid.CellToWorld(new Vector3Int(-1, -1, 0));
        }
        else if (transform.name == "FrontLeft_1")
        {
            transform.position = grid.CellToWorld(new Vector3Int(-1, 1, 0));
        }
        else if (transform.name == "Goal_1")
        {
            transform.position = grid.CellToWorld(new Vector3Int(0, 0, 0));
        }
    }
}
