using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Camera : MonoBehaviour
{
    [SerializeField] public float vertical_speed= 2.0f;
    [SerializeField] public float horizontal_speed= 2.0f;

    private float left_right = 0;
    private float up_down = 0;

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetAxis("Mouse X") != 0)
        {
            //transform.position = transform.position + new Vector3(Input.GetAxisRaw("Mouse X") * Time.deltaTime * speed, 0f, Input.GetAxisRaw("Mouse Y") * Time.deltaTime * speed);
            left_right = left_right + horizontal_speed * Input.GetAxis("Mouse X");
            up_down = up_down + vertical_speed * Input.GetAxis("Mouse Y");
            transform.eulerAngles = new Vector3( -up_down, left_right, 0f) ;
        }
    }
}
