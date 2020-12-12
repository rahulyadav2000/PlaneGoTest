using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using GoogleARCore;

public class SpawnRunway : MonoBehaviour
{
    public Transform Runway;
    
    private Vector3 NextSpawnPos = new Vector3(0,-4,7);

    public GameObject Content;
    public GameObject Quitcontroller;
  
    // Start is called before the first frame update
    void Start()
    {
        Content.SetActive(false);
        Quitcontroller.SetActive(false);
        StartCoroutine(SpawnPath());
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    IEnumerator SpawnPath()
    {
        Content.SetActive(true);
        Invoke("QuitSpawner", 16f);
        Instantiate(Runway, NextSpawnPos, Runway.rotation);
        NextSpawnPos.z += 10;
        yield return new WaitForSeconds(1f);
        StartCoroutine(SpawnPath());
    }

    private void QuitSpawner()
    {
        Quitcontroller.SetActive(true);
    }
}
