using System;
using DefaultNamespace;
using UnityEngine;
using UnityEngine.SceneManagement;


public class PistolControl : MonoBehaviour
{
    [SerializeField] private ParticleSystem _shotParticleSystem;
    [SerializeField] private AudioSource _shotAudioSource;
    [SerializeField] private AudioSource _musicAudioSource;
    [SerializeField] private Animator _animator;
    [SerializeField] private BulletView _bulletPrefab;
    [SerializeField] private Transform _barrelTransform;
    [SerializeField] private float _pistolRotation = 15.0f;
    
    private static readonly int _shotAnimatorTrigger = Animator.StringToHash("Shot");

    private void Start()
    {
        _musicAudioSource.volume = PlayerPrefs.GetFloat(SettingsParameterNames.VOLUME);
        _shotAudioSource.volume = PlayerPrefs.GetFloat(SettingsParameterNames.VOLUME);
    }

    private void Update ()
    {
        if (Input.GetKey(KeyCode.A))
        {
            transform.Rotate(Vector3.up, -_pistolRotation * Time.deltaTime);
        }
        else if (Input.GetKey(KeyCode.D))
        { 
            transform.Rotate(Vector3.up, _pistolRotation * Time.deltaTime);
        }
        
        if (Input.GetKeyDown(KeyCode.Space))
        {
            var bullet = Instantiate(_bulletPrefab, _barrelTransform.position,
                _barrelTransform.rotation);
            bullet.Shoot(_barrelTransform.forward);
            _animator.SetTrigger(_shotAnimatorTrigger);
            _shotAudioSource.Play();
            _shotParticleSystem.Play();
        }

        if (Input.GetKeyDown(KeyCode.Escape))
        {
            SceneManager.LoadScene(0);
        }
	}
}
