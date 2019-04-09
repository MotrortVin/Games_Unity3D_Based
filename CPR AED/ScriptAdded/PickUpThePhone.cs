using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PickUpThePhone : MonoBehaviour {
    private GameObject smallPhone;
    private GameObject bigPhone;
    private bool ifEnablePhone = false;
	public bool ifCheckPhone = false; //Huge phone occurs!
	// Use this for initialization
	void Start () {
        bigPhone = GameObject.Find("Phone").transform.Find("BigPhone").gameObject;
        smallPhone = GameObject.Find("Phone").transform.Find("SmallPhone").gameObject;
        if (bigPhone == null) Debug.Log("PickUpThePhone : Can't find big phone!");
        if (smallPhone == null) Debug.Log("PickUpThePhone : Can't find small phone!");
    }

	// Update is called once per frame
	void Update () {

	}

	public IEnumerator SetPhone()
	{
        ifEnablePhone = true;
        ifCheckPhone = false;
        while (!ifCheckPhone)
        {
            yield return null;
        }
	}

    void OnTriggerEnter(Collider interactObject)
    {
        Debug.Log("Trigger small phone!");
		if (ifEnablePhone) {
            smallPhone.gameObject.SetActive (false);
            bigPhone.gameObject.SetActive (true);
            ifCheckPhone = true;
            ifEnablePhone = false;
        }
	}

}