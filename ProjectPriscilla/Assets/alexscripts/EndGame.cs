using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class EndGame : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
	
	//On Collision with unity object "Door", load new scene
	void OnCollisionEnter(Collision collision)
	{
		if(collision.gameObject.name == "Door")
		 SceneManager.LoadScene("End", LoadSceneMode.Single);
		
	}	
}
