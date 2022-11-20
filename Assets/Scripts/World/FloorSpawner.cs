using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

public class FloorSpawner : MonoBehaviour
{
    public List<GameObject> floors;
    
    [SerializeField] private GameObject floorScale;
    [SerializeField] private float floorOffset = 10f;

    int debugCount = 0;

    void Start()
    {
        if (floors != null && floors.Count > 0)
            floors = floors.OrderBy(r => r.transform.position.z).ToList();
    }

    public void MoveFloor()
    {
        GameObject movedFloor = floors[0];
        floors.Remove(movedFloor);
        float newZ = floors[floors.Count - 1].transform.position.z + floorOffset;
        movedFloor.transform.position = new Vector3(0, 0, newZ);
        floors.Add(movedFloor);

        Debug.Log("floor move happened " + debugCount++);
    }
}
