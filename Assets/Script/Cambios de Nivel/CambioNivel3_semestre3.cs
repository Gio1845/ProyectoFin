using System.Collections;
using UnityEngine.SceneManagement;
using UnityEngine;

public class CambioNivel3_semestre3 : MonoBehaviour
{
   void OnTriggerEnter(Collider other) 
   {
        if(other.tag == "Player")
        {
            SceneManager.LoadScene("Semestre3");
        }    
   }
}
