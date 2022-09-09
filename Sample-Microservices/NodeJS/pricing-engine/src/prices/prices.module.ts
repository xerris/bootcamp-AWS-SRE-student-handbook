import { Module } from '@nestjs/common';
import { PricesController } from './prices.controller';
import { PricingService } from './pricing.service';
import { PricingRepository } from './pricing-repository.service';

@Module({
  controllers: [PricesController],
  providers: [PricingService, PricingRepository],
})
export class PricesModule {}
