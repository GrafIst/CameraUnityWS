using System.Collections;
using System.Collections.Generic;
using System.Security.Cryptography;
using UnityEngine;
using UnityEngine.InputSystem;

public class CelController : MonoBehaviour
{

    InputManager _inputs;
    Rigidbody rb;
    [SerializeField]bool surfaceIsGround;
    [SerializeField] bool isGrounded;

    [SerializeField] float playerSpeed, jumpForce;

    

    Vector3 stayAxed;

    private void Awake()
    {
        _inputs = new InputManager();
        rb = GetComponent<Rigidbody>();
        isGrounded = true;
        stayAxed = transform.position;
    }

    private void OnEnable()
    {
        _inputs.Enable();
        _inputs.Celeste.Jump.performed += Jump;
    }
    private void OnDisable()
    {
        _inputs.Disable();
        _inputs.Celeste.Jump.performed -= Jump;
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float dirTwoD = _inputs.Celeste.Walk.ReadValue<float>();
        if(dirTwoD > 0.8)
        {
            transform.rotation = Quaternion.Euler(0, 90, 0);
            transform.Translate(0,0,playerSpeed * Time.deltaTime);
        }
        else if (dirTwoD < -0.8)
        {
            transform.rotation = Quaternion.Euler(0, 270, 0);
            transform.Translate(0,0,playerSpeed * Time.deltaTime);
            
        }

        if(rb.velocity.y < 0.05 && rb.velocity.y > -0.05 && surfaceIsGround)
        {
            isGrounded = true;
        }



    }

    private void FixedUpdate()
    {
        transform.position = new Vector3(transform.position.x, transform.position.y, stayAxed.z);
    }

    private void Jump(InputAction.CallbackContext ctx)
    {
        if (isGrounded)
        {
            rb.AddForce(Vector3.up * jumpForce);
            isGrounded = false;
        }  
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.transform.CompareTag("Ground"))
        {
            surfaceIsGround = true;
        }
    }

    private void OnCollisionExit(Collision collision)
    {
        if (collision.transform.CompareTag("Ground"))
        {
            surfaceIsGround = false;
        }
    }
}
