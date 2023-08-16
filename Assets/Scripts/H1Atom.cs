using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class H1Atom : MonoBehaviour
{
    [SerializeField] private GameObject H2Atom;
    public float lifeTime;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        lifeTime += Time.deltaTime;
    }

    private void OnCollisionEnter (Collision collision)
    {
       if (collision.gameObject.tag == "H1")
       {
            float collisionAtomLifeTime = collision.gameObject.GetComponent<H1Atom>().lifeTime;
            
            if(lifeTime > collisionAtomLifeTime)
            {
                Instantiate(H2Atom, transform.position, Quaternion.identity);
                Destroy(collision.gameObject);
            }
            else
            {
                Destroy(collision.gameObject);
            }
       }
    }
}
