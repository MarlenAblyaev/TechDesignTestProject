using System;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using Assets.SimpleLocalization.Scripts;

namespace Assets.SimpleLocalization
{
	/// <summary>
	/// Asset usage example.
	/// </summary>
	public class Localization : MonoBehaviour
	{
		private List<string> _languages = new List<string>();
		private int _active_language;
		public void Awake ()
		{
			_languages.Add("German");
			_languages.Add("Russian");
			_languages.Add("English");

			LocalizationManager.Read();

			switch (Application.systemLanguage)
			{
				case SystemLanguage.German:
					LocalizationManager.Language = "German";
					_active_language = 0;
					break;
				case SystemLanguage.Russian:
					LocalizationManager.Language = "Russian";
					_active_language = 1;
					break;
				default:
					LocalizationManager.Language = "English";
					_active_language = 2;
					break;
			}
		}

		public void SetLocalization()
		{
			if (_active_language > 1)
				_active_language = 0;
			else
				_active_language++;

			LocalizationManager.Language = _languages[_active_language];
		}		
	}
}