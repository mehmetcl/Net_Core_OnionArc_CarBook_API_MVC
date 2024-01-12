﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarBook.Dto.CarPricingDtos
{
	public class ResultCarPricingWithDto
	{
		public int CarPricingId { get; set; }

		public string Brand { get; set; }

		public string Model { get; set; }

		public decimal Amount { get; set; }

		public string CoverImageUrl { get; set; }

        public string PricingType { get; set; }
    }
}
