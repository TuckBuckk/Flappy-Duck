using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnerScript : MonoBehaviour
{

    bool phase1isActive = true;
    bool phase2isActive = false;
    bool phase3isActive = false;

    [SerializeField] GameObject[] pipePrefabs;
    
    [Tooltip("How long it takes for the next pipe to spawn in seconds.")] [SerializeField] float PipeSpawnTime = 2;
    [Tooltip("How long it takes for the next pipe to spawn in seconds.")] [SerializeField] float GroundSpawnTime = 6;

    [SerializeField] GameObject Ground;
    // Start is called before the first frame update
    void Start()
    {
        PhaseChecker();
        StartCoroutine(GroundSpawner());
    }

    // Update is called once per frame
     void Update()
    {
        if (Input.GetKeyDown("1"))
        {
            phase1isActive = true;
            phase2isActive = false;
            phase3isActive = false;
            Debug.Log("1");
        }
        if (Input.GetKeyDown("2"))
        {
            phase1isActive = false;
            phase2isActive = true;
            phase3isActive = false;
            Debug.Log("2");
        }
        if (Input.GetKeyDown("3"))
        {
            phase1isActive = false;
            phase2isActive = false;
            phase3isActive = true;
            Debug.Log("3");
        }
    }

     void PhaseChecker()
    {
        if (phase1isActive)
        {
            StartCoroutine(Phase1Pipes());
            
        }
        else if (phase2isActive)
        {
            StartCoroutine(Phase2Pipes());

        }
        else if (phase3isActive)
        {
            StartCoroutine(Phase3Pipes());

        }

    }
    IEnumerator Phase1Pipes()
        //GreenPipes
    {
        
            yield return new WaitForSeconds(PipeSpawnTime);
            Instantiate(pipePrefabs[0]);
            PhaseChecker();
        
    }
    IEnumerator Phase2Pipes()
        // GreenPipes and RedPipes
    {
        int Rand = Random.Range(1,4);
        print(Rand);
        yield return new WaitForSeconds(PipeSpawnTime);
        switch (Rand)
        {
            case 1: { Instantiate(pipePrefabs[0]); break; }
            case 2: { Instantiate(pipePrefabs[0]); break; }
            case 3: { Instantiate(pipePrefabs[1]); break; }
        }

        
        PhaseChecker();
    
    }
    IEnumerator Phase3Pipes()
        //Green Red and Purple Pipes
    {
        int Rand = Random.Range(1, 5);
        print(Rand);
        yield return new WaitForSeconds(PipeSpawnTime);
        switch (Rand)
        {
            case 1: { Instantiate(pipePrefabs[0]); break; }
            case 2: { Instantiate(pipePrefabs[0]); break; }
            case 3: { Instantiate(pipePrefabs[1]); break; }
            case 4: { Instantiate(pipePrefabs[2]); break; }
        }


        PhaseChecker();


    }

    IEnumerator GroundSpawner()
    {
        
            Instantiate(Ground);
            yield return new WaitForSeconds(GroundSpawnTime);
            StartCoroutine(GroundSpawner());
        
    }
}
