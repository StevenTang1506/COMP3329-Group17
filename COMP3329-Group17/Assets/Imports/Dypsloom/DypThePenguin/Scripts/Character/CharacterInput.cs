using UnityEngine;

namespace Dypsloom.DypThePenguin.Scripts.Character
{
    using Dypsloom.DypThePenguin.Scripts.Items;

    public class CharacterInput : ICharacterInput
    {
        protected Character m_Character;

        public CharacterInput(Character character)
        {
            m_Character = character;
        }

        // Modify the Horizontal input to only respond to left and right movements
        public float Horizontal => Input.GetAxisRaw("Horizontal");

        // Completely ignore the Vertical input which controls forward and backward movements
        public float Vertical => 0;

        public bool Jump => Input.GetButtonDown("Jump");
        public bool Interact => Input.GetKeyDown(KeyCode.E) || Input.GetButtonDown("Fire2");

        public bool UseEquippedItemInput(IUsableItem usableItemObject, int actionIndex)
        {
            if (usableItemObject == null || usableItemObject.Item == null) { return false; }

            if (actionIndex == 0)
            {
                return Input.GetButtonDown("Fire1");
            }

            return true;
        }

        public bool UseItemHotbarInput(int slotIndex)
        {
            return !Input.GetKey(KeyCode.LeftShift) && Input.GetKeyDown(KeyCode.Alpha1 + slotIndex);
        }

        public bool DropItemHotbarInput(int slotIndex)
        {
            return Input.GetKey(KeyCode.LeftShift) && Input.GetKeyDown(KeyCode.Alpha1 + slotIndex);
        }
    }
}