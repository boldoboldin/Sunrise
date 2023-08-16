using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ElectrosphereMove : MonoBehaviour
{
    private float vel;
    
    // Start is called before the first frame update
    void Start()
    {
        vel = Random.Range(-1, 1);
    }

    // Update is called once per frame
    void Update()
    {
        transform.localRotation = Quaternion.Euler(transform.localRotation.x, transform.localRotation.y, transform.localRotation.z + vel * Time.deltaTime);
    }
}
