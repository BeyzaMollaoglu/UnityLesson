using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Lessons
{
    [CreateAssetMenu(menuName = "Lessons/Lesson1/Rotate Settings")]
    public class RotateSettings : ScriptableObject
    {
        [SerializeField] private float _speed = 1;
        public float Speed { get { return _speed; } }    //once private yapip sonra property ayari yapilabilir burada private objeyi private iken public floata get ile ekledik
    }
}