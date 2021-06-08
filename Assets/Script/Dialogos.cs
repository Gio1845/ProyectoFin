using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Dialogos : MonoBehaviour
{
    public GameObject panel;

    public string[] dialogoInicial;
    public string[] dialogoPelea;
    public string[] dialogoFinal;

    public Text txtDialogo;
    public bool isDialogoActive;

    Coroutine auxCorutine;

    public void AbrirCajaDialogo(int valor)
    {
        if(isDialogoActive)
        {
            //CerrarDialogo();
            StartCoroutine(esperaSolaparicionDialogo(valor));
        }
        else
        {
            isDialogoActive = false;
            auxCorutine = StartCoroutine(mostrarDialogo(valor));
        }
    }

    IEnumerator mostrarDialogo(int valor, float time = 0.10f)
    {
        panel.SetActive(true);
        string[] dialogo;
        if (valor == 0) dialogo = dialogoInicial;
        else if (valor == 1) dialogo = dialogoPelea;
        else dialogo = dialogoFinal;

        int total = dialogo.Length;
        string res = "";
        isDialogoActive = true;
        yield return null;
        for ( int i = 0; i < total; i++)
        {
            res = "";
            if (isDialogoActive)
            {
                for(int s = 0; s < dialogo[i].Length; s++)
                {
                    if(isDialogoActive)
                    {
                        res = string.Concat(res, dialogo[i][s]);
                        txtDialogo.text = res;
                        yield return new WaitForSeconds(time);
                    }
                    else yield break;
                }
                yield return new WaitForSeconds(1f);
            }
            else yield break;
        }
        yield return new WaitForSeconds(1f);
        Debug.Log("CIERRAMOS MOSRAR");
        //CerrarDialogo();
    }
    IEnumerator esperaSolaparicionDialogo(int valor)
    {
        yield return new WaitForEndOfFrame();
        auxCorutine = StartCoroutine(mostrarDialogo(valor));
    }
    //public void CerrarDialogo()
    //{
        //isDialogoActive = false;
        //if (auxCorutine !=null)
        //{
          //  Debug.Log("detenedola");
           // StopCoroutine(auxCorutine);
            //auxCorutine = null;
        //}
        //txtDialogo.text = "";
        //panel.SetActive(false);
    //}
    private void Update() 
    {
        if(Input.GetKeyDown(KeyCode.Space))
        {
            AbrirCajaDialogo(0);
        }    
    }
}
