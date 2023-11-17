using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OuvrirPortes : MonoBehaviour
{
    [SerializeField] GameObject _porteDroite;
    [SerializeField] GameObject _porteGauche;

    [SerializeField] GameObject _Joueur;

    [SerializeField] GameObject _Zone;

    void Start()
    {
        
    }

    void OnTriggerEnter(Collider Player)
    {
        if (Player.CompareTag("Player"))
        {
            _Zone.GetComponentInChildren<Animator>().SetBool("Ouvert", true);
            _Zone.GetComponentInChildren<Animator>().SetBool("Fermé", false); 
        }
    }

    void OnTriggerExit(Collider Player)
    {
        if (Player.CompareTag("Player"))
        {
            _Zone.GetComponentInChildren<Animator>().SetBool("Ouvert", false);
            _Zone.GetComponentInChildren<Animator>().SetBool("Fermé", true);
        }
    }


}

