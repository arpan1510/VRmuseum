using System;
using System.Collections;
using System.Collections.Generic;
using System.Threading;
using UnityEngine;

public class planetsVisitedOrNot : MonoBehaviour
{
    private int count = 0;
    public GameObject marker;
    public GameObject exitUI;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    private void OnTriggerExit(Collider other)
    {
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
                exitUI.SetActive(true);
            }
        }
    }
}
