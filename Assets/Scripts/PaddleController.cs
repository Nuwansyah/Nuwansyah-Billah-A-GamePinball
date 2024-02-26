using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PaddleKanan : MonoBehaviour
{

    public KeyCode input;
    private HingeJoint hinge;

    private float targetReleased;
    private float targetPressed;

    void Start()
    {
        hinge = GetComponent<HingeJoint>();
        targetPressed = hinge.limits.max;
        targetReleased = hinge.limits.min;
    }


    void Update()
    {
        ReadInput();
    }

    private void ReadInput()
    {
        JointSpring jointSpring =hinge.spring;

        if (Input.GetKey(input))
        {
            
            jointSpring.targetPosition = targetPressed;
        }
        else
        {
            jointSpring.targetPosition = targetReleased;
        }
        hinge.spring = jointSpring;

    }
}
