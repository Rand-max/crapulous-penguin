using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AppleController : MonoBehaviour
{
    public ParticleSystem pb;
    public bool alive;
    // Start is called before the first frame update
    void Start()
    {
        alive = true;
    }

    // Update is called once per frame
    void Update()
    {
        if (!alive)
        {
            Instantiate(pb, this.gameObject.transform.position, Quaternion.identity);
            Destroy(this.gameObject);
        }
    }
    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag=="penguin")
        {
            alive = false;
        }
    }
}
