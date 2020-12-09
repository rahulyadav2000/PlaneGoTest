using System.Collections;
using GoogleARCore;
using System.Collections.Generic;
using UnityEngine;

public class AugmentedImageController : MonoBehaviour
{
    public GameObject[] ObjectsToSpawn;
    public GameObject[] Readings;

    public bool IsAtr;
    public bool IsF16D;
    public bool IsF4C;
    public bool IsHawk2;
    public bool IsPiper18;

    private List<AugmentedImage> _AugmentedImages = new List<AugmentedImage>();
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Session.Status != SessionStatus.Tracking)
        {
            return;
        }

        Session.GetTrackables<AugmentedImage>(_AugmentedImages, TrackableQueryFilter.Updated);
        foreach(AugmentedImage marker in _AugmentedImages)
        {
            if(!IsAtr && marker.Name == "ATR")
            {
                var atr = Instantiate(ObjectsToSpawn[0]) as GameObject;
                var read = Instantiate(Readings[0]) as GameObject;
                atr.transform.position = marker.CenterPose.position + new Vector3(3,0,4);
                read.transform.position = marker.CenterPose.position + new Vector3(0,0,20);
                IsAtr = true;
            }
            else if (!IsF16D && marker.Name == "F16D")
            {
                var f16d = Instantiate(ObjectsToSpawn[1]) as GameObject;
                var read = Instantiate(Readings[1]) as GameObject;
                f16d.transform.position = marker.CenterPose.position + new Vector3(3, 0, 4);
                read.transform.position = marker.CenterPose.position + new Vector3(0, 0, 20);
                IsF16D = true;
            }
            else if(!IsF4C && marker.Name == "F4C")
            {
                var f4c = Instantiate(ObjectsToSpawn[2]) as GameObject;
                var read = Instantiate(Readings[2]) as GameObject;
                f4c.transform.position = marker.CenterPose.position + new Vector3(3, 0, 4);
                read.transform.position = marker.CenterPose.position + new Vector3(0, 0, 20);
                IsF4C = true;
            }
            else if(!IsHawk2 && marker.Name == "Hawk2")
            {
                var hawk = Instantiate(ObjectsToSpawn[3]) as GameObject;
                var read = Instantiate(Readings[3]) as GameObject;
                hawk.transform.position = marker.CenterPose.position + new Vector3(3, 0, 4);
                read.transform.position = marker.CenterPose.position + new Vector3(0, 0, 20);
                IsHawk2 = true;
            }
            else if(!IsPiper18 && marker.Name == "Piper18")
            {
                var piper = Instantiate(ObjectsToSpawn[4]) as GameObject;
                var read = Instantiate(Readings[4]) as GameObject;
                piper.transform.position = marker.CenterPose.position + new Vector3(3, 0, 3);
                read.transform.position = marker.CenterPose.position + new Vector3(0, 0, 20);
                IsPiper18 = true;
            }
            else
            {
                //Do Nothing
            }
        }

    }
}
