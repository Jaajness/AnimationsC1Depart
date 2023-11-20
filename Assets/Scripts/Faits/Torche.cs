using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Torche : MonoBehaviour
{
  
   [SerializeField] private GameObject _joueur;
    [SerializeField] private GameObject _laTorche;
    [SerializeField] private GameObject _torcheJoueur;

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
        if(other.tag =="Player"){

           _laTorche.SetActive(false);
           _torcheJoueur.SetActive(true);

        }
    }

}
