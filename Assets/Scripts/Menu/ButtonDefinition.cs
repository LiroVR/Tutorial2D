using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

[RequireComponent(typeof(Button))]
public class ButtonDefinition : MonoBehaviour
{
    public Color _unselectedTint = Color.grey;
    public Color _selectedTint = Color.white;
    public bool _selected = false;
    private Button _button;
    private Image _image;
    public AudioClip _swapToSFX;
    public AudioClip _confirmSFX;
    public float _confirmTime;
    private bool _disableControls = false;
    // Start is called before the first frame update
    void Start()
    {
        _button = GetComponent<Button>();
        _image = GetComponent<Image>();
        if(_selected)
        {
            _image.color = _selectedTint;
        }
        else
        {
            _image.color = _unselectedTint;
        }
    }

    public void SwappedTo()
    {
        _selected = true;
        if(_swapToSFX != null)
        {
            AudioSource.PlayClipAtPoint(_swapToSFX, Vector3.zero);
        }
        _image.color = _selectedTint;
    }

    public void SwappedOff()
    {
        _selected = false;
        _image.color = _unselectedTint;
    }
    public IEnumerator ClickButton()
    {
        if (!_disableControls)
        {
            _disableControls = true;
            if(_confirmSFX != null)
            {
                AudioSource.PlayClipAtPoint(_confirmSFX, Vector3.zero);
            }
            yield return new WaitForSeconds(_confirmTime);
            _button.onClick.Invoke();
            _disableControls = false;
        }
    }

    public bool GetDisableControls()
    {
        return _disableControls;
    }
}
