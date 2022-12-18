using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletSpawner : MonoBehaviour
{
    public GameObject BulletPrefab;

    public float delayMin = 1f;
    public float delayMax = 3f;

    private Transform target;
    //public GameObject Player = FindObject<PlayerController>();
    private float delayTime;
    private float timeNow ;

    
    void Start()
    {
        timeNow = 0f;
        delayTime = Random.Range(delayMin, delayMax);
        target = FindObjectOfType<PlayerController>().transform;

    }

    
    void Update()
    {
        timeNow += Time.deltaTime;
        if(timeNow >= delayTime)
        { 
        GameObject Bullet = Instantiate(BulletPrefab, transform.position, transform.rotation);
        timeNow = 0f;
        Bullet.transform.LookAt(target);
        delayTime = Random.Range(delayMin, delayMax);

        }

    }
}
