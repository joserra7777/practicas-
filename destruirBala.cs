using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class destruirBala : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        //Destroy(this.gameObject,2f);
    }

    private void OnBecameInvisible()
    {
        Destroy(this.gameObject);
    }
}
