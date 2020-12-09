using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using GoogleARCore;

public class SpawnRunway : MonoBehaviour
{
    public Transform Runway;
    public GameObject[] Player;
    private Vector3 NextSpawnPos;

    private AugmentedImageController Control;
    private ColorChanger Changer;
    // Start is called before the first frame update
    void Start()
    {        
        //Instantiate(Runway, new Vector3(0, 0, 7), Runway.rotation);
        StartCoroutine(SpawnPath());
    }

    // Update is called once per frame
    void Update()
    {
        if (Control.IsAtr == true || Changer.isGreen == true)
        {
            Instantiate(Player[0], new Vector3(0, 1.5f, 7), Quaternion.identity);
        }
        if (Control.IsF16D == true || Changer.isGreen == true)
        {
            Instantiate(Player[1], new Vector3(0, 1.5f, 7), Quaternion.identity);
        }
        if (Control.IsF4C == true || Changer.isGreen == true)
        {
            Instantiate(Player[2], new Vector3(0, 1.5f, 7), Quaternion.identity);
        }
        if (Control.IsHawk2 == true || Changer.isGreen == true)
        {
            Instantiate(Player[3], new Vector3(0, 1.5f, 7), Quaternion.identity);
        }
        if (Control.IsPiper18 == true || Changer.isGreen == true)
        {
            Instantiate(Player[4], new Vector3(0, 1.5f, 7), Quaternion.identity);
        }
    }

    IEnumerator SpawnPath()
    {
        Instantiate(Runway, NextSpawnPos, Runway.rotation);
        NextSpawnPos.z += 10;
        yield return new WaitForSeconds(1f);
        Instantiate(Runway, NextSpawnPos, Runway.rotation);
        //StartCoroutine(SpawnPath());
    }
}
