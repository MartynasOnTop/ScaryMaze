using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Appear : MonoBehaviour
{
    public float spawnCooldown;
    float spawnTimer;
    public GameObject button;

    void Start()
    {
        spawnTimer = spawnCooldown;
    }

    void Update()
    {
        spawnTimer -= Time.deltaTime;
        if (spawnTimer <= 0)
        {
            button.SetActive(true);
        }
    } 
}
