using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class detectPlayer : MonoBehaviour
{
    public GameObject title;
    public GameObject planet;
    public GameObject proximityCircle;
    public GameObject planetUI;
    public GameObject planetInfoSound;
    public Material material_old;
    public Material material_new;
    Renderer titleRend;
    Renderer proximityRend;
    private Animator planetRotate;
    private SphereCollider planetCollider;
    private AudioSource planetTitleSound;
    private AudioSource pInfoSound;

    void Start()
    {
        planetRotate = planet.GetComponent<Animator>();
        planetRotate.speed = 0;
        planetTitleSound = GetComponent<AudioSource>();
        pInfoSound=planetInfoSound.GetComponent<AudioSource>();
        titleRend = title.GetComponent<Renderer>();
        proximityRend = proximityCircle.GetComponent<Renderer>();
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
            planetUI.SetActive(true);
            planetTitleSound.Play();
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
            planetUI.SetActive(false);
        }
        if(pInfoSound.isPlaying)
        {
            pInfoSound.Stop();
        }
    }
}
