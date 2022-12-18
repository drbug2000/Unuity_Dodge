using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    public float speed = 8f;
    private Rigidbody bulletRigidbody;

    void Start()
    {
        bulletRigidbody = GetComponent<Rigidbody>();

        bulletRigidbody.velocity = transform.forward * speed;

        Destroy(gameObject, 2f);
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            //PlayerController playerController = other.GetComponent<PlayerController>();
            PlayerController playerController = (other.GetComponent<Rigidbody>()).GetComponent<PlayerController>();


            if (playerController != null)
            {
                playerController.Die();


            }
        }



    }
    /*
    // Update is called once per frame
    void Update()
    {
        
    }
    */
}
