What it does: Gets the bullet Rigidbody, applies a relative forward force at startup, and destroys the bullet on collision.
Study points:
Focus on the fields, Unity event methods, conditions, and the exact GameObject names/tags used by the script.
  
using UnityEngine;

public class BulletForce : MonoBehaviour
{
    Rigidbody bulletRigid;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        bulletRigid = GetComponent<Rigidbody>();
        //bulletRigid.AddForce(Vector3.forward*2000);
        bulletRigid.AddRelativeForce(Vector3.forward * 2000);
        bulletRigid.AddRelativeTorque(Vector3.forward * 2000);
        Destroy(bulletRigid, 3);//after 3s, bullet gets destroyed
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnCollisionEnter(Collision collision)
    {
        //if (collision.collider.name != "Stage")
        //{
        //    GameObject obs = collision.collider.gameObject;
        //    Destroy(obs);
        //}
        Destroy(gameObject);
    }
}



FROM NADINE:
What it does: Gets the bullet Rigidbody, applies a relative forward force at startup, and destroys the bullet on collision.
Study points:
Focus on the fields, Unity event methods, conditions, and the exact GameObject names/tags used by the script.
using UnityEngine;

public class BulletForce : MonoBehaviour
{
    Rigidbody bulletRigid;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        bulletRigid = GetComponent<Rigidbody>();
        // bulletRigid.AddForce(Vector3.forward * 2000);
        bulletRigid.AddRelativeForce(Vector3.forward * 2000);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnCollisionEnter(Collision collision)
    {
        //if(collision.collider.name != "Stage")
        //{
        //    GameObject obs = collision.collider.gameObject;
        //    Destroy(obs);
        //}
        Destroy(gameObject);
    }
}What it does: Gets the bullet Rigidbody, applies a relative forward force at startup, and destroys the bullet on collision.
Study points:
Focus on the fields, Unity event methods, conditions, and the exact GameObject names/tags used by the script.
  
using UnityEngine;

public class BulletForce : MonoBehaviour
{
    Rigidbody bulletRigid;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        bulletRigid = GetComponent<Rigidbody>();
        // bulletRigid.AddForce(Vector3.forward * 2000);
        bulletRigid.AddRelativeForce(Vector3.forward * 2000);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnCollisionEnter(Collision collision)
    {
        //if(collision.collider.name != "Stage")
        //{
        //    GameObject obs = collision.collider.gameObject;
        //    Destroy(obs);
        //}
        Destroy(gameObject);
    }
}
