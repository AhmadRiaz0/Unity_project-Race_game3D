using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//Stabilisation de la camera 
public class CameraStable : MonoBehaviour { 

    //Variable 
    public GameObject Car; //Voiture principale 
    public float CarX; //Axe horizontale
    public float CarY; //Axe verticale
    public float CarZ; //Axe profondeur


    // Start is called before the first frame update
    //Action realiser lors du démmarrage 
    void Start()
    {
        
    }

    // Update is called once per frame
    //Frame : référence à une image individuelle affichée à l'écran
    //Action realiser a chaque mise a jour de cette Frame
    void Update()
    {
        //Rotation de l'objet 
        CarX = Car.transform.eulerAngles.x;
        CarY = Car.transform.eulerAngles.y;
        CarZ = Car.transform.eulerAngles.z;

        transform.eulerAngles = new Vector3(CarX - CarX, CarY, CarZ - CarZ);


    }
}
