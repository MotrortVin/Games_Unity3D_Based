using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//脚本用于手臂碰撞事件的处理
//由于碰撞激活的相关事件请用public函数定义在被操作的GameObj上
public class TriggerController : MonoBehaviour {

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
            GameObject.Find("Cube").GetComponent<TestTriggerCube>().SubCollision();
        }*/
    }

    void OnTriggerEnter(Collider other)
    {
        /*if (other.gameObject.CompareTag("Cube"))
        {
            GameObject.Find("Cube").GetComponent<TestTriggerCube>().AddCollision();
        }*/
    }
}
