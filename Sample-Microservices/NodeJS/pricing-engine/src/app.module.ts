import { Module } from '@nestjs/common';
import { PricesModule } from './prices/prices.module';

@Module({
  imports: [PricesModule],
})
export class AppModule {}
