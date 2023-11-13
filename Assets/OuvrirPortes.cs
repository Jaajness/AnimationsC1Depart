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

    // Update is called once per frame
    void Update()
    {
        
     
    }

    void OnTriggerEnter(Collider Player)
    {
        
      if(Player.tag == "Player"){
          _Zone.GetComponentInChildren<Animator>().SetBool("Ouvert",true);
      }
      

    }
}
