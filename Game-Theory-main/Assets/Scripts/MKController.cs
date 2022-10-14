using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class MKController : MonoBehaviour
{
    InputManager _inputs;
    Rigidbody rb;
    Camera cameraMk;
    CapsuleCollider charaCollider;

    [SerializeField] float accelerateSpeed, backdownSpeed, rotationSpeed, maxSpeed;
    Vector3 cameraPos;
    Quaternion cameraRot;

    private void Awake()
    {
        _inputs = new InputManager();
        rb = GetComponent<Rigidbody>();
        cameraMk = GetComponentInChildren<Camera>();
        charaCollider = GetComponentInChildren<CapsuleCollider>();
        cameraPos = cameraMk.transform.position;
        cameraRot = cameraMk.transform.rotation;
    }
  

    private void OnEnable()
    {
        _inputs.Enable();
        //_inputs.Default.Accelerate.started += Accelerate;
        _inputs.Default.FlipCamera.performed += FlipCam;
        _inputs.Default.FlipCamera.canceled += ResetCam;


    }

    private void OnDisable()
    {
        _inputs.Disable();
        //_inputs.Default.Accelerate.started -= Accelerate;
        _inputs.Default.FlipCamera.performed -= FlipCam;
        _inputs.Default.FlipCamera.canceled -= ResetCam;
    }

    private void Update()
    {
       
    }

    private void FlipCam(InputAction.CallbackContext ctx)
    {
        //cameraMk.transform.Rotate(0, 180, 0);
        cameraMk.transform.RotateAround(transform.position, Vector3.up, 180);
    }

    private void ResetCam(InputAction.CallbackContext ctx)
    {
        cameraMk.transform.RotateAround(transform.position, Vector3.up, 180);
    }


    private void FixedUpdate()
    {
        Vector2 movAxis = _inputs.Default.Movement.ReadValue<Vector2>();
        float acceleratePressed = _inputs.Default.Accelerate.ReadValue<float>();

        rb.AddForce(transform.forward * acceleratePressed * accelerateSpeed);
        if (rb.velocity.magnitude != 0)
            transform.Rotate(0, rotationSpeed * movAxis.x * Time.deltaTime, 0);

        if (rb.velocity.magnitude > maxSpeed)
            rb.velocity = rb.velocity.normalized * maxSpeed;


        if (movAxis.y < 0)
        {
            rb.AddForce(-transform.forward * backdownSpeed);
        }
    }
}
