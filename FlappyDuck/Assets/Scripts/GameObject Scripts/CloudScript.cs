using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CloudScript : MonoBehaviour
{
    [SerializeField] Sprite[] cloudSprites;
    [Tooltip("Where the cloud will spawn on the x axis.")] [SerializeField] float xSpawnPos;


    [SerializeField] float minY;
    [SerializeField] float maxY;

    [SerializeField] float minSpeed = 0.1f;
    [SerializeField] float maxSpeed = 1f;
    SpriteRenderer sR;
    Transform tF;
    // Start is called before the first frame update
    void Start()
    {
        sR = GetComponent<SpriteRenderer>();
        tF = GetComponent<Transform>();
        sR.sprite = cloudSprites[Random.Range(0, 6)];
        transform.localPosition = new Vector3 (xSpawnPos,Random.Range(minY,maxY) ,transform.localPosition.z);
     
    }

    // Update is called once per frame
    void Update()
    {
        tF.localPosition = new Vector3(tF.localPosition.x - Random.Range(minSpeed,maxSpeed) * Time.deltaTime,tF.localPosition.y,tF.localPosition.z);
    }
}
