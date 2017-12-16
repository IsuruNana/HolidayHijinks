using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class ElfMovementScript : MonoBehaviour {

    public float speed = 5;
    public Text countText;

    private Rigidbody2D elfBody;
    private int count;

	// Use this for initialization
    //Comment
	void Start () {
        elfBody = GetComponent<Rigidbody2D>();
        count = 0;
        SetCountText();
	}
	
	// Update is called once per frame
	void Update () {
        float moveHorizontal = Input.GetAxis ("Horizontal");
        float moveVertical = Input.GetAxis ("Vertical");
        Vector2 movement = new Vector2(moveHorizontal, moveVertical);
        elfBody.AddForce(movement*speed);
    }

    /*void Awake()
    {
        DontDestroyOnLoad(this);
    }*/


    void OnTriggerEnter2D(Collider2D other){

		if (other.gameObject.CompareTag("pickup"))
		{
			other.gameObject.SetActive(false);
            count++;
            SetCountText();
        }
		if (other.gameObject.CompareTag("enemy")) 
		{
			SceneManager.LoadScene(3);
		}
	}

    void SetCountText()
    {
        countText.text = count.ToString();
    }
}
