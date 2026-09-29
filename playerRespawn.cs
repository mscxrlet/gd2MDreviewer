What it does: Stores the initial player position and returns the player there when the stage is above the player on the Y axis.
Study points:
Focus on the fields, Unity event methods, conditions, and the exact GameObject names/tags used by the script.

using UnityEngine;

public class playerRespawn : MonoBehaviour
{
    [SerializeField]
    
    Transform playerTrans, stageTrans;
    Vector3 startingposition;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
        startingposition = playerTrans.position;
    }

    // Update is called once per frame
    void Update()
    {
        if (stageTrans.position.y > playerTrans.position.y )
        {
            playerTrans.position = startingposition;
        }
    }
}
