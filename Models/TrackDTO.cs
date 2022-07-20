namespace oop.Models {

  public class TrackDTO {

    public int TrackNo { get; set; }
    public string Name { get; set; }

    public TrackDTO(Track Track)
    {
      TrackNo = Track.TrackNo;
      Name = Track.Name;
    }
  }
}
