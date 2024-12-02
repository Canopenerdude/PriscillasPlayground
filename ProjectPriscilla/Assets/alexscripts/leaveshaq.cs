using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class leaveshaq : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
	
	//On Collision with unity object "Hole", load new scene
	void OnCollisionEnter(Collision collision)
	{
		if(collision.gameObject.name == "Hole")
		 SceneManager.LoadScene("Crawl", LoadSceneMode.Single);
		
	}	
}
