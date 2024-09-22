using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit.Interactables;

public class snapBackOnRelease : MonoBehaviour
{
    // declaring variables
    public GameObject ghost;
    private XRGrabInteractable grabInteractable;
    private GameObject planet;
    private Vector3 initialLocalPosition;
    
    void Start()
    {
        //giving reference to the components
        grabInteractable = GetComponent<XRGrabInteractable>();
        initialLocalPosition = transform.localPosition;
    }
    void Update()
    {
        
        if (!grabInteractable.isSelected)
        {
            // if the grab button is unpressed the planet will move to its original previous position
            transform.localPosition = initialLocalPosition;
            ghost.SetActive(false);
        }
        else
        {
            // if the grab button is pressed the planet will follow the controller transform and the ghost planet will be visible at the planet's place
            ghost.transform.localPosition = initialLocalPosition;
            ghost.SetActive(true);
        }
    }
}
