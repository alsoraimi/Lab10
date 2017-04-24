using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab10
{
    class Movies
    {
        private string Title;
        private string Category;

        public string GTitle
        {
            set
            {
                Title = value;
            }
            get
            {
                return Title;
            }

        }

        public string GCategory
        {
            set
            {
                Category = value;
            }
            get
            {
                return Category;
            }
        }

    }
}
