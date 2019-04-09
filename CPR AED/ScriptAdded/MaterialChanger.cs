using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MaterialChanger : MonoBehaviour {
	//public ControllerManager manager; 
	//private float lx, ly, lz;//,rx,ry,rz;
	public  GameObject ball;
	public Material origin;
	public Material highlight;
	public bool ifTouched = false;
    public bool enableTouch = false;
    public GameObject showText;

	// Use this for initialization
	void Start(){
		/*lx = manager.leftControllerPosition.x;
		ly = manager.leftControllerPosition.y;
		lz = manager.leftControllerPosition.z;
		rx = manager.rightControllerPosition.x;
		ry = manager.rightControllerPosition.y;
		rz = manager.rightControllerPosition.z;
		*/
		ball.GetComponent<Renderer>().material.color = origin.color;
	

	

	}

    
    public IEnumerator TouchTheBody()
    {
        enableTouch = true;
        while(!ifTouched)
        {
            yield return null;
        }
    }

    void OnTriggerEnter(Collider interactObject)
    {
        ball.GetComponent<Renderer>().material.color = highlight.color;//object change color to highlight 
        showText.SetActive(true);
        Debug.Log("111");
        Invoke("TextVanish", 3);

        //ifTouched = true;
    }
    void OnTriggerExit(Collider interactObject)
    {
        ball.GetComponent<Renderer>().material.color = origin.color;

        ifTouched = true;
    }

    void TextVanish()
    {
        showText.SetActive(false);
    }
    /*void OnCollisionEnter(Collision interactObject)
	{
		ball.GetComponent<Renderer> ().material.color = highlight.color;//object change color to highlight 

		ifTouched = true;
	}

	void OnCollisionExit(Collision interactObject)
	{
		ball.GetComponent<Renderer>().material.color = origin.color;
	}*/
}
