using GameElements;
using UnityEngine;

namespace LessonGameSystem.Scripts
{
    public sealed class DynamicObjectLoader : MonoBehaviour, IGameReferenceElement
    {
        public IGameSystem GameSystem { private get; set; }

        [SerializeField]
        private DynamicObject prefab;

        private void Update()
        {
            if (Input.GetKey(KeyCode.L))
            {
                this.LoadObject();
            }
        }

        private void LoadObject()
        {
            var dynamicObject = Instantiate(this.prefab);
            this.GameSystem.AddElement(dynamicObject);
        }
    }
}