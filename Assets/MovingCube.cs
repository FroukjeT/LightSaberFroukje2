using System.Security.Cryptography;
using System.Threading;
using UnityEngine;

public class MovingCube : MonoBehaviour
{

    // Update is called once per frame
    void Update()
    {
        transform.position += transform.forward * -0.5f * Time.deltaTime;
    }
}
