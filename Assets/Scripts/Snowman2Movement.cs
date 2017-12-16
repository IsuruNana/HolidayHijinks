using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Snowman2Movement : MonoBehaviour {

    public Transform target;    public float speed;

    // Update is called once per frame
    void Update()
    {        target = GameObject.FindGameObjectWithTag("elf").transform;
        Vector2 pos = Vector2.MoveTowards(transform.position, target.position, speed * Time.deltaTime);
        GetComponent<Rigidbody2D>().MovePosition(pos);
    }
}
