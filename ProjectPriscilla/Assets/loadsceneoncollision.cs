using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class loadsceneoncollision : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
	
	//On Collision with object, load new scene
	void OnCollisionEnter(Collision collision)
	{
		SceneManager.LoadScene("BurnPile", LoadSceneMode.Single);
	}	
}