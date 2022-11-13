using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class StartMenue : MonoBehaviour
{

   public GameObject credit;


    public void Start()
    {
        credit.SetActive(false);
    }


    //place number for game scene 
    public void Startgame()
    {
        SceneManager.LoadScene(1);

    }


    public void credits()
    {
        credit.SetActive(true);
    }


    public void closeCredits()
    {
        credit.SetActive(false);
    }


    public void closeGame()
    {
        Application.Quit();
        Debug.Log("Closed game");
    }

}
