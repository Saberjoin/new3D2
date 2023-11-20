using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class shootcontrol : MonoBehaviour
{
    float time = 0f;
    public GameObject BulletPrefab;
    public float destroyTime = 3f;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        time += Time.deltaTime;
        // Access or manipulate the GameObject or its components here
        if (Input.GetKeyUp(KeyCode.Space))
        {
            if (time > 0.5f)
            {
                GameObject bullet = Instantiate(BulletPrefab, transform.position, transform.rotation);
                time = 0;
                Destroy(bullet, 3f);
            }
        }
    }
}
