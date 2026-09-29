What it does: Rotates the gun around the Y axis using horizontal mouse movement.
Study points:
Focus on the fields, Unity event methods, conditions, and the exact GameObject names/tags used by the script.
  
using UnityEngine;
using UnityEngine.InputSystem;

public class Gun_Script : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float rotY = Mouse.current.delta.ReadValue().x;
        transform.Rotate(0, rotY*.5f, 0);
    }
}v
