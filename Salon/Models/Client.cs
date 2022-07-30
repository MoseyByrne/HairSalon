namespace Salon.Models
{
  public class Client
  {
    public int ClientId { get; set; }
    public string Details { get; set; }
    public int StylistId { get; set; }
    public virtual Stylist Stylist { get; set; }
  }
}