using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace academia.DAO
{
    public class AulaDAO
    {

        #region Verificação

        public static bool verificarData(string data)
        {
            var regExp = new Regex(@"^\d{2}.\d{2}.\d{4}"); //@"^\d{3}.\d{3}.\d{3}-\d{2}"
            return regExp.IsMatch(data);
        }

        #endregion
    }
}
