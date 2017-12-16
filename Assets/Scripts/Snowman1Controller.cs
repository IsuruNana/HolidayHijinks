using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Snowman1Controller : MonoBehaviour {

    public Transform[] target;
    public float speed;

    private int current;
    
	// Update is called once per frame
	void Update () {
        String yNew = transform.position.y.ToString();
        if (yNew.Length > 4)
        {
            yNew = yNew.Substring(0, 3);
        }
        if (!(yNew.Equals(target[current].position.y.ToString())) && !(transform.position.x.ToString().Equals(target[current].position.x.ToString())))
        {
            Vector2 pos = Vector2.MoveTowards(transform.position, target[current].position, speed * Time.deltaTime);
            GetComponent<Rigidbody2D>().MovePosition(pos);
        }

        else current = (current + 1) % target.Length;
	}
}
