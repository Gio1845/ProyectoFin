using System.Collections;
using UnityEngine.SceneManagement;
using UnityEngine;

public class CambioNivel_semestre : MonoBehaviour
{
   void OnTriggerEnter(Collider other) 
   {
        if(other.tag == "Player")
        {
            SceneManager.LoadScene("Semestre8");
        }    
   }
}
