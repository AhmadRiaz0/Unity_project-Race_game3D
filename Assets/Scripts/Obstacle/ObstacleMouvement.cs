using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ObstacleMouvement : MonoBehaviour
{
    //Suivie de tracer du chemin 
    public float speed = 10f; //Vitesse
    private Transform target; //Cible 
    private int waypointIndex = 0; //Waypoint vers lequelle on se déplace 




    void Start()
    {
        
        target = Waypoint.points[Waypoint.points.Length - 1];
    }

    private void Update()
    {


        Vector3 dir = target.position - transform.position; //postion target.position : waypoint / transform.position : position actuelle 
        transform.Translate(dir.normalized * speed * Time.deltaTime, Space.World);//Deplacement personnaliser
    
        if(Vector3.Distance(transform.position, target.position) <= 2) //Rajoute une marge pour le point de rencontre
        {
            GetNextWaypoint();
        } 
    }

    //Passer au point suivant 
    private void GetNextWaypoint()
    {

        if (waypointIndex <= 0)
        {
            waypointIndex = Waypoint.points.Length - 1;
        }
        else
        {
            waypointIndex--;
        }
        target = Waypoint.points[waypointIndex]; // Cible le waypoint suivant 

    }



}
