using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Boton : MonoBehaviour
{
    public Animator boton;
    public Animator puerta;
    // Start is called before the first frame update
    void Start()
    {
        boton.SetBool("ON", false);
        puerta.SetBool("abrir", false);
    }

    // Update is called once per frame
    void OnTriggerEnter(Collider other) {
        boton.SetBool ("ON",true);
        puerta.SetBool("abrir", true);
    }
}
