using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Enemy_Script : MonoBehaviour
{
    public Transform[] target;
    public float speed;
    private int current;

    void Start()
    {
        current = 0;
    }

    void FixedUpdate()
    {
        if (Vector3.Distance(transform.position, target[current].position) > 0.1)
        {
            transform.position = Vector3.MoveTowards(transform.position, target[current].position, speed * Time.deltaTime);
        }
        else
            current = (current + 1) % target.Length;
    }
}
