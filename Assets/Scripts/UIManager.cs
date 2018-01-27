using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

namespace AssemblyCSharp
{
	public class UIManager : MonoBehaviour
	{
		GameObject[] pauseObjects;
		void Start()
		{
			Time.timeScale = 1;
            pauseObjects = GameObject.FindGameObjectsWithTag("ShowOnPause");
            hidePaused();
		}

        void Update()
        {
            //P button pauses the game
            if (Input.GetKeyDown(KeyCode.P))
            {
                if(Time.timeScale == 1)
                {
                    Time.timeScale = 0;
                    showPaused();
                }
                else if(Time.timeScale == 0)
                {
                    Debug.Log("high");
                    Time.timeScale = 1;
                    hidePaused();
                }
            }
        }

		public void ReloadScene()
		{
			string scenename = SceneManager.GetActiveScene ().name;

			SceneManager.LoadScene (scenename, LoadSceneMode.Single);
		}
		public void PauseControl()
		{
			if (Time.timeScale == 1) {
				Time.timeScale = 0;
				showPaused ();
			} else if (Time.timeScale == 0) {
				Time.timeScale = 1;
				hidePaused ();
			}

		}
		public void showPaused()
		{
			foreach (GameObject g in pauseObjects) {
				g.SetActive (true);
			}
		}

		public void hidePaused()
		{
			foreach (GameObject g in pauseObjects) {
				g.SetActive (false);
			}
		}

		public void LoadLevel(string lev)
		{
			SceneManager.LoadScene (lev);
		}

	}
}

