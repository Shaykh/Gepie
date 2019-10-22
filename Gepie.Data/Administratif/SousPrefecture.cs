using System;
using System.Collections.Generic;

namespace Gepie.Data
{
    public class SousPrefecture : Localite
    {
        public int SousPrefectureID { get; set; }
        public virtual ICollection<Village> Villages { get; set; }
        
        public SousPrefecture()
        {
            this.Villages = new HashSet<Village>();
        }
    }
}