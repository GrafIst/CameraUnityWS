using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CelCamera : MonoBehaviour
{
    [SerializeField] Transform target;
    [SerializeField] Transform minLevelPos, maxLevelPos;

    float heightCamera, widthCamera;

    // Start is called before the first frame update
    void Start()
    {
       Camera cam = GetComponent<Camera>();
        heightCamera = 2f * cam.orthographicSize;
        widthCamera = heightCamera * cam.aspect;
    }

    // Update is called once per frame
    void Update()
    {
        float xDistMin = minLevelPos.position.x - transform.position.x;
        float xDistMax = maxLevelPos.position.x - transform.position.x;

        float xCameraHalfed = widthCamera / 2;

        Vector3 endCameraFromCharacLeft = target.transform.position + (Vector3.left * xCameraHalfed);
        Vector3 endCameraFromCharacRight = target.transform.position + (Vector3.right * xCameraHalfed);

        Debug.Log(endCameraFromCharacRight.x);

        float xDistCameraMin = endCameraFromCharacLeft.x - target.position.x;
        float xDistCameraMax = endCameraFromCharacRight.x - target.position.x;

        //Debug.Log(xDistMin);
        //Debug.Log(xCameraHalfed);

        float distanceBetweenCameraAndMinLvl = xDistMin - endCameraFromCharacLeft.x;
        float distanceBetweenCameraAndMaxLvl = xDistMax - endCameraFromCharacRight.x;

        //Debug.Log(distanceBetweenCameraAndMaxLvl);

        if (distanceBetweenCameraAndMinLvl < 0)
            transform.position = new Vector3(target.position.x, transform.position.y, transform.position.z);

        //if(distanceBetweenCameraAndMaxLvl > 0)
        //     transform.position = new Vector3(target.position.x, transform.position.y, transform.position.z);

        transform.position = new Vector3(transform.position.x, target.position.y, transform.position.z);

    }
}
