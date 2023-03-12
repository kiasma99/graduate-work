using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Character : MonoBehaviour
{
    private Animator animator;
    public bool PressStart = false;
    Vector3 moveVelocity = Vector3.zero;
    float moveSpeed = 4;

    // Start is called before the first frame update
    void Start()
    {
        animator = GetComponent<Animator>();
        transform.position = new Vector3(0, -3, 0);
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
        if (PressStart)
        {
            moveVelocity = new Vector3(0, 0.10f, 0);
            animator.SetInteger("WalkType", 1);
            transform.position += moveVelocity * moveSpeed * Time.deltaTime;
        }
    }
}
