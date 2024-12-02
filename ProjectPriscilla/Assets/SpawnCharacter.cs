using UnityEngine;

public class SpawnCharacter : MonoBehaviour
{
    public GameObject characterPrefab;  // Reference to your character prefab
    public float spawnRotationY = 90f;  // The rotation you want for the character (in degrees)

    void Start()
    {
        Spawn();
    }

    void Spawn()
    {
        // Instantiate the character at the spawn point with a specific rotation
        Quaternion rotation = Quaternion.Euler(0f, spawnRotationY, 0f); // Adjust the Y rotation to face the correct direction
    }
}
