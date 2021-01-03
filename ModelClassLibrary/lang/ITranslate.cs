using ModelClassLibrary.lang.impl;
using System;
using System.Collections.Generic;
using System.Text;

namespace ModelClassLibrary.lang
{
    public interface ITranslate
    {
        Item LoadJson(string lang);
        ItemLogin loadJsonLogin(string lang);
    }
}
