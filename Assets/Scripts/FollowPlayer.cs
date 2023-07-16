using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowPlayer : MonoBehaviour
{
    public GameObject player;
    private Vector3 offset = new Vector3(0, 5, -7);

    private float turnSpeed = 100;
    private float horizontalInput;

    // Start is called before the first frame update
    void Start()
    {
        // offset = transform.position - player.transform.position;

    }

    // Update is called once per frame
    void Update()
    {
        var angle = Time.deltaTime * turnSpeed * horizontalInput;
        horizontalInput = Input.GetAxis("Horizontal");

        // offset = new Vector3(Mathf.Sin(angle), 0, Mathf.Cos(angle));

        transform.position = player.transform.position + offset;
        transform.RotateAround(player.transform.position, Vector3.up, angle);
    }

    private float DegToRad(float deg)
    {
        return deg * Mathf.PI / 180;
    }
}
