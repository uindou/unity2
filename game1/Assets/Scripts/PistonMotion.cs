using UnityEngine;
using System.Collections;
public class PistonMotion : MonoBehaviour
{
    public float freq = 10;
    public float amplitude = 10;
    void Update()
    {
        transform.position = new Vector3(transform.position.x, Mathf.PingPong(Time.time * freq, amplitude), transform.position.z);
    }
}