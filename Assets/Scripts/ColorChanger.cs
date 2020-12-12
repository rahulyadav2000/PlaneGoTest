using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class ColorChanger : MonoBehaviour
{
    public Camera Cam;
    
    public GameObject Controller;

    private AugmentedImageController Control;

    public bool isGreen = false;
    
    // Start is called before the first frame update
    void Start()
    {
        Controller.SetActive(false);       
    }

    // Update is called once per frame
    void Update()
    {
        Ray ray = new Ray(Cam.transform.position, Cam.transform.forward);
        RaycastHit HitInfo;
        
        if(Physics.Raycast(ray,out HitInfo))
        {
            if(HitInfo.transform.gameObject.CompareTag("Correct"))
            {
                HitInfo.transform.GetComponent<MeshRenderer>().material.color = Color.green;
                isGreen = true;
            }
            else if(HitInfo.transform.gameObject.CompareTag("Wrong"))
            {
                HitInfo.transform.GetComponent<MeshRenderer>().material.color = Color.red;
            }
            else
            {
                //Do Nothing
            }
        }

        if(isGreen == true)
        {
            Controller.SetActive(true);   // Proceed further to the spawning of Runway & Coins
            Invoke("Spawner", 1f);
        }
    }

    
}
