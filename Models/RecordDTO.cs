using System.Collections.ObjectModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using oop.enums;

namespace oop.Models
{
  public class RecordDTO {

    public int Id { get; set; }

    public string SerialNumber { get; set; }

    public string Name { get; set; }

    public string Artist { get; set; }


    public Genre Genre { get; set; }

    public string ImageUrl { get; set; }

    public string ReleaseYear { get; set; }

    public List<TrackDTO> Tracks { get; set; }

    public RecordDTO(Record Record)
    {
      Id = Record.Id;
      SerialNumber = Record.SerialNumber;
      Name = Record.Name;
      Artist = Record.Artist.Name;
      Genre = Record.Genre;
      ImageUrl = Record.ImageUrl;
      ReleaseYear = Record.ReleaseYear;
      Tracks = new List<TrackDTO>();
      Record.Tracks.ForEach(track => Tracks.Add(new TrackDTO(track)));
    }
  }
}
