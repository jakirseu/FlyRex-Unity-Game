using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class batSpawner : MonoBehaviour
{

    public float maxTime = 1;
    public GameObject bat;

    private float timer;
    public float height;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

        if (timer > maxTime)
        {
            GameObject newBat = Instantiate(bat);
            newBat.transform.position = transform.position + new Vector3(0, Random.Range(-height, height), 0);
            Destroy(newBat, 15);
            timer = 0;
        }

        timer += Time.deltaTime;



    }
}
