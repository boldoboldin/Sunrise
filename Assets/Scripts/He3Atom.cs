using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class He3Atom : MonoBehaviour
{
    [SerializeField] private GameObject He4Atom;
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
        if (collision.gameObject.tag == "He3")
        {
            float collisionAtomLifeTime = collision.gameObject.GetComponent<He3Atom>().lifeTime;

            if (lifeTime > collisionAtomLifeTime)
            {
                Instantiate(He4Atom, transform.position, Quaternion.identity);
                Destroy(collision.gameObject);
            }
            else
            {
                Destroy(collision.gameObject);
            }
        }
    }
}