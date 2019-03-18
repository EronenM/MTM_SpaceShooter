using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveCrosshair : MonoBehaviour
{
    //public Joystick joystick;
    float CrosshairMoveSpeed = 1000f;
    Rigidbody2D rb;


    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        //Vector3 direction = Vector3.up * joystick.Vertical + Vector3.right * joystick.Horizontal; // Suunnat oikein
        //rb.velocity = direction * CrosshairMoveSpeed * Time.fixedDeltaTime;
    }
}
