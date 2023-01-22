using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraMovement : MonoBehaviour
{
    public Transform target; // the transform of the object to follow
    public float smoothTime = 0.3f; // the time it takes for the camera to catch up with the target's movement
    public Vector3 offset; // the distance between the camera and the target

    private Vector3 velocity = Vector3.zero; // the velocity at which the camera is moving

    void LateUpdate()
    {
        // set the position of the camera to the target's position, offset by the desired distance
        Vector3 desiredPosition = target.position + offset;
        transform.position = Vector3.SmoothDamp(transform.position, desiredPosition, ref velocity, smoothTime);
    }
}

