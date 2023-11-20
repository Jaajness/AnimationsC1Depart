using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerInteraction : MonoBehaviour
{
    private Animator doorAnimator;
    private GameObject key;

    private void Start()
    {
        doorAnimator = GameObject.Find("Portes").GetComponent<Animator>();
        key = GameObject.Find("Key_Rusty");
    }

    private void OnTriggerEnter(Collider other)
    {

        if (other.gameObject.name == "Key_Rusty")
        {
            
            doorAnimator.SetBool("Ouvert", true);
            doorAnimator.SetBool("Fermé", false);

            key.SetActive(false);

            StartCoroutine(CloseDoorAfterDelay());
        }
    }

    private IEnumerator CloseDoorAfterDelay()
    {
        
        yield return new WaitForSeconds(20f); 

        
        doorAnimator.SetBool("Ouvert", false);
        doorAnimator.SetBool("Fermé", true);

        key.SetActive(true);
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.gameObject.name == "Key_Rusty")
        {
            doorAnimator.SetBool("Ouvert", true);
            doorAnimator.SetBool("Fermé", false);
        }
    }
}
