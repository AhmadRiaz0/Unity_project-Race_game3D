using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Waypoint : MonoBehaviour
{

    public static Transform[] points; //Liste pour recuperer tous les Waypoints

    private void Awake()
    {
        points = new Transform[transform.childCount]; //Taille 

        //Parcours et recupere les waypoints
        for (int i = 0; i < points.Length; i++)
        {
            points[i] = transform.GetChild(i);
        }
    }

}





















    
