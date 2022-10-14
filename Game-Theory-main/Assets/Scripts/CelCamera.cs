using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CelCamera : MonoBehaviour
{
    [SerializeField] Transform target;
    [SerializeField] Transform minLevelPos, maxLevelPos;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = new Vector3(target.position.x, target.position.y, transform.position.z);
    }
}
