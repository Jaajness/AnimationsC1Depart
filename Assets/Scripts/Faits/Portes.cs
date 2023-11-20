using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Portes : MonoBehaviour
{

    [SerializeField] private GameObject _porteDroite;

    [SerializeField] private GameObject _porteGauche;

    // Update is called once per frame

    void Start()
    {
  
    }

    // Update is called once per frame
    void Update()
    {

    }

    void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {

            _porteDroite.GetComponent<Animator>().SetBool("Ouvre", true);
            _porteGauche.GetComponent<Animator>().SetBool("Ouvre", true);

        }
    }

    void OnTriggerExit(Collider other)
    {
        if (other.tag == "Player")
        {
            _porteGauche.GetComponent<Animator>().SetBool("Ouvre", false);
            _porteDroite.GetComponent<Animator>().SetBool("Ouvre", false);
        }
    }
}
