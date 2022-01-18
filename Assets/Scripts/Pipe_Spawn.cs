using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pipe_Spawn : MonoBehaviour
{
   
    [SerializeField] private GameObject pipeObject;
    [SerializeField] private float spawnRate = 1f;
    [SerializeField] private float minHeight = -1f;
    [SerializeField] private float maxHeight = 1f;
    private void OnEnable() 
    {
        InvokeRepeating(nameof(Spawn),spawnRate,spawnRate);
    }
    private void OnDisable() 
    {
        CancelInvoke(nameof(Spawn));
    }
    private void Spawn()
    {
        var pipes = Instantiate(pipeObject,transform.position,Quaternion.identity);
        pipes.transform.position += Vector3.up * Random.Range(minHeight,maxHeight);
    }
}
