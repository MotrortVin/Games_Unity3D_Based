
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Playcontroller : MonoBehaviour
{
    private Rigidbody rb;
    public float speed;
    public Text countText;
    public Text winText;
    private int count;
    
  

    void Start()
    {
        rb = GetComponent<Rigidbody>();
        count = 0;
        SetcountText();
        winText.text = "";
    
    }
    void FixedUpdate()
    {
        float moveHorizontal = Input.GetAxis("Horizontal");
        float moveVertical = Input.GetAxis("Vertical");

        Vector3 movement = new Vector3(moveHorizontal, 0.0f, moveVertical);
        rb.AddForce(movement*speed);


    }

    void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.CompareTag("pick up"))
        {
            other.gameObject.SetActive(false);
            count = count + 1;
            SetcountText();
        }
    }
    void SetcountText()
    {
        countText.text = "Count:" + count.ToString();
        if(count>7)
        {
            winText.text = "you win";
        }
    }
}



