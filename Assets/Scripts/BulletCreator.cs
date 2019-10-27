using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletCreator : MonoBehaviour
{

    //A reference to the projectile prefab we want to instantiate
    //Must be public for it to appear in Inspector and be able to do the binding from Unity
    public GameObject projectilePrefabReference;

    public float thrust = 1.0f;    

    // Update is called once per frame
    void Update()
    {
        //if (Input.GetKeyDown(KeyCode.F))
        if( Input.GetMouseButtonDown(0) )
        {
            GameObject projectile = Instantiate( projectilePrefabReference , this.transform.position, Quaternion.identity );
            projectile.GetComponent<Rigidbody>().AddForce( transform.forward * thrust, ForceMode.Impulse );
            Destroy(projectile, 5.0f);
        }
    }
}
