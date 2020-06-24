using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ObstacleCollision : MonoBehaviour
{
    public GameObject obstacle;
    public GameObject obstacle1;
    public GameObject obstacle2;
    public GameObject obstacle3;

    private int rand;
    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("Obstacle", 1, 1);
    }

    // Update is called once per frame
    void Update()
    {

        rand = Random.Range(0, 5);
    }

    void Obstacle()
    {
        if (rand == 1)
        {
            Instantiate(obstacle,new Vector3(Random.Range(-5, 5), 0,0),Quaternion.identity);
        }

        if (rand == 2)
        {
            Instantiate(obstacle1,new Vector3(Random.Range(-5, 5), 0,0),Quaternion.identity);
        }

        if (rand == 3)
        {
            Instantiate(obstacle2, new Vector3(Random.Range(-5, 5), 0,0),Quaternion.identity);
        }

        if (rand == 4)
        {
            Instantiate(obstacle3,new Vector3(Random.Range(-5,5),0,0),Quaternion.identity);
        }
    }
}
