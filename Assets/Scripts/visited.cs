using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class visited : MonoBehaviour
{
    // The variable is later checked to verify if the player has visited all the exhibits
    public bool isVisited;
    private void OnTriggerExit(Collider other)
    {
        // if the planet collider triggers with the XR Rig Collider then the "isVisited" variable will become true
        if (other.gameObject.name == "XR Origin (XR Rig)")
        {
            isVisited = true;
        }
    }
}
