using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class manager : MonoBehaviour
{
    public GameObject Cube;

    public GameObject Example;

    public Transform SpawnPoint;

    void Start()
    {

    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Inst();
        }
    }

    void Inst()
    {

        Instantiate(Example, SpawnPoint.position, SpawnPoint.rotation, transform);

    }

    void EnableDisable()
    {

        Cube.SetActive(!Cube.activeSelf);

    }

    void ObjAndComp()
    {

    }
}