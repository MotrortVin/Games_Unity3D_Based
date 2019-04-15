using System.Collections;
using UnityEngine.Events;
using System.Collections.Generic;
using UnityEngine;

public class testEvent : MonoBehaviour {

    public UnityAction action;
    public UnityEvent myEvent = new UnityEvent();

    void Start()
    {       
        action = new UnityAction(MyFunction);
        action+=MyFunction2;
        myEvent.AddListener(action);
    }

    void Update()
    {
        if(Input.GetKeyDown(KeyCode.P))
        {
            myEvent.Invoke();
        }
    }

    public void MyFunction()
    {
        print ("Hello: ");
    }

    public void MyFunction2()
    {
        print ("Hello2: ");
    }

}
