using System.Collections;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class Texto : MonoBehaviour
{
    public TextMeshProUGUI textComponent;
    public float typingSpeed = 0.05f;
    
    private string fullText = "Bienvenido.  Las instrucciones son bastantes simple, más de lo que crees. con WASD, te mueves libremente por el mundo, con la barra espaciadora saltas y con el 2 usas el jetpack, pero ten en cuenta que el jetpack no es inifinito, no abuses de él porfavor. Hay plataformas que caen y otras que se mueven, ¡Ten mucho cuidado!";
    private string currentText = "";

    void Start()
    {
        StartCoroutine(Escribir());
    }

    IEnumerator Escribir()
    {
        for (int i = 0; i < fullText.Length; i++)
        {
            currentText = fullText.Substring(0, i + 1);
            textComponent.text = currentText;
            yield return new WaitForSeconds(typingSpeed);
        }
    }
}
