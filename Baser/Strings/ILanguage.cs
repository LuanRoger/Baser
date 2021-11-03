﻿using Baser.Enum;
using GlobalStrings;

namespace Baser.Strings
{
    public interface ILanguage
    {
        LanguageInfo<LanguageCode, string, string> language { get; }

        void InitLanguage();
    }
}