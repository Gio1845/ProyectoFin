using System.Collections;
using UnityEngine.SceneManagement;
using UnityEngine;

public class CambioNivel4_semestre4 : MonoBehaviour
{
   void OnTriggerEnter(Collider other) 
   {
        if(other.tag == "Player")
        {
            SceneManager.LoadScene("Semestre4");
        }    
   }
}
