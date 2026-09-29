What it does: Counts collisions with the target, changes its material to a random color after every collision, 
  and spawns an explosion then destroys the target on the third collision.
Study points:
Focus on the fields, Unity event methods, conditions, and the exact GameObject names/tags used by the script.
  
using UnityEngine;
using UnityEngine.InputSystem;

public class TargetScript : MonoBehaviour
{
    [SerializeField] GameObject explotionPrefab;
    [SerializeField] Transform targetLocation;
    int ctr;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        ctr = 0;
       
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.collider.name != "Cube" || collision.collider.name != "Explosion")
        {
            ctr++;
        }
       
        if (ctr >=3)
        {
            
            Instantiate(explotionPrefab, targetLocation.position, targetLocation.rotation);

            Destroy(gameObject);
        }
        MeshRenderer targetRenderer = GetComponent<MeshRenderer>();
        targetRenderer.material.color =
            new Color(Random.Range(0f, 1f), Random.Range(0f, 1f), Random.Range(0f, 1f));
    }
}
