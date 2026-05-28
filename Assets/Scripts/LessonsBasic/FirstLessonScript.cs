using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace LessonsBasic
{   ///


    public class FirstLessonScript : MonoBehaviour
    {
        private float ondalikSayi = 0.25f;
        [SerializeField] private Vector3 ucFloat = new Vector3(1, 2, 3);

        public float floatProperty { get; set; } // kendimiz yonetiriz geti ya da seti private olarak ayirabiliriz,,,,, 

        // Start is called before the first frame update
        void Start()
        {
            ondalikSayi = 10000;
            floatProperty = 100000f;
        }

        // Update is called once per frame
        void Update()
        {

        }
    }
}
