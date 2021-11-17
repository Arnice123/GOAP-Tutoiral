using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawn : MonoBehaviour
{
    public GameObject patientPrefab;
    public int numPatient;
    // Start is called before the first frame update
    void Start()
    {
        for (int i = 0; i < numPatient; i++)
        {
            Instantiate(patientPrefab, this.transform.position, Quaternion.identity);
        }

        Invoke("SpawnPatient", 5);
    }

    void SpawnPatient()
    {
        Instantiate(patientPrefab, this.transform.position, Quaternion.identity);

        Invoke("SpawnPatient", Random.Range(7, 10));
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
