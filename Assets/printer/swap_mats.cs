using UnityEngine;
using System.Collections;

public class swap_mats : MonoBehaviour
{
    // Blends between two materials
    public Material material1;
    public Material material2;
    public float duration = 2.0F;
    public float delay = 21;
    public Renderer rend;

    void Start()
    {
        // At start, use the first material
        rend = GetComponent<Renderer>();
        rend.material = material1;
    }

    void Update()
    {
        // Ping-pong between the materials over the duration
        //float lerp = Mathf.PingPong(Time.time, duration) / duration;
        //rend.material.Lerp(material1, material2, lerp);
        StartCoroutine(TimeDelay());
    }

    IEnumerator TimeDelay()
    {
        yield return new WaitForSeconds(delay);
        //float lerp = Mathf.PingPong(Time.time, duration) / duration;
        //rend.material.Lerp(material1, material2, lerp);
        rend.material = material2;
    }
}