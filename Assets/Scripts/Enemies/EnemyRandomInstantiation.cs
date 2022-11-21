using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyRandomInstantiation : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("enemy spazwener box wpsohayhe");
        foreach (Transform t in transform)
        {
            if (t.CompareTag("Enemy"))
            {
                GameObject child = t.gameObject;
                Vector3 randomPosition = new Vector3(
                    Random.Range(-transform.localScale.x, transform.localScale.x),
                    Random.Range(-transform.localScale.y, transform.localScale.y),
                    Random.Range(-transform.localScale.z, transform.localScale.z)
                ) * 0.5f;
                child.transform.position = transform.position + randomPosition;
            }
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
