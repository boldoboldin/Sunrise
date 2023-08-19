using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ElectrosphereMove : MonoBehaviour
{
    private float vel;
    
    // Start is called before the first frame update
    void Start()
    {
        vel = Random.Range(150, 300);
    }

    // Update is called once per frame
    void Update()
    {
        transform.localEulerAngles = new Vector3(transform.localEulerAngles.x, transform.localEulerAngles.y + vel * Time.deltaTime, transform.localEulerAngles.z);
    }
}
