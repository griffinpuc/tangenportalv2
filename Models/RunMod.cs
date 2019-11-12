namespace tangenportalv2
{
    public class RunMod
    {
        public int Id { get; set; }
        public string SampleId { get; set; }
        public string UniqueId { get; set; }
        public string DownloadDateTime { get; set; }
        public string AssayId { get; set; }
        public string KitLotId { get; set; }
        public string InstrumentUuid { get; set; }
        public string InstrumentName { get; set; }

        //[JsonIgnore]
        public string DirPointer { get; set; }

        //[JsonIgnore]
        //public ICollection<modelTag> tags { get; set; }
        //public ICollection<modelTarget> targets { get; set; }
        //public ICollection<modelWell> wells { get; set; }
    }
}