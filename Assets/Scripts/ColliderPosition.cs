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
            transform.position = grid.CellToWorld(new Vector3Int(-1, 0, 0));
        }
        else if (transform.name == "CrossWalk_3_2")
        {
            transform.position = grid.CellToWorld(new Vector3Int(-1, 1, 0));
        }
        else if (transform.name == "DeadEnd_3_1")
        {
            transform.position = grid.CellToWorld(new Vector3Int(-1, -1, 0));
        }
        else if (transform.name == "DeadEnd_3_2")
        {
            transform.position = grid.CellToWorld(new Vector3Int(0, 2, 0));
        }
        else if (transform.name == "Trap_3")
        {
            transform.position = (grid.CellToWorld(new Vector3Int(0, 0, 0)) + grid.CellToWorld(new Vector3Int(-1, 1, 0)))/2;
        }
        else if (transform.name == "Tool_3")
        {
            transform.position = grid.CellToWorld(new Vector3Int(-1, -1, 0));
        }
        else if (transform.name == "Goal_3")
        {
            transform.position = grid.CellToWorld(new Vector3Int(0, 0, 0));
        }

        //Stage 4
        else if (transform.name == "CrossWalk_4_1")
        {
            transform.position = grid.CellToWorld(new Vector3Int(-2, -1, 0));
        }
        else if (transform.name == "CrossWalk_4_2")
        {
            transform.position = grid.CellToWorld(new Vector3Int(-1, 0, 0));
        }
        else if (transform.name == "CrossWalk_4_3")
        {
            transform.position = grid.CellToWorld(new Vector3Int(-1, -2, 0));
        }
        else if (transform.name == "CrossWalk_4_4")
        {
            transform.position = grid.CellToWorld(new Vector3Int(-1, -1, 0));
        }
        else if (transform.name == "CrossWalk_4_5")
        {
            transform.position = grid.CellToWorld(new Vector3Int(-1, 1, 0));
        }
        else if (transform.name == "CrossWalk_4_6")
        {
            transform.position = grid.CellToWorld(new Vector3Int(-2, 1, 0));
        }
        else if (transform.name == "DeadEnd_4")
        {
            transform.position = grid.CellToWorld(new Vector3Int(0, -2, 0));
        }
        else if (transform.name == "FrontLeft_4")
        {
            transform.position = grid.CellToWorld(new Vector3Int(-2, 0, 0));
        }
        else if (transform.name == "Road_4_1")
        {
            transform.position = grid.CellToWorld(new Vector3Int(0, 0, 0));
        }
        else if (transform.name == "Road_4_2")
        {
            transform.position = grid.CellToWorld(new Vector3Int(-2, -2, 0));
        }
        else if (transform.name == "Road_4_3")
        {
            transform.position = grid.CellToWorld(new Vector3Int(0, 1, 0));
        }
        else if (transform.name == "Trap_4")
        {
            transform.position = (grid.CellToWorld(new Vector3Int(-2, 1, 0)) + grid.CellToWorld(new Vector3Int(-3, 1, 0))) / 2;
        }
        else if (transform.name == "Tool_4_1")
        {
            transform.position = grid.CellToWorld(new Vector3Int(0, -2, 0));
        }
        else if (transform.name == "Tool_4_2")
        {
            transform.position = (grid.CellToWorld(new Vector3Int(-1, 0, 0)) + grid.CellToWorld(new Vector3Int(-1, 1, 0))) / 2;
        }
        else if (transform.name == "Goal_4")
        {
            transform.position = grid.CellToWorld(new Vector3Int(-3, 1, 0));
        }

        //Stage 5
        else if (transform.name == "CrossWalk_5_1")
        {
            transform.position = grid.CellToWorld(new Vector3Int(-1, 0, 0));
        }
        else if (transform.name == "CrossWalk_5_2")
        {
            transform.position = grid.CellToWorld(new Vector3Int(-1, 1, 0));
        }
        else if (transform.name == "DeadEnd_5_1")
        {
            transform.position = grid.CellToWorld(new Vector3Int(-1, -1, 0));
        }
        else if (transform.name == "DeadEnd_5_2")
        {
            transform.position = grid.CellToWorld(new Vector3Int(-2, 1, 0));
        }
        else if (transform.name == "Monster_5")
        {
            transform.position = (grid.CellToWorld(new Vector3Int(-2, 1, 0)) + grid.CellToWorld(new Vector3Int(-1, 1, 0))) / 2;
        }
        else if (transform.name == "Goal_5")
        {
            transform.position = grid.CellToWorld(new Vector3Int(0, 1, 0));
        }

        // Stage 6
        else if (transform.name == "CrossWalk_6_1")
        {
            transform.position = grid.CellToWorld(new Vector3Int(-2, 1, 0));
        }
        else if (transform.name == "CrossWalk_6_2")
        {
            transform.position = grid.CellToWorld(new Vector3Int(-1, 0, 0));
        }
        else if (transform.name == "CrossWalk_6_3")
        {
            transform.position = grid.CellToWorld(new Vector3Int(-1, 1, 0));
        }
        else if (transform.name == "CrossWalk_6_4")
        {
            transform.position = grid.CellToWorld(new Vector3Int(0, 2, 0));
        }
        else if (transform.name == "CrossWalk_6_5")
        {
            transform.position = grid.CellToWorld(new Vector3Int(-1, -1, 0));
        }
        else if (transform.name == "CrossWalk_6_6")
        {
            transform.position = grid.CellToWorld(new Vector3Int(0, 0, 0));
        }
        else if (transform.name == "CrossWalk_6_7")
        {
            transform.position = grid.CellToWorld(new Vector3Int(0, -1, 0));
        }
        else if (transform.name == "CrossWalk_6_8")
        {
            transform.position = grid.CellToWorld(new Vector3Int(0, 1, 0));
        }
        else if (transform.name == "CrossWalk_6_9")
        {
            transform.position = grid.CellToWorld(new Vector3Int(1, 1, 0));
        }
        else if (transform.name == "DeadEnd_6")
        {
            transform.position = grid.CellToWorld(new Vector3Int(0, 3, 0));
        }
        else if (transform.name == "Road_6")
        {
            transform.position = grid.CellToWorld(new Vector3Int(-1, 2, 0));
        }
        else if (transform.name == "Front_6_1")
        {
            transform.position = grid.CellToWorld(new Vector3Int(-2, -1, 0));
        }
        else if (transform.name == "Front_6_2")
        {
            transform.position = grid.CellToWorld(new Vector3Int(-2, 3, 0));
        }
        else if (transform.name == "FrontRight_6_1")
        {
            transform.position = grid.CellToWorld(new Vector3Int(-2, 0, 0));
        }
        else if (transform.name == "FrontRight_6_2")
        {
            transform.position = grid.CellToWorld(new Vector3Int(0, -2, 0));
        }
        else if (transform.name == "FrontRight_6_3")
        {
            transform.position = grid.CellToWorld(new Vector3Int(1, 0, 0));
        }
        else if (transform.name == "FrontRight_6_4")
        {
            transform.position = grid.CellToWorld(new Vector3Int(-2, 2, 0));
        }
        else if (transform.name == "FrontLeft_6")
        {
            transform.position = grid.CellToWorld(new Vector3Int(-1, 3, 0));
        }
        else if (transform.name == "BackRight_6")
        {
            transform.position = grid.CellToWorld(new Vector3Int(1, -1, 0));
        }
        else if (transform.name == "Trap_6_1")
        {
            transform.position = (grid.CellToWorld(new Vector3Int(1, 1, 0)) + grid.CellToWorld(new Vector3Int(2, 1, 0))) / 2;
        }
        else if (transform.name == "Trap_6_2")
        {
            transform.position = (grid.CellToWorld(new Vector3Int(0, 1, 0)) + grid.CellToWorld(new Vector3Int(0, 2, 0))) / 2;
        }
        else if (transform.name == "Tool_6_1")
        {
            transform.position = grid.CellToWorld(new Vector3Int(-2, 2, 0));
        }
        else if (transform.name == "Tool_6_2")
        {
            transform.position = grid.CellToWorld(new Vector3Int(-1, -1, 0));
        }
        else if (transform.name == "Tool_6_3")
        {
            transform.position = grid.CellToWorld(new Vector3Int(-1, 1, 0));
        }
        else if (transform.name == "Tool_6_4")
        {
            transform.position = grid.CellToWorld(new Vector3Int(0, 3, 0));
        }
        else if (transform.name == "Monster_6_1")
        {
            transform.position = (grid.CellToWorld(new Vector3Int(1, 1, 0)) + grid.CellToWorld(new Vector3Int(0, 1, 0))) / 2;
        }
        else if (transform.name == "Monster_6_2")
        {
            transform.position = (grid.CellToWorld(new Vector3Int(0, 0, 0)) + grid.CellToWorld(new Vector3Int(-1, -1, 0))) / 2;
        }
        else if (transform.name == "Goal_6")
        {
            transform.position = grid.CellToWorld(new Vector3Int(2, 1, 0));
        }
    }
}
