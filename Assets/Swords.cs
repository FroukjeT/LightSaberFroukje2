
using UnityEngine;

public class Swords : MonoBehaviour
{
    private Vector3 lastpos;
    private Vector3 velocity;

    public string swordColorTag = "Red";

    //here we measure the velocity every frame 
    void Update()
    {
        velocity = (transform.position - lastpos) / Time.deltaTime;
        lastpos = transform.position;
        
    }

    private void OnTriggerEnter(Collider other)
    {
        MovingCube cube = other.GetComponent<MovingCube>(); //so this gets the reference to the movingCube script, if it doesnt exist it exits
        if (cube == null) return;

        //check color tag
        if(other.tag != swordColorTag) return; //if the tag of the collided object is not the same as the sword, exit (do nothing

        Vector3 swingDir = velocity.normalized; //normalize it

        // Compare with required direction
        float dot = Vector3.Dot(swingDir, cube.requiredDirection); //so you compare its sword (SwingDir) with the cube (req direct)

        if (dot > 0.6f) // 1 = perfect alignment, 0 = perpendicular
        {
            Debug.Log("Correct slice!");
            Destroy(cube.gameObject);
        }
        else
        {
            Debug.Log("Wrong direction!");
            // maybe give feedback, but don't destroy
        }
    }



}
