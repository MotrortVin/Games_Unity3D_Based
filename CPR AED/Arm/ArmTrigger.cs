using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//脚本用于手臂碰撞事件的处理
//由于碰撞激活的相关事件请用public函数定义在被操作的GameObj上

public class ArmTrigger : MonoBehaviour {
    
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    void OnTriggerExit(Collider other)
    {
        /*if (other.gameObject.CompareTag("Cube"))
        {
            //other.gameObject.SetActive(true);
            //GameObject.Find("CubeParent").transform.Find("Cube").gameObject.GetComponent<TestTriggerCube>().SubCollision();
            //GameObject.Find("CubeParent").transform.Find("Cube").gameObject.GetComponent<TestTriggerCube>().TriggerOff();
            //GameObject.Find("Cube").GetComponent<TestTriggerCube>().TriggerOff();
        }*/
    }

    void OnTriggerEnter(Collider other)
    {
        /*if (other.gameObject.CompareTag("Cube"))
        {
            //GameObject.Find("CubeParent").transform.Find("Cube").gameObject.GetComponent<TestTriggerCube>().TriggerOn();
            //GameObject.Find("CubeParent").transform.Find("Cube").gameObject.GetComponent<TestTriggerCube>().TriggerOff();
            //GameObject.Find("Cube").GetComponent<TestTriggerCube>().TriggerOn();
        }*/
    }

    // Collect pick-ups
    /*void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Pick Ups"))
        {
            ++count;
            speed = initialSpeed + count;
            SetCountText();
            //other.gameObject.SetActive(false);
        }

        //Destroy(other.gameObject);
    }

    void OnCollisionEnter(Collision other)
    {
        if (other.collider.tag == "Obstacles")
        {
            SetCountText();
            PostOver();
        }
    }*/
}
