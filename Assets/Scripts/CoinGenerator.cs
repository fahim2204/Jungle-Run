using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoinGenerator : MonoBehaviour
{
    public ObjectPooler coinPooler;
    public void SpawnCoins(Vector3 position, float groundWidth)
    {
        int random = Random.Range(1, 100);
        if (random < 50)
            return;
        float x = Random.Range(3, 5);

        int numberOfCoins = (int)Random.Range(3f, groundWidth);
        for (int i = 0; i < numberOfCoins; i++)
        {
            GameObject coin = coinPooler.GetPooledGameObject();


            coin.transform.position = new Vector3(position.x - (groundWidth/2+1) + i , position.y+x, position.z);
            coin.SetActive(true);
        }
    }

    

    
}
