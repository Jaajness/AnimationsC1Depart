using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Clee : MonoBehaviour
{
    [SerializeField] private GameObject _porte;

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
            _porte.GetComponent<Animator>().SetTrigger("OuvrePorte");
        }
    }
}
