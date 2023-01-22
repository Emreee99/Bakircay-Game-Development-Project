using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TextMovement : MonoBehaviour
{
    public float speed = 6f;

    Vector3 movement;
    Animator anim;
    Rigidbody playerRigidbody;
    int floorMask;
    float camRayLength = 100f;

    void Awake()
    {
        floorMask = LayerMask.GetMask("Floor");
    }

    void FixedUpdate()
    {
        float horizontal = Input.GetAxis("Horizontal");
        float vertical = Input.GetAxis("Vertical");

        transform.position += transform.forward * vertical * speed * Time.deltaTime;
        transform.Rotate(0, horizontal * speed * Time.deltaTime * 8, 0);

    }


}
