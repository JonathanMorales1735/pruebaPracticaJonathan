﻿namespace pruebaPracticaJonathan.Models
{
    public class Order
    {

        public long id {  get; set; }
        public DateTime dateOrder { get; set; }
        public long MemberId {  get; set; }
        public long ProductId { get; set; }
        public Member member { get; set; }
        public Product product { get; set; }

        
        


    }
}
