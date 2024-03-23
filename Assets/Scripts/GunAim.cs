using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GunAim : MonoBehaviour
{
    [SerializeField] FPSController controller;
    [SerializeField] LayerMask shootableLayers;
    [SerializeField] Transform gun;
    [SerializeField] Image crosshair;
    [SerializeField] Transform barrelEnd;

    [SerializeField] Color colorValidTarget;
    [SerializeField] Color colorNoValidTarget;

    bool isAlive = true;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Aim();
        if(isAlive == false)
        {
            gameObject.SetActive(false);
            GameObject.Destroy(crosshair);
        }
    }

    void Aim()
    {
        RaycastHit hit;
        Vector3 start = controller.Cam.transform.position;
        Vector3 forward = controller.Cam.transform.forward;

        if (Physics.Raycast(start, forward, out hit, 1000.0f, shootableLayers))
        {
            barrelEnd.LookAt(hit.point);
            crosshair.color = colorValidTarget;
            return;
        }

        crosshair.color = colorNoValidTarget;
        //gun.forward = forward;
        barrelEnd.forward = forward;
    }

    public void isNotAlive()
    {
        isAlive = false;
    }
}
