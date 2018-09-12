using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Character : MonoBehaviour {

    public float moveSpeed = 2f;
    public float jumpPower = 300f;

    public GameManager GameManager;

    void Start()
    {
        Time.timeScale = 1f;    
    }

    // Update is called once per frame
    void Update () {
           // Update Frame 시간 차 * Time.timeScale * Time.deltaTime
        transform.Translate (moveSpeed * Vector3.right * Time.deltaTime);
	}

    public void Jump()
    {
        GetComponent<Rigidbody2D>().AddForce(Vector3.up * jumpPower);
    }
    
    void OnTriggerEnter2D(Collider2D col)
    {
        if(col.transform.name == "WinCollider")
        {
            GameManager.Win();
        } else if(col.transform.name == "LoseCollider")
        {
            GameManager.Lose();
        }
    }
}
