using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class ObjectCreator : MonoBehaviour
{
    [SerializeField]// public variable that can be seen in inspector
    float initialCreateDelay = 5.0f;
    [SerializeField]
    float createRate = 25f;//Creates an obstacle every 10 seconds
    [SerializeField]
    float createRateTimer;
   public GameObject obstacle;
    // Start is called before the first frame update
    void Start()
    {
        // timer creation
        createRateTimer = initialCreateDelay;
    }

    // Update is called once per frame
    void Update()
    {
        // measuring time, and decrease seconds passed in game
        createRateTimer -= Time.deltaTime;
        if(createRateTimer <=0)
        {
            //spawn object
            Spawn();
        }
        
    }

    void Spawn()
    {
        Instantiate(obstacle,new Vector2(Random.Range(-9f,9f),Random.Range(-5f,9f)),obstacle.transform.rotation);
        createRateTimer = createRate;
    }
}
