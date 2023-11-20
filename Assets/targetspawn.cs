using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class targetspawn : MonoBehaviour
{
    float time = 0f;
    int type = 0;
    public GameObject targetprefab;
    public GameObject cubeprefab;
    public GameObject cylinderfab;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        time += Time.deltaTime;
        if (time > 3f)
        {
            time = 0f;
            spawntarget();
        }
    }
    private void spawntarget()
    {
        float sz = Random.Range(-10.5f, -20.5f);
        float sx = Random.Range(-6.5f, 6.5f);
        float sy = Random.Range(0f, 4.5f);
        transform.position = new Vector3(sx, sy, sz);
        if (type == 0)
        {
            GameObject target = Instantiate(targetprefab, transform.position, transform.rotation);
            Destroy(target, 6f);
        }
        if(type==1) {
            GameObject target = Instantiate(cubeprefab, transform.position, transform.rotation);
            Destroy(target, 6f);
        }
        if (type == 2)
        {
            GameObject target = Instantiate(cylinderfab, transform.position, transform.rotation);
            Destroy(target, 6f);
            type = -1;
        }
        type++;
    }
}
