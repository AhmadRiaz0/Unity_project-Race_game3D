using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Finish : MonoBehaviour
{
    public LapComplete lapComplete;
    public Text TotalTimeL1;
    public Text TotalTimeL2;

    void Start()
    {
        lapComplete = FindObjectOfType<LapComplete>();
        

    }

    void Update()
    {


        TotalTimeL1.text = LapComplete.totalTimeL1;
        TotalTimeL2.text = LapComplete.totalTimeL2;
        Debug.Log("Finish : Temps total enregistré : " + TotalTimeL1.ToString());


    }

    public void LoadGame()
    {
        SceneManager.LoadScene("RaceArea01");
    }

    public void QuitGame()
    {
        SceneManager.LoadScene("MainMenu");
    }
}
