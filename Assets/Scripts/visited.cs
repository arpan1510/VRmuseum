using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class visited : MonoBehaviour
{
    public bool isVisited;
    // Start is called before the first frame update
    private void OnTriggerExit(Collider other)
    {
        if (other.gameObject.name == "XR Origin (XR Rig)")
        {
            isVisited = true;
        }
    }
}
