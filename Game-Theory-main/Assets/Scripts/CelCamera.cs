using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CelCamera : MonoBehaviour
{
    [SerializeField] Transform target;
    [SerializeField] Transform minLevelPos, maxLevelPos;

    float heightCamera, widthCamera;

    [SerializeField] bool lockedOnLeft, lockedOnRight = false;

    [SerializeField] bool lockedOnTop, lockedOnBottom = false;

    [SerializeField] bool lockHorizontalTrigger, lockVerticalTrigger;
    [SerializeField] float posWhenLockedHorizontally, posWhenLockedVertically;

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

        float yDistMin = minLevelPos.position.y - transform.position.y;
        float yDistMax = maxLevelPos.position.y - transform.position.y;

        float xCameraHalfed = widthCamera / 2;
        float yCameraHalfed = heightCamera / 2;


        Vector3 endCameraFromCharacLeft = target.transform.position + (Vector3.left * xCameraHalfed);
        Vector3 endCameraFromCharacRight = target.transform.position + (Vector3.right * xCameraHalfed);

        Vector3 endCameraFromCharacTop = target.transform.position + (Vector3.up * yCameraHalfed);
        Vector3 endCameraFromCharacBottom = target.transform.position + (Vector3.down * yCameraHalfed);

        float xDistCameraMin = endCameraFromCharacLeft.x - target.position.x;
        float xDistCameraMax = endCameraFromCharacRight.x - target.position.x;

        float yDistCameraMin = endCameraFromCharacTop.y - target.position.y;
        float yDistCameraMax = endCameraFromCharacBottom.y - target.position.y;


        float distanceBetweenCameraAndMinLvlX = xDistMin - xDistCameraMin;
        float distanceBetweenCameraAndMaxLvlX = xDistMax - xDistCameraMax;

        float distanceBetweenCameraAndMinLvlY = yDistMin - yDistCameraMin;
        float distanceBetweenCameraAndMaxLvlY = yDistMax - yDistCameraMax;

        lockedOnLeft = distanceBetweenCameraAndMinLvlX > 0;
        lockedOnRight = distanceBetweenCameraAndMaxLvlX < 0;

        lockedOnTop = distanceBetweenCameraAndMinLvlY < 0;
        lockedOnBottom = distanceBetweenCameraAndMaxLvlY > 0;

        KeepDataWhenLockedHorizontally();
        KeepDataWhenLockedVertically();

        CameraHorizontalMovement();
        CameraVerticalMovement();


    }

    void KeepDataWhenLockedHorizontally()
    {
        if((lockedOnLeft || lockedOnRight) && !lockHorizontalTrigger)
        {
            lockHorizontalTrigger = true;
            posWhenLockedHorizontally = target.transform.position.x;
        }
        else if (!(lockedOnLeft || lockedOnRight))
        {
            lockHorizontalTrigger = false;
        }
    }

    void KeepDataWhenLockedVertically()
    {
        if ((lockedOnTop || lockedOnBottom) && !lockVerticalTrigger)
        {
            lockVerticalTrigger = true;
            posWhenLockedVertically = target.transform.position.y;
            //posWhenLockedHorizontally = target.transform.position.x;
        }
        else if (!(lockedOnTop || lockedOnBottom))
        {
            lockVerticalTrigger = false;
        }
    }

    void CameraHorizontalMovement()
    {
        if (lockedOnLeft)
        {
            //float distPlayerLockedPos = (posBeforeLock - target.position).magnitude;

            //Debug.Log("Lock "+posWhenLocked.x);
            //Debug.Log("Playerpos "+target.position.x);

            if(target.transform.forward == Vector3.right && target.position.x > posWhenLockedHorizontally)
            {
                transform.position = new Vector3(target.position.x, transform.position.y, transform.position.z);
            }
        } 
        else if (lockedOnRight)
        {
            if(target.transform.forward == Vector3.left && target.position.x < posWhenLockedHorizontally) //need to verify the character is near the same x as when it got locked
            {
                transform.position = new Vector3(target.position.x, transform.position.y, transform.position.z);
            }
        }
        else
        {
            transform.position = new Vector3(target.position.x, transform.position.y, transform.position.z);
        }
    }

    void CameraVerticalMovement()
    {
        if (lockedOnTop)
        {
            if(target.GetComponent<Rigidbody>().velocity.y < -1.5 && target.position.y < posWhenLockedVertically)
            {
                transform.position = new Vector3(transform.position.x, target.position.y, transform.position.z);
            }
        }
        else if (lockedOnBottom)
        {
            if(target.GetComponent<Rigidbody>().velocity.y > 1 && target.position.y > posWhenLockedVertically)
            {
                transform.position = new Vector3(transform.position.x, target.position.y, transform.position.z);
            }
        }
        else
        {
            transform.position = new Vector3(transform.position.x, target.position.y, transform.position.z);
        }
    }

      
}
