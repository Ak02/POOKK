using System;
using System.Collections.Generic;
using System.Text;

namespace POO_PFR_Part2
{
    class Administration
    {
        // champ
        private List<Attraction> attractions;
        private List<Personnel> toutLePersonnel;

        public Administration(List<Attraction> attractions, List<Personnel> toutLePersonnel)
        {
            this.attractions = attractions;
            this.toutLePersonnel = toutLePersonnel;
        }
    }
}
