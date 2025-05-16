using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DificultadNivel1 : MonoBehaviour
{
    private static int dificultadNivel1;
    [SerializeField] private GameObject Medio;
    [SerializeField] private GameObject Dificil;
    void Start()
    {

    }

    public DificultadNivel1(int dificultad)
    {
        dificultadNivel1 = dificultad;
    }

    // Update is called once per frame
    void Update()
    {
        if (dificultadNivel1 == 1)
        {
            Medio.SetActive(false);
            Dificil.SetActive(false);
        }
        else if (dificultadNivel1 == 2)
        {
            Medio.SetActive(true);
            Dificil.SetActive(false);
        }
        else if (dificultadNivel1 == 3)
        {
            Medio.SetActive(true);
            Dificil.SetActive(true);
        }
    }
}
