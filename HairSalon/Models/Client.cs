namespace HairSalon.Models
{
  public class Client
  {
    public int ClientId { get; set; }
    public string Name { get; set; }
    public string Phone { get; set; }

    public string Email { get; set; }
    public virtual Stylist Stylist { get; set; }

  }
}
