What it does: Stores a serialized scrap Rigidbody GameObject reference; its current Start method contains no active behavior.
Study points:
Focus on the fields, Unity event methods, conditions, and the exact GameObject names/tags used by the script.
  
using UnityEngine;

public class ExplosionScript : MonoBehaviour
{
    [SerializeField]
    GameObject scrapRigid;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        Destroy(scrapRigid, 3);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
