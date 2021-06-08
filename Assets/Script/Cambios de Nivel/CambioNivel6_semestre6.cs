using System.Collections;
using UnityEngine.SceneManagement;
using UnityEngine;

public class CambioNivel6_semestre6 : MonoBehaviour
{
   void OnTriggerEnter(Collider other) 
   {
        if(other.tag == "Player")
        {
            SceneManager.LoadScene("Semestre6");
        }    
   }
}
