using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class triggerDoorOpen : MonoBehaviour
{
    public GameObject ldoor;
    public GameObject rdoor;
    private Animator ldooranimator;
    private Animator rdooranimator;
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Markers"))
        {
            ldooranimator = ldoor.GetComponent<Animator>();
            rdooranimator = rdoor.GetComponent<Animator>();
            other.gameObject.SetActive(false);
            ldooranimator.SetTrigger("TrOpen");
            rdooranimator.SetTrigger("TrOpen");

        }
    }

}
