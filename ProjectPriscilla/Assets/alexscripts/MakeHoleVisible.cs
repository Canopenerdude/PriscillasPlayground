using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MakeHoleVisible : MonoBehaviour
{
    public GameObject Hole;
    bool m_Activate;
    float waitTime = 6;
    float Timer = 0;
    // Start is called before the first frame update
    void Start()
    {
        m_Activate = false;
    }

    // Update is called once per frame
    void Update()
    {
        Hole.SetActive(m_Activate);
    }

    void OnTimer()
    {
        Timer += Time.deltaTime;
        if (Timer > waitTime)
        {
            m_Activate = true;
        }
    }
}
