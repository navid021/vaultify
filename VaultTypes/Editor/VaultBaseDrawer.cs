using UnityEngine;
using UnityEditor;

using Vaultify.VaultTypes;

namespace Vaultify.VaultTypes.Editor
{
    [CustomPropertyDrawer(typeof(VaultBase), true)]
    public class VaultBaseDrawer : PropertyDrawer
    {
        // Draw the property inside the given rect
        public override void OnGUI(Rect position, SerializedProperty property, GUIContent label)
        {
            // Using BeginProperty / EndProperty on the parent property means that
            // prefab override logic works on the entire property.
            EditorGUI.BeginProperty(position, label, property);

            // Draw label
            position = EditorGUI.PrefixLabel(position, GUIUtility.GetControlID(FocusType.Passive), label);

            EditorGUI.PropertyField(position, property.FindPropertyRelative("_value"), GUIContent.none);

            EditorGUI.EndProperty();
        }
    }
}
