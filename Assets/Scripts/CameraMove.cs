using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraMove : MonoBehaviour
{
    public GameObject Target;

    public float offsetX = 0.0f;
    public float offsetY = 0.5f;

    public float CameraSpeed = 10.0f;
    Vector3 TargetPos;

    // Update is called once per frame
    void FixedUpdate()
    {
        TargetPos = Target.transform.position + new Vector3(offsetX, offsetY, -1.0f);

        transform.position = Vector3.Lerp(transform.position, TargetPos, Time.deltaTime * CameraSpeed);
    }
}
