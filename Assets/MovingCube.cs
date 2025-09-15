using UnityEngine;

public class MovingCube : MonoBehaviour
{
    public Vector3 requiredDirection;

    // Update is called once per frame
    void Update()
    {
        transform.position += transform.forward * -0.5f * Time.deltaTime;
    }
}
