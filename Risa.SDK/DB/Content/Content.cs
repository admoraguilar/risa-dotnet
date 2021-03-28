using System.Collections.Generic;

namespace Risa.SDK
{
	public class Content
	{
		public string Value { get; set; } = "How are you?";
		public string Pronunciation { get; set; } = "Hau ar u?";

		public List<string> LanguageCode { get; set; } = new List<string> {
			"en-US"
		};

		public List<string> Type { get; set; } = new List<string> {
			ContentTypes.Greeting
		};

		public string Romanized { get; set; } = string.Empty;

		public List<string> CommonUseCases { get; set; } = new List<string>() {
			"When meeting someone again after a long time.",
			"When asking if someone is alright."
		};

		public List<string> Formalities { get; set; } = new List<string>() {
			"Strangers",
			"Friends",
			"Business"
		};

		public List<string> Synonyms { get; set; } = new List<string>();

		public List<string> OtherLanguagesTranslation { get; set; } = new List<string>() {
			"Kamusta ka? (fil-PH)"
		};
	}
}
