using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class H2Atom : MonoBehaviour
{
    [SerializeField] private GameObject He3Atom;
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

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "H2")
        {
            float collisionAtomLifeTime = collision.gameObject.GetComponent<H2Atom>().lifeTime;

            if (lifeTime > collisionAtomLifeTime)
            {
                Instantiate(He3Atom, transform.position, Quaternion.identity);
                Destroy(collision.gameObject);
            }
            else
            {
                Destroy(collision.gameObject);
            }
        }
    }
}
