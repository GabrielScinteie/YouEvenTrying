using System.Collections;
using UnityEngine;

public class CameraController : MonoBehaviour
{
    public GameObject Player;
    private Vector3 offset;
    void Start()
    {
        offset = transform.position - Player.transform.position;
    }


    void Update()
    {
        transform.position = Player.transform.position + offset;
    }
}
