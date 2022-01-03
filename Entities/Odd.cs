using WebApi.Models;

namespace WebApi.Entities
{
    public class Odd
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public Bet Bet { get; set; }
        public decimal Value { get; set; }
        public string SpecialValue { get; set; }

        public Odd(OddProxy proxy)
        {
            Id = proxy.Id;
            Name = proxy.Name;
            Value = proxy.Value;
            SpecialValue = proxy.SpecialValue;
        }
    }
}