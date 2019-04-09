using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DailThePhone : MonoBehaviour
{
    private GameObject NumOne;
    private GameObject NumTwo;
    private GameObject NumZero;
    private GameObject bigPhone;
    //private string theOther;
    private GameObject Dail;
    public bool enableDail = false;
    public int duarationTime;
    //private bool justOne, justTwo = false;
    // Use this for initialization

    void Start()
    {
        bigPhone = GameObject.Find("Phone").transform.Find("BigPhone").gameObject;
        if (bigPhone == null) Debug.Log("DailThePhone : Can't find big phone!");

        NumOne = bigPhone.transform.Find("Canvas/Button1").gameObject;
        NumTwo = bigPhone.transform.Find("Canvas/Button2").gameObject;
        NumZero = bigPhone.transform.Find("Canvas/Button0").gameObject;
        Dail = bigPhone.transform.Find("Canvas/Dail").gameObject;
        if (NumOne == null || NumTwo == null || NumZero == null) Debug.Log("DailThePhone : Can't find button!");
    }
    // Update is called once per frame

    void Update()
    {
     
        //Debug.Log(theOther);

        //StartCoroutine(Dailing());


    }

    /*void OnTriggerEnter(Collider interactObject)
    {
        Debug.Log("Button Trigger!");
        if (enableDail)
        {
            //theOther = interactObject.gameObject.tag;
            if (interactObject.gameObject.CompareTag(NumOne.tag)) justOne = true;
            else if (justOne && interactObject.gameObject.CompareTag(NumTwo.tag)) justTwo = true;
            else if (justOne && justTwo && interactObject.gameObject.CompareTag(NumZero.tag)) ifDailed = true;
        }
    }*/

    void OnTriggerExit(Collider interactObject)
    {
        //theOther = "None";
    }

    public IEnumerator StartDailing()
    {
        Debug.Log("Dail begin!");
        enableDail = true;
        yield return StartCoroutine(Dailing());
  
    }

    private IEnumerator Dailing()
    {
        yield return StartCoroutine(DailOne());
        yield return StartCoroutine(DailTwo());
        yield return StartCoroutine(DailZero());
        yield return StartCoroutine(Success());
    }

    private IEnumerator DailOne()
    {
        Debug.Log("Wait for dailing 1");
        NumOne.GetComponent<ButtonTrigger>().ifEnabled = true;
        while(!NumOne.GetComponent<ButtonTrigger>().ifPressed)
        {
            yield return null;
        }
        NumOne.GetComponent<ButtonTrigger>().ifEnabled = false;
        Dail.GetComponent<Text>().text = "1";
    }

    private IEnumerator DailTwo()
    {
        Debug.Log("Wait for dailing 2");
        NumTwo.GetComponent<ButtonTrigger>().ifEnabled = true;
        while (!NumTwo.GetComponent<ButtonTrigger>().ifPressed)
        {
            yield return null;
        }
        NumTwo.GetComponent<ButtonTrigger>().ifEnabled = false;
        Dail.GetComponent<Text>().text = "12";
        /*if (theOther == NumTwo.tag & justOne)
        {
            Dail.GetComponent<Text>().text = "12";
            justTwo = true;
            yield return null;
        }*/
    }

    private IEnumerator DailZero()
    {
        Debug.Log("Wait for dailing 0");
        NumZero.GetComponent<ButtonTrigger>().ifEnabled = true;
        while (!NumZero.GetComponent<ButtonTrigger>().ifPressed)
        {
            yield return null;
        }
        NumZero.GetComponent<ButtonTrigger>().ifEnabled = false;
        Dail.GetComponent<Text>().text = "120";
        //ifDailed = true;
        yield return new WaitForSeconds(1);
        /*
        if (theOther == NumZero.tag & justTwo)
        {
            Dail.GetComponent<Text>().text = "120";
            yield return StartCoroutine(Wait());
            yield return StartCoroutine(Success());
        }*/
    }

    private IEnumerator Success()
    {
        Dail.GetComponent<Text>().text = "拨号成功";
        yield return new WaitForSeconds(1);
        yield return StartCoroutine(OnTalking());
    }

    private IEnumerator OnTalking()
    {
        Dail.GetComponent<Text>().text = "正在通话";
        yield return null;
    }
}
