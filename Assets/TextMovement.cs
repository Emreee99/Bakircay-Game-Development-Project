using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TextMovement : MonoBehaviour
{
    public float speed = 6f; // movement speed

    Vector3 movement; // movement direction
    Animator anim; // reference to the animator component
    Rigidbody playerRigidbody; // reference to the rigidbody component
    int floorMask; // layer mask for the floor
    float camRayLength = 100f; // length of the ray from the camera

    void Awake()
    {
        // create a layer mask for the floor layer
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
