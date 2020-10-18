using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{

    private float firstDelay = 2.0f;
    private float repeatRate = 2.5f;
    private PlayerController playerControllerScript;

    public GameObject obstacle;
    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("SpawnObstracleAuto",firstDelay,repeatRate);
        playerControllerScript = GameObject.Find("Player").GetComponent<PlayerController>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void SpawnObstracleAuto()
    {
        if (playerControllerScript.gameOver == false)
        {
            Instantiate(obstacle, obstacle.transform.position, obstacle.transform.rotation);
        }
    }
}
