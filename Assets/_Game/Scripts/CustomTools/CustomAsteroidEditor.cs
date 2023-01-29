using UnityEngine;
using UnityEditor;
using UnityEngine.UIElements;
using UnityEditor.UIElements;

namespace Asteroids
{
    [CustomPropertyDrawer(typeof(Asteroid))]
    public class CustomAsteroidEditor : PropertyDrawer
    {
        public override VisualElement CreatePropertyGUI(SerializedProperty property)
        {
            return new PropertyField(property);
        }
    }
}

