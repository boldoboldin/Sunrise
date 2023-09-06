using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class H1Geren : MonoBehaviour
{
    [SerializeField] private GameObject H1Atom;
    [SerializeField] private float minDist;
    [SerializeField] private float maxDist;

    [Header("Time Variables")]
    [SerializeField] private float gerenTimer;
    public float gerenCount;
    
    // Start is called before the first frame update
    void Start()
    {
        gerenCount = gerenTimer;
    }

    // Update is called once per frame
    void Update()
    {
        gerenCount -= Time.deltaTime;
        
        if (gerenCount <= 0)
        {
            Vector3 gerenPos = new Vector3(Random.Range(minDist, maxDist), Random.Range(minDist, maxDist), Random.Range(minDist, maxDist));
            Instantiate(H1Atom, gerenPos, Quaternion.identity);

            gerenCount = gerenTimer;
        }
    }
}
