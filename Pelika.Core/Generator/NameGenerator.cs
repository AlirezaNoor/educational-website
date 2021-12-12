using System;
using System.Collections.Generic;
using System.Text;

namespace Pelika.Core.Generator
{
    public class NameGenerator
    {
        public static string GeneratorUniqCode()
        {
            return Guid.NewGuid().ToString().Replace("-", "");
        }
    }
}
