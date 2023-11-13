using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ExempleDemo : MonoBehaviour
{

    public string monNom = "Eli";
    public bool vraiNom = true;
    public int _age = 29;
    public bool _verite = false;
 
    void Start()
    {
      Debug.Log(_age);
    }
    
    void Update()
    {
       Debug.Log(_verite);
    }
}
