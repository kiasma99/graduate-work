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
    float moveSpeed = 3;

    // Start is called before the first frame update
    void Start()
    {
        animator = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
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
            moveVelocity = new Vector3(-0.34f, 0.20f, 0);
            transform.position += moveVelocity * moveSpeed * Time.deltaTime;
        }
        if (MoveFrontRight)
        {
            animator.SetInteger("WalkType", 2);
            moveVelocity = new Vector3(0.34f, 0.20f, 0);
            transform.rotation = Quaternion.Euler(0, 0, 0);
            transform.position += moveVelocity * moveSpeed * Time.deltaTime;
        }
        if (MoveBackLeft)
        {
            animator.SetInteger("WalkType", 2);
            transform.rotation = Quaternion.Euler(0, 180, 0);
            moveVelocity = new Vector3(-0.34f, -0.20f, 0);
            transform.position += moveVelocity * moveSpeed * Time.deltaTime;
        }
        if (MoveBackRight)
        {
            animator.SetInteger("WalkType", 2);
            transform.rotation = Quaternion.Euler(0, 0, 0);
            moveVelocity = new Vector3(0.34f, -0.20f, 0);
            transform.position += moveVelocity * moveSpeed * Time.deltaTime;
        }
        if (MoveBack)
        {
            animator.SetInteger("WalkType", 3);
            transform.rotation = Quaternion.Euler(0, 0, 0);
            moveVelocity = new Vector3(0, -0.20f, 0);
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
        if (collision.gameObject.tag == "Front")
        {
            CommandClear();
            MoveFront = true;
        }
        if (collision.gameObject.tag == "FrontLeft")
        {
            CommandClear();
            MoveFrontLeft = true;
        }
        if (collision.gameObject.tag == "FrontRight")
        {
            CommandClear();
            MoveFrontRight = true;
        }
        else if (collision.gameObject.tag == "CrossWalk")
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
        else if (collision.gameObject.tag == "DeadEnd")
        {
            if (MoveFrontLeft)
            {
                CommandClear();
                MoveBackRight = true;
                BackCrossWalk = true;
            }
            else if (MoveFrontRight)
            {
                CommandClear();
                MoveBackLeft = true;
                BackCrossWalk = true;
            }
            else if (MoveBackLeft)
            {
                CommandClear();
                MoveFrontRight = true;
                BackCrossWalk = true;
            }
            else if(MoveBackRight)
            {
                CommandClear();
                MoveFrontLeft = true;
                BackCrossWalk = true;
            }
        }
        else if(collision.gameObject.tag == "Goal")
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
