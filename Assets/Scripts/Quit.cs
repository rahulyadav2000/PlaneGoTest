using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Quit : MonoBehaviour
{
    public Camera cam;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Ray ray = new Ray(cam.transform.position, cam.transform.forward);
        RaycastHit hit;

        if(Physics.Raycast(ray,out hit))
        {
            if (hit.transform.gameObject.CompareTag("Quit")) //Closes the application
            {
                Application.Quit();
            }    
        }
    }
}
