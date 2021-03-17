using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class background : MonoBehaviour
{
    public GameObject target;

    // Update is called once per frame
    void Update()
    {
        this.transform.position = target.transform.position;
    }
}
