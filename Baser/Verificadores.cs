using System;

namespace Baser
{
    class Verificadores
    {
        #region Verificar strings
        public static bool VerificarStrings(string valor1) => String.IsNullOrEmpty(valor1);
        public static bool VerificarStrings(string valor1, string valor2) => String.IsNullOrEmpty(valor1) || String.IsNullOrEmpty(valor2);
        public static bool VerificarStrings(string valor1, string valor2, string valor3) => String.IsNullOrEmpty(valor1) || String.IsNullOrEmpty(valor2) || String.IsNullOrEmpty(valor3);
        #endregion
    }
}
