using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CloudSpawner : MonoBehaviour
{

    [SerializeField] int waitTime;
    [SerializeField] GameObject clouds;
    void Start()
    {
        StartCoroutine(Spawn());
    }



    // Update is called once per frame
    void Update()
    {
        
    }

    IEnumerator Spawn()
    {
        Instantiate(clouds);
        yield return new WaitForSeconds(waitTime);
       StartCoroutine(Spawn());
    }
}
