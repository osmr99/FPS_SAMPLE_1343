using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ParticleActivator : MonoBehaviour
{
    [SerializeField] Gun theGun;
    [SerializeField] ParticleSystem ps;
    float fpsX;
    float fpsY;
    float fpsZ;
    [SerializeField] float xOffset;
    [SerializeField] float yOffset;
    [SerializeField] float zOffset;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        ps.transform.forward = theGun.transform.forward;
        ps.transform.rotation.Normalize();

        fpsX = theGun.transform.position.x + xOffset;
        fpsY = theGun.transform.position.y + yOffset;
        fpsZ = theGun.transform.position.z + zOffset;
        ps.transform.position = new Vector3(fpsX, fpsY, fpsZ);
    }

}
