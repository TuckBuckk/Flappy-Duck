using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PipePingPong : MonoBehaviour
{
    [SerializeField] float speed = 1f;
    
    Transform tF;
    // Start is called before the first frame update
    void Start()
    {
        tF = GetComponent<Transform>();
    }

    // Update is called once per frame
    void Update()
    {
        float y = Mathf.PingPong(Time.time * speed, 1) * 5 - 2;
        tF.position = new Vector3(tF.localPosition.x, y, tF.localPosition.z);
    }
}
