using System;
using System.Collections;
using System.Collections.Generic;
using System.Threading;
using UnityEngine;

public class planetsVisitedOrNot : MonoBehaviour
{
    //This script checks whether the player has visited all the exhibits

    // declaring required variables
    private int count = 0;
    public GameObject marker;

    private void OnTriggerExit(Collider other)
    {
        //it will access the objects with tag "planets" which has isVisited value "true" and if the number of count becomes equal to the number of objects it means that the player has visited all the planets
        if (other.gameObject.CompareTag("planets"))
        {
            count = 0;
            var objects = GameObject.FindGameObjectsWithTag("planets");
            foreach (var obj in objects)
            {
                if (obj.GetComponent<visited>().isVisited)
                {
                    count++;
                }
            }
            if (count == objects.Length)
            {
                marker.SetActive(true);
            }
        }
    }
}
