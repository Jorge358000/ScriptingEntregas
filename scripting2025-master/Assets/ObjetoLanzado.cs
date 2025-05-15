using UnityEngine;

public class ObjetoLanzado : MonoBehaviour
{
    [SerializeField] private float distancia = 1f;
    [SerializeField] private float velocidad = 5f;

    private Vector3 destino;
    private bool moviendo = false;
    private float direccion = 1f;

    public void SetDireccion(float dir)
    {
        direccion = dir;
        Vector3 direccionVector = direccion > 0 ? Vector3.right : Vector3.left;
        destino = transform.position + direccionVector * distancia;
        moviendo = true;
    }

    void Update()
    {
        if (moviendo)
        {
            transform.position = Vector3.MoveTowards(transform.position, destino, velocidad * Time.deltaTime);
            if (Vector3.Distance(transform.position, destino) < 0.01f)
            {
                moviendo = false;
                Destroy(gameObject, 1f); // Se destruye después de 1 segundo
            }
        }
    }
}
