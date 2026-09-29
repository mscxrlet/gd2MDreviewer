What it does: Moves an object with WASD and changes its material to a random color when Space is pressed. 
  Several earlier transform and timer experiments remain comments.
Study points:
Focus on the fields, Unity event methods, conditions, and the exact GameObject names/tags used by the script.
  
using UnityEngine;
using UnityEngine.InputSystem;

public class NewMonoBehaviourScript : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    Transform sTrans;
    MeshRenderer sRenderer;
    float gTime;
    void Start()
    {
        sTrans = GetComponent<Transform>();
        //sTrans.position = new Vector3(10, 5, -7);
        //sTrans.eulerAngles = new Vector3(90, 70, 270);
        //sTrans.localScale = new Vector3(2, 3, 4);
        sRenderer = GetComponent<MeshRenderer>();
        //sRenderer.material.color = new Color(Random.Range(0f, 1f), Random.Range(0f, 1f), Random.Range(0f, 1f));
        gTime = 0;
    }

    // Update is called once per frame
    void Update()
    {
        //Debug.Log(Time.deltaTime);
        //sTrans.Translate(-0.01f,0,0);
        //sTrans.Rotate(5, 2, 3);
        //gTime += Time.deltaTime;
        //////if (gTime >=1)
        //////{
        //////    sRenderer.material.color = new Color(Random.Range(0f, 1f), Random.Range(0f, 1f), Random.Range(0f, 1f));
        //////    gTime = 0;
        //////}
        if (Keyboard.current.aKey.isPressed)
        {
            sTrans.Translate(-.05f, 0, 0);
        }
        if(Keyboard.current.dKey.isPressed)
        {
            sTrans.Translate(.05f, 0, 0);
        }
        if (Keyboard.current.wKey.isPressed)
        {
            sTrans.Translate(0, 0, .05f);
        }
        if (Keyboard.current.sKey.isPressed)
        {
            sTrans.Translate(0, 0, -.05f);
        }
        if (Keyboard.current.spaceKey.wasPressedThisFrame)
        {
            sRenderer.material.color = new Color(Random.Range(0f, 1f), Random.Range(0f, 1f), Random.Range(0f, 1f));
        }    

    }
}
