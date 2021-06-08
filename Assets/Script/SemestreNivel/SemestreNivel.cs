using UnityEngine;
using System.Collections.Generic;
using UnityEngine.SceneManagement;

public class SemestreNivel : MonoBehaviour
{
    public void LoadScene(string sceneName)
    {
        SceneManager.LoadScene(sceneName);
    }
}
