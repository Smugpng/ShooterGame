using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyTwoBehavior : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(new Vector3(1, -2, 0) * Time.deltaTime * 4);
        if (transform.position.y < -8f)
        {
            Destroy(this.gameObject);
        }
        if (transform.position.y < 0.48f)
        {
            transform. Translate(new Vector3(-2, 0, 0)* Time.deltaTime * 4);
        }
    }
}