using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ElectrosphereMove : MonoBehaviour
{
    private float vel;
    
    // Start is called before the first frame update
    void Start()
    {
        vel = 5;
    }

    // Update is called once per frame
    void Update()
    {
        transform.localRotation = Quaternion.Euler(new Vector3(transform.localRotation.x, transform.localRotation.y + vel * Time.deltaTime, transform.localRotation.z));
    }
}
