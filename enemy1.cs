using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemy1 : MonoBehaviour
{
    public GameObject enemyPrefab;
    float speed = 10.0f;
    float chanceToChangeDirection = 0.01f;
    float chanceToChangeAxisDirect = 0.4f;
    
    // Start is called before the first frame update
    void Start()
    {
        Invoke("SpawnEnemy", 6f);
    }

    void SpawnEnemy()
    {
        GameObject enemy = Instantiate<GameObject>(enemyPrefab);
        Vector3 posToSpawn = this.transform.position;
        posToSpawn.x = Random.Range(-500, 500);
        posToSpawn.z = Random.Range(-50, 250);
        this.transform.position = posToSpawn;
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 pos = transform.position;
        if (Random.value < chanceToChangeAxisDirect)
        {
            pos.x += speed * Time.deltaTime;
        }
        else if (Random.value > chanceToChangeAxisDirect)
        {
            pos.z += speed * Time.deltaTime;
        }
        transform.position = pos;
    }

    void FixedUpdate()
    {
        if (Random.value < chanceToChangeDirection)
        {
            speed = speed * -1;
        }
    }
}
