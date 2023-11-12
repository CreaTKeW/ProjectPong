using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    [SerializeField] public GameObject spawnPrefab;
    
    void Start()
    {
        Instantiate(spawnPrefab, new Vector3(0,0,0), Quaternion.identity);
    }
}
