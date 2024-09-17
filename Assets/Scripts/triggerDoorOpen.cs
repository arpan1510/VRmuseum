using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class triggerDoorOpen : MonoBehaviour
{
    public GameObject ldoor;
    public GameObject rdoor;
    private Animator ldooranimator;
    private Animator rdooranimator;
    private AudioSource doorSound;
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
            //doorSound.pitch = -1f;
            ldooranimator.SetTrigger("TrClose");
            rdooranimator.SetTrigger("TrClose");
            other.gameObject.SetActive(false);
            //doorSound.Play();
        }
    }
    private void OnTriggerExit(Collider other)
    {
        
    }
}
