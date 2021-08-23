using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PipeScript : MonoBehaviour
{
    Transform tF;
    [SerializeField] float moveSpeed = 3f;

    [SerializeField] int min = -2;
    [SerializeField] int max = 3;
    [Tooltip("Where the pipe will spawn on the x axis.")] [SerializeField] float xPosSpawn = 11;
    void Start()
    {
        tF = GetComponent<Transform>();
        max += 1;

        int randomNumber = Random.Range(min, max);

        Vector3 StartPos = new Vector3(xPosSpawn, randomNumber, 0);
        tF.localPosition = StartPos;

        
    }

    // Update is called once per frame
    void Update()
    {

        tF.localPosition = new Vector3(tF.localPosition.x - moveSpeed * Time.deltaTime,tF.localPosition.y,tF.localPosition.z);
        
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {

        if (collision.CompareTag("Finish"))
        {
            
            Destroy(this.gameObject);
        }
        else if (collision.CompareTag("Player"))
        { }
    }
}
