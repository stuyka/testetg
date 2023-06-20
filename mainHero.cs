using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class mainHero : MonoBehaviour
{
    private float speed = 0.5f;
    private int hp = 6;

    void Start()
    {
        Vector3 spawnPos = this.transform.position;
        spawnPos.x = 0;
        spawnPos.z = -200;
        this.transform.position = spawnPos;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.D))
        {
            Vector3 pos = this.transform.position;
            pos.x = pos.x + speed;
            this.transform.position = pos;
        }

        else if (Input.GetKey(KeyCode.A))
        {
            Vector3 pos = this.transform.position;
            pos.x = pos.x - speed;
            this.transform.position = pos;
        }

        else if (Input.GetKey(KeyCode.W))
        {
            Vector3 pos = this.transform.position;
            pos.z = pos.z + speed;
            this.transform.position = pos;
        }

        else if (Input.GetKey(KeyCode.S))
        {
            Vector3 pos = this.transform.position;
            pos.z = pos.z - speed;
            this.transform.position = pos;
        }
    }

    void OnCollisionEnter(Collision coll)
    {
        GameObject collidedWith = coll.gameObject;
        if (collidedWith.tag == "enemy1")
        {
            hp = hp - 1;
        }
        print(hp);
        if (hp == 0)
        {
            print("Game over");
            Destroy(this.gameObject);
        }
    }
}
