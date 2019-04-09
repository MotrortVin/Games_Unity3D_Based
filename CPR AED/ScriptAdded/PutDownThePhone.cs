using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PutDownThePhone : MonoBehaviour {
    private bool enablePut = false;
    private bool ifPutFinish = false;
    public GameObject bigPhone;
    public GameObject middlePhone;

    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
	}

    public IEnumerator PutItDown()
    {
        enablePut = true;
        while(!ifPutFinish)
        {
            yield return null;
        }
    }

    void OnTriggerEnter(Collider other)
    {
        Debug.Log("111");
        if(enablePut)
        {
            bigPhone.SetActive(false);
            middlePhone.SetActive(true);
            ifPutFinish = true;
        }
    }
}
