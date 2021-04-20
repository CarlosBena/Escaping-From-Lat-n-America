using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class camara : MonoBehaviour
{
    public GameObject john;

    void Update()
    {
        Vector3 position = transform.position;
        position.x = john.transform.position.x;
        transform.position = position;
    }
}
