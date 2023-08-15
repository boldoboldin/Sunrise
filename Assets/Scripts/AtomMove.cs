using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AtomMove : MonoBehaviour
{
    private Rigidbody rb;
    [SerializeField] float vel;
    
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = new Vector3((transform.position.x + Random.Range(-vel, vel)), (transform.position.y + Random.Range(-vel, vel)), transform.position.z);
    }
}
