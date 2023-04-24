using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    public GameObject[] Balls;
    public int waitSecond;
    public bool Canspawn;

    void Start()
    {
        StartCoroutine(Spawn());
    }
    private void Update()
    {
        if(Canspawn)
        {
            StartCoroutine(Spawn());
        }
    }


    private IEnumerator Spawn()
    {
        Canspawn = false;
        int randomEnemy= Random.Range(0, Balls.Length);
        Instantiate(Balls[randomEnemy],new Vector3(Random.Range(-9,9),7,0), Quaternion.identity);
        yield return new WaitForSeconds(waitSecond);
        Canspawn = true;
    }
}
