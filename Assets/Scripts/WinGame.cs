using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class WinGame : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (gameObject.tag == "EndR")
        {
            if (other.gameObject.tag == "LaserRed")
            {
                SceneManager.LoadScene("WinScene");
            }
        }
        else if (gameObject.tag == "EndG")
        {
            if (other.gameObject.tag == "LaserGreen")
            {
                SceneManager.LoadScene("WinScene");
            }
        }
        else if (gameObject.tag == "EndB")
        {
            if (other.gameObject.tag == "LaserBlue")
            {
                SceneManager.LoadScene("WinScene");
            }
        }
        else if (gameObject.tag == "EndW")
        {
            if (other.gameObject.tag == "LaserWhite")
            {
                SceneManager.LoadScene("WinScene");
            }
        }
    }
}
