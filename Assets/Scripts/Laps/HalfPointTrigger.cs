using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HalfPointTrigger : MonoBehaviour
{
    public GameObject LapCompleteTrig;
    public GameObject HalfLapTrig;

    void OnTriggerEnter(Collider other)
    {
        //Permet d'activer/desactiver les différent point de rencontre entre la voiture et le marquage du terrain
        LapCompleteTrig.SetActive(true);
        HalfLapTrig.SetActive(false);
    }

}
