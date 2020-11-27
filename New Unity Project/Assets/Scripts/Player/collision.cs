using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[RequireComponent(typeof(Collider))]
public class collision : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }
    void OnCollisionStay(Collision collision)
    {
        if (collision.gameObject.tag == "ground")
        {
           // Debug.Log("On Ground");
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
