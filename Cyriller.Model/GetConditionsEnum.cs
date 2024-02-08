using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cyriller.Model
{
    public enum GetConditionsEnum
    {
        /// <summary>
        /// Полное совпадение
        /// </summary>
        Strict, 

        /// <summary>
        /// Полное или частичное совпадение
        /// </summary>
        Similar
    }
}
