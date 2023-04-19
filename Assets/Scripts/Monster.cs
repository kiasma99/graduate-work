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
    float moveSpeed = 0.3f;

    // Start is called before the first frame update
    void Start()
    {
        animator = GetComponent<Animator>();
        grid = transform.parent.GetComponentInParent<Grid>();

        Player = GameObject.Find("Player");
        character = Player.GetComponent<Character>();
    }

    // Update is called once per frame
    void Update()
    {
        if (MoveFront)
        {
            animator.SetBool("Move", true);
            transform.rotation = Quaternion.Euler(0, 0, 0);
            moveVelocity = grid.CellToWorld(new Vector3Int(1, 0, 0));
            transform.position += moveVelocity * moveSpeed * Time.deltaTime;
        }
        if (MoveFrontLeft)
        {
            animator.SetBool("Move", true);
            transform.rotation = Quaternion.Euler(0, 0, 0);
            moveVelocity = grid.CellToWorld(new Vector3Int(0, -1, 0));
            transform.position += moveVelocity * moveSpeed * Time.deltaTime;
        }
        if (MoveFrontRight)
        {
            animator.SetBool("Move", true);
            transform.rotation = Quaternion.Euler(0, 180, 0);
            moveVelocity = grid.CellToWorld(new Vector3Int(0, 1, 0));
            transform.position += moveVelocity * moveSpeed * Time.deltaTime;
        }
        if (MoveBackLeft)
        {
            animator.SetBool("Move", true);
            transform.rotation = Quaternion.Euler(0, 0, 0);
            moveVelocity = grid.CellToWorld(new Vector3Int(-1, -1, 0));
            transform.position += moveVelocity * moveSpeed * Time.deltaTime;
        }
        if (MoveBackRight)
        {
            animator.SetBool("Move", true);
            transform.rotation = Quaternion.Euler(0, 180, 0);
            moveVelocity = grid.CellToWorld(new Vector3Int(-1, 1, 0));
            transform.position += moveVelocity * moveSpeed * Time.deltaTime;
        }
        if (MoveBack)
        {
            animator.SetBool("Move", true);
            transform.rotation = Quaternion.Euler(0, 180, 0);
            moveVelocity = grid.CellToWorld(new Vector3Int(-1, 0, 0));
            transform.position += moveVelocity * moveSpeed * Time.deltaTime;
        }
        if (character.Pause)
        {
            animator.SetBool("Move", false);
            transform.rotation = Quaternion.Euler(0, 0, 0);
            moveSpeed = 0;
        }
        else
        {
            moveSpeed = 0.3f;
        }
        if (character.Clear)
        {
            CommandClear();
            animator.SetBool("Move", false);
            transform.rotation = Quaternion.Euler(0, 0, 0);
            moveVelocity = Vector3.zero;
        }
        if (character.Fail)
        {
            CommandClear();
            animator.SetBool("Move", false);
            transform.rotation = Quaternion.Euler(0, 0, 0);
            moveVelocity = Vector3.zero;
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
