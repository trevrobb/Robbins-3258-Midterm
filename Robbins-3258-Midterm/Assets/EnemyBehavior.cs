using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;
using UnityEngine.SceneManagement;

public class EnemyBehavior : MonoBehaviour
{
    GameObject _Player;
    NavMeshAgent _thisEnemy;
    void Start()
    {
        _Player = GameObject.FindGameObjectWithTag("Player");
        _thisEnemy = GetComponent<NavMeshAgent>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Vector3.Distance(this.transform.position, _Player.transform.position)< 100f)
        {
            _thisEnemy.SetDestination(_Player.transform.position);
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        }
    }
}
