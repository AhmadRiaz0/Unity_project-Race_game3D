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
    //Action realiser lors du d�mmarrage 
    void Start()
    {
        
    }

    // Update is called once per frame
    //Frame : r�f�rence � une image individuelle affich�e � l'�cran
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
