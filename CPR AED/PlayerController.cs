using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerController : MonoBehaviour {
    private float speed; //Player's movement speed
    public float force; //To move player
    public Text countText;
    //public informControl informImage;
    private Rigidbody rb;
    private int count;
    private bool state;
    private const int initialSpeed = 10;

    void Start()
    {
        speed = initialSpeed;
        count = 0;
        state = true;
        rb = GetComponent<Rigidbody>();
        //SetCountText();
    }

    // Where the physics codes will go
    void FixedUpdate()
    {
        if (state)
        {
            float moveHorizontal = Input.GetAxis("Horizontal");
            float moveVertical = Input.GetAxis("Vertical");
            Vector3 movement = new Vector3(moveHorizontal, 0.0f, moveVertical);
            rb.AddForce(movement * speed);
        }
    }

    // Collect pick-ups
    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Pick Ups"))
        {
            ++count;
            speed = initialSpeed + count;
            //SetCountText();
            //other.gameObject.SetActive(false);
        }

        //Destroy(other.gameObject);
    }

    /*void OnCollisionEnter(Collision other)
    {
        if (other.collider.tag == "Obstacles")
        {
            //SetCountText();
            //PostOver();
        }
    }*/

    /*void SetCountText()
    {
        countText.text = "Count:" + count.ToString();
    }*/

    /* void PostWin()
     {
         informImage.ShowInform("Winner winner, chicken dinner!");
         state = false;
     }

     void PostLose()
     {
         informImage.ShowInform("Oooh, it seems that you lose. Try again!");
         state = false;
     }*/

    /*void PostOver()
    {
        informImage.ShowInform("Oooh, game over! Try again!");
        state = false;
    }*/

}
