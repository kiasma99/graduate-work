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

        // Stage 1
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

        // Stage 2
        else if (transform.name == "CrossWalk_2_1")
        {
            transform.position = grid.CellToWorld(new Vector3Int(-1, 0, 0));
        }
        else if (transform.name == "CrossWalk_2_2")
        {
            transform.position = grid.CellToWorld(new Vector3Int(-1, 1, 0));
        }
        else if (transform.name == "CrossWalk_2_3")
        {
            transform.position = grid.CellToWorld(new Vector3Int(-1, -1, 0));
        }
        else if (transform.name == "CrossWalk_2_4")
        {
            transform.position = grid.CellToWorld(new Vector3Int(0, -1, 0));
        }
        else if (transform.name == "CrossWalk_2_5")
        {
            transform.position = grid.CellToWorld(new Vector3Int(0, 0, 0));
        }
        else if (transform.name == "DeadEnd_2_1")
        {
            transform.position = grid.CellToWorld(new Vector3Int(-1, 2, 0));
        }
        else if (transform.name == "DeadEnd_2_2")
        {
            transform.position = grid.CellToWorld(new Vector3Int(1, 0, 0));
        }
        else if (transform.name == "FrontRight_2")
        {
            transform.position = grid.CellToWorld(new Vector3Int(0, -2, 0));
        }
        else if (transform.name == "Goal_2")
        {
            transform.position = grid.CellToWorld(new Vector3Int(0, 1, 0));
        }

        //Stage 3
        else if (transform.name == "CrossWalk_3_1")
        {
            transform.position = grid.CellToWorld(new Vector3Int(-2, 1, 0));
        }
        else if (transform.name == "CrossWalk_3_2")
        {
            transform.position = grid.CellToWorld(new Vector3Int(-1, 0, 0));
        }
        else if (transform.name == "CrossWalk_3_3")
        {
            transform.position = grid.CellToWorld(new Vector3Int(-1, 1, 0));
        }
        else if (transform.name == "CrossWalk_3_4")
        {
            transform.position = grid.CellToWorld(new Vector3Int(0, 2, 0));
        }
        else if (transform.name == "CrossWalk_3_5")
        {
            transform.position = grid.CellToWorld(new Vector3Int(-1, -1, 0));
        }
        else if (transform.name == "CrossWalk_3_6")
        {
            transform.position = grid.CellToWorld(new Vector3Int(0, 0, 0));
        }
        else if (transform.name == "CrossWalk_3_7")
        {
            transform.position = grid.CellToWorld(new Vector3Int(0, -1, 0));
        }
        else if (transform.name == "CrossWalk_3_8")
        {
            transform.position = grid.CellToWorld(new Vector3Int(0, 1, 0));
        }
        else if (transform.name == "CrossWalk_3_9")
        {
            transform.position = grid.CellToWorld(new Vector3Int(1, 1, 0));
        }
        else if (transform.name == "DeadEnd_3_1")
        {
            transform.position = grid.CellToWorld(new Vector3Int(-2, 2, 0));
        }
        else if (transform.name == "DeadEnd_3_2")
        {
            transform.position = grid.CellToWorld(new Vector3Int(-1, 3, 0));
        }
        else if (transform.name == "Road_3")
        {
            transform.position = grid.CellToWorld(new Vector3Int(-1, 2, 0));
        }
        else if (transform.name == "Front_3")
        {
            transform.position = grid.CellToWorld(new Vector3Int(-2, -1, 0));
        }
        else if (transform.name == "FrontRight_3_1")
        {
            transform.position = grid.CellToWorld(new Vector3Int(-2, 0, 0));
        }
        else if (transform.name == "FrontRight_3_2")
        {
            transform.position = grid.CellToWorld(new Vector3Int(0, -2, 0));
        }
        else if (transform.name == "FrontRight_3_3")
        {
            transform.position = grid.CellToWorld(new Vector3Int(1, 0, 0));
        }
        else if (transform.name == "BackRight_3")
        {
            transform.position = grid.CellToWorld(new Vector3Int(1, -1, 0));
        }
        else if (transform.name == "Goal_3")
        {
            transform.position = grid.CellToWorld(new Vector3Int(2, 1, 0));
        }

        //Stage 4
        else if (transform.name == "CrossWalk_4_1")
        {
            transform.position = grid.CellToWorld(new Vector3Int(-1, 0, 0));
        }
        else if (transform.name == "CrossWalk_4_2")
        {
            transform.position = grid.CellToWorld(new Vector3Int(-1, 1, 0));
        }
        else if (transform.name == "DeadEnd_4_1")
        {
            transform.position = grid.CellToWorld(new Vector3Int(-1, -1, 0));
        }
        else if (transform.name == "DeadEnd_4_2")
        {
            transform.position = grid.CellToWorld(new Vector3Int(0, 2, 0));
        }
        else if (transform.name == "Trap_4")
        {
            transform.position = (grid.CellToWorld(new Vector3Int(0, 0, 0)) + grid.CellToWorld(new Vector3Int(-1, 1, 0)))/2;
        }
        else if (transform.name == "Tool_4")
        {
            transform.position = grid.CellToWorld(new Vector3Int(-1, -1, 0));
        }
        else if (transform.name == "Goal_4")
        {
            transform.position = grid.CellToWorld(new Vector3Int(0, 0, 0));
        }

        //Stage 5
        else if (transform.name == "CrossWalk_5_1")
        {
            transform.position = grid.CellToWorld(new Vector3Int(-2, -1, 0));
        }
        else if (transform.name == "CrossWalk_5_2")
        {
            transform.position = grid.CellToWorld(new Vector3Int(-1, 0, 0));
        }
        else if (transform.name == "CrossWalk_5_3")
        {
            transform.position = grid.CellToWorld(new Vector3Int(-1, -2, 0));
        }
        else if (transform.name == "CrossWalk_5_4")
        {
            transform.position = grid.CellToWorld(new Vector3Int(-1, -1, 0));
        }
        else if (transform.name == "CrossWalk_5_5")
        {
            transform.position = grid.CellToWorld(new Vector3Int(-1, 1, 0));
        }
        else if (transform.name == "CrossWalk_5_6")
        {
            transform.position = grid.CellToWorld(new Vector3Int(-2, 1, 0));
        }
        else if (transform.name == "DeadEnd_5")
        {
            transform.position = grid.CellToWorld(new Vector3Int(0, -2, 0));
        }
        else if (transform.name == "FrontLeft_5")
        {
            transform.position = grid.CellToWorld(new Vector3Int(-2, 0, 0));
        }
        else if (transform.name == "Road_5_1")
        {
            transform.position = grid.CellToWorld(new Vector3Int(0, 0, 0));
        }
        else if (transform.name == "Road_5_2")
        {
            transform.position = grid.CellToWorld(new Vector3Int(-2, -2, 0));
        }
        else if (transform.name == "Road_5_3")
        {
            transform.position = grid.CellToWorld(new Vector3Int(0, 1, 0));
        }
        else if (transform.name == "Trap_5")
        {
            transform.position = (grid.CellToWorld(new Vector3Int(-2, 1, 0)) + grid.CellToWorld(new Vector3Int(-3, 1, 0))) / 2;
        }
        else if (transform.name == "Tool_5_1")
        {
            transform.position = grid.CellToWorld(new Vector3Int(0, -2, 0));
        }
        else if (transform.name == "Tool_5_2")
        {
            transform.position = (grid.CellToWorld(new Vector3Int(-1, 0, 0)) + grid.CellToWorld(new Vector3Int(-1, 1, 0))) / 2;
        }
        else if (transform.name == "Goal_5")
        {
            transform.position = grid.CellToWorld(new Vector3Int(-3, 1, 0));
        }
    }
}
