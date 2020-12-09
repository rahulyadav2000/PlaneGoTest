using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlaneControl : MonoBehaviour
{
    private Rigidbody rigidbody;
    
    private SpawnCoins spawncoins;
    private float dirX;
    private float MoveSpeed = 20f;
    public bool isCollected = false;
    // Start is called before the first frame update
    void Start()
    {
        rigidbody = GetComponent<Rigidbody>();       
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKey(KeyCode.A))
        {
            rigidbody.AddForce(Vector2.left * 2);
        }

        if (Input.GetKey(KeyCode.D))
        {
            rigidbody.AddForce(-Vector2.left * 2);
        }

        /*dirX = Input.acceleration.x * MoveSpeed;
        transform.position = new Vector3(Mathf.Clamp(transform.position.x, -3, 3), 0, transform.position.z);*/
    }

    /*private void FixedUpdate()
    {
        rigidbody.velocity = new Vector3(dirX, 0, 0);
    }*/


    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.tag == "GoldCoin")
        {
            Destroy(other.gameObject);
            isCollected = true;
        }
    }
}
