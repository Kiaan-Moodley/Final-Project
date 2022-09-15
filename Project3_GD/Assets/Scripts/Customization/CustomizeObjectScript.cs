using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CustomizeObjectScript : MonoBehaviour
{
    public List<Customization> customizations;
    int _currentCustomizationIndex;

    public Customization CurrentCustomization { get; private set; }

    private void Awake()
    {
        foreach (var customization in customizations)
        {
            customization.UpdateRenderers();
        }
    }

    void Update()
    {
        SelectCustomization();

        if (Input.GetKeyDown(KeyCode.C))
        {
            CurrentCustomization.NextMaterial();
        }
    }

    void SelectCustomization()
    {
        if(Input.GetKeyDown(KeyCode.C))
        {
            _currentCustomizationIndex++;
        }
        if (Input.GetKeyDown(KeyCode.V))
        {
            _currentCustomizationIndex--;
        }
        if (_currentCustomizationIndex < 0)
        {
            _currentCustomizationIndex = customizations.Count -1;
        }
        if (_currentCustomizationIndex >= customizations.Count)
        {
            _currentCustomizationIndex = 0;
        }
        CurrentCustomization = customizations[_currentCustomizationIndex];
    }

    [System.Serializable]
    public class Customization
    {
        public List<Renderer> renderers;
        public List<Material> materials;
        int _materialIndex;

        public void NextMaterial()
        {
            _materialIndex++;
            if (_materialIndex >= materials.Count)
                _materialIndex = 0;

            UpdateRenderers();
        }

        public void UpdateRenderers()
        {
            foreach (var renderer in renderers)
                if (renderer)
                    renderer.material = materials[_materialIndex];
        }
    }
}
