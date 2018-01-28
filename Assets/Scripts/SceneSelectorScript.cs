using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneSelectorScript : MonoBehaviour
{

    public void LoadLevel(string lev)
    {
        SceneManager.LoadScene(lev);
    }
}
