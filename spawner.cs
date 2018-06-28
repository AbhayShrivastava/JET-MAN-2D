using UnityEngine;
using System.Collections;

public class spawner : MonoBehaviour {
    public GameObject ledgePrefab;
    public int ledgepoolsize = 4;
    public float spawnrate = 3f;
    public float minsize;
    public float maxsize;

    private GameObject[] ledge;
    private int currentledge=0;
    private Vector2 spawnpos;
    private float timelastspawn;

	// Use this for initialization
	void Start () {
        timelastspawn = 0;

        spawnpos = transform.position;
        ledge = new GameObject[ledgepoolsize];
        for (int i = 0; i < ledgepoolsize; i++)
        {
            ledge[i] = (GameObject)Instantiate(ledgePrefab, spawnpos, Quaternion.identity);
        }
	
	}
	
	// Update is called once per frame
	void Update () {
        
        
        
        
        timelastspawn += Time.deltaTime;
        if (timelastspawn > spawnrate)
        {
            timelastspawn = 0;


            spawnpos.y = Random.Range(minsize,maxsize);

            ledge[currentledge].transform.position = spawnpos;
            currentledge++;

            if (currentledge >= ledgepoolsize)
            {
                currentledge = 0;
            }
        
        }
	
	}
}
