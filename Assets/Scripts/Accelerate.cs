using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Accelerate : MonoBehaviour
{
    void OnTriggerEnter(Collider other)
    {
        GetComponent<Rigidbody>().AddForce(Vector3.back * 1000.0f);
    }
}
