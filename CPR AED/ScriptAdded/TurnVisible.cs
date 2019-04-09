using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TurnVisible : MonoBehaviour {
    public GameObject segment;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    public IEnumerator Show()
    {
        segment.gameObject.SetActive(true);
        yield return null;
    }
}
