using System.Collections.Generic;
using Orchard.Data.Conventions;

namespace Orchard.Core.Settings.Metadata.Records {
    public class ContentTypeDefinitionRecord  {
        public ContentTypeDefinitionRecord() {
            ContentTypePartDefinitionRecords = new List<ContentTypePartDefinitionRecord>();
        }

        public virtual int Id { get; set; }
        public virtual string Name { get; set; }
        public virtual bool Hidden { get; set; }
        public virtual string Settings { get; set; }

        [CascadeAllDeleteOrphan]
        public virtual IList<ContentTypePartDefinitionRecord> ContentTypePartDefinitionRecords { get; set; }
    }

}
