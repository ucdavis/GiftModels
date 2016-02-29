using System;

namespace GiftModels
{
    /// <summary>
    /// Records a rejection along with the person who rejected this gift
    /// </summary>
    public class Rejection
    {
        public string Code { get; set; }
        public string Description { get; set; }
        public string Actor { get; set; }
        public string ActorName { get; set; }
        public DateTime CreatedDate { get; set; }
        public string ResolutionComment { get; set; }
    }
}