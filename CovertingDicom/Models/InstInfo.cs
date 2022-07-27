using System;
using System.Collections.Generic;

namespace CovertingDicom.Models
{
    public partial class InstInfo
    {
        public int InstIncId { get; set; }
        public int? SeriesIncIdDet { get; set; }
        public int? InstStudyIncIdDet { get; set; }
        public string? InstPatId { get; set; }
        public string? InstStudyUid { get; set; }
        public string? InstSeriesUid { get; set; }
        public string? InstUid { get; set; }
        public float? SliceThick { get; set; }
        public int? InstNumber { get; set; }
        public string? ImagePos { get; set; }
        public string? PixelAspectRatio { get; set; }
        public byte? BitsAllocated { get; set; }
        public string? TransSyntax { get; set; }
        public float? SliceLoc { get; set; }
        public DateTime? AcquisTime { get; set; }
        public DateTime? ImageDate { get; set; }
        public int? NoFrames { get; set; }
        public int? NoRows { get; set; }
        public int? NoCloumns { get; set; }
        public string? PixelSpace { get; set; }
        public byte? LossyComp { get; set; }
        public byte? BitsStored { get; set; }
        public byte? HighBit { get; set; }
        public int? PixelRepresent { get; set; }
        public string? ImageOrient { get; set; }
        public string? SopclassUid { get; set; }
        public string? Manufacturer { get; set; }
        public string? ViewPosition { get; set; }
        public string? ModalityName { get; set; }
        public string? ManufacturersModelName { get; set; }
        public string? ImageType { get; set; }
        public string? SeriesDir { get; set; }
        public string? InstFileName { get; set; }
        public string? ConvKernel { get; set; }
        public string? FrameRefUid { get; set; }
        public string? ImageLaterality { get; set; }
        public int? Photometric { get; set; }
        public string? KnCodingSchemeDesi { get; set; }
        public string? KnCodeValue { get; set; }
        public string? KnCodeMeaning { get; set; }
        public DateTime? ObservationDate { get; set; }
        public string? PrLabel { get; set; }
        public string? PrDesc { get; set; }
        public string? PrCreatorName { get; set; }
        public DateTime? PrCreationDate { get; set; }
        public byte? InstType { get; set; }

        public virtual Series? SeriesIncIdDetNavigation { get; set; }
    }
}
