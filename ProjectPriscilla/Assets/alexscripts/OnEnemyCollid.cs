using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class OnEnemyCollid : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void OnCollisionEnter(Collision collision)
	{
		if(collision.gameObject.name == "Enemy")
        {
		 SceneManager.LoadScene("Shaq", LoadSceneMode.Single);
        }
	}
}
