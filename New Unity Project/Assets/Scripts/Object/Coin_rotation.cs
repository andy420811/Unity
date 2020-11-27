using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Coin_rotation : MonoBehaviour
{
    public Vector3 Rotaion_direction;
    public float Rotation_amount;
    Rigidbody Rigidbody;
    // Start is called before the first frame update
    void Start()
    {
        Rigidbody = GetComponent<Rigidbody>();
        Rigidbody.AddTorque(Rotaion_direction * Rotation_amount);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
