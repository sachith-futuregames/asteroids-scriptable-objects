
using UnityEngine;

namespace Asteroids
{
    [CreateAssetMenu(fileName = "Asteroid Config", menuName = "ScriptableObjects/AsteroidConfig", order = 0)]
    public class AsteroidConfig : ScriptableObject
    {
        [Range(0.2f, 1f)] public float Size;
        [Range(2f, 6f)] public float Force;
        [Range(0.1f, 0.5f)] public float Torque;

        public void SetData(ref Asteroid asteroid)
        {
            asteroid.Size = Size;
            asteroid.Force = Force;
            asteroid.Torque = Torque;
        }
    }
}