using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FallDown : MonoBehaviour {
    private GameObject standBody;
    private GameObject faintBody;
    private GameObject TVscreen;
    private bool enableAED = false;
	public bool ifFainted = false;

	// Use this for initialization
	void Start () {
        standBody = GameObject.Find("Body").transform.Find("StandBody").gameObject;
        faintBody = GameObject.Find("Body").transform.Find("FaintBody").gameObject;
        TVscreen = GameObject.Find("_Level").transform.Find("TVscreen").gameObject;
        if (standBody==null)
        {
            Debug.Log("FallDown : Can't find standing body!");
        }
        if (faintBody == null)
        {
            Debug.Log("FallDown : Can't find standing body!");
        }
        if (TVscreen == null)
        {
            Debug.Log("FallDown : Can't find TV screen!");
        }
    }

	// Update is called once per frame
	void Update () {

	}

	public IEnumerator WaitForCheckingAED()
	{
        enableAED = true;
        // Keep coming back each frame whilst the groups are currently fading.
        while (!ifFainted)
		{
			yield return null;
		}
        // Return once the FadeIn coroutine has finished.
        // yield return StartCoroutine (FadeIn ());
        enableAED = false;
    }

    void OnTriggerEnter(Collider interactObject)
    {
        Debug.Log("Trigger AED!");
        if (enableAED) //&& interactObject.gameObject.CompareTag("RigidRoundHand_L") || interactObject.gameObject.CompareTag("RigidRoundHand_R"))
        {
            standBody.gameObject.SetActive(false);
            faintBody.gameObject.SetActive(true);
            TVscreen.gameObject.SetActive(true);
            ifFainted = true;
        }
    }

    /*void OnCollisionExit(Collision interactObject)
    {
        standBody.gameObject.SetActive (false);
        faintBody.gameObject.SetActive (true);
		ifFainted = true;
	}*/

}