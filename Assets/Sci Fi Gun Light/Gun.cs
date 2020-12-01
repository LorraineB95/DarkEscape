using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Gun : MonoBehaviour
{
    private RaycastHit hit;
    private Ray ray;

    public GameObject impactEffect;

    void Update()
    {
        ray = Camera.main.ViewportPointToRay(new Vector3(.5f, .5f, 0));
        if(Input.GetMouseButtonDown(0))
        {
            if (Physics.Raycast(ray, out hit, Mathf.Infinity))
            {
                GameObject impactEffectGO = Instantiate(impactEffect, hit.point, Quaternion.identity) as GameObject;
                Destroy(impactEffectGO, 5);

            }
        }
    }
}
