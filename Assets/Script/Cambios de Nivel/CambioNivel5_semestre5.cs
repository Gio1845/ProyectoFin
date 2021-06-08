using System.Collections;
using UnityEngine.SceneManagement;
using UnityEngine;

public class CambioNivel5_semestre5 : MonoBehaviour
{
   void OnTriggerEnter(Collider other) 
   {
        if(other.tag == "Player")
        {
            SceneManager.LoadScene("Semestre5");
        }    
   }
}
