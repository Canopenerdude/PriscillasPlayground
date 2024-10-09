using System;
using System.Collections;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;
using System.Threading;
using UnityEngine;
using UnityEngine.UIElements;

public class MakeHoleVisible : MonoBehaviour
{
    public GameObject Hole;
    public bool m_Activate;
    public float waitTime;
    public float Timer;

    //float x = 0;
    //float y = 1;
    // Start is called before the first frame update
    void Awake()
    {
        Application.targetFrameRate = 144;
    }
    void Start()
    {
        m_Activate = false;
    }

    // Update is called once per frame
    void Update()
    {
        Hole.SetActive(m_Activate);
        OnTimer();
        //x+=y;
        //print(x); //this is just to check if its running
    }

    public void OnTimer()
    {
        Timer += Time.fixedDeltaTime;
        //print(Timer);
        if (Timer > waitTime)
        {
            //print("Timer is bigger than waitTime");
            m_Activate = true;
        }
    }
}
