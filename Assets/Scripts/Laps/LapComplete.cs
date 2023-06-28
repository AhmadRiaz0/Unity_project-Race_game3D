using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class LapComplete : MonoBehaviour
{
    public GameObject LapCompleteTrig;
    public GameObject HalfLapTrip;

    public GameObject MinuteDisplay;
    public GameObject SecondDisplay;
    public GameObject MilliDisplay;

    public GameObject LapTimeBox;

    public GameObject LapCounter;
    public int LapsDone;

    //Affichage Finale
    public GameObject RaceFinish;
    public GameObject sceneLoaderObject;
    public SceneLoader sceneLoader;

    
    //Temps finale
    public static string totalTimeL1;
    public static string totalTimeL2;

    void Start()
    {
        sceneLoader = sceneLoaderObject.GetComponent<SceneLoader>();
    }

    private void Update()
    {
        /*
        if (LapsDone == 2)
        {
            RaceFinish.SetActive(true);
            Debug.Log("Condition LapsDone == 2 est respectée.");
            sceneLoader.LoadScene();

        }
        */
    }

    void OnTriggerEnter()
    {


        LapsDone += 1;

        if (LapsDone == 2)
        {
            RaceFinish.SetActive(true);
            Debug.Log("Condition LapsDone == 2 est respectée.");
            sceneLoader.LoadScene();

        }

        //Second
        if (LapTimeManager.SecondCount <= 9)
        {
            SecondDisplay.GetComponent<Text>().text = "0" + LapTimeManager.SecondCount + ".";
        }
        else
        {
            SecondDisplay.GetComponent<Text>().text = "" + LapTimeManager.SecondCount + ".";
        }

        //Minute
        if (LapTimeManager.MinuteCount <= 9)
        {
            MinuteDisplay.GetComponent<Text>().text = "0" + LapTimeManager.MinuteCount + ".";
        }
        else
        {
            MinuteDisplay.GetComponent<Text>().text = "" + LapTimeManager.MinuteCount + ".";
        }

        MilliDisplay.GetComponent<Text>().text = "" + LapTimeManager.MilliCount;

        if (LapsDone == 1)
        {
            totalTimeL1 += LapTimeManager.MinuteCount + " Minute / " + LapTimeManager.SecondCount + " Second / " + LapTimeManager.MilliCount + " Millisecond";
            Debug.Log("LapComplete : Temps total enregistré L1 : " + totalTimeL1.ToString());
        }

        if (LapsDone == 2)
        {
            totalTimeL2 += LapTimeManager.MinuteCount + " Minute / " + LapTimeManager.SecondCount + " Second / " + LapTimeManager.MilliCount + " Millisecond";
            Debug.Log("LapComplete : Temps total enregistré L2 : " + totalTimeL2.ToString());
        }



        LapTimeManager.MinuteCount = 0;
        LapTimeManager.SecondCount = 0;
        LapTimeManager.MilliCount = 0;

        LapCounter.GetComponent<Text>().text = "" + LapsDone;

        
       


        HalfLapTrip.SetActive(true);
        LapCompleteTrig.SetActive(false);


    }

}
