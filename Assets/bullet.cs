using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bullet : MonoBehaviour
{
    public float speed = 0.1f;
    public score Score;
    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        this.transform.Translate(new Vector3(0,-speed,0));
    }
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Target")
        {
            Destroy(this.gameObject);
            Destroy(collision.gameObject);
            Score.SubScoreAndDisplay();
        }
        if (collision.gameObject.tag == "cube")
        {
            Destroy(this.gameObject);
            Destroy(collision.gameObject);
            Score.AddScoreAndDisplay();
        }
        if (collision.gameObject.tag == "Finish")
        {
            Destroy(this.gameObject);
            Destroy(collision.gameObject);
            Score.AddScoreAndDisplay();
            Score.AddScoreAndDisplay();
        }
    }

}
