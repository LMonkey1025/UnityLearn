
using System;
using UnityEngine;
using Object = System.Object;


[DisallowMultipleComponent]
public class test : MonoBehaviour
{
    private GameObject obj;
    private void Start()
    {
        this.gameObject.SendMessageUpwards("testfunction");
            
    }

    void testfunction()
    {
        Debug.Log("testfunction called in test");
    }
}
