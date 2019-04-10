using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RayPro : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        // Create a ray from the transform position along the transform's z-axis
        //从当前变换位置开始，沿当前变换的Z方向创建一条射线。
        Ray ray = new Ray(transform.position, transform.forward);
        RaycastHit hitInfo;
        if (Physics.Raycast(ray, out hitInfo))
        {
            Debug.DrawRay(ray.origin, hitInfo.point);
        }
    }
}
