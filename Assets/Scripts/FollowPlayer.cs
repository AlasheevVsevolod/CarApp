using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowPlayer : MonoBehaviour
{
    // public Transform target; // The target object to follow
    // public float distance = 5f; // The distance between the camera and target object
    // public float height = 2f; // The height of the camera above the target object
    // public float smoothTime = 0.2f; // The smooth time for camera movement

    // public Vector3 velocity; // Velocity reference for SmoothDamp function

    public Transform target;
    public float distance = -10f; // The distance between the camera and target object
    public float height = 3f; // The height of the camera above the target object
    public float angle = 3f; // The height of the camera above the target object
    public Vector3 rotationAngles; // The height of the camera above the target object

    void LateUpdate()
    {
        transform.position = target.position + target.forward * distance + Vector3.up * height;
        transform.rotation = target.rotation * Quaternion.AngleAxis(transform.rotation.x, Vector3.right);
        // transform.rotation = target.rotation * Quaternion.Euler(rotationAngles);

    }
    // void LateUpdate()
    // {
    //     // Calculate the desired position and rotation of the camera
    //     Vector3 desiredPosition = target.position - target.forward * distance + Vector3.up * height;
    //     Quaternion desiredRotation = Quaternion.LookRotation(target.position - transform.position, Vector3.up);
    //
    //     // Smoothly move and rotate the camera towards the desired position and rotation
    //     transform.position = Vector3.SmoothDamp(transform.position, desiredPosition, ref velocity, smoothTime);
    //     transform.rotation = Quaternion.Slerp(transform.rotation, desiredRotation, smoothTime);
    // }

    // public GameObject player;
    // private Vector3 offset = new Vector3(0, 5, -7);
    //
    // private float turnSpeed = 100;
    // private float horizontalInput;
    //
    // // Start is called before the first frame update
    // void Start()
    // {
    //     // offset = transform.position - player.transform.position;
    //
    // }
    //
    // // Update is called once per frame
    // void Update()
    // {
    //     var angle = Time.deltaTime * turnSpeed * horizontalInput;
    //     horizontalInput = Input.GetAxis("Horizontal");
    //
    //     // offset = new Vector3(Mathf.Sin(angle), 0, Mathf.Cos(angle));
    //
    //     transform.position = player.transform.position + offset;
    //     transform.RotateAround(player.transform.position, Vector3.up, angle);
    // }
    //
    // private float DegToRad(float deg)
    // {
    //     return deg * Mathf.PI / 180;
    // }
}
