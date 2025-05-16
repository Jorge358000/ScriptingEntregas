using System.Collections;
using System.Collections.Generic;
using MoreMountains.Tools;
using UnityEngine;

public class LlamarDif : MonoBehaviour
{
    // Start is called before the first frame update
    public void facil()
    {
        DificultadNivel1 dif = new DificultadNivel1(1);
        MMSceneLoadingManager.LoadScene("Nivel1");
    }

    // Update is called once per frame
    public void Medio()
    {
        DificultadNivel1 dif = new DificultadNivel1(2);
        MMSceneLoadingManager.LoadScene("Nivel1");
    }

    public void Dificil()
    {
        DificultadNivel1 dif = new DificultadNivel1(3);
        MMSceneLoadingManager.LoadScene("Nivel1");
    }
}
