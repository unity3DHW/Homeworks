namespace Assets
{
    using UnityEngine;
    using System.Collections;

    public abstract class Movable : MonoBehaviour
    {
        public Vector3 MuveUp(float speed)
        {
            Vector3 position = this.transform.position;
            position.z += speed;
            return this.transform.position = position;
        }

        public Vector3 MuveDown(float speed)
        {
            Vector3 position = this.transform.position;
            position.z -= speed;
            return this.transform.position = position;
        }

        public Vector3 MuveLeft(float speed)
        {
            Vector3 position = this.transform.position;
            position.x -= speed;
            return this.transform.position = position;
        }

        public Vector3 MuveRight(float speed)
        {
            Vector3 position = this.transform.position;
            position.x += speed;
            return this.transform.position = position;
        }
    }
}
