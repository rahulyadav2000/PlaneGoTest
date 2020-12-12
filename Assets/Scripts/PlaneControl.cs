using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlaneControl : MonoBehaviour
{
    private Rigidbody rigidbody;

    public GameObject Runway;
    
    private float dirX;
    private float MoveSpeed = 20f;
    
    public bool isCollected = false;
    
    private AudioSource audio;
    public AudioClip Coin;
    public AudioClip explode;
    
    // Start is called before the first frame update
    void Start()
    {
        audio = GetComponent<AudioSource>();
        rigidbody = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
       if(Input.touchCount > 0)
        {
            Touch touch = Input.GetTouch(0);
            if(touch.phase == TouchPhase.Began)
            {
                if (touch.position.x < Screen.width / 2 && transform.position.x > -1.75f)
                {
                    transform.position = new Vector3(transform.position.x - 1.75f, transform.position.y, transform.position.z);
                }

                if(touch.position.x > Screen.width / 2 && transform.position.x < 1.75f)
                {
                    transform.position = new Vector3(transform.position.x + 1.75f, transform.position.y, transform.position.z);
                }

            }
        }
    }

    

    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.tag == "GoldCoin")
        {
            Destroy(other.gameObject);
            audio.PlayOneShot(Coin, 2);
            isCollected = true;
        }
        else if(other.gameObject.tag == "DeadCoin")
        {
            Destroy(other.gameObject);
            audio.PlayOneShot(explode, 2);
            Destroy(gameObject, 0.5f);
        }
    }
}
