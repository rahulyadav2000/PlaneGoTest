using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class QuitSpawner : MonoBehaviour
{
    public GameObject QuitButton;
   
    // Start is called before the first frame update
    void Start()
    {
        var exit = Instantiate(QuitButton) as GameObject;  //Spawning of the Quit Plane/ Button
        exit.transform.position += new Vector3(0, 6, 20);
    }

    // Update is called once per frame
    void Update()
    {
    }
}
