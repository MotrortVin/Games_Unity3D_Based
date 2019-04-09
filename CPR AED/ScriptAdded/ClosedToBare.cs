using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClosedToBare : MonoBehaviour {
	private GameObject closed;
	public bool enableBare = false;
    public bool ifBare = false;
    private GameObject bare;
   // private GameObject black;
	// Use this for initialization
	void Start () {
        closed = GameObject.Find("Body").transform.Find("FaintBody").gameObject;
        bare = GameObject.Find("Body").transform.Find("BareFaintBody").gameObject;
       // black = GameObject.Find("Body").transform.Find("Theblack").gameObject;
    }

	// Update is called once per frame
	void Update () {

	}
	public IEnumerator CheckBare()
	{
		enableBare = true;
		ifBare = false;
		while(!ifBare)
		{
			yield return null;
		}
        enableBare = false;
    }
	void OnTriggerEnter(Collider interactObject)
	{
		if (enableBare) {
            //black.gameObject.SetActive(true);
			closed.gameObject.SetActive (false);
			bare.gameObject.SetActive (true);
            //System.Threading.Thread.Sleep(3000);
            //black.gameObject.SetActive(false);
            ifBare = true;
		}
	}
}
