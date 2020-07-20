using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class PlayerController : MonoBehaviour
{
    public Text y;
    private Rigidbody rb;
    public float deathcounter;
    public float speed;
    public GameObject[] prefab_respawn;
    public GameObject[] enemy;
    private int picked;
    void Start()
    {
        rb = GetComponent<Rigidbody>();
        picked = 0;
        deathcounter = 0;
        y.text = "Deaths = 0";
    }

    void FixedUpdate()
    {
        float moveHorizontal = Input.GetAxis("Horizontal");
        float moveVertical = Input.GetAxis("Vertical");
        Vector3 movement = new Vector3(moveHorizontal, 0, moveVertical);
        rb.AddForce(movement * speed);
        y.text = "Deaths = " + deathcounter.ToString();
        for(int j = 0; j < enemy.Length; j++)
            if(Vector3.Distance(transform.position, enemy[j].transform.position) <= 1.7)
            {
                rb.velocity = Vector3.zero;
                transform.position = new Vector3(-10, 1, -12);
                picked = 0;
                for (int i = 0; i < prefab_respawn.Length; i++)
                    prefab_respawn[i].SetActive(true);
                deathcounter++;
            }
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("PickUp1"))
        {
            picked++;
            other.gameObject.SetActive(false);
            if (picked == 7)
                SceneManager.LoadScene("Win",LoadSceneMode.Single);
        }

        if (other.gameObject.CompareTag("Wall") || other.gameObject.CompareTag("enemy"))
        {
            rb.velocity = Vector3.zero;
            transform.position = new Vector3(-10, 1, -12);
            picked = 0;
            for (int i = 0; i < prefab_respawn.Length; i++)
                prefab_respawn[i].SetActive(true);
            deathcounter++;
        }

            
    }
}
