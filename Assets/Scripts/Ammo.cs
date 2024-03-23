using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.Events;
using static UnityEngine.ProBuilder.AutoUnwrapSettings;

public class Ammo : MonoBehaviour
{
    [SerializeField] FPSController fpsController;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }


    private void OnTriggerEnter(Collider other)
    {
        if (other.TryGetComponent(out FPSController controller))
            other.GetComponent<FPSController>().interaction += refillAmmo;
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.TryGetComponent(out FPSController controller))
            other.GetComponent<FPSController>().interaction -= refillAmmo;
    }

    void refillAmmo()
    {
        fpsController.IncreaseAmmo(10);
    }
}
