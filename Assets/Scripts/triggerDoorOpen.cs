using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class triggerDoorOpen : MonoBehaviour
{
    public GameObject ldoor;
    public GameObject rdoor;
    public GameObject proximityUI;
    public GameObject proMarker;
    private Animator ldooranimator;
    private Animator rdooranimator;
    private AudioSource doorSound;
    public GameObject uiExit;
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Markers"))
        {
            ldooranimator = ldoor.GetComponent<Animator>();
            rdooranimator = rdoor.GetComponent<Animator>();
            doorSound=ldoor.GetComponent<AudioSource>();
            other.gameObject.SetActive(false);
            ldooranimator.SetTrigger("TrOpen");
            rdooranimator.SetTrigger("TrOpen");
            doorSound.Play();
            
        }

        if(other.gameObject.name== "DoorClose")
        {
            ldooranimator.SetTrigger("TrClose");
            rdooranimator.SetTrigger("TrClose");
            other.gameObject.SetActive(false);
            proximityUI.SetActive(true);
        }

        if (other.gameObject.name == "markerExit")
        {
            ldooranimator = ldoor.GetComponent<Animator>();
            rdooranimator = rdoor.GetComponent<Animator>();
            doorSound = ldoor.GetComponent<AudioSource>();
            other.gameObject.SetActive(false);
            ldooranimator.SetTrigger("TrOpen");
            rdooranimator.SetTrigger("TrOpen");
            doorSound.Play();
            uiExit.SetActive(true);
        }

        if (other.gameObject.name == "proMarker")
        {
            proMarker.SetActive(false);
        }
    }
    private void OnTriggerExit(Collider other)
    {
        
    }
}
