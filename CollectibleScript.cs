What it does: Counts Coin collisions, destroys collected coins, and increases the CharacterController step offset after at least three coins are collected.
Study points:
Focus on the fields, Unity event methods, conditions, and the exact GameObject names/tags used by the script.

using Unity.VisualScripting;
using UnityEngine;

public class CollectibleScript : MonoBehaviour
{
    GameObject[] coinObjs;
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

    private void OnControllerColliderHit(ControllerColliderHit hit)
    {
        if(hit.collider.name == "Coin")
        {
            ctr++;
            Destroy(hit.gameObject);
        }
        if(ctr >= 3)
        {
            CharacterController avatarCont = GetComponent<CharacterController>();
            avatarCont.stepOffset = 1;
        }

        //if(hit.collider.name == "collide")
        //{
        //    ctr++;
        //    hit.collider.transform.localScale *= 0.8f;

           
        //}
    }
}
