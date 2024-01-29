
using UnityEngine;

public class PlanetRotation : MonoBehaviour
{   

    public GameObject planet;
    // Start is called before the first frame update
    // Update is called once per frame
    void Update()
    {
        transform.RotateAround(planet.transform.position, Vector3.up, 10 * Time.deltaTime);
    }
}
