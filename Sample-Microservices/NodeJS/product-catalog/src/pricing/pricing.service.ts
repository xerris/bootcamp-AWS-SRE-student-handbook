import { Injectable } from '@nestjs/common';
import { Price } from '../models/price.model';
import { ConfigService } from '@nestjs/config';

@Injectable()
export class PricingService {
  constructor(private config: ConfigService) {}
  GetAllPrices(): Price[] {
    const pricingUrl = this.config.get<string>('pricing-url');
    console.log(pricingUrl);
    return [];
  }
}
