using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit.Interactables;

public class snapBackOnRelease : MonoBehaviour
{
    public GameObject ghost;
    private XRGrabInteractable grabInteractable;
    private GameObject planet;
    private Vector3 initialLocalPosition;
    // Start is called before the first frame update
    void Start()
    {
        grabInteractable = GetComponent<XRGrabInteractable>();
        initialLocalPosition = transform.localPosition;
    }

    // Update is called once per frame
    void Update()
    {
        
        if (!grabInteractable.isSelected)
        {
            transform.localPosition = initialLocalPosition;
            ghost.SetActive(false);
        }
        else
        {
            ghost.SetActive(true);
        }
    }
}
