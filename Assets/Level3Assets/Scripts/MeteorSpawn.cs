using UnityEngine;
public class MeteorSpawn : MonoBehaviour
{
    public GameObject meteor; // Assign your meteor prefab in the inspector
    public float spawnInterval = 2f; // Time interval between spawns

    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("SpawnMeteor", spawnInterval, spawnInterval);
    }

    void SpawnMeteor()
    {
       
        // Generate a random position within a certain range
        Vector3 spawnPosition = new Vector3(Random.Range(-transform.localScale.x/2, transform.localScale.x/2), 300, transform.position.z+Random.Range(-transform.localScale.z/2, transform.localScale.z/2));
        //Debug.Log(spawnPosition);
        // Instantiate the meteor at the random position
        Instantiate(meteor, spawnPosition, Quaternion.identity);
    }
}