using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week7GroupWork.Entities.Enums
{
    public class ApplicationPageEnumWrapper
    {
        ApplicationPageEnum pageEnum;

        public ApplicationPageEnumWrapper(ApplicationPageEnum pageEnum)
        {
            this.pageEnum = pageEnum;
        }

        public ApplicationPageEnum PageEnum { get => pageEnum; set => pageEnum = value; }

        public override string ToString()
        {
            DescriptionAttribute attribute = PageEnum.GetType()
            .GetField(PageEnum.ToString())
            .GetCustomAttributes(typeof(DescriptionAttribute), false)
            .SingleOrDefault() as DescriptionAttribute;

            return attribute.Description;
        }


    }
}
