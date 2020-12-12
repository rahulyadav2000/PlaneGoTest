using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ContentToggle : MonoBehaviour
{
    public GameObject ATRread;
    public GameObject F16read;
    public GameObject F4Uread;
    public GameObject Hawkread;
    public GameObject Piper18read;
    public GameObject ATRblock;
    public GameObject F16block;
    public GameObject F4Ublock;
    public GameObject Hawkblock;
    public GameObject Piperblock;
   
    // Start is called before the first frame update
    void Start()
    {
        ATRread = GameObject.FindGameObjectWithTag("ATRRead");
        ATRblock = GameObject.FindGameObjectWithTag("ATRBlock");
        Destroy(ATRread, 1f);
        Destroy(ATRblock, 1f);
        
        F16read = GameObject.FindGameObjectWithTag("F16DRead");
        F16block = GameObject.FindGameObjectWithTag("F16Block");
        Destroy(F16read, 1f);
        Destroy(F16block, 1f);
        
        F4Uread = GameObject.FindGameObjectWithTag("F4URead");
        F4Ublock = GameObject.FindGameObjectWithTag("F4UBlock");
        Destroy(F4Uread, 1f);
        Destroy(F4Ublock, 1f);
        
        Hawkread = GameObject.FindGameObjectWithTag("Hawk2Read");
        Hawkblock = GameObject.FindGameObjectWithTag("HawkBlock");
        Destroy(Hawkread, 1f);
        Destroy(Hawkblock, 1f);
        
        Piper18read = GameObject.FindGameObjectWithTag("PiperRead");
        Piperblock = GameObject.FindGameObjectWithTag("PiperBlock");
        Destroy(Piper18read, 1f);
        Destroy(Piperblock, 1f);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
