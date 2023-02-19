using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class movement : MonoBehaviour
{
    Rigidbody rb;
    [SerializeField] float jump_force = 5;
    [SerializeField] float movement_speed = 5;
    //[SerializeField] Transform groundCheck;
    //[SerializeField] LayerMask ground;
    public Transform player;
    float heading = 0;
    public Transform cam;

    Vector2 input;

    void Start()
    {
        rb = GetComponent<Rigidbody>();

    }
    void Update()
    {
        //float horizontal = Input.GetAxis("Horizontal");
        //float vertical = Input.GetAxis("Vertical");
        //rb.velocity = new Vector3(horizontal * movement_speed, rb.velocity.y, vertical * movement_speed);

        heading = heading + Input.GetAxis("Mouse X") * Time.deltaTime * 180;
        player.rotation = Quaternion.Euler(0, heading, 0);

        input = new Vector2(Input.GetAxis("Horizontal"), Input.GetAxis("Vertical"));
        input = Vector2.ClampMagnitude(input,1);

        Vector3 camF = cam.forward;
        Vector3 camR = cam.right;
        camF.y = 0;
        camR.y = 0;
        camF = camF.normalized;
        camR = camR.normalized;

        transform.position = transform.position + (camF*input.y + camR*input.x)*Time.deltaTime* movement_speed;


        if (Input.GetButtonDown("Jump"))
        {
            rb.velocity = new Vector3(rb.velocity.x, jump_force, rb.velocity.z);
        }

    }

    /*bool IsGrounded()
    {
        return Physics.CheckSphere(groundCheck.position, .1f, ground);
    }
    */
}
