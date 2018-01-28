using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MainMenu_Buttons : MonoBehaviour {
    //Instantiating the main menu panel and the level select panels that branch off it via button selection
    public GameObject MainPanel;
    public GameObject ClassicLvlPanel;
    public GameObject PuzzleLvlPanel;
    public GameObject InstructionsPanel;

	// Only main panel and logo appear upon startup. Button submenues appear when they are clicked.
	void Start ()
    {
        MainPanel.SetActive(true); 
        ClassicLvlPanel.SetActive(false);
        PuzzleLvlPanel.SetActive(false);
        InstructionsPanel.SetActive(false);
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    //Method to open Classic Level Panel
    public void ShowClassicLvlPanel()
    {
        MainPanel.SetActive(true);
        ClassicLvlPanel.SetActive(true);
        PuzzleLvlPanel.SetActive(false);
        InstructionsPanel.SetActive(false);
    }
    
    //Method to open Puzzle Level Panel
    public void ShowPuzzleLvlPanel()
    {
        MainPanel.SetActive(true);
        PuzzleLvlPanel.SetActive(true);
        InstructionsPanel.SetActive(false);
        ClassicLvlPanel.SetActive(false);
    }

    //Method to open instructions panel
    public void ShowInstructionsPanel()
    {
        MainPanel.SetActive(true);
        InstructionsPanel.SetActive(true);
        ClassicLvlPanel.SetActive(false);
        PuzzleLvlPanel.SetActive(false);
    }

    //Onclick method for Exit Button
    public void QuitGame()
    {
        Application.Quit();
        Debug.Log("Game is exiting");
    }

}
