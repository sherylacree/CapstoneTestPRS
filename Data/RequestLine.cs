using CapstoneTestPRS.Models;

namespace CapstoneTestPRS.Data;

public class RequestLine {
    public int Id { get; set; }
    
    public int RequestId { get; set; }
    virtual public Request Request { get; set; }

    public int ProductId { get; set; }
    public virtual Product Product { get; set; }

    public int Quantity {  get; set; } = 1;
}
