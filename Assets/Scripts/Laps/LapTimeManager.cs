using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LapTimeManager : MonoBehaviour
{
    //Variable
    public static int MinuteCount;
    public static int SecondCount;
    public static float MilliCount;
    public static string MilliDisplay;

    //GameObject
    public GameObject MinuteBox;
    public GameObject SecondBox;
    public GameObject MilliBox;

    // Update is called once per frame
    void Update()
    {
        //Milliseconde
        MilliCount += Time.deltaTime * 10; //Stocker les miliseconde
        MilliDisplay = MilliCount.ToString("F0"); //Convertire en String
        MilliBox.GetComponent<Text>().text = "" + MilliDisplay; //Mise en place dans la vue 

        //Lorsque les milliseonde arrive a 10 on rajoute 1 au seconde
        if (MilliCount >= 10)
        {
            MilliCount = 0;
            SecondCount += 1;
        }

        //Affichage seconde
        if (SecondCount <= 9)
        {
            SecondBox.GetComponent<Text>().text = "0" + SecondCount + ".";
        }
        else
        {
            SecondBox.GetComponent<Text>().text = "" + SecondCount + ".";

        }

        //Minute
        if(SecondCount >= 60)
        {
            SecondCount = 0;
            MinuteCount += 1;
        }

        if (MinuteCount <= 9)
        {
            MinuteBox.GetComponent<Text>().text = "0" + MinuteCount + ":";
        }
        else
        {
            MinuteBox.GetComponent<Text>().text = "" + MinuteCount + ":";
        }

    }
}
