using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ScenePortal : MonoBehaviour
{

    public GameObject player;
    public float distance;
    public string target;


    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
    	if (player) {
            float dist = Vector3.Distance(transform.position, player.transform.position);
            if (dist < distance) {
                SceneManager.LoadScene(target);
            }
        }
    }
}
