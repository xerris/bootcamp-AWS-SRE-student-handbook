import { Price } from './models';
import { Injectable } from '@nestjs/common';

@Injectable()
export class PricingRepository {
  latte = new Price('c0c20648-ecd9-4896-999d-8c2d55010f77', 5.75, 3);
  spice = new Price('c0c20648-ecd9-4896-999d-8c2d55010f77', 5.75, 3.15);
  brownee = new Price('76ad06f0-8ced-401e-862d-da27b1b496bb', 4.25, 2.75);

  GetAllPrices() {
    return [this.latte, this.spice, this.brownee];
  }
}
