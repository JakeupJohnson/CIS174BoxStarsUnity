using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PaddleScript : MonoBehaviour
{

    public float startingPosition = 0f;
    public float swingPosition = 45f;
    public float hitStrength = 10000f;
    public float paddleDamper = 150f;
    HingeJoint hinge;
    public string inputName;

    // Start is called before the first frame update
    void Start()
    {
        hinge = GetComponent<HingeJoint>();
        hinge.useSpring = true;
    }

    // Update is called once per frame
    void Update()
    {
        JointSpring spring = new JointSpring();
        spring.spring = hitStrength;
        spring.damper = paddleDamper;

        if (Input.GetAxis(inputName) == 1)
        {
            spring.targetPosition = swingPosition;
        }
        else
        {
            spring.targetPosition = startingPosition;
        }
        hinge.spring = spring;
        hinge.useLimits = true;

    }
}
