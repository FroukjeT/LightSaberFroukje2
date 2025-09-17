using UnityEngine;

public class DestroyAfterSeconds : MonoBehaviour
{
    [Tooltip("Time in seconds before this object is destroyed")]
    public float lifetime = 8f;

    void Start()
    {
        Destroy(gameObject, lifetime);
    }
}
