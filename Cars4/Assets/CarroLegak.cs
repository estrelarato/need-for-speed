using UnityEngine;

public class CarController : MonoBehaviour
{
    public WheelJoint2D wheelLeft;
    public WheelJoint2D wheelRight;
    public float motorSpeed = -1500f;
    public float maxTorque = 1000f;

    void Update()
    {
        float input = Input.GetAxis("Horizontal");

        JointMotor2D motor = new JointMotor2D();
        motor.motorSpeed = motorSpeed * input;
        motor.maxMotorTorque = maxTorque;

        wheelLeft.motor = motor;
        wheelRight.motor = motor;
    }
}
