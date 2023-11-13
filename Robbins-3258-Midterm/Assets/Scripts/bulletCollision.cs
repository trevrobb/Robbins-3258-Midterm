using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bulletCollision : MonoBehaviour
{
    [SerializeField] AudioSource[] audioSources;
    void Start()
    {
        StartCoroutine(Despawn());
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Enemy"))
        {
            StopCoroutine(Despawn());
            Destroy(gameObject);
            ParticleSystem ps = GameObject.Find("BloodPS").GetComponent<ParticleSystem>();
            ps.transform.position = other.transform.position;
            ps.Play();
            int RandomAudionumber = Random.Range(0, 5);
            AudioSource a = Instantiate(audioSources[RandomAudionumber], other.transform.position, Quaternion.identity);
            StartCoroutine(DespawnAudio(a));
            Destroy(other.gameObject);
        }
    }

    IEnumerator Despawn()
    {
        yield return new WaitForSeconds(3f);
        Destroy(gameObject);
    }

    IEnumerator DespawnAudio(AudioSource audio)
    {
        yield return new WaitForSeconds(2f);
        Destroy(audio);
    }
}
