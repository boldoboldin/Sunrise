using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AtomMove : MonoBehaviour
{
    private Rigidbody rb;
    [SerializeField] private float vibration;
    [SerializeField] private float velVar;
    private float velX;
    private float velY;




    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
        velX = Random.Range(-velVar, velVar);
        velY = Random.Range(-velVar, velVar);
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = new Vector3((transform.position.x + velX + Random.Range(-vibration, vibration)), (transform.position.y + velY + Random.Range(-vibration, vibration)), transform.position.z);
    }
}
