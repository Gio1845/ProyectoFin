using System.Collections;
using UnityEngine.SceneManagement;
using UnityEngine;

public class CambioNivel7_semestre7 : MonoBehaviour
{
   void OnTriggerEnter(Collider other) 
   {
        if(other.tag == "Player")
        {
            SceneManager.LoadScene("Semestre7");
        }    
   }
}
