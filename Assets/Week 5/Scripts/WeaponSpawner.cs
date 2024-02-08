using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WeaponSpawner : MonoBehaviour
{
    public GameObject arrowPrefab;
    public Transform Spawn;

    public void ShootArrow()
    {
        Instantiate(arrowPrefab, Spawn.position, Spawn.rotation);
    }

}
