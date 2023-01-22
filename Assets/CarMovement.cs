using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CarMovement : MonoBehaviour
{
    public float speed = 10f;

    void Update()
    {
        float horizontal = Input.GetAxis("Horizontal");
        float vertical = Input.GetAxis("Vertical");

        transform.position += transform.forward * vertical * speed * Time.deltaTime;
        transform.Rotate(0, horizontal * speed * Time.deltaTime * 4, 0);
    }
}
