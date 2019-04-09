using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System;
public class ButtonContent : MonoBehaviour
{
    public Button btn;
    //public Button Button1;
    void Start()
    {
        // btn = GameObject.Find("Button1").GetComponent<Button>(); //-----------(1)  
        //Text text = btn.transform.Find("Text").GetComponent<Text>(); //------------(2)  
        //或者吧（1）（2）合并成：  
        //  Text text = GameObject.Find("填写button名/Text").getComponent<Text>();  
        //Debug.Log(text.text.ToString());
        //其实就一条语句  
        //     Debug.Log(GameObject.Find("填写button名/Text").getComponent<Text>().text.toString()); 
        Debug.Log(GameObject.Find("Button1/Text").GetComponent<Text>().text.ToString());
    }
}