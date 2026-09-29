What it does: Changes the color of an object tagged Radius to a randomly selected red, green, or blue result. If the two assigned renderers match, it reduces the avatar radius.
Study points:
Focus on the fields, Unity event methods, conditions, and the exact GameObject names/tags used by the script.
  
using System.Security.Cryptography;
using UnityEngine;

public class RadiusScript : MonoBehaviour
{
    [SerializeField] MeshRenderer s1, s2;
    bool checkCollide;


    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        //s1 = GetComponent<MeshRenderer>();
        //s2 = GetComponent<MeshRenderer>();
        checkCollide = false;
    }

    private void OnControllerColliderHit(ControllerColliderHit hit)
    {
        if (hit.collider.tag == "Radius")
        {
            hit.collider.GetComponent<MeshRenderer>().material.color =
                Random.Range(0, 20) % 3 == 0 ? Color.red : Random.Range(0, 20) % 3 == 0 ? Color.green : Color.blue;
            checkCollide = true;
        }

        if (checkCollide)
        {
            if (s1.material.color == s2.material.color)
            {
                CharacterController avatarCont = GetComponent<CharacterController>();
                avatarCont.radius = .1f;
            }
        }
    }
}
