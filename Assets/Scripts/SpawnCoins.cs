using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class SpawnCoins : MonoBehaviour
{
    public GameObject GoldCoin;
    public GameObject DeadCoin;

    public int xPos;
    public int zPos;
    public int CoinCount;
    
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(SpawnGoldCoin());
        StartCoroutine(SpawnDeadCoin());
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    IEnumerator SpawnGoldCoin()
    {
        while (CoinCount < 100)
        {
            xPos = Random.Range(0, 3);
            zPos = Random.Range(2, 800);
            Instantiate(GoldCoin, new Vector3(xPos, -2.7f, zPos), Quaternion.EulerRotation(0, 0, 90f));
            yield return new WaitForSeconds(1f);
            CoinCount++;
        }
    }
    
    IEnumerator SpawnDeadCoin() // Destorys the Aircraft
    {
        while (CoinCount < 4)
        {
            xPos = Random.Range(0, 3);
            zPos = Random.Range(20, 800);
            Instantiate(DeadCoin, new Vector3(xPos, -2.7f, zPos), Quaternion.EulerRotation(0, 0, 90f));
            yield return new WaitForSeconds(1f);
            CoinCount++;
        }
    }
}
