using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using UnityEngine.Events;

public class PlayerHUD : MonoBehaviour
{
    [SerializeField] Image healthBar;
    [SerializeField] TMP_Text currentAmmoText;
    [SerializeField] TMP_Text maxAmmoText;

    FPSController player;

    int ammo = 10;
    int maxAmmo = 10;

    // Start is called before the first frame update
    void Start()
    {
        player = FindObjectOfType<FPSController>();
        currentAmmoText.text = ammo.ToString();
        maxAmmoText.text = maxAmmo.ToString();
    }

    public void updateAmmo(int bullets)
    {
        currentAmmoText.text = bullets.ToString();
    }
}
