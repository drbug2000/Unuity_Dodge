using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{

    private Rigidbody playerRigidbody;
    public float speed =  4.5f;
    
    
    
    void Start()
    {
        playerRigidbody = GetComponent<Rigidbody>();
    }

    
    void Update()
    {
   


        float x = Input.GetAxis("Horizontal");
        float z = Input.GetAxis("Vertical");

        float xspeed = x * speed;
        float zspeed = z * speed;

        Vector3 playerspeed = new Vector3(xspeed, 0, zspeed);


        playerRigidbody.velocity = playerspeed; 

    }

    public void Die() {
        //이 오브젝트를 비활성화.
        gameObject.SetActive(false); 
    }
}
