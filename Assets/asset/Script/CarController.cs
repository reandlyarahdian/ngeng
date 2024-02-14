using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CarController : MonoBehaviour
{
    public InputManager input;
    public List<WheelCollider> throttleWheels;
    public List<WheelCollider> steerWheels;
    public float strengthCoefficient = 2000f;
    public float maxTurn = 20f;

    void Start()
    {
        input = GetComponent<InputManager>();
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        foreach (WheelCollider wheel in throttleWheels)
        {
            wheel.motorTorque = strengthCoefficient * Time.deltaTime * input.throttle;
        }
        foreach (WheelCollider wheel in steerWheels)
        {
            wheel.steerAngle = maxTurn * input.steer;
        }

    }
}
