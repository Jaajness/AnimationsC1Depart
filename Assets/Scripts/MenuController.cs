using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

 public class MenuController : MonoBehaviour
{    
     public void ChangeScene(string _sceneName)
     { 
         SceneManager.LoadScene(_Scene1);
     }


     public void Quit()
     {
         Application.Quit();
     }
      
}