import { Injectable } from '@nestjs/common';
import { PricingRepository } from './pricing-repository.service';

@Injectable()
export class PricingService {
  constructor(private pricingRepository: PricingRepository) {}
  GetAllPrices() {
    return this.pricingRepository.GetAllPrices();
  }
}
