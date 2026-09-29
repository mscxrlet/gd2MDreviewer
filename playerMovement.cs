What it does: Allows arrow-key or WASD movement only while PlayerDrop reports a collision with the stage.
Study points:
Focus on the fields, Unity event methods, conditions, and the exact GameObject names/tags used by the script.
using UnityEngine;
using UnityEngine.InputSystem;

public class playerMovement : MonoBehaviour
{
    PlayerDrop pd;
    Transform playerTrans;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        playerTrans = GetComponent<Transform>();
    }

    // Update is called once per frame
    void Update()
    {
        PlayerDrop pd = GetComponent<PlayerDrop>();
        if (pd.getCollision())
        {
            if (Keyboard.current.upArrowKey.isPressed || Keyboard.current.wKey.isPressed)
            {
                playerTrans.Translate(0, 0, .05f);

            }
            if (Keyboard.current.downArrowKey.isPressed || Keyboard.current.sKey.isPressed)
            {
                playerTrans.Translate(0, 0, -.05f);

            }
            if (Keyboard.current.leftArrowKey.isPressed || Keyboard.current.aKey.isPressed)
            {
                playerTrans.Translate(-0.05f, 0, 0);

            }
            if (Keyboard.current.rightArrowKey.isPressed || Keyboard.current.dKey.isPressed)
            {
                playerTrans.Translate(.05f, 0, 0);

            }
        }
    }
}
