namespace Assets.MoveElement1
{
    using UnityEngine;
    using System.Collections;

    public class Element1 : Movable
    {

        // Use this for initialization
        void Start()
        {

        }

        // Update is called once per frame
        void Update()
        {
            float speed = 0.11f;

            if (Input.GetKey(KeyCode.W))
            {
                MuveUp(speed);
            }

            if (Input.GetKey(KeyCode.S))
            {
                MuveDown(speed);
            }

            if (Input.GetKey(KeyCode.A))
            {
                MuveLeft(speed);
            }

            if (Input.GetKey(KeyCode.D))
            {
                MuveRight(speed);
            }
        }
    }
}