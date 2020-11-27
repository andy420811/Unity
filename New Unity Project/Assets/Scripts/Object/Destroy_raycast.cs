using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Destroy_raycast : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
        RaycastHit raycastHit;
        if (Input.GetMouseButton(0))
        {
            if(Physics.Raycast(ray ,out raycastHit))
            {
                Destroy(raycastHit.collider.gameObject);
            }
        }
    }
}
