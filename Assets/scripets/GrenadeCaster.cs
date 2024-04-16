using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GrenadeCaster : MonoBehaviour
{
    public float damage = 50;

    public Rigidbody grenadePrefab;
    public Transform grenageSourceTransform;

    public float force = 10;

    private void Update()
    {
        if (Input.GetMouseButtonDown(1))
        {
            var grenade = Instantiate(grenadePrefab);
            grenade.transform.position = grenageSourceTransform.position;
            grenade.GetComponent<Rigidbody>().AddForce(grenageSourceTransform.forward * force);
            grenade.GetComponent<Grenade>().damage = damage;
        }
    }
}
