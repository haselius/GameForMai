using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FallDown : MonoBehaviour
{

    void Update()
    {
        if (transform.position.y < -3f)
        {
            Destroy(gameObject);
        }
        transform.position -= new Vector3(0, Characteristics.fallSpeed * Time.deltaTime, 0);
    }
}
