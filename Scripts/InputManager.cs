using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InputManager : MonoBehaviour {

    [SerializeField]
    private Catapult catapult;


    [SerializeField]
    private RayBeam rayBeam;

    private GameController gController;

    // Use this for initialization
    void Start ()
    {
        gController = GameObject.Find("Main Camera").GetComponent<GameController>();
    }
	
	// Update is called once per frame
	void Update ()
    {
        if (Input.anyKeyDown)
        {
            //gController.AssignNextTurn();
        }

        elegirAccion();
	}

    public void elegirAccion()
    {
        if (Input.GetKeyDown(KeyCode.W))
        {
            catapult.Fire();
        }
        if (Input.GetKeyDown(KeyCode.Space))
        {
            rayBeam.Fire();
        }
    }
}
