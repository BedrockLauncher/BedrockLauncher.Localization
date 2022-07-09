using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BedrockLauncher.Localization.Language
{
    public static class AvaliableLanuages
    {
        public static List<string> GetAll()
        {
            return new List<string>()
            {
                "en-US",
                "es-ES",
                "fi-FI",
                "fr-FR",
                "ru-RU",
                "ms-MS",
                "pl-PL",
                "pt-PT",
                "pt-BR",
                "uk-UA",
                "zh-CH",
                "zh-TW"
            };
        }
    }
}
