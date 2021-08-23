using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GroundScript
    : MonoBehaviour
{
    Transform tF;
    [SerializeField] float moveSpeed = 3f;

    [SerializeField] bool allReadyPlaced = false;
    
    [Tooltip("Where the ground will spawn on the x axis.")] [SerializeField] float xSpawnPos = 19f;
    [Tooltip("Where the ground will spawn on the y axis.")] [SerializeField] float ySpawnPos = -5.057f;
    void Start()
    {
        tF = GetComponent<Transform>();




        Vector3 StartPos = new Vector3(xSpawnPos, ySpawnPos, 0);
        if (allReadyPlaced == false)
        {
        transform.localPosition = StartPos;
        }
        
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
        {}
    }
}
