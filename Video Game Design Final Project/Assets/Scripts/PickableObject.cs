using System.Collections;
using System.Collections.Generic;
using UnityEngine;


[RequireComponent(typeof(AudioSource))]
public class PickableObject : MonoBehaviour
{
    public AudioSource audio;

    // Use this for initialization
    void Start()
    {
        AudioSource audio = GetComponent<AudioSource>();
    }
    // Update is called once per frame
    void Update()
    {
        transform.localEulerAngles += new Vector3(0, 5.0f, 0);
    }


 /*  void OnTriggerEnter(Collider col)
    {
        Debug.Log("Enter Food!");
        if (col.gameObject.CompareTag("Player"))
        {
            Destroy(gameObject);
        }
    }
 */


    void OnTriggerEnter(Collider col)
    {
        if (col.gameObject.CompareTag("Player"))
        {
            StartCoroutine(PlayAndDestroy(audio.clip.length));
        }
    }
    private IEnumerator PlayAndDestroy(float waitTime)
    {
        audio.Play();
        yield return new WaitForSeconds(waitTime);
        Destroy(gameObject);
    }
}