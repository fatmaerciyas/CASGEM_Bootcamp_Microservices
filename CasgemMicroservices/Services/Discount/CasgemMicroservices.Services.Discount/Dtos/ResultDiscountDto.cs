﻿namespace CasgemMicroservices.Services.Discount.Dtos
{
    public class ResultDiscountDto
    {
        public int DiscountCouponID { get; set; }
        public string UserID { get; set; }
        public int Rate { get; set; }
        public string Code { get; set; }
        public DateTime CreatedTime { get; set; }
    }
}
