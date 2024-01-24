using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public enum MenuType
{
    HORIZONTAL,
    VERTICAL
}
public class MenuDefinition : MonoBehaviour
{
    public MenuType _menuType = MenuType.HORIZONTAL;
    public List<GameObject> _menuButtonObjects = new List<GameObject>();
    private List<ButtonDefinition> _menuButtonDefinitions = new List<ButtonDefinition>();
    private List<Button> _menuButtons = new List<Button>();
}
