using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Threading;
[RequireComponent(typeof(Rigidbody))]
public class Cube_Control : MonoBehaviour
{
    [SerializeField] Vector3 move_vector;
    [SerializeField] Transform camera;
    MeshRenderer meshRenderer;
    [SerializeField] float moving_speed;

    float origin_speed;
    bool state = false;
    Vector3 tmp;
    // Start is called before the first frame update
    void Start()
    {
        origin_speed = moving_speed;
        Debug.Log("Start");
        // Transform t = GetComponent<Transform>();
        transform.position = Vector3.zero;
        meshRenderer = GetComponent<MeshRenderer>();
        tmp = camera.localPosition;
    }

    // Update is called once per frame
    void Update()
    {

        transform.position += Time.deltaTime * move_vector;
        //    meshRenderer.material.color = new Color(((int)Time.time % 2) * 255f, 0f, 0f);
        if (Input.GetKeyDown(KeyCode.LeftShift))
        {
            moving_speed = 20;
        }
        else if(Input.GetKeyUp(KeyCode.LeftShift))
        {
            moving_speed = origin_speed;
        }
        if (Input.GetKey(KeyCode.W))
        {
            
            transform.localPosition += Time.deltaTime * moving_speed * Vector3.forward;
        }
        if (Input.GetKey(KeyCode.S))
        {
            transform.localPosition += Time.deltaTime * moving_speed * Vector3.back;
        }
        if (Input.GetKey(KeyCode.A))
        {
            transform.localPosition += Time.deltaTime * moving_speed * Vector3.left;
        }
        if (Input.GetKey(KeyCode.D))
        {
            transform.localPosition += Time.deltaTime * moving_speed * Vector3.right;
        }
        if (Input.GetKeyDown(KeyCode.C))
        {
            state = !state;
            if (state)
            {
                camera.localPosition += 7 * Vector3.back;
                camera.localPosition += 1 * Vector3.up;
            }
            else
            {
                camera.localPosition = tmp;
            }
        }
    }

}
