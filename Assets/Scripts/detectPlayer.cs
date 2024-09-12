using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class detectPlayer : MonoBehaviour
{
    public GameObject title;
    public GameObject planet;
    public Material material_old;
    public Material material_new;
    Renderer rend;
    private Animator planetRotate;
    private Color color;

    void Start()
    {
        
        
    }
    private void OnTriggerEnter(Collider other)
    {
        
        if (other.gameObject.name == "XR Origin (XR Rig)")
        {
            planetRotate = planet.GetComponent<Animator>();
            rend = title.GetComponent<Renderer>();
            rend.material = material_new;
            //planetRotate.SetTrigger("TrMercury");
            planetRotate.speed = 1;
        }
    }
    private void OnTriggerExit(Collider other)
    {

        if (other.gameObject.name == "XR Origin (XR Rig)")
        {
            planetRotate = planet.GetComponent<Animator>();
            rend = title.GetComponent<Renderer>();
            rend.material = material_old;
            //planetRotate.SetTrigger("TrMercuryClose");
            planetRotate.speed = 0;
        }
    }
}
