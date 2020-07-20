using System.Collections;
using UnityEngine;

public class Rotater : MonoBehaviour
{
    void Start()
    {
    }
    void Update()
    {
        Vector3 rotate = new Vector3(30,30,30);
        transform.Rotate(rotate * Time.deltaTime);
    }
}
