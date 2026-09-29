What it does: Reads keyboard movement and mouse rotation. It moves the CharacterController, repeatedly shrinks its height while K is held, 
  enables jumping after the LAST object is hit, and destroys LAST on collision.
Study points:
Focus on the fields, Unity event methods, conditions, and the exact GameObject names/tags used by the script.
  
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.UI;

public class AvatarMovement : MonoBehaviour
{
    CharacterController avatarCont;
    // float drop;
    float jump;
    bool allowJump;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        avatarCont = GetComponent<CharacterController>();
        jump = 0;
        /*drop = 0;*/ // fall
    }

    // Update is called once per frame
    void Update()
    {
        //if (!avatarCont.isGrounded)
        //    drop = -.05f;
        //} else
        //{
        //    drop = 0;
        //}

        //if (Keyboard.current.spaceKey.isPressed && avatarCont.isGrounded)
        //{
        //    jump = 0.3f;
        //}
        //if (!avatarCont.isGrounded)
        //{
        //    jump -= 0.01f;
        //}

        float movX = 0, movZ = 0;

        if (Keyboard.current.aKey.isPressed)
        {
            movX = -.05f;
        }
        if (Keyboard.current.dKey.isPressed)
        {
            movX = .05f;
        }
        if (Keyboard.current.sKey.isPressed)
        {
            movZ = -.05f;
        }
        if (Keyboard.current.wKey.isPressed)
        {
            movZ = .05f;
        }

        if (Keyboard.current.kKey.isPressed)//shrink
        {
            CharacterController avatarCont = GetComponent<CharacterController>();
            avatarCont.height *= 0.3f;
        }

        avatarCont.Move(transform.TransformDirection(new Vector3(movX, jump, movZ)));  // (movX, 0, movZ = kasi wala pang jump)
                                                                                       // avatar to local to global

        float rotY = Mouse.current.delta.ReadValue().x;
        transform.Rotate(0, rotY, 0);
        // avatarCont.stepOffset = 1;

        if (allowJump == true)
        {
            if (Keyboard.current.spaceKey.isPressed &&
            avatarCont.isGrounded)
            {
                jump = 0.3f;
            }
            if (!avatarCont.isGrounded)
            {
                jump -= 0.01f;

            }
        }
    }

    private void OnControllerColliderHit(ControllerColliderHit hit)
    {
        if (hit.collider.name == "LAST")
        {
            Destroy(hit.gameObject);
            allowJump = true;
        }
    }
}
