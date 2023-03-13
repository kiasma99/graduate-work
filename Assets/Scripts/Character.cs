using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Character : MonoBehaviour
{
    private Animator animator;
    public bool MoveFront = false;
    public bool MoveFrontLeft = false;
    public bool MoveFrontRight = false;
    public bool MoveBack = false;
    public bool MoveBackLeft = false;
    public bool MoveBackRight = false;
    public bool Finish = false;
    // Left가 true, Right가 false
    public bool LeftRight = false;
    public bool BackCrossWalk = false;
    Vector3 moveVelocity = Vector3.zero;
    float moveSpeed = 4;

    // Start is called before the first frame update
    void Start()
    {
        animator = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.W))
        {
            animator.SetInteger("WalkType", 1);
            transform.rotation = Quaternion.Euler(0, 0, 0);
        }
        if (Input.GetKey(KeyCode.A))
        {
            animator.SetInteger("WalkType", 2);
            transform.rotation = Quaternion.Euler(0, 180, 0);
        }
        if (Input.GetKey(KeyCode.D))
        {
            animator.SetInteger("WalkType", 2);
            transform.rotation = Quaternion.Euler(0, 0, 0);
        }
        if (Input.GetKey(KeyCode.S))
        {
            animator.SetInteger("WalkType", 3);
            transform.rotation = Quaternion.Euler(0, 0, 0);
        }
        if (MoveFront)
        {
            animator.SetInteger("WalkType", 1);
            moveVelocity = new Vector3(0, 0.20f, 0);
            transform.rotation = Quaternion.Euler(0, 0, 0);
            transform.position += moveVelocity * moveSpeed * Time.deltaTime;
        }
        if (MoveFrontLeft)
        {
            animator.SetInteger("WalkType", 2);
            transform.rotation = Quaternion.Euler(0, 180, 0);
            moveVelocity = new Vector3(-0.33f, 0.20f, 0);
            transform.position += moveVelocity * moveSpeed * Time.deltaTime;
        }
        if (MoveFrontRight)
        {
            animator.SetInteger("WalkType", 2);
            moveVelocity = new Vector3(0.33f, 0.20f, 0);
            transform.rotation = Quaternion.Euler(0, 0, 0);
            transform.position += moveVelocity * moveSpeed * Time.deltaTime;
        }
        if (MoveBackLeft)
        {
            animator.SetInteger("WalkType", 2);
            transform.rotation = Quaternion.Euler(0, 180, 0);
            moveVelocity = new Vector3(-0.33f, -0.20f, 0);
            transform.position += moveVelocity * moveSpeed * Time.deltaTime;
        }
        if (MoveBackRight)
        {
            animator.SetInteger("WalkType", 2);
            transform.rotation = Quaternion.Euler(0, 0, 0);
            moveVelocity = new Vector3(0.33f, -0.20f, 0);
            transform.position += moveVelocity * moveSpeed * Time.deltaTime;
        }
        if (Finish)
        {
            animator.SetInteger("WalkType", 0);
            transform.rotation = Quaternion.Euler(0, 0, 0);
            moveVelocity = Vector3.zero;
        }
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        Debug.Log("충돌");
        if (collision.gameObject.name == "Front")
        {
            CommandClear();
            MoveFront = true;
        }
        if (collision.gameObject.name == "FrontLeft")
        {
            CommandClear();
            MoveFrontLeft = true;
        }
        else if (collision.gameObject.name == "CrossWalk")
        {
            CommandClear();
            if (BackCrossWalk)
            {
                if (LeftRight)
                {
                    MoveFrontRight = true;
                }
                else
                {
                    MoveFrontLeft = true;
                }
                BackCrossWalk = false;
            }
            else
            {
                if (LeftRight)
                {
                    MoveFrontLeft = true;
                }
                else
                {
                    MoveFrontRight = true;
                }
            }
        }
        else if (collision.gameObject.name == "DeadEnd")
        {
            if (MoveFrontLeft)
            {
                CommandClear();
                MoveBackRight = true;
                BackCrossWalk = true;
            }
            else
            {
                CommandClear();
                MoveBackRight = true;
                BackCrossWalk = true;
            }
        }
        else if(collision.gameObject.name == "Goal")
        {
            CommandClear();
            Finish = true;
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
