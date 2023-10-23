using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;
using UnityEngine.SceneManagement;

public class FOVEnemy : MonoBehaviour
{
    public bool _playerInFOV;
    public static FOVEnemy Instance;
    void Start()
    {
        Instance = this;
        _playerInFOV = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (_playerInFOV)
        {
            this.GetComponent<NavMeshAgent>().SetDestination(GameObject.FindGameObjectWithTag("Player").transform.position);
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if (this.gameObject.name.Contains("FOVEnemy")){
            if (other.gameObject.CompareTag("Player"))
            {
                SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
            }
        }
    }
   
}
