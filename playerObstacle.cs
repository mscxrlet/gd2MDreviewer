What it does: Checks bounds intersection between player and obstacle renderers.
  On intersection it adjusts a stored player position and assigns it back to the player transform.
Study points:
Focus on the fields, Unity event methods, conditions, and the exact GameObject names/tags used by the script.
  
using UnityEngine;

public class playerObstacle : MonoBehaviour
{
    [SerializeField]
    
    MeshRenderer obstacleRenderer,playerRenderer;
    Transform playerTrans;
    bool checkHit;
    Vector3 playerpos;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
        obstacleRenderer = GetComponent<MeshRenderer>();
        checkHit = false;
        playerpos = playerTrans.position;
    }

    // Update is called once per frame
    void Update()
    {
        if (playerRenderer.bounds.Intersects(obstacleRenderer.bounds))
        {
            checkHit = true;
            playerpos.x -= 2;
            playerpos.y += 2;
            playerTrans.position = playerpos;
        }
        else
        {
            checkHit = false;
        }
    }
}
