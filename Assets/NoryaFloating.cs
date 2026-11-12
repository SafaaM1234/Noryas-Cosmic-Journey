
using UnityEngine;

public class NoryaFloating : MonoBehaviour
{
    public float amplitude = 0.15f;
    public float speed = 1.5f;

    private Vector3 startPosition;

    void Start()
    {
        startPosition = transform.localPosition;
    }

    void Update()
    {
        float newY = startPosition.y +
                     Mathf.Sin(Time.time * speed) * amplitude;

        transform.localPosition = new Vector3(
            startPosition.x,
            newY,
            startPosition.z
        );
    }
}
