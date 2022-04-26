using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float speed = 4000f;
    public float angle = 5f;

    public float currentTurnAngle = 0;

    public WheelCollider frontright;
    public WheelCollider frontleft;
    public WheelCollider backright;
    public WheelCollider backleft;

    
    // Update is called once per frame
    void FixedUpdate()
    {
        frontleft.motorTorque = speed;
        frontright.motorTorque = speed;

        currentTurnAngle = angle * Input.GetAxis("Horizontal");
        frontleft.steerAngle= currentTurnAngle;
        frontright.steerAngle = currentTurnAngle;

    }
}
