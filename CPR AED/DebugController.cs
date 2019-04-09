using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DebugController : MonoBehaviour
{
    private Rigidbody rb;
    private const int rotSpeed = 45;
    private const int posSpeed = 1;
    //public GameObject view;
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    // Where the physics codes will go
    void FixedUpdate()
    {

        float moveHorizontal = Input.GetAxis("Horizontal");
        float moveVertical = Input.GetAxis("Vertical");

        Vector3 movement = new Vector3(moveHorizontal, 0.0f, moveVertical);
        rb.AddForce(movement * rotSpeed);
        if (Input.GetKey(KeyCode.E))
        {
            transform.parent.gameObject.transform.localRotation *= Quaternion.Euler(Vector3.up * 30.0f * Time.deltaTime);
            //transform.localRotation = transform.localRotation * Quaternion.Euler(Vector3.up * 30.0f * Time.deltaTime);
        }
        if (Input.GetKey(KeyCode.Q))
        {
            transform.parent.gameObject.transform.localRotation *= Quaternion.Euler(Vector3.down * 30.0f * Time.deltaTime);
            //transform.localRotation = transform.localRotation * Quaternion.Euler(Vector3.down * 30.0f * Time.deltaTime);
        }
        if (Input.GetKey(KeyCode.W))
        {
            transform.localPosition += new Vector3(0, 0, 1) * posSpeed * Time.deltaTime;
        }
        if (Input.GetKey(KeyCode.S))
        {
            transform.localPosition += new Vector3(0, 0, -1) * posSpeed * Time.deltaTime;
        }
        if (Input.GetKey(KeyCode.A))
        {
            transform.localPosition += new Vector3(-1, 0, 0) * posSpeed * Time.deltaTime;
        }
        if (Input.GetKey(KeyCode.D))
        {
            transform.localPosition += new Vector3(1, 0, 0) * posSpeed * Time.deltaTime;
        }
        transform.parent.gameObject.transform.position = transform.position;
    }
}

