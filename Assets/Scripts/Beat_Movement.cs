using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Beat_Size : MonoBehaviour
{
    public float beatTempo;
    public float timetest;
    public float startTime;

    public bool canBePressed;


    // Start is called before the first frame update
    void Start()
    {
        gameObject.GetComponent<Renderer>().enabled = false;
        beatTempo = beatTempo / 60f;
        timetest = 0;
    }

    // Update is called once per frame
    void Update()
    {
        timetest += Time.deltaTime;

        if (timetest >= startTime)
        {
            gameObject.GetComponent<Renderer>().enabled = true;

            if (timetest <= 1.75f * beatTempo + startTime) transform.localScale -= new Vector3(beatTempo * Time.deltaTime, beatTempo * Time.deltaTime, 0f);
        }

        if (Input.GetMouseButtonDown(0) && canBePressed)
        {
            gameObject.SetActive(false);
        }

    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "Activator")
            canBePressed = true;
    }

    private void OnTriggerExit2D(Collider2D other)
    {
        if (other.tag == "Activator")
            canBePressed = false;
    }
}
