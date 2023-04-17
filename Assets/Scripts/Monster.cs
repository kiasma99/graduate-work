using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Monster : MonoBehaviour
{
    private Animator animator;
    private Grid grid;
    GameObject Player;
    Character character;
    public bool MoveFront = false;
    public bool MoveFrontLeft = false;
    public bool MoveFrontRight = false;
    public bool MoveBack = false;
    public bool MoveBackLeft = false;
    public bool MoveBackRight = false;
    Vector3 moveVelocity = Vector3.zero;
    float moveSpeed = 0.5f;

    // Start is called before the first frame update
    void Start()
    {
        //animator = GetComponent<Animator>();
        grid = transform.parent.GetComponentInParent<Grid>();

        Player = GameObject.Find("Player");
        character = Player.GetComponent<Character>();
    }

    // Update is called once per frame
    void Update()
    {
        if (MoveFront)
        {
            //animator.SetInteger("WalkType", 1);
            transform.rotation = Quaternion.Euler(0, 0, 0);
            moveVelocity = grid.CellToWorld(new Vector3Int(1, 0, 0));
            transform.position += moveVelocity * moveSpeed * Time.deltaTime;
        }
        if (MoveFrontLeft)
        {
            //animator.SetInteger("WalkType", 2);
            transform.rotation = Quaternion.Euler(0, 180, 0);
            moveVelocity = grid.CellToWorld(new Vector3Int(0, -1, 0));
            transform.position += moveVelocity * moveSpeed * Time.deltaTime;
        }
        if (MoveFrontRight)
        {
            //animator.SetInteger("WalkType", 2);
            transform.rotation = Quaternion.Euler(0, 0, 0);
            moveVelocity = grid.CellToWorld(new Vector3Int(0, 1, 0));
            transform.position += moveVelocity * moveSpeed * Time.deltaTime;
        }
        if (MoveBackLeft)
        {
            //animator.SetInteger("WalkType", 2);
            transform.rotation = Quaternion.Euler(0, 180, 0);
            moveVelocity = grid.CellToWorld(new Vector3Int(-1, -1, 0));
            transform.position += moveVelocity * moveSpeed * Time.deltaTime;
        }
        if (MoveBackRight)
        {
            //animator.SetInteger("WalkType", 2);
            transform.rotation = Quaternion.Euler(0, 0, 0);
            moveVelocity = grid.CellToWorld(new Vector3Int(-1, 1, 0));
            transform.position += moveVelocity * moveSpeed * Time.deltaTime;
        }
        if (MoveBack)
        {
            //animator.SetInteger("WalkType", 3);
            transform.rotation = Quaternion.Euler(0, 0, 0);
            moveVelocity = grid.CellToWorld(new Vector3Int(-1, 0, 0));
            transform.position += moveVelocity * moveSpeed * Time.deltaTime;
        }
        if (character.Clear)
        {
            CommandClear();
            //animator.SetBool("Clear", true);
            transform.rotation = Quaternion.Euler(0, 0, 0);
            moveVelocity = Vector3.zero;
        }
        if (character.Fail)
        {
            CommandClear();
            //animator.SetBool("Clear", true);
            transform.rotation = Quaternion.Euler(0, 0, 0);
            moveVelocity = Vector3.zero;
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (transform.name == "Monster_6_1")
        {
            if (MoveFront)
            {
                CommandClear();
                MoveBackLeft = true;
            }
            else
            {
                CommandClear();
                MoveBack = true;
            }
        }

        else if(transform.name == "Monster_6_2")
        {
            if (MoveBackLeft)
            {
                CommandClear();
                MoveBack = true;
            }
            else
            {
                CommandClear();
                MoveFrontLeft = true;
            }
        }
    }

        private void CommandClear()
    {
        MoveFront = false;
        MoveFrontLeft = false;
        MoveFrontRight = false;
        MoveBack = false;
        MoveBackLeft = false;
        MoveBackRight = false;
    }
}
