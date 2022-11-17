using UnityEngine;
using System.Collections;

public class PickupObject : MonoBehaviour 
{
    public float degreesPerSecond = 45f;
    public float amplitude = 1f;
    public float frequency = 1f;
 
    // Position variables
    Vector3 positionOffset = new Vector3();
    Vector3 tempPosition = new Vector3();
 
    // Start is called before the first frame update
    void Start() 
    {
        // Store the starting position & rotation of the object
        positionOffset = transform.position;
    }
     
    // Update is called once per frame
    void Update() 
    {
        // Spin object around Y-Axis of the world, as opposed to the object's own Y-Axis
        transform.Rotate(new Vector3(0f, Time.deltaTime * degreesPerSecond, 0f), Space.World);
 
        // Float up and down using sin function
        tempPosition = positionOffset;
        tempPosition.y += 1 + (Mathf.Sin(Time.fixedTime * Mathf.PI * frequency) * amplitude);
 
        transform.position = tempPosition;
    }
}