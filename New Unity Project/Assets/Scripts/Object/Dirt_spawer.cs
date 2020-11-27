using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Dirt_spawer : MonoBehaviour
{
    public Transform cube;
    public Transform dirt;
    // Start is called before the first frame update
    void Start()
    {
        for (int i = 0; i < 30; i++)
        {
            if (Random.Range(0, 2) == 0)
            {
                Transform d = Instantiate(cube);
                d.parent = transform;
                d.localPosition = new Vector3(Random.Range(-30, 30), Random.Range(0, 5), Random.Range(-30, 30));

            }
            else
            {
                Transform c = Instantiate(dirt);
                c.parent = transform;
                c.localPosition = new Vector3(Random.Range(-30, 30), Random.Range(0, 5), Random.Range(-30, 30));
            }
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
