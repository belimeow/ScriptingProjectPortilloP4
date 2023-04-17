using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Invoke : MonoBehaviour
{
    public GameObject targets;

    // Start is called before the first frame update
    void Start()
    {
        Invoke("SpawnObject", 2);

    }

    void SpawnObject()
    {
        Instantiate(targets, new Vector3(0, 2, 0), Quaternion.identity);
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
