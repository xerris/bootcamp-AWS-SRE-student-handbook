import { Module } from '@nestjs/common';
import { ProductsModule } from './products/products.module';
import { ConfigModule } from "@nestjs/config";

@Module({
  imports: [
    ProductsModule,
    ConfigModule.forRoot({
      isGlobal: true,
      envFilePath: ['.env.dev.local', '.env.dev'],
  })],
})
export class AppModule {}
