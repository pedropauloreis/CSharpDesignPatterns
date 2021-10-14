using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03_Builder.Components
{
    class Airbag
    {
        private AirbagQualityType airbagQuality;
        public Airbag(AirbagQualityType airbagQuality)
        {
            this.airbagQuality = airbagQuality;
        }

        public AirbagQualityType AirbagQualityType
        {
            get => this.airbagQuality;
            set => this.airbagQuality = value;

        }
    }
}
