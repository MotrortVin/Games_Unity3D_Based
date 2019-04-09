using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TestTriggerCube : MonoBehaviour {
    public uint CollisionOnNum = 0;
    public uint CollisionOffNum = 0;
    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    public void TriggerOn()
    {
        gameObject.SetActive(false);
    }

    public void TriggerOff()
    {
        gameObject.SetActive(true);
    }
    public void AddCollision()
    {
        CollisionOnNum++;
    }
    public void SubCollision()
    {
        CollisionOffNum++;
    }
    void OnTriggerEnter(Collider interactObject)
    {
        Debug.Log("Trigger!");
    }
    void OnTriggerExit(Collider interactObject)
    {
        Debug.Log("Trigger off!");
    }    /*void OnCollisionEnter(Collision interactObject)
    {
        AddCollision();
        //ball.GetComponent<Renderer>().material.color = highlight.color;//object change color to highlight 
        //ifTouched = true;
    }

    void OnCollisionExit(Collision interactObject)
    {
        SubCollision();
        //ball.GetComponent<Renderer>().material.color = origin.color;
    }*/
}
