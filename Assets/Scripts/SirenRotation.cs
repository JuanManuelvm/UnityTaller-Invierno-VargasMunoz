using UnityEngine;

public class SirenRotation : MonoBehaviour
{
    [Header("Configuración de Rotación")]
    public float rotationSpeed = 250f; // Permite ajustarla desde el Inspector

    void Update()
    {
        // Rota sobre el eje Y local continuamente considerando el tiempo transcurrido
        transform.Rotate(0f, rotationSpeed * Time.deltaTime, 0f);
    }
}