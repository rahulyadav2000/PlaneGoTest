using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class SpawnCoins : MonoBehaviour
{
    public GameObject GoldCoin;
    //public GameObject SilverCoin;
    public int xPos;
    public int zPos;
    public int CoinCount;
    
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(SpawnGoldCoin());
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    IEnumerator SpawnGoldCoin()
    {
        while (CoinCount < 50)
        {
            xPos = Random.Range(0, 3);
            zPos = Random.Range(10, 2000);
            Instantiate(GoldCoin, new Vector3(xPos, 1.5f, zPos), Quaternion.EulerRotation(0, 0, 90f));
            yield return new WaitForSeconds(1f);
            CoinCount++;
        }
    }
}
