using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FermeExterieur : MonoBehaviour
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

    private void OnCollisionEnter(Collision other)
    {
    _porte.GetComponent<Animator>().SetBool("Ouvre", false);
    }
}
