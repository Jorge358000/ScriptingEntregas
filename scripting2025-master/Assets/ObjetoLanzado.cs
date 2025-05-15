using UnityEngine;

public class ObjetoLanzado : MonoBehaviour
{
    [SerializeField] private float distancia = 1f;
    [SerializeField] private float velocidad = 5f;

    private Vector3 destino;
    private bool moviendo = true;

    void Start()
    {
        destino = transform.position + Vector3.right * distancia;
    }

    void Update()
    {
        if (moviendo)
        {
            transform.position = Vector3.MoveTowards(transform.position, destino, velocidad * Time.deltaTime);
            if (Vector3.Distance(transform.position, destino) < 0.01f)
            {
                moviendo = false;
            }
        }
    }
}