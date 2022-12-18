using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class secondDeBuging : MonoBehaviour
{
    // Start is called before the first frame update
    private float realTime;
    private float scondCounter;
    void Start()
    {
        realTime = 0f;
        scondCounter = 1f;
    }

    // Update is called once per frame
    void Update()
    {
        realTime += Time.deltaTime;
            if (realTime > scondCounter)
        {
            scondCounter++;
            Debug.Log(realTime + "√ ");
        }
    }
}
