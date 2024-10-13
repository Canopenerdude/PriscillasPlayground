using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class loadBurn : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
	
	//On Collision with unity object "FrontDoor", load new scene
	void OnCollisionEnter(Collision collision)
	{
		if(collision.gameObject.name == "BurnTransition")
		 SceneManager.LoadScene("BurnPile", LoadSceneMode.Single);
		
	}	
}
