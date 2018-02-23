﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using CPRUnitySystem;

public class CPRDataSaverBehaviour : MonoBehaviour
{

    // Use this for initialization
    void Start()
    {
        var t = new TestClass();
        t.a = 3;
        t.b = 5;
        Debug.Log("TestClass : a=" + t.a + " b=" + t.b);

        Debug.Log("Save and load");
        CPRDataSaver.SetPlayerPrefs("Test", t);
        t = CPRDataSaver.GetPlayerPrefs<TestClass>("Test");
        Debug.Log("TestClass : a=" + t.a + " b=" + t.b);

        Debug.Log("Save and load");
        PlayerPrefs.SetString("TestEnc", "");
        CPRDataSaver.SetPlayerPrefsEncrypt("TestEnc", t, "password!!!!!!!!");
        t = CPRDataSaver.GetPlayerPrefsEncrypt<TestClass>("TestEnc", "password!!!!!!!!");
        Debug.Log("TestClass : a=" + t.a + " b=" + t.b);
    }

    // Update is called once per frame
    void Update()
    {

    }
}

[System.Serializable]
public class TestClass
{
    public int a;
    public int b;
}
