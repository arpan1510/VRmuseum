using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class detectPlayer : MonoBehaviour
{
    // This script is responsible for the overall planet interaction behaviour including UI, sounds and animations

    // gameobject external references required by the script
    public GameObject title;
    public GameObject planet;
    public GameObject proximityCircle;
    public GameObject planetUI;
    public GameObject planetInfoSound;
    public Material material_old;
    public Material material_new;

    // components required by the script to change material of proximity circle, title and play the info and title audio
    Renderer titleRend;
    Renderer proximityRend;
    private AudioSource planetTitleSound;
    private AudioSource pInfoSound;

    // components required to trigger animations
    private Animator planetRotate;
    private SphereCollider planetCollider;
    

    void Start()
    {
        // getting reference for the required components of the gameobjects
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
        // when the XR Origin will collide with the planet colliders the following things will happen
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
        // when the XR Origin will move away from the planet colliders the following things will happen
        if (other.gameObject.name == "XR Origin (XR Rig)")
        {
            titleRend.material = material_old;
            proximityRend.material = material_old;
            planetCollider.enabled = false;
            planetRotate.speed = 0;
            planetUI.SetActive(false);
        }

        // if planet info audio is playing then it should be stopped when user moves out of the proximity circle 
        if(pInfoSound.isPlaying)
        {
            pInfoSound.Stop();
        }
    }
}
