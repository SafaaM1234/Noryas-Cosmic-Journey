using UnityEngine;

public class CubeRotation : MonoBehaviour
{
    // Définit l'axe de rotation dans l'Inspector
    [SerializeField] private Vector3 rotationVector;

    // Définit la vitesse de rotation
    [SerializeField] private float speed = 3f;

    // Appelée à chaque frame
    void Update()
    {
        // Applique une rotation continue au cube
        transform.Rotate(rotationVector * Time.deltaTime * speed);
    }
}