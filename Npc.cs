using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Npc : MonoBehaviour
{
    // Start is called before the first frame update
    int level = 5;
    int health = 6;
    int speed = 5;
    void Start()
    {
        health += level;
        print("health:"+health);

    }

    // Update is called once per frame
    void Update()
    {
        Vector3 newpos = transform.position;
        newpos.z += speed * Time.deltaTime;
        transform.position = newpos;
    }
}
