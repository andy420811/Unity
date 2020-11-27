using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[RequireComponent(typeof(Collider))]
public class Airdoor : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }
    void OnTriggerEnter(Collider collider)
    {
        Debug.Log("Welcome");
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
