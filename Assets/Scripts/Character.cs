using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Character : MonoBehaviour
{
    public bool PressStart = false;
    Vector3 moveVelocity = Vector3.zero;
    float moveSpeed = 4;

    // Start is called before the first frame update
    void Start()
    {
        transform.position = new Vector3(0, -1, 0);
    }

    // Update is called once per frame
    void Update()
    {
        if (PressStart)
        {
            moveVelocity = new Vector3(0, 0.10f, 0);
            transform.position += moveVelocity * moveSpeed * Time.deltaTime;
        }
    }
}
