import { Controller, Get } from '@nestjs/common';
import { PricingService } from './pricing.service';
import { Price } from './models';

@Controller('prices')
export class PricesController {
  constructor(private pricingService: PricingService) {}

  @Get()
  getAllPrices(): Price[] {
    return this.pricingService.GetAllPrices();
  }
}
