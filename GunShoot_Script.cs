What it does: Starts with five rounds, fires a bullet prefab on a left-click press while ammunition remains,
and reloads to five rounds when R is pressed.
Study points:
Focus on the fields, Unity event methods, conditions, and the exact GameObject names/tags used by the script.
  
using UnityEngine;
using UnityEngine.InputSystem;

public class GunShoot_Script : MonoBehaviour
{
    [SerializeField] GameObject bulletPrefab;
    [SerializeField] Transform bulletLocation;
    int rounds;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        rounds = 5;
    }

    // Update is called once per frame
    void Update()
    {
        if (Mouse.current.leftButton.wasPressedThisFrame && rounds > 0)
        {
            rounds--;
            Debug.Log(rounds);
            Instantiate(bulletPrefab, bulletLocation.position, bulletLocation.rotation);
        }

        if (Keyboard.current.rKey.wasPressedThisFrame )
        {
            rounds = 5;
            Debug.Log("there are " + rounds + " bullets left ");
        }
    }
}



FROM NADINE:
What it does: This version fires a bullet prefab with the left mouse button while rounds remain and resets the round count to five when R is pressed.
Study points:
Focus on the fields, Unity event methods, conditions, and the exact GameObject names/tags used by the script.
  
using System.Threading;
using UnityEngine;
using UnityEngine.InputSystem;

public class GunShoot : MonoBehaviour
{
    [SerializeField] GameObject bulletPrefab;
    [SerializeField] Transform bulletLocation;
    int ctr;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        ctr = 0;
    }

    // Update is called once per frame
    void Update()
    {
        if (Mouse.current.leftButton.wasPressedThisFrame) //wasPressedThisFrame
        {
            if (ctr < 3)
            {
                Instantiate(bulletPrefab, bulletLocation.position, bulletLocation.rotation);
                ctr++;
            }
        }

        if (Keyboard.current.rKey.wasPressedThisFrame)
        {
            ctr = 0;
        }
        
    }
}
