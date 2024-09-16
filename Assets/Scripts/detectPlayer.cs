using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class detectPlayer : MonoBehaviour
{
    public GameObject title;
    public GameObject planet;
    public GameObject proximityCircle;
    public Material material_old;
    public Material material_new;
    Renderer titleRend;
    Renderer proximityRend;
    private Animator planetRotate;
    private Color color;
    private SphereCollider planetCollider;

    void Start()
    {
        planetRotate = planet.GetComponent<Animator>();
        titleRend = title.GetComponent<Renderer>();
        proximityRend = title.GetComponent<Renderer>();
        planetCollider = planet.GetComponent<SphereCollider>();
        planetCollider.enabled = false;

    }
    private void OnTriggerEnter(Collider other)
    {
        
        if (other.gameObject.name == "XR Origin (XR Rig)")
        {
            titleRend.material = material_new;
            proximityRend.material = material_new;
            planetCollider.enabled = true;
            planetRotate.speed = 1;
        }
    }
    private void OnTriggerExit(Collider other)
    {

        if (other.gameObject.name == "XR Origin (XR Rig)")
        {
            titleRend.material = material_old;
            proximityRend.material = material_old;
            planetCollider.enabled = false;
            planetRotate.speed = 0;
        }
    }
}
