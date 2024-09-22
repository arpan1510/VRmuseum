using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class triggerDoorOpen : MonoBehaviour
{
    // declaring required components
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
        // if the XR rig will collide the marker, the door will open with the sound
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

        // After opening the door if the XR rig moves forward, the door will be automatically closed
        if (other.gameObject.name== "DoorClose")
        {
            ldooranimator.SetTrigger("TrClose");
            rdooranimator.SetTrigger("TrClose");
            other.gameObject.SetActive(false);
            proximityUI.SetActive(true);
        }

        // After all the planets are visited, the markerExit will be activated and when the XR rig collides with the markerExit thedoor will get open and exit UI will be enabled.
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
}
